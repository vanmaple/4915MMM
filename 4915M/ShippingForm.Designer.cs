namespace ShippingApp
{
    partial class ShippingForm
    {
        private System.ComponentModel.IContainer components = null;

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
            dgvShipping = new DataGridView();
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            cmbStatus = new ComboBox();
            label4 = new Label();
            cmbCourier = new ComboBox();
            label3 = new Label();
            txtTrackingNumber = new TextBox();
            label2 = new Label();
            txtOrderId = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShipping).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();

            dgvShipping.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShipping.Location = new Point(12, 12);
            dgvShipping.Name = "dgvShipping";
            dgvShipping.RowHeadersWidth = 51;
            dgvShipping.Size = new Size(776, 300);
            dgvShipping.TabIndex = 0;

            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbCourier);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTrackingNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtOrderId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 318);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 169);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Shipping Record";

            btnAdd.Location = new Point(210, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(260, 30);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Record";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Shipped", "In Transit", "Delivered" });
            cmbStatus.Location = new Point(500, 50);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(120, 28);
            cmbStatus.TabIndex = 7;

            label4.AutoSize = true;
            label4.Location = new Point(500, 30);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "Status";

            cmbCourier.FormattingEnabled = true;
            cmbCourier.Items.AddRange(new object[] { "FedEx", "UPS", "DHL" });
            cmbCourier.Location = new Point(350, 50);
            cmbCourier.Name = "cmbCourier";
            cmbCourier.Size = new Size(120, 28);
            cmbCourier.TabIndex = 5;
 
            label3.AutoSize = true;
            label3.Location = new Point(350, 30);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 4;
            label3.Text = "Courier";

            txtTrackingNumber.Location = new Point(200, 50);
            txtTrackingNumber.Name = "txtTrackingNumber";
            txtTrackingNumber.Size = new Size(120, 27);
            txtTrackingNumber.TabIndex = 3;

            label2.AutoSize = true;
            label2.Location = new Point(200, 30);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 2;
            label2.Text = "Tracking Number";

            txtOrderId.Location = new Point(50, 50);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(120, 27);
            txtOrderId.TabIndex = 1;

            label1.AutoSize = true;
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Order ID";

            ClientSize = new Size(800, 499);
            Controls.Add(groupBox1);
            Controls.Add(dgvShipping);
            Name = "ShippingForm";
            Text = "Shipping Management System";
            ((System.ComponentModel.ISupportInitialize)dgvShipping).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvShipping;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCourier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label1;
    }
}