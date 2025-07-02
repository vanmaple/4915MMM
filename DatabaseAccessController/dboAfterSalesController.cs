using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseAccessController
{
    public class dboAfterSalesController : dboDatabaseController
    {
        public dboAfterSalesController(string connectionString) : base(connectionString)
        {
        }

        public int CreateRequest(int orderId, string type, string description)
        {
            string sqlCmd = @"
                INSERT INTO AfterSales (OrderId, Type, Description, Status, CreatedAt)
                VALUES (@OrderId, @Type, @Description, 'Pending', NOW())
            ";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Description", description);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllRequests()
        {
            string sqlCmd = @"
                SELECT 
                    Id AS 'Request ID',
                    OrderId AS 'Order Number',
                    Type AS 'Issue Type',
                    Description AS 'Description',
                    Status AS 'Status',
                    DATE_FORMAT(CreatedAt, '%Y-%m-%d %H:%i') AS 'Created Date'
                FROM AfterSales
                ORDER BY CreatedAt DESC";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
            }
        }

        public int ResolveRequest(int id, bool approve)
        {
            string status = approve ? "Resolved" : "Rejected";
            string sqlCmd = @"
                UPDATE AfterSales
                SET Status = @Status
                WHERE Id = @Id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}