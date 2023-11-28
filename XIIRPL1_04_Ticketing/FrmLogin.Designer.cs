namespace XIIRPL1_04_Ticketing
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtLinkLabel = new LinkLabel();
            btnLogin = new Button();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Location = new Point(371, 390);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(96, 15);
            txtLinkLabel.TabIndex = 16;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Daftar Sekarang !";
            txtLinkLabel.LinkClicked += txtLinkLabel_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(580, 370);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(71, 35);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login\r\n";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 390);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 14;
            label3.Text = "Belum Punya Akun?";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(300, 253);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(288, 23);
            txtUsername.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(300, 303);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(288, 23);
            txtPassword.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 311);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 11;
            label2.Text = "Password\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 256);
            label1.Name = "label1";
            label1.Size = new Size(60, 45);
            label1.TabIndex = 10;
            label1.Text = "Username\r\n\r\n\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 160);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLinkLabel);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmLogin";
            Text = "Login";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel txtLinkLabel;
        private Button btnLogin;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}