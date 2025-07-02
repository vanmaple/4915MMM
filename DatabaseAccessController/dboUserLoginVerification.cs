using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace DatabaseAccessController
{
    public class dboUserLoginVerification : dboDatabaseController
    {
        public dboUserLoginVerification(string connectionString) : base(connectionString)
        {
        }

        public bool VerifyUserLogin(string username, string password, bool isUser)
        {
            string tableName = isUser ? "customers" : "admin";
            string columnName = isUser ? "customerName" : "adminName";
            string passwordColumnName = isUser ? "customerPassword" : "adminPassword";

            string sqlCmd = $"SELECT COUNT(*) FROM `{tableName}` WHERE `{columnName}` = @username AND `{passwordColumnName}` = @password";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    System.Diagnostics.Debug.WriteLine($"Connection String: {connectionString}");
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (ArgumentException ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Invalid connection string: {ex.Message}");
                    throw;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"An error occurred: {ex.Message}");
                    throw;
                }
            }
        }
    }
}