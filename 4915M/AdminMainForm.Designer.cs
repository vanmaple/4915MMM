namespace _4915M
{
    partial class AdminMainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAfterSales;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnShipping;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAfterSales = new Button();
            btnInventory = new Button();
            btnShipping = new Button();
            btnMaterialProcurement = new Button();
            SuspendLayout();

            btnAfterSales.Location = new Point(330, 30);
            btnAfterSales.Name = "btnAfterSales";
            btnAfterSales.Size = new Size(500, 86);
            btnAfterSales.TabIndex = 0;
            btnAfterSales.Text = "After Sales Service";
            btnAfterSales.UseVisualStyleBackColor = true;
            btnAfterSales.Click += btnAfterSales_Click;
 
            btnInventory.Location = new Point(330, 153);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(500, 83);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "Inventory Management";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
 
            btnShipping.Location = new Point(330, 292);
            btnShipping.Name = "btnShipping";
            btnShipping.Size = new Size(500, 75);
            btnShipping.TabIndex = 2;
            btnShipping.Text = "Shipping Management";
            btnShipping.UseVisualStyleBackColor = true;
            btnShipping.Click += btnShipping_Click;
 
            btnMaterialProcurement.Location = new Point(330, 424);
            btnMaterialProcurement.Name = "btnMaterialProcurement";
            btnMaterialProcurement.Size = new Size(500, 75);
            btnMaterialProcurement.TabIndex = 3;
            btnMaterialProcurement.Text = "MaterialProcurement";
            btnMaterialProcurement.UseVisualStyleBackColor = true;
            btnMaterialProcurement.Click += btnMaterialProcurement_Click;

            ClientSize = new Size(1177, 600);
            Controls.Add(btnMaterialProcurement);
            Controls.Add(btnShipping);
            Controls.Add(btnInventory);
            Controls.Add(btnAfterSales);
            Name = "AdminMainForm";
            Text = "Admin Main Form";
            ResumeLayout(false);

        }
        private Button btnMaterialProcurement;
    }
}