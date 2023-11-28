namespace XIIRPL1_04_Ticketing.MasterForm
{
    partial class FrmMasterBd
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNama = new TextBox();
            txtIata = new TextBox();
            txtKota = new TextBox();
            txtTerminal = new NumericUpDown();
            txtAlamat = new RichTextBox();
            btn_batal = new Button();
            btn_simpan = new Button();
            txtNegara = new ComboBox();
            id = new TextBox();
            btnedit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTerminal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 11);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 0;
            label1.Text = "Master Bandara";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(23, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(755, 183);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 44);
            label2.Name = "label2";
            label2.Size = new Size(269, 15);
            label2.TabIndex = 2;
            label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 272);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 311);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Kode IATA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 346);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 5;
            label5.Text = "Kota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 380);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 6;
            label6.Text = "Negara";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 272);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 7;
            label7.Text = "Jumlah Terminal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(360, 311);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 8;
            label8.Text = "Alamat";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(129, 272);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(176, 23);
            txtNama.TabIndex = 9;
            // 
            // txtIata
            // 
            txtIata.Location = new Point(129, 311);
            txtIata.Name = "txtIata";
            txtIata.Size = new Size(176, 23);
            txtIata.TabIndex = 10;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(129, 346);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(176, 23);
            txtKota.TabIndex = 11;
            // 
            // txtTerminal
            // 
            txtTerminal.Location = new Point(478, 272);
            txtTerminal.Name = "txtTerminal";
            txtTerminal.Size = new Size(217, 23);
            txtTerminal.TabIndex = 12;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(478, 308);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(217, 76);
            txtAlamat.TabIndex = 13;
            txtAlamat.Text = "";
            // 
            // btn_batal
            // 
            btn_batal.Location = new Point(703, 414);
            btn_batal.Name = "btn_batal";
            btn_batal.Size = new Size(75, 23);
            btn_batal.TabIndex = 14;
            btn_batal.Text = "Batal";
            btn_batal.UseVisualStyleBackColor = true;
            // 
            // btn_simpan
            // 
            btn_simpan.Location = new Point(509, 415);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(75, 23);
            btn_simpan.TabIndex = 15;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = true;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(129, 380);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(176, 23);
            txtNegara.TabIndex = 16;
            // 
            // id
            // 
            id.Location = new Point(726, 36);
            id.Name = "id";
            id.Size = new Size(52, 23);
            id.TabIndex = 17;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(605, 415);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(75, 23);
            btnedit.TabIndex = 18;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // FrmMasterBd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnedit);
            Controls.Add(id);
            Controls.Add(txtNegara);
            Controls.Add(btn_simpan);
            Controls.Add(btn_batal);
            Controls.Add(txtAlamat);
            Controls.Add(txtTerminal);
            Controls.Add(txtKota);
            Controls.Add(txtIata);
            Controls.Add(txtNama);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FrmMasterBd";
            Text = "FrmMasterBd";
            Load += FrmMasterBd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNama;
        private TextBox txtIata;
        private TextBox txtKota;
        private NumericUpDown txtTerminal;
        private RichTextBox txtAlamat;
        private Button btn_batal;
        private Button btn_simpan;
        private ComboBox txtNegara;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnedit;
    }
}