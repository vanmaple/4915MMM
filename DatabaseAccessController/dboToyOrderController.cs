using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseAccessController
{
    public class dboToyOrderController : dboDatabaseController
    {
        public dboToyOrderController(string connectionString) : base(connectionString)
        {
        }

        public DataTable GetToysByCustomer(int customerID)
        {
            string sqlCmd = @"
                SELECT toys.toy_id, toys.name, toys.description, toys.category, toys.brand, toys.inventory, orders.quantity, orders.order_date
                FROM orders
                JOIN toys ON orders.toy_id = toys.toy_id
                WHERE orders.customerID = @customerID
            ";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        MySqlDataAdapter adr = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adr.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public int AddOrder(int customerID, int toyID, int quantity)
        {
            string sqlCmd = @"
                INSERT INTO orders (customerID, toy_id, quantity)
                VALUES (@customerID, @toyID, @quantity)
            ";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@toyID", toyID);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        return cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public int DeleteOrder(int customerID, int toyID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string deleteShippingSql = @"
                DELETE FROM shipping
                WHERE order_id IN (SELECT order_id FROM orders WHERE customerID = @customerID AND toy_id = @toyID)
            ";
                    using (MySqlCommand shippingCmd = new MySqlCommand(deleteShippingSql, conn))
                    {
                        shippingCmd.Parameters.AddWithValue("@customerID", customerID);
                        shippingCmd.Parameters.AddWithValue("@toyID", toyID);
                        shippingCmd.ExecuteNonQuery();
                    }
                    string deleteOrderSql = @"
                DELETE FROM orders
                WHERE customerID = @customerID AND toy_id = @toyID
            ";
                    using (MySqlCommand orderCmd = new MySqlCommand(deleteOrderSql, conn))
                    {
                        orderCmd.Parameters.AddWithValue("@customerID", customerID);
                        orderCmd.Parameters.AddWithValue("@toyID", toyID);
                        return orderCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public int ModifyOrder(int customerID, int toyID, int newQuantity)
        {
            string sqlCmd = @"
                UPDATE orders
                SET quantity = @newQuantity
                WHERE customerID = @customerID AND toy_id = @toyID
            ";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@toyID", toyID);
                        cmd.Parameters.AddWithValue("@newQuantity", newQuantity);
                        return cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public DataTable SearchOrders(int customerID, string toyName)
        {
            string sqlCmd = @"
                SELECT toys.name, toys.description, toys.category, toys.brand, toys.inventory, orders.quantity, orders.order_date
                FROM orders
                JOIN toys ON orders.toy_id = toys.toy_id
                WHERE orders.customerID = @customerID AND toys.name LIKE @toyName
            ";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@toyName", $"%{toyName}%");
                        MySqlDataAdapter adr = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adr.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool GetScalarValue(string getCustomerIdSql, MySqlParameter mySqlParameter)
        {
            throw new NotImplementedException();
        }
    }
}