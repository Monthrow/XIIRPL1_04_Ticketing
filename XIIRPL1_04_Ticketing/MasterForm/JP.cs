using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL1_04_Ticketing.MasterForm
{
    public partial class JP : Form
    {
        ComboBoxFunction cb = new ComboBoxFunction();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        int Record_id;
        public JP()
        {
            InitializeComponent();
        }

        private void JP_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();

            string negaraquery = "SELECT * FROM db_ticket_xii_rpl_1_04.tbl_negara";
            //ComboBoxFunction.Set_ComboBox(negaraquery, "nama", dari);
            //ComboBoxFunction.Set_ComboBox(negaraquery, "nama", ke);
            dari.DataSource = cb.getData(negaraquery);
            dari.DisplayMember = "nama";
            dari.ValueMember = "id";

            ke.DataSource = cb.getData(negaraquery);
            ke.DisplayMember = "nama";
            ke.ValueMember = "id";

            string maskapaiquery = "SELECT * FROM db_ticket_xii_rpl_1_04.tbl_maskapai";
            //ComboBoxFunction.Set_ComboBox(maskapaiquery, "nama", maskapai);
            maskapai.DataSource = cb.getData(maskapaiquery);
            maskapai.DisplayMember = "nama";
            maskapai.ValueMember = "id";
        }

        private void kode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_04.tbl_jadwalpenerbangan" +
                    "(id,kode_penerbangan,bdr_keberangkatan_id,bdr_tujuan_id,maskapai_id,tgl_keberangkatan,waktu_keberangkatan,durasi_penerbangan,hrg_per_tiket)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + kode.Text + "'," +
                    "'" + dari.SelectedValue + "'," +
                    "'" + ke.SelectedValue + "'," +
                    "'" + maskapai.SelectedValue + "'," +
                    "'" + tanggal.Text + "'," +
                    "'" + waktu.Text + "'," +
                    "'" + durasi.Text + "'," +
                    "'" + harga.Text + "')";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Jadwal Penerbangan");
                Koneksi.conn.Close();
                view_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    Koneksi.conn.Open();
                    String sql = "DELETE FROM db_ticket_xii_rpl_1_04.tbl_jadwalpenerbangan WHERE id=@id";
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
        }

        public void view_data()
        {
            string sql = "SELECT db_ticket_xii_rpl_1_04.tbl_jadwalpenerbangan.id, " +
                         "db_ticket_xii_rpl_1_04.tbl_jadwalpenerbangan.bdr_keberangkatan_id, " +
                         "db_ticket_xii_rpl_1_04.tbl_jadwalpenerbangan.bdr_tujuan_id, " +
                         "db_ticket_xii_rpl_1_04.tbl_maskapai.nama " +
                         "FROM db_ticket_xii_rpl_1_04.tbl_jadwalpenerbangan INNER JOIN " +
                         "db_ticket_xii_rpl_1_04.tbl_maskapai ON db_ticket_xii_rpl_1_04.tbl_jadwalpenerbangan.maskapai_id = db_ticket_xii_rpl_1_04.tbl_maskapai.id";

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, Koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].HeaderText = "ID";
            dataGridView1.Columns[3].HeaderText = "Bandara Keberangkatan";
            dataGridView1.Columns[4].HeaderText = "Bandara Tujuan";
            dataGridView1.Columns[5].HeaderText = "Nama Maskapai";
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            Koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_04.tbl_jadwalpenerbangan where id in(select max(id) FROM db_ticket_xii_rpl_1_04.tbl_jadwalpenerbangan) order by id desc";
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
    }
}
