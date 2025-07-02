namespace _4915M
{
    partial class AfterSalesForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.ComboBox cmbIssueType;
        private System.Windows.Forms.ComboBox cmbResolutionStatus;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblIssueType;
        private System.Windows.Forms.Label lblResolutionStatus;
        private System.Windows.Forms.DataGridView dgvAfterSales;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;

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
            txtOrderNumber = new TextBox();
            cmbIssueType = new ComboBox();
            cmbResolutionStatus = new ComboBox();
            btnSubmitRequest = new Button();
            lblOrderNumber = new Label();
            lblIssueType = new Label();
            lblResolutionStatus = new Label();
            dgvAfterSales = new DataGridView();
            txtDescription = new TextBox();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAfterSales).BeginInit();
            SuspendLayout();
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(192, 51);
            txtOrderNumber.Margin = new Padding(4, 5, 4, 5);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(298, 27);
            txtOrderNumber.TabIndex = 0;
            // 
            // cmbIssueType
            // 
            cmbIssueType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIssueType.FormattingEnabled = true;
            cmbIssueType.Items.AddRange(new object[] { "Defective Product", "Incorrect Item Received", "Shipping Delay", "Damaged During Transit", "Other Issue" });
            cmbIssueType.Location = new Point(192, 112);
            cmbIssueType.Margin = new Padding(4, 5, 4, 5);
            cmbIssueType.Name = "cmbIssueType";
            cmbIssueType.Size = new Size(298, 28);
            cmbIssueType.TabIndex = 1;
            // 
            // cmbResolutionStatus
            // 
            cmbResolutionStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResolutionStatus.FormattingEnabled = true;
            cmbResolutionStatus.Items.AddRange(new object[] { "New Request", "In Progress", "Completed", "Cancelled" });
            cmbResolutionStatus.Location = new Point(189, 174);
            cmbResolutionStatus.Margin = new Padding(4, 5, 4, 5);
            cmbResolutionStatus.Name = "cmbResolutionStatus";
            cmbResolutionStatus.Size = new Size(298, 28);
            cmbResolutionStatus.TabIndex = 2;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Location = new Point(192, 411);
            btnSubmitRequest.Margin = new Padding(4, 5, 4, 5);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(502, 64);
            btnSubmitRequest.TabIndex = 3;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.UseVisualStyleBackColor = true;
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new Point(45, 51);
            lblOrderNumber.Margin = new Padding(4, 0, 4, 0);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(116, 20);
            lblOrderNumber.TabIndex = 4;
            lblOrderNumber.Text = "Order Number";
            // 
            // lblIssueType
            // 
            lblIssueType.AutoSize = true;
            lblIssueType.Location = new Point(45, 112);
            lblIssueType.Margin = new Padding(4, 0, 4, 0);
            lblIssueType.Name = "lblIssueType";
            lblIssueType.Size = new Size(85, 20);
            lblIssueType.TabIndex = 5;
            lblIssueType.Text = "Issue Type";
            // 
            // lblResolutionStatus
            // 
            lblResolutionStatus.AutoSize = true;
            lblResolutionStatus.Location = new Point(45, 174);
            lblResolutionStatus.Margin = new Padding(4, 0, 4, 0);
            lblResolutionStatus.Name = "lblResolutionStatus";
            lblResolutionStatus.Size = new Size(136, 20);
            lblResolutionStatus.TabIndex = 6;
            lblResolutionStatus.Text = "Resolution Status";
            // 
            // dgvAfterSales
            // 
            dgvAfterSales.AllowUserToAddRows = false;
            dgvAfterSales.AllowUserToDeleteRows = false;
            dgvAfterSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAfterSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAfterSales.Location = new Point(537, 51);
            dgvAfterSales.Margin = new Padding(4, 5, 4, 5);
            dgvAfterSales.Name = "dgvAfterSales";
            dgvAfterSales.ReadOnly = true;
            dgvAfterSales.RowHeadersVisible = false;
            dgvAfterSales.RowHeadersWidth = 51;
            dgvAfterSales.Size = new Size(643, 296);
            dgvAfterSales.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(192, 245);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(298, 60);
            txtDescription.TabIndex = 8;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(45, 248);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(93, 20);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description";
            // 
            // AfterSalesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 550);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(dgvAfterSales);
            Controls.Add(lblResolutionStatus);
            Controls.Add(lblIssueType);
            Controls.Add(lblOrderNumber);
            Controls.Add(btnSubmitRequest);
            Controls.Add(cmbResolutionStatus);
            Controls.Add(cmbIssueType);
            Controls.Add(txtOrderNumber);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AfterSalesForm";
            Text = "After-Sales Service Request";
            Load += AfterSalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAfterSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}