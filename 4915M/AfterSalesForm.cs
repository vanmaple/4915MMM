using System;
using System.Data;
using System.Windows.Forms;
using DatabaseAccessController;
using MySql.Data.MySqlClient;

namespace _4915M
{
    public partial class AfterSalesForm : Form
    {
        private string connectionString = "server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;";
        private dboAfterSalesController afterSalesController;

        public AfterSalesForm()
        {
            InitializeComponent();
            afterSalesController = new dboAfterSalesController(connectionString);
        }

        private void AfterSalesForm_Load(object sender, EventArgs e)
        {
            LoadAfterSalesData();
        }

        private async void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderNumber.Text))
            {
                MessageBox.Show("Please enter a valid order number", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbIssueType.SelectedItem == null)
            {
                MessageBox.Show("Please select an issue type", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int orderId = int.Parse(txtOrderNumber.Text.Trim());

                if (!IsOrderIdExists(orderId))
                {
                    MessageBox.Show("The provided order number does not exist.", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string issueType = cmbIssueType.SelectedItem.ToString();
                string description = txtDescription.Text;

                int rowsAffected = afterSalesController.CreateRequest(orderId, issueType, description);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Request submitted successfully",
                                      "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadAfterSalesData(); // Refresh grid data
                }
                else
                {
                    MessageBox.Show("Failed to submit request",
                        "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:\n{ex.Message}",
                    "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsOrderIdExists(int orderId)
        {
            string sqlCmd = @"SELECT COUNT(*) FROM orders WHERE order_id = @OrderId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }


        private void LoadAfterSalesData()
        {
            try
            {
                DataTable dt = afterSalesController.GetAllRequests();
                dgvAfterSales.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load after-sales data: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtOrderNumber.Clear();
            txtDescription.Clear();
            cmbIssueType.SelectedIndex = -1;
            cmbResolutionStatus.SelectedIndex = 0;
            txtOrderNumber.Focus();
        }
    }
}