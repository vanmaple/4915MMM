using System;
using System.Data;
using System.Windows.Forms;
using DatabaseAccessController;

namespace _4915M
{
    public partial class MaterialProcurementForm : Form
    {
        private string connectionString = "server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;";
        private dboMaterialProcurementController procurementController;

        public MaterialProcurementForm()
        {
            InitializeComponent();
            procurementController = new dboMaterialProcurementController(connectionString);
            ConfigureDataGridView();
            LoadProcurementOrders();
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            Column1.DataPropertyName = "order_id";
            Column2.DataPropertyName = "material_name";
            Column3.DataPropertyName = "quantity";
            Column4.DataPropertyName = "status";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadProcurementOrders()
        {
            try
            {
                DataTable procurementData = procurementController.GetAllProcurementOrders();
                dataGridView1.DataSource = procurementData;

                if (procurementData.Rows.Count > 0)
                {
                    MessageBox.Show($"Loaded {procurementData.Rows.Count} procurement orders.");
                }
                else
                {
                    MessageBox.Show("No procurement orders found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading procurement orders: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;

            try
            {
                DataTable searchResult = procurementController.SearchProcurementOrders(searchTerm);
                dataGridView1.DataSource = searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching procurement orders: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProcurementOrders();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProcurementOrder addOrderForm = new AddProcurementOrder(this);
            addOrderForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int orderID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column1"].Value);
                EditProcurementOrder editOrderForm = new EditProcurementOrder(this, orderID);
                editOrderForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RefreshProcurementOrders()
        {
            LoadProcurementOrders();
        }
    }
}