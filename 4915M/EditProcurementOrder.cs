using System;
using System.Data;
using System.Windows.Forms;
using DatabaseAccessController;
using MySql.Data.MySqlClient;

namespace _4915M
{
    public partial class EditProcurementOrder : Form
    {
        private string connectionString = "server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;";
        private dboMaterialProcurementController procurementController;
        private MaterialProcurementForm parentForm;
        private int orderID;

        public EditProcurementOrder(MaterialProcurementForm parent, int id)
        {
            InitializeComponent();
            procurementController = new dboMaterialProcurementController(connectionString);
            parentForm = parent;
            orderID = id;
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            try
            {
                DataTable orderData = procurementController.GetProcurementOrderByID(orderID);
                if (orderData.Rows.Count > 0)
                {
                    txtMaterialName.Text = orderData.Rows[0]["material_name"].ToString();
                    txtQuantity.Text = orderData.Rows[0]["quantity"].ToString();
                    txtStatus.Text = orderData.Rows[0]["status"].ToString(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order details: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string materialName = txtMaterialName.Text.Trim();
                string quantity = txtQuantity.Text.Trim();
                string status = txtStatus.Text.Trim(); 

                if (string.IsNullOrEmpty(materialName))
                {
                    MessageBox.Show("Material name is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(quantity, out int parsedQuantity) || parsedQuantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string updateSql = @"
                            UPDATE procurement_orders
                            SET material_name = @materialName, quantity = @quantity, status = @status
                            WHERE order_id = @orderID";

                        using (MySqlCommand cmd = new MySqlCommand(updateSql, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@materialName", materialName);
                            cmd.Parameters.AddWithValue("@quantity", parsedQuantity);
                            cmd.Parameters.AddWithValue("@status", status); 
                            cmd.Parameters.AddWithValue("@orderID", orderID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show("Procurement order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                parentForm.RefreshProcurementOrders();
                                this.Close();
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Failed to update procurement order.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error occurred while updating procurement order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}