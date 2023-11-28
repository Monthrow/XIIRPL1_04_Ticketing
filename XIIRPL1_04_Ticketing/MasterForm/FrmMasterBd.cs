using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace XIIRPL1_04_Ticketing.MasterForm
{
    public partial class FrmMasterBd : Form
    {
        ComboBoxFunction cb = new ComboBoxFunction();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        int Record_id;

        public FrmMasterBd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMasterBd_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();

            string query = "SELECT * FROM db_ticket_xii_rpl_1_04.tbl_negara";
            //ComboBoxFunction.Set_ComboBox(query, "nama", txtNegara);
            txtNegara.DataSource = cb.getData(query);
            txtNegara.DisplayMember = "nama";
            txtNegara.ValueMember = "id";
            
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_04.tbl_bandara" +
                    "(id,nama,kode_iata,kota,negara_id,jumlah_terminal,alamat)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtNama.Text + "'," +
                    "'" + txtIata.Text + "'," +
                    "'" + txtKota.Text + "'," +
                    "'" + txtNegara.SelectedValue + "'," +
                    "'" + txtTerminal.Text + "'," +
                    "'" + txtAlamat.Text + "')";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Bandara");
                Koneksi.conn.Close();
                view_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void view_data()
        {
            string sql = "SELECT db_ticket_xii_rpl_1_04.tbl_bandara.id, " +
                         "db_ticket_xii_rpl_1_04.tbl_bandara.nama, " +
                         "db_ticket_xii_rpl_1_04.tbl_bandara.kode_iata, " +
                         "db_ticket_xii_rpl_1_04.tbl_bandara.kota, " +
                         "db_ticket_xii_rpl_1_04.tbl_negara.nama, " +
                         "db_ticket_xii_rpl_1_04.tbl_bandara.jumlah_terminal " +
                         "FROM db_ticket_xii_rpl_1_04.tbl_bandara INNER JOIN " +
                         "db_ticket_xii_rpl_1_04.tbl_negara ON db_ticket_xii_rpl_1_04.tbl_bandara.negara_id = db_ticket_xii_rpl_1_04.tbl_negara.id";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, Koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].HeaderText = "ID";
            dataGridView1.Columns[3].HeaderText = "Nama Bandara";
            dataGridView1.Columns[4].HeaderText = "Kode IATA";
            dataGridView1.Columns[5].HeaderText = "Kota";
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            Koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_04.tbl_bandara where id in(select max(id) FROM db_ticket_xii_rpl_1_04.tbl_bandara) order by id desc";
            cmd = new NpgsqlCommand(sql, Koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                nomor = Convert.ToInt32(dr[0]);
                hitung = nomor + 1;
            }
            else
            {
                hitung = 1;
            }
            dr.Close();
            id.Text = Convert.ToString(hitung);
            Koneksi.conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    Koneksi.conn.Open();
                    String sql = "DELETE FROM db_ticket_xii_rpl_1_04.tbl_bandara WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, Koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Koneksi.conn.Close();
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                id.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                txtNama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nama"].Value);
                txtIata.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["kode_iata"].Value);
                txtKota.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["kota"].Value);
                txtNegara.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["negara_id"].Value);
                txtTerminal.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["jumlah_terminal"].Value);
                txtAlamat.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["alamat"].Value);
                btn_simpan.Enabled = false;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "UPDATE db_ticket_xii_rpl_1_04.tbl_bandara SET " +
                    "nama = '" + txtNama.Text + "'," +
                    "kode_iata = '" + txtIata.Text + "'," +
                    "kota = '" + txtKota.Text + "'," +
                    "negara_id = '" + txtNegara.Text + "'," +
                    "jumlah_terminal = '" + txtTerminal.Text + "'," +
                    "alamat = '" + txtAlamat.Text + "'" +
                    "WHERE id = '" + id.Text + "'";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Ubah Data Bandara");
                view_data();
                Koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
