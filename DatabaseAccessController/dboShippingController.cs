using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseAccessController
{
    public class dboShippingController
    {
        public readonly string _connectionString;

        public dboShippingController(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetShippingRecords()
        {
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM shipping", conn))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public int AddShippingRecord(int orderId, string trackingNumber, string courier, string status)
        {
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(
                    "INSERT INTO shipping (order_id, tracking_number, courier, status) " +
                    "VALUES (@orderId, @trackingNumber, @courier, @status)", conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@trackingNumber", trackingNumber);
                    cmd.Parameters.AddWithValue("@courier", courier);
                    cmd.Parameters.AddWithValue("@status", status);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}