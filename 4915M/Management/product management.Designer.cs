
using _4915M.Management;
using System.Data;

namespace _4915M
{
    partial class pManagement
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
            btnAdd = new Button();
            btnDelete = new Button();
            btnModify = new Button();
            btnrefresh = new Button();
            txtToyID = new TextBox();
            btnSearch = new Button();
            mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnAdd.Location = new Point(820, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 68);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add product order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnDelete.Location = new Point(1001, 31);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 68);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete product order";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnModify
            // 
            btnModify.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnModify.Location = new Point(820, 168);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(149, 68);
            btnModify.TabIndex = 3;
            btnModify.Text = "Modify order information";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnrefresh.Location = new Point(1001, 168);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(149, 68);
            btnrefresh.TabIndex = 4;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += button4_Click;
            // 
            // txtToyID
            // 
            txtToyID.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtToyID.Location = new Point(810, 294);
            txtToyID.Name = "txtToyID";
            txtToyID.Size = new Size(176, 38);
            txtToyID.TabIndex = 5;
            txtToyID.TextChanged += txtToyID_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSearch.Location = new Point(1001, 282);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.Yes;
            btnSearch.Size = new Size(149, 68);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Order inquiry";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click_1;
            // 
            // mySqlDataAdapter1
            // 
            mySqlDataAdapter1.DeleteCommand = null;
            mySqlDataAdapter1.InsertCommand = null;
            mySqlDataAdapter1.SelectCommand = null;
            mySqlDataAdapter1.UpdateBatchSize = 0;
            mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(765, 479);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 505);
            Controls.Add(btnSearch);
            Controls.Add(txtToyID);
            Controls.Add(btnrefresh);
            Controls.Add(btnModify);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "pManagement";
            Text = "Product Management";
            Load += pManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtToyID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pManagement_Load(object sender, EventArgs e)
        {
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string toyName = txtToyID.Text;

            try
            {
                DataTable searchResult = toyOrderController.SearchOrders(currentCustomerID, toyName);
                dataGridView1.DataSource = searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching orders: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadToysForCustomer(currentCustomerID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrder addOrderForm = new AddOrder(this, currentCustomerID);
            addOrderForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion
        private Button btnAdd;
        private Button btnDelete;
        private Button btnModify;
        private Button btnrefresh;
        private TextBox txtToyID;
        private Button btnSearch;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private DataGridView dataGridView1;
    }
}