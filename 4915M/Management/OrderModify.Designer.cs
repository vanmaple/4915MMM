namespace _4915M.新文件夹
{
    partial class OrderModify
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
            btnCancel = new Button();
            btnAdd = new Button();
            txtDescription = new TextBox();
            txtBrand = new TextBox();
            txtCategory = new TextBox();
            txtQuantity = new TextBox();
            txtTID = new TextBox();
            lblTID = new Label();
            chbCategory = new CheckBox();
            chbDescription = new CheckBox();
            chbQuantity = new CheckBox();
            chbBrand = new CheckBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(408, 419);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(166, 75);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(184, 419);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(166, 75);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Confirm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtDescription.Location = new Point(298, 287);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(276, 38);
            txtDescription.TabIndex = 21;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtBrand.Location = new Point(298, 169);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(276, 38);
            txtBrand.TabIndex = 20;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCategory.Location = new Point(298, 99);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(276, 38);
            txtCategory.TabIndex = 19;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtQuantity.Location = new Point(298, 228);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(276, 38);
            txtQuantity.TabIndex = 18;
            // 
            // txtTID
            // 
            txtTID.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtTID.Location = new Point(298, 32);
            txtTID.Name = "txtTID";
            txtTID.Size = new Size(276, 38);
            txtTID.TabIndex = 12;
            // 
            // lblTID
            // 
            lblTID.AutoSize = true;
            lblTID.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTID.Location = new Point(121, 32);
            lblTID.Name = "lblTID";
            lblTID.Size = new Size(93, 31);
            lblTID.TabIndex = 29;
            lblTID.Text = "Toy ID";
            // 
            // chbCategory
            // 
            chbCategory.AutoSize = true;
            chbCategory.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            chbCategory.Location = new Point(71, 99);
            chbCategory.Name = "chbCategory";
            chbCategory.Size = new Size(143, 35);
            chbCategory.TabIndex = 30;
            chbCategory.Text = "Category";
            chbCategory.UseVisualStyleBackColor = true;
            chbCategory.CheckedChanged += chbCategory_CheckedChanged;
            // 
            // chbDescription
            // 
            chbDescription.AutoSize = true;
            chbDescription.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            chbDescription.Location = new Point(71, 287);
            chbDescription.Name = "chbDescription";
            chbDescription.Size = new Size(172, 35);
            chbDescription.TabIndex = 31;
            chbDescription.Text = "Description";
            chbDescription.UseVisualStyleBackColor = true;
            chbDescription.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chbQuantity
            // 
            chbQuantity.AutoSize = true;
            chbQuantity.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            chbQuantity.Location = new Point(74, 228);
            chbQuantity.Name = "chbQuantity";
            chbQuantity.Size = new Size(140, 35);
            chbQuantity.TabIndex = 32;
            chbQuantity.Text = "Quantity";
            chbQuantity.UseVisualStyleBackColor = true;
            // 
            // chbBrand
            // 
            chbBrand.AutoSize = true;
            chbBrand.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            chbBrand.Location = new Point(71, 169);
            chbBrand.Name = "chbBrand";
            chbBrand.Size = new Size(105, 35);
            chbBrand.TabIndex = 33;
            chbBrand.Text = "Brand";
            chbBrand.UseVisualStyleBackColor = true;
            // 
            // OrderModify
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(chbBrand);
            Controls.Add(chbQuantity);
            Controls.Add(chbDescription);
            Controls.Add(chbCategory);
            Controls.Add(lblTID);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtBrand);
            Controls.Add(txtCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtTID);
            Name = "OrderModify";
            Text = "OrderModify";
            Load += OrderModify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private TextBox txtDescription;
        private TextBox txtBrand;
        private TextBox txtCategory;
        private TextBox txtQuantity;
        private TextBox txtTID;
        private RadioButton rbtQuantity;
        private RadioButton rbtBrand;
        private Label lblTID;
        private CheckBox chbCategory;
        private CheckBox chbDescription;
        private CheckBox checkBox1;
        private CheckBox chbQuantity;
        private CheckBox chbBrand;
    }
}