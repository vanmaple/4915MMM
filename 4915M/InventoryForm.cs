using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DatabaseAccessController;
using MySql.Data.MySqlClient;

namespace _4915M
{
    public partial class InventoryForm : Form
    {
        private readonly string _connectionString = "server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;";
        private readonly dboInventoryController _inventoryController;
        private DataTable _inventoryData;
        private readonly int _currentAdminId;
        private string _currentAdminName;

        public InventoryForm(int adminId, string adminName)
        {
            InitializeComponent();
            _currentAdminId = adminId;
            _currentAdminName = adminName;
            _inventoryController = new dboInventoryController(_connectionString);
            ConfigureDataGrids();
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            this.Text = $"Inventory Management System - {_currentAdminName}";
            this.FormClosing += InventoryForm_FormClosing;
            numericUpDownAdjustment.Increment = 1;
            numericUpDownAdjustment.Minimum = -1000;
            numericUpDownAdjustment.Maximum = 1000;
        }

        private void ConfigureDataGrids()
        {
            dataGridViewInventory.AutoGenerateColumns = false;
            dataGridViewInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInventory.MultiSelect = false;
            dataGridViewInventory.AllowUserToAddRows = false;
            dataGridViewInventory.AllowUserToDeleteRows = false;

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50,
                ReadOnly = true
            });

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                DataPropertyName = "Name",
                HeaderText = "Product Name",
                Width = 150,
                ReadOnly = true
            });

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStock",
                DataPropertyName = "Stock",
                HeaderText = "Current Stock",
                Width = 80,
                ReadOnly = true
            });

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMinLevel",
                DataPropertyName = "MinimumStockLevel",
                HeaderText = "Min Level",
                Width = 80,
                ReadOnly = true
            });

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStatus",
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 100,
                ReadOnly = true
            });

            dataGridViewLogs.AutoGenerateColumns = false;
            dataGridViewLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLogs.MultiSelect = false;
            dataGridViewLogs.AllowUserToAddRows = false;
            dataGridViewLogs.AllowUserToDeleteRows = false;

            dataGridViewLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLogId",
                DataPropertyName = "Id",
                HeaderText = "Log ID",
                Width = 60,
                Visible = false
            });

            dataGridViewLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProduct",
                DataPropertyName = "ProductName",
                HeaderText = "Product",
                Width = 120,
                ReadOnly = true
            });

            dataGridViewLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAdjustment",
                DataPropertyName = "ChangeAmount",
                HeaderText = "Adjustment",
                Width = 80,
                ReadOnly = true
            });

            dataGridViewLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colReason",
                DataPropertyName = "Reason",
                HeaderText = "Reason",
                Width = 200,
                ReadOnly = true
            });

            dataGridViewLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAdmin",
                DataPropertyName = "AdminName",
                HeaderText = "Admin",
                Width = 100,
                ReadOnly = true
            });

            dataGridViewLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDate",
                DataPropertyName = "CreatedAt",
                HeaderText = "Date/Time",
                Width = 120,
                ReadOnly = true
            });
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void LoadInventoryData()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                statusLabel.Text = "Loading data...";

                _inventoryData = _inventoryController.GetAllProductsWithStockStatus();
                dataGridViewInventory.DataSource = _inventoryData;

                foreach (DataGridViewRow row in dataGridViewInventory.Rows)
                {
                    if (row.Cells["colStatus"].Value.ToString() == "Low Stock")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightPink;
                        row.DefaultCellStyle.Font = new Font(dataGridViewInventory.Font, FontStyle.Bold);
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.Font = dataGridViewInventory.Font;
                    }
                }

                var logs = _inventoryController.GetInventoryLogs();
                dataGridViewLogs.DataSource = logs;

                statusLabel.Text = $"Loaded {_inventoryData.Rows.Count} products and {logs.Rows.Count} logs";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load inventory data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Error loading data";
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product first", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericUpDownAdjustment.Value == 0)
            {
                MessageBox.Show("Adjustment quantity cannot be zero", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Please enter adjustment reason", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewInventory.SelectedRows[0];
            var productId = Convert.ToInt32(selectedRow.Cells["colId"].Value);
            var productName = selectedRow.Cells["colName"].Value.ToString();
            var currentStock = Convert.ToInt32(selectedRow.Cells["colStock"].Value);
            var adjustment = (int)numericUpDownAdjustment.Value;
            var reason = txtReason.Text.Trim();

            var confirmMessage = new StringBuilder();
            confirmMessage.AppendLine($"Product: {productName}");
            confirmMessage.AppendLine($"Current Stock: {currentStock}");
            confirmMessage.AppendLine($"Adjustment: {(adjustment > 0 ? "+" : "")}{adjustment}");
            confirmMessage.AppendLine($"New Stock: {currentStock + adjustment}");
            confirmMessage.AppendLine($"Reason: {reason}");
            confirmMessage.AppendLine();
            confirmMessage.Append("Confirm this adjustment?");

            if (MessageBox.Show(confirmMessage.ToString(), "Confirm Adjustment",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                statusLabel.Text = "Processing adjustment...";

                int result = _inventoryController.AdjustInventory(productId, adjustment, reason, _currentAdminId);

                if (result > 0)
                {
                    MessageBox.Show("Inventory adjusted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    numericUpDownAdjustment.Value = 0;
                    txtReason.Clear();

                    LoadInventoryData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Inventory adjustment failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Adjustment failed";
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void dataGridViewInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewInventory.SelectedRows[0];
                var productName = selectedRow.Cells["colName"].Value.ToString();
                lblSelectedProduct.Text = $"Selected: {productName}";
            }
            else
            {
                lblSelectedProduct.Text = "No product selected";
            }
        }

        private void InventoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the Inventory Management System?",
                "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}