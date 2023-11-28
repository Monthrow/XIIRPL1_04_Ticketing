namespace XIIRPL1_04_Ticketing.MasterForm
{
    partial class JP
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
            id = new TextBox();
            waktu = new DateTimePicker();
            tanggal = new DateTimePicker();
            dari = new ComboBox();
            ke = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            maskapai = new ComboBox();
            btn_simpan = new Button();
            button1 = new Button();
            harga = new NumericUpDown();
            durasi = new TextBox();
            kode = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)harga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // id
            // 
            id.Location = new Point(730, 37);
            id.Name = "id";
            id.Size = new Size(48, 23);
            id.TabIndex = 64;
            // 
            // waktu
            // 
            waktu.CustomFormat = "hh:mm:ss";
            waktu.Format = DateTimePickerFormat.Time;
            waktu.Location = new Point(478, 309);
            waktu.Name = "waktu";
            waktu.ShowUpDown = true;
            waktu.Size = new Size(200, 23);
            waktu.TabIndex = 63;
            // 
            // tanggal
            // 
            tanggal.Location = new Point(477, 273);
            tanggal.Name = "tanggal";
            tanggal.Size = new Size(200, 23);
            tanggal.TabIndex = 62;
            // 
            // dari
            // 
            dari.FormattingEnabled = true;
            dari.Location = new Point(129, 309);
            dari.Name = "dari";
            dari.Size = new Size(176, 23);
            dari.TabIndex = 61;
            // 
            // ke
            // 
            ke.FormattingEnabled = true;
            ke.Location = new Point(129, 347);
            ke.Name = "ke";
            ke.Size = new Size(176, 23);
            ke.TabIndex = 60;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(346, 381);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 59;
            label9.Text = "Harga Tiket";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(346, 347);
            label10.Name = "label10";
            label10.Size = new Size(113, 15);
            label10.TabIndex = 58;
            label10.Text = "Durasi Penerbangan";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(346, 312);
            label11.Name = "label11";
            label11.Size = new Size(123, 15);
            label11.TabIndex = 57;
            label11.Text = "Waktu Keberangkatan";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(346, 273);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 56;
            label12.Text = "Tanggal";
            // 
            // maskapai
            // 
            maskapai.FormattingEnabled = true;
            maskapai.Location = new Point(129, 381);
            maskapai.Name = "maskapai";
            maskapai.Size = new Size(176, 23);
            maskapai.TabIndex = 55;
            // 
            // btn_simpan
            // 
            btn_simpan.Location = new Point(602, 415);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(75, 23);
            btn_simpan.TabIndex = 54;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = true;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(492, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 53;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // harga
            // 
            harga.Location = new Point(478, 379);
            harga.Name = "harga";
            harga.Size = new Size(199, 23);
            harga.TabIndex = 52;
            // 
            // durasi
            // 
            durasi.Location = new Point(478, 347);
            durasi.Name = "durasi";
            durasi.Size = new Size(199, 23);
            durasi.TabIndex = 51;
            // 
            // kode
            // 
            kode.Location = new Point(129, 273);
            kode.Name = "kode";
            kode.Size = new Size(176, 23);
            kode.TabIndex = 50;
            kode.TextChanged += kode_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 381);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 49;
            label6.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 347);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 48;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 312);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 47;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 273);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 46;
            label3.Text = "Kode Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 45);
            label2.Name = "label2";
            label2.Size = new Size(256, 15);
            label2.TabIndex = 45;
            label2.Text = "Semua jadwal penerbangan akan muncul disini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(23, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(755, 183);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 12);
            label1.Name = "label1";
            label1.Size = new Size(288, 30);
            label1.TabIndex = 43;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // JP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(id);
            Controls.Add(waktu);
            Controls.Add(tanggal);
            Controls.Add(dari);
            Controls.Add(ke);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(maskapai);
            Controls.Add(btn_simpan);
            Controls.Add(button1);
            Controls.Add(harga);
            Controls.Add(durasi);
            Controls.Add(kode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "JP";
            Text = "JP";
            Load += JP_Load;
            ((System.ComponentModel.ISupportInitialize)harga).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id;
        private DateTimePicker waktu;
        private DateTimePicker tanggal;
        private ComboBox dari;
        private ComboBox ke;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox maskapai;
        private Button btn_simpan;
        private Button button1;
        private NumericUpDown harga;
        private TextBox durasi;
        private TextBox kode;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Label label1;
    }
}