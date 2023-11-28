namespace XIIRPL1_04_Ticketing.MasterForm
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPassword = new TextBox();
            txtNomortlp = new TextBox();
            txtNama = new TextBox();
            txtUsername = new TextBox();
            txtTglLahir = new DateTimePicker();
            pictureBox1 = new PictureBox();
            btnDaftar = new Button();
            label8 = new Label();
            txtLinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 28);
            label1.Name = "label1";
            label1.Size = new Size(234, 50);
            label1.TabIndex = 0;
            label1.Text = "Daftar Akun\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 78);
            label2.Name = "label2";
            label2.Size = new Size(304, 15);
            label2.TabIndex = 1;
            label2.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 118);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 164);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Nama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 205);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 4;
            label5.Text = "Tanggal Lahir";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 299);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 252);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 6;
            label7.Text = "Nomor Telepon";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(177, 291);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtNomortlp
            // 
            txtNomortlp.Location = new Point(177, 244);
            txtNomortlp.Name = "txtNomortlp";
            txtNomortlp.Size = new Size(200, 23);
            txtNomortlp.TabIndex = 8;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(177, 156);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(200, 23);
            txtNama.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(177, 118);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 11;
            // 
            // txtTglLahir
            // 
            txtTglLahir.Location = new Point(177, 197);
            txtTglLahir.Name = "txtTglLahir";
            txtTglLahir.Size = new Size(200, 23);
            txtTglLahir.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(426, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(302, 332);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(75, 32);
            btnDaftar.TabIndex = 14;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 403);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 15;
            label8.Text = "Sudah punya akun?";
            label8.Click += label8_Click;
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Location = new Point(145, 403);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(37, 15);
            txtLinkLabel.TabIndex = 16;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Login";
            txtLinkLabel.LinkClicked += txtLinkLabel_LinkClicked;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLinkLabel);
            Controls.Add(label8);
            Controls.Add(btnDaftar);
            Controls.Add(pictureBox1);
            Controls.Add(txtTglLahir);
            Controls.Add(txtUsername);
            Controls.Add(txtNama);
            Controls.Add(txtNomortlp);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPassword;
        private TextBox txtNomortlp;
        private TextBox txtNama;
        private TextBox txtUsername;
        private DateTimePicker txtTglLahir;
        private PictureBox pictureBox1;
        private Button btnDaftar;
        private Label label8;
        private LinkLabel txtLinkLabel;
    }
}