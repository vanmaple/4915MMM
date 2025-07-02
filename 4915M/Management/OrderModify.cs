using System;
using System.Windows.Forms;
using DatabaseAccessController;
using MySql.Data.MySqlClient;

namespace _4915M.新文件夹
{
    public partial class OrderModify : Form
    {
        private string connectionString = "Server=localhost;Database=yourdbname;Uid=yourusername;Pwd=yourpassword;";
        private dboToyOrderController orderController;
        private pManagement parentForm;

        public void SetToyID(int toyID)
        {
            txtTID.Text = toyID.ToString();
        }

        public OrderModify(pManagement parent)
        {
            InitializeComponent();
            orderController = new dboToyOrderController(connectionString);
            parentForm = parent;
        }

        private void OrderModify_Load(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtTID.Text, out int toyID) || toyID <= 0)
                {
                    MessageBox.Show("Please enter a valid Toy ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!chbCategory.Checked && !chbBrand.Checked && !chbQuantity.Checked && !chbDescription.Checked)
                {
                    MessageBox.Show("Please select at least one field to modify", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string updateSql = "UPDATE toys SET ";
                        bool hasUpdates = false;

                        if (chbCategory.Checked)
                        {
                            updateSql += "category = @category";
                            hasUpdates = true;
                        }

                        if (chbBrand.Checked)
                        {
                            if (hasUpdates) updateSql += ", ";
                            updateSql += "brand = @brand";
                            hasUpdates = true;
                        }

                        if (chbDescription.Checked)
                        {
                            if (hasUpdates) updateSql += ", ";
                            updateSql += "description = @description";
                            hasUpdates = true;
                        }

                        if (chbQuantity.Checked)
                        {
                            if (!int.TryParse(txtQuantity.Text, out int newQuantity) || newQuantity <= 0)
                            {
                                MessageBox.Show("Please enter a valid quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string updateOrderSql = "UPDATE orders SET quantity = @quantity WHERE toy_id = @toyID";
                            using (MySqlCommand orderCmd = new MySqlCommand(updateOrderSql, conn, transaction))
                            {
                                orderCmd.Parameters.AddWithValue("@quantity", newQuantity);
                                orderCmd.Parameters.AddWithValue("@toyID", toyID);
                                orderCmd.ExecuteNonQuery();
                            }
                        }

                        if (hasUpdates)
                        {
                            updateSql += " WHERE toy_id = @toyID";
                            using (MySqlCommand cmd = new MySqlCommand(updateSql, conn, transaction))
                            {
                                if (chbCategory.Checked)
                                    cmd.Parameters.AddWithValue("@category", txtCategory.Text.Trim());

                                if (chbBrand.Checked)
                                    cmd.Parameters.AddWithValue("@brand", txtBrand.Text.Trim());

                                if (chbDescription.Checked)
                                    cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());

                                cmd.Parameters.AddWithValue("@toyID", toyID);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Order modified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        parentForm.RefreshOrders();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error occurred while modifying order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbCategory_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
