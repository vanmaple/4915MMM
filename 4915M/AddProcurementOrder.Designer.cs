namespace _4915M
{
    partial class AddProcurementOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMaterialName = new System.Windows.Forms.TextBox();
            lblMaterialName = new System.Windows.Forms.Label();
            lblQuantity = new System.Windows.Forms.Label();
            txtQuantity = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            txtMaterialName.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            txtMaterialName.Location = new System.Drawing.Point(361, 61);
            txtMaterialName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new System.Drawing.Size(354, 46);
            txtMaterialName.TabIndex = 0;
 
            lblMaterialName.AutoSize = true;
            lblMaterialName.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            lblMaterialName.Location = new System.Drawing.Point(98, 67);
            lblMaterialName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMaterialName.Name = "lblMaterialName";
            lblMaterialName.Size = new System.Drawing.Size(239, 40);
            lblMaterialName.TabIndex = 1;
            lblMaterialName.Text = "Material Name";

            lblQuantity.AutoSize = true;
            lblQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            lblQuantity.Location = new System.Drawing.Point(98, 146);
            lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(147, 40);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity";
 
            txtQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            txtQuantity.Location = new System.Drawing.Point(361, 146);
            txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(354, 46);
            txtQuantity.TabIndex = 3;
 
            btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAdd.Location = new System.Drawing.Point(170, 522);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(213, 88);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Confirm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
 
            btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancel.Location = new System.Drawing.Point(458, 522);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(213, 88);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;

            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            lblStatus.Location = new System.Drawing.Point(98, 225);
            lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(99, 40);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
 
            txtStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            txtStatus.Location = new System.Drawing.Point(361, 225);
            txtStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(354, 46);
            txtStatus.TabIndex = 7;
  
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 676);
            this.Controls.Add(txtStatus);
            this.Controls.Add(lblStatus);
            this.Controls.Add(btnCancel);
            this.Controls.Add(btnAdd);
            this.Controls.Add(txtQuantity);
            this.Controls.Add(lblQuantity);
            this.Controls.Add(lblMaterialName);
            this.Controls.Add(txtMaterialName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProcurementOrder";
            this.Text = "Add Procurement Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
    }
}