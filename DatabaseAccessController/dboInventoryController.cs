using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseAccessController
{
    public class dboInventoryController
    {
        private readonly string _connectionString;

        public dboInventoryController(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetAllProductsWithStockStatus()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string sql = @"
                    SELECT 
                        p.Id, 
                        p.Name, 
                        p.Stock, 
                        p.MinimumStockLevel,
                        CASE 
                            WHEN p.Stock < p.MinimumStockLevel THEN 'Low Stock'
                            ELSE 'In Stock'
                        END AS Status
                    FROM Products p
                    ORDER BY p.Name";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }

            return dt;
        }

        public DataTable GetInventoryLogs()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string sql = @"
                    SELECT 
                        l.Id,
                        p.Name AS ProductName,
                        l.ChangeAmount,
                        l.Reason,
                        a.adminName AS AdminName,
                        l.CreatedAt
                    FROM InventoryLogs l
                    JOIN Products p ON l.ProductId = p.Id
                    JOIN Admin a ON l.AdminId = a.adminID
                    ORDER BY l.CreatedAt DESC";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }

            return dt;
        }

        public int AdjustInventory(int productId, int changeAmount, string reason, int adminId)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string updateSql = @"
                        UPDATE Products 
                        SET Stock = Stock + @changeAmount 
                        WHERE Id = @productId";

                    MySqlCommand updateCmd = new MySqlCommand(updateSql, conn, transaction);
                    updateCmd.Parameters.AddWithValue("@changeAmount", changeAmount);
                    updateCmd.Parameters.AddWithValue("@productId", productId);
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        transaction.Rollback();
                        return 0;
                    }

                    string logSql = @"
                        INSERT INTO InventoryLogs 
                        (ProductId, ChangeAmount, Reason, AdminId) 
                        VALUES (@productId, @changeAmount, @reason, @adminId)";

                    MySqlCommand logCmd = new MySqlCommand(logSql, conn, transaction);
                    logCmd.Parameters.AddWithValue("@productId", productId);
                    logCmd.Parameters.AddWithValue("@changeAmount", changeAmount);
                    logCmd.Parameters.AddWithValue("@reason", reason);
                    logCmd.Parameters.AddWithValue("@adminId", adminId);
                    logCmd.ExecuteNonQuery();

                    transaction.Commit();
                    return 1;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}