namespace XIIRPL1_04_Ticketing.MasterForm
{
    partial class FrmMasterKP
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
            btn_simpan = new Button();
            button1 = new Button();
            deskripsi = new RichTextBox();
            maks_diskon = new NumericUpDown();
            kode_promo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label7 = new Label();
            id = new TextBox();
            presentase_diskon = new NumericUpDown();
            berlaku_sampai = new DateTimePicker();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)maks_diskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)presentase_diskon).BeginInit();
            SuspendLayout();
            // 
            // btn_simpan
            // 
            btn_simpan.Location = new Point(602, 415);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(75, 23);
            btn_simpan.TabIndex = 32;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = true;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(492, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 31;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // deskripsi
            // 
            deskripsi.Location = new Point(478, 273);
            deskripsi.Name = "deskripsi";
            deskripsi.Size = new Size(217, 76);
            deskripsi.TabIndex = 30;
            deskripsi.Text = "";
            // 
            // maks_diskon
            // 
            maks_diskon.Location = new Point(129, 381);
            maks_diskon.Name = "maks_diskon";
            maks_diskon.Size = new Size(176, 23);
            maks_diskon.TabIndex = 29;
            // 
            // kode_promo
            // 
            kode_promo.Location = new Point(129, 273);
            kode_promo.Name = "kode_promo";
            kode_promo.Size = new Size(176, 23);
            kode_promo.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 381);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 23;
            label6.Text = "Maksimum Diskon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 347);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 22;
            label5.Text = "Presentase Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 312);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 21;
            label4.Text = "Berlaku Sampai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 273);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 20;
            label3.Text = "Kode Promo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 45);
            label2.Name = "label2";
            label2.Size = new Size(291, 15);
            label2.TabIndex = 19;
            label2.Text = "Semua kode promo yang terdaftar akan muncul disini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(23, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(755, 183);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 12);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 17;
            label1.Text = "Master Kode Promo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 273);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 24;
            label7.Text = "Deskripsi";
            // 
            // id
            // 
            id.Location = new Point(724, 37);
            id.Name = "id";
            id.Size = new Size(54, 23);
            id.TabIndex = 33;
            // 
            // presentase_diskon
            // 
            presentase_diskon.Location = new Point(131, 347);
            presentase_diskon.Name = "presentase_diskon";
            presentase_diskon.Size = new Size(174, 23);
            presentase_diskon.TabIndex = 34;
            // 
            // berlaku_sampai
            // 
            berlaku_sampai.Location = new Point(129, 312);
            berlaku_sampai.Name = "berlaku_sampai";
            berlaku_sampai.Size = new Size(176, 23);
            berlaku_sampai.TabIndex = 35;
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
            // FrmMasterKP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(berlaku_sampai);
            Controls.Add(presentase_diskon);
            Controls.Add(id);
            Controls.Add(btn_simpan);
            Controls.Add(button1);
            Controls.Add(deskripsi);
            Controls.Add(maks_diskon);
            Controls.Add(kode_promo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FrmMasterKP";
            Text = "FrmMasterKP";
            Load += FrmMasterKP_Load;
            ((System.ComponentModel.ISupportInitialize)maks_diskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)presentase_diskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_simpan;
        private Button button1;
        private RichTextBox deskripsi;
        private NumericUpDown maks_diskon;
        private TextBox kode_promo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label7;
        private TextBox id;
        private NumericUpDown presentase_diskon;
        private DateTimePicker berlaku_sampai;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}