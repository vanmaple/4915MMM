using System;
using System.Windows.Forms;
using DatabaseAccessController;
using MySql.Data.MySqlClient;

namespace _4915M.Management
{
    public partial class AddOrder : Form
    {
        private string connectionString = "server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;";
        private dboToyOrderController orderController;
        private pManagement parentForm;
        private int currentCustomerID;

        public AddOrder(pManagement parent, int customerID)
        {
            InitializeComponent();
            orderController = new dboToyOrderController(connectionString);
            parentForm = parent;
            currentCustomerID = customerID;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                string toyName = txtTname.Text.Trim();
                string description = txtDescription.Text.Trim();
                string category = txtCategory.Text.Trim();
                string brand = txtBrand.Text.Trim();

                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(toyName))
                {
                    MessageBox.Show("Toy name is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string insertToySql = @"
                            INSERT INTO toys (name, description, category, brand)
                            VALUES (@name, @description, @category, @brand);
                            SELECT LAST_INSERT_ID();";

                        using (MySqlCommand cmd = new MySqlCommand(insertToySql, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@name", toyName);
                            cmd.Parameters.AddWithValue("@description", description);
                            cmd.Parameters.AddWithValue("@category", category);
                            cmd.Parameters.AddWithValue("@brand", brand);

                            int toyID = Convert.ToInt32(cmd.ExecuteScalar());

                            string insertOrderSql = @"
                                INSERT INTO orders (customerID, toy_id, quantity)
                                VALUES (@customerID, @toyID, @quantity)";

                            using (MySqlCommand orderCmd = new MySqlCommand(insertOrderSql, conn, transaction))
                            {
                                orderCmd.Parameters.AddWithValue("@customerID", currentCustomerID);
                                orderCmd.Parameters.AddWithValue("@toyID", toyID);
                                orderCmd.Parameters.AddWithValue("@quantity", quantity);

                                int rowsAffected = orderCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    MessageBox.Show("Order added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    parentForm.RefreshOrders();
                                    this.Close();
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Failed to add order.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error occurred while adding order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}