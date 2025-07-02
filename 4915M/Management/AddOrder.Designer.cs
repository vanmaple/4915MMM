namespace _4915M.Management
{
    partial class AddOrder
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
            txtTname = new TextBox();
            lblName = new Label();
            lblQuantity = new Label();
            lblBrand = new Label();
            lblCategory = new Label();
            lblDescription = new Label();
            txtQuantity = new TextBox();
            txtCategory = new TextBox();
            txtBrand = new TextBox();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtTname
            // 
            txtTname.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtTname.Location = new Point(246, 57);
            txtTname.Name = "txtTname";
            txtTname.Size = new Size(276, 38);
            txtTname.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblName.Location = new Point(76, 57);
            lblName.Name = "lblName";
            lblName.Size = new Size(131, 31);
            lblName.TabIndex = 1;
            lblName.Text = "ToyName";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblQuantity.Location = new Point(76, 253);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(121, 31);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblBrand.Location = new Point(76, 194);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(86, 31);
            lblBrand.TabIndex = 3;
            lblBrand.Text = "Brand";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblCategory.Location = new Point(76, 124);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(124, 31);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblDescription.Location = new Point(76, 319);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(153, 31);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtQuantity.Location = new Point(246, 253);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(276, 38);
            txtQuantity.TabIndex = 6;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCategory.Location = new Point(246, 124);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(276, 38);
            txtCategory.TabIndex = 7;
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtBrand.Location = new Point(246, 194);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(276, 38);
            txtBrand.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtDescription.Location = new Point(246, 312);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(276, 38);
            txtDescription.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(132, 444);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(166, 75);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Confirm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(356, 444);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(166, 75);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 575);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtBrand);
            Controls.Add(txtCategory);
            Controls.Add(txtQuantity);
            Controls.Add(lblDescription);
            Controls.Add(lblCategory);
            Controls.Add(lblBrand);
            Controls.Add(lblQuantity);
            Controls.Add(lblName);
            Controls.Add(txtTname);
            Name = "AddOrder";
            Text = "AddOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTname;
        private Label lblName;
        private Label lblQuantity;
        private Label lblBrand;
        private Label lblCategory;
        private Label lblDescription;
        private TextBox txtQuantity;
        private TextBox txtCategory;
        private TextBox txtBrand;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnCancel;
    }
}