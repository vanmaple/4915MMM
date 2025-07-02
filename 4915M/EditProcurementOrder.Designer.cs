namespace _4915M
{
    partial class EditProcurementOrder
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStatus; 
        private System.Windows.Forms.TextBox txtStatus; 

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
            txtMaterialName = new TextBox();
            lblMaterialName = new Label();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblStatus = new Label();
            txtStatus = new TextBox();
            SuspendLayout();

            txtMaterialName.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtMaterialName.Location = new Point(352, 57);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new Size(276, 46);
            txtMaterialName.TabIndex = 0;

            lblMaterialName.AutoSize = true;
            lblMaterialName.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblMaterialName.Location = new Point(76, 57);
            lblMaterialName.Name = "lblMaterialName";
            lblMaterialName.Size = new Size(239, 40);
            lblMaterialName.TabIndex = 1;
            lblMaterialName.Text = "Material Name";

            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblQuantity.Location = new Point(76, 129);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(147, 40);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity";

            txtQuantity.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtQuantity.Location = new Point(352, 129);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(276, 46);
            txtQuantity.TabIndex = 3;

            btnSave.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSave.Location = new Point(121, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 75);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
 
            btnCancel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnCancel.Location = new Point(352, 280);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(166, 75);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblStatus.Location = new Point(76, 201);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(110, 40);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
 
            txtStatus.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtStatus.Location = new Point(352, 201);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(276, 46);
            txtStatus.TabIndex = 7;

            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 403);
            Controls.Add(txtStatus);
            Controls.Add(lblStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(lblMaterialName);
            Controls.Add(txtMaterialName);
            Name = "EditProcurementOrder";
            Text = "Edit Procurement Order";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}