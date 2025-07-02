namespace _4915M
{
    partial class InventoryForm
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
            dataGridViewInventory = new DataGridView();
            groupBox1 = new GroupBox();
            lblSelectedProduct = new Label();
            statusLabel = new Label();
            btnRefresh = new Button();
            labelLogs = new Label();
            dataGridViewLogs = new DataGridView();
            btnSubmit = new Button();
            txtReason = new TextBox();
            label2 = new Label();
            numericUpDownAdjustment = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdjustment).BeginInit();
            SuspendLayout();

            dataGridViewInventory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Location = new Point(446, 47);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.ReadOnly = true;
            dataGridViewInventory.RowHeadersWidth = 51;
            dataGridViewInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInventory.Size = new Size(529, 206);
            dataGridViewInventory.TabIndex = 0;
            dataGridViewInventory.SelectionChanged += dataGridViewInventory_SelectionChanged;

            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblSelectedProduct);
            groupBox1.Controls.Add(statusLabel);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(labelLogs);
            groupBox1.Controls.Add(dataGridViewLogs);
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(dataGridViewInventory);
            groupBox1.Controls.Add(txtReason);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericUpDownAdjustment);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1049, 626);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventory Management";

            lblSelectedProduct.AutoSize = true;
            lblSelectedProduct.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblSelectedProduct.Location = new Point(59, 70);
            lblSelectedProduct.Name = "lblSelectedProduct";
            lblSelectedProduct.Size = new Size(118, 18);
            lblSelectedProduct.TabIndex = 9;
            lblSelectedProduct.Text = "No product selected";

            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(59, 550);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 20);
            statusLabel.TabIndex = 8;

            btnRefresh.Location = new Point(93, 470);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(292, 29);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh Data";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;

            labelLogs.AutoSize = true;
            labelLogs.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            labelLogs.Location = new Point(446, 270);
            labelLogs.Name = "labelLogs";
            labelLogs.Size = new Size(132, 20);
            labelLogs.TabIndex = 6;
            labelLogs.Text = "Inventory Logs";

            dataGridViewLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLogs.Location = new Point(446, 300);
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.ReadOnly = true;
            dataGridViewLogs.RowHeadersWidth = 51;
            dataGridViewLogs.Size = new Size(529, 300);
            dataGridViewLogs.TabIndex = 5;

            btnSubmit.Location = new Point(93, 417);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(292, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit Adjustment";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;

            txtReason.Location = new Point(234, 210);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(175, 80);
            txtReason.TabIndex = 3;

            label2.AutoSize = true;
            label2.Location = new Point(59, 233);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 2;
            label2.Text = "Adjustment Reason:";

            numericUpDownAdjustment.Location = new Point(259, 114);
            numericUpDownAdjustment.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownAdjustment.Minimum = new decimal(new int[] { 1000, 0, 0, -2147483648 });
            numericUpDownAdjustment.Name = "numericUpDownAdjustment";
            numericUpDownAdjustment.Size = new Size(150, 27);
            numericUpDownAdjustment.TabIndex = 1;

            label1.AutoSize = true;
            label1.Location = new Point(59, 121);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 0;
            label1.Text = "Adjustment Quantity:";

            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 650);
            Controls.Add(groupBox1);
            Name = "InventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += InventoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdjustment).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dataGridViewInventory;
        private GroupBox groupBox1;
        private Label label2;
        private NumericUpDown numericUpDownAdjustment;
        private Label label1;
        private TextBox txtReason;
        private Button btnSubmit;
        private DataGridView dataGridViewLogs;
        private Label labelLogs;
        private Button btnRefresh;
        private Label statusLabel;
        private Label lblSelectedProduct;
    }
}