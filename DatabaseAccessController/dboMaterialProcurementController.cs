using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseAccessController
{
    public class dboMaterialProcurementController
    {
        private string connectionString;

        public dboMaterialProcurementController(string connString)
        {
            connectionString = connString;
        }

        public DataTable GetAllProcurementOrders()
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT order_id, material_name, quantity, status FROM procurement_orders";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public DataTable SearchProcurementOrders(string searchTerm)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT order_id, material_name, quantity, status FROM procurement_orders WHERE material_name LIKE @searchTerm";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public DataTable GetProcurementOrderByID(int orderID)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT order_id, material_name, quantity, status FROM procurement_orders WHERE order_id = @orderID";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@orderID", orderID);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}