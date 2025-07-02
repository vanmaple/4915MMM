using System;
using System.Data;
using System.Windows.Forms;
using DatabaseAccessController;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace ShippingApp
{
    public partial class ShippingForm : Form
    {
        private readonly dboShippingController _controller;
        private string connectionString;

        public ShippingForm()
        {
            InitializeComponent();
            _controller = new dboShippingController("server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;");
            LoadShippingData();
            SetupDataGridView();
        }

        private void LoadShippingData()
        {
            try
            {
                dgvShipping.DataSource = _controller.GetShippingRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void SetupDataGridView()
        {
            dgvShipping.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShipping.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShipping.Columns["order_id"].HeaderText = "Order ID";
            dgvShipping.Columns["tracking_number"].HeaderText = "Tracking Number";
            dgvShipping.Columns["courier"].HeaderText = "Courier";
            dgvShipping.Columns["status"].HeaderText = "Status";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOrderId.Text, out int orderId))
            {
                MessageBox.Show("Please enter a valid Order ID");
                return;
            }

            if (!IsOrderIdExists(orderId))
            {
                MessageBox.Show("The provided order ID does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var trackingNumber = txtTrackingNumber.Text;
            var courier = cmbCourier.Text;
            var status = cmbStatus.Text;

            if (string.IsNullOrEmpty(trackingNumber) || string.IsNullOrEmpty(courier) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            try
            {
                int result = _controller.AddShippingRecord(orderId, trackingNumber, courier, status);
                if (result > 0)
                {
                    MessageBox.Show("Record added successfully");
                    LoadShippingData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private bool IsOrderIdExists(int orderId)
        {
            string sqlCmd = @"
        SELECT COUNT(*) 
        FROM orders 
        WHERE order_id = @OrderId";

            using (MySqlConnection conn = new MySqlConnection(_controller._connectionString))
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

        private void ClearForm()
        {
            txtOrderId.Clear();
            txtTrackingNumber.Clear();
            cmbCourier.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }
    }
}