
namespace _4915M
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblCName = new Label();
            lblUName = new Label();
            lblPassword = new Label();
            txtPsw = new TextBox();
            txtUName = new TextBox();
            btnLogin = new Button();
            rbtUser = new RadioButton();
            rbtAdmin = new RadioButton();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblCName
            // 
            lblCName.AutoSize = true;
            lblCName.BackColor = SystemColors.Window;
            lblCName.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblCName.Location = new Point(159, 9);
            lblCName.Name = "lblCName";
            lblCName.Size = new Size(475, 39);
            lblCName.TabIndex = 0;
            lblCName.Text = "Smile And Sunshine Toy Co Ltd";
            // 
            // lblUName
            // 
            lblUName.AutoSize = true;
            lblUName.BackColor = Color.Transparent;
            lblUName.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblUName.Location = new Point(98, 140);
            lblUName.Name = "lblUName";
            lblUName.Size = new Size(178, 39);
            lblUName.TabIndex = 1;
            lblUName.Text = "UserName:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblPassword.Location = new Point(104, 217);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(164, 39);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            lblPassword.Click += label2_Click;
            // 
            // txtPsw
            // 
            txtPsw.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtPsw.Location = new Point(274, 220);
            txtPsw.Name = "txtPsw";
            txtPsw.Size = new Size(205, 38);
            txtPsw.TabIndex = 4;
            txtPsw.TextChanged += txtPassword_TextChanged;
            // 
            // txtUName
            // 
            txtUName.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtUName.Location = new Point(274, 143);
            txtUName.Name = "txtUName";
            txtUName.Size = new Size(205, 38);
            txtUName.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnLogin.ForeColor = Color.Lime;
            btnLogin.Location = new Point(194, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 44);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // rbtUser
            // 
            rbtUser.AutoSize = true;
            rbtUser.BackColor = Color.Transparent;
            rbtUser.Checked = true;
            rbtUser.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rbtUser.Location = new Point(185, 285);
            rbtUser.Name = "rbtUser";
            rbtUser.Size = new Size(143, 35);
            rbtUser.TabIndex = 7;
            rbtUser.TabStop = true;
            rbtUser.Text = "Customer";
            rbtUser.UseVisualStyleBackColor = false;
            rbtUser.CheckedChanged += rbtUser_CheckedChanged;
            // 
            // rbtAdmin
            // 
            rbtAdmin.AutoSize = true;
            rbtAdmin.BackColor = Color.Transparent;
            rbtAdmin.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rbtAdmin.Location = new Point(401, 285);
            rbtAdmin.Name = "rbtAdmin";
            rbtAdmin.Size = new Size(107, 35);
            rbtAdmin.TabIndex = 8;
            rbtAdmin.Text = "Admin";
            rbtAdmin.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnLogout.ForeColor = Color.Lime;
            btnLogout.Location = new Point(384, 326);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(134, 44);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(794, 439);
            Controls.Add(btnLogout);
            Controls.Add(rbtAdmin);
            Controls.Add(rbtUser);
            Controls.Add(btnLogin);
            Controls.Add(txtUName);
            Controls.Add(txtPsw);
            Controls.Add(lblPassword);
            Controls.Add(lblUName);
            Controls.Add(lblCName);
            ForeColor = SystemColors.ControlText;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login System";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void rbtUser_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label lblCName;
        private Label lblUName;
        private Label lblPassword;
        private TextBox txtPsw;
        private TextBox txtUName;
        private Button btnLogin;
        private RadioButton rbtUser;
        private RadioButton rbtAdmin;
        private Button btnLogout;
    }
}
