using System;
using System.Windows.Forms;
using ShippingApp;

namespace _4915M
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void btnAfterSales_Click(object sender, EventArgs e)
        {
            AfterSalesForm afterSalesForm = new AfterSalesForm();
            afterSalesForm.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(1, "Admin");
            inventoryForm.ShowDialog();
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            ShippingForm shippingForm = new ShippingForm();
            shippingForm.ShowDialog();
        }

        private void btnMaterialProcurement_Click(object sender, EventArgs e)
        {
            MaterialProcurementForm materialProcurementForm = new MaterialProcurementForm();
            materialProcurementForm.ShowDialog();
        }
    }
}