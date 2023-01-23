using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuBes_1214057_1214079.model;
using TuBes_1214057_1214079.controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TuBes_1214057_1214079
{
    public partial class FormJenisObat : Form
    {
        Koneksi koneksi = new Koneksi();
        M_jenisobat m_jnobt = new M_jenisobat();
        string id;
        public void Tampil()
        {
            //Query DB
            DataJenisObat.DataSource = koneksi.ShowData("SELECT *FROM jenisobat");

            //Mengubah Nama Kolom Tabel
            DataJenisObat.Columns[0].HeaderText = "Jenis Obat";
            DataJenisObat.Columns[1].HeaderText = "Keterangan";
        }
        public FormJenisObat()
        {
            InitializeComponent();
        }

        private void FormJenisObat_Load_1(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (jenis_obat.Text == "" || keterangan.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Jenisobat jnobt = new Jenisobat();
                m_jnobt.Jenis_obat = jenis_obat.Text;
                m_jnobt.Keterangan = keterangan.Text;

                jnobt.Insert(m_jnobt);

                jenis_obat.Text = "";
                keterangan.Text = "";

                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (jenis_obat.Text == "" || keterangan.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Jenisobat jnobt = new Jenisobat();
                m_jnobt.Jenis_obat = jenis_obat.Text;
                m_jnobt.Keterangan = keterangan.Text;

                jnobt.Update(m_jnobt, id);

                jenis_obat.Text = "";
                keterangan.Text = "";

                Tampil();
            }
        }

        private void DataJenisObat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataJenisObat.Rows[e.RowIndex].Cells[0].Value.ToString();
            jenis_obat.Text = DataJenisObat.Rows[e.RowIndex].Cells[0].Value.ToString();
            keterangan.Text = DataJenisObat.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            jenis_obat.Text = "";
            keterangan.Text = "";

            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Jenisobat jnobt = new Jenisobat();
                jnobt.Delete(id);

                jenis_obat.Text = "";
                keterangan.Text = "";
                Tampil();
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search data
            DataJenisObat.DataSource = koneksi.ShowData("SELECT * FROM jenisobat WHERE jenis_obat LIKE '%' '" + tbCariData.Text + "' '%' OR keterangan LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void btMn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btMx_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
