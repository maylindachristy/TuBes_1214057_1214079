using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuBes_1214057_1214079.controller;
using TuBes_1214057_1214079.model;

namespace TuBes_1214057_1214079.view
{
    public partial class FormPresensi : Form
    {
        Koneksi koneksi = new Koneksi();
        M_presensi m_prs = new M_presensi();
        string id;

        public void Tampil()
        {
            //Query DB
            DataPresensi.DataSource = koneksi.ShowData("SELECT *FROM presensi");

            //Mengubah Nama Kolom Tabel
            DataPresensi.Columns[0].HeaderText = "Kode Absen";
            DataPresensi.Columns[1].HeaderText = "Nama Karyawan";
            DataPresensi.Columns[2].HeaderText = "Jam Masuk";
            DataPresensi.Columns[3].HeaderText = "Jam Keluar";
            DataPresensi.Columns[4].HeaderText = "Tanggal";
        }
        public FormPresensi()
        {
            InitializeComponent();
        }

        private void FormPresensi_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (kode_presensi.Text == "" || nama_karyawan.Text == "" || jammasuk.Text == "" || jamkeluar.Text == "" || tanggal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Presensi prs = new Presensi();
                m_prs.Kode_presensi = kode_presensi.Text;
                m_prs.Nama_karyawan = nama_karyawan.Text;
                m_prs.Jammasuk = jammasuk.Text;
                m_prs.Jamkeluar = jamkeluar.Text;
                m_prs.Tanggal = tanggal.Text;

                prs.Insert(m_prs);

                kode_presensi.Text = "";
                nama_karyawan.Text = "";
                jammasuk.Text = "";
                jamkeluar.Text = "";
                tanggal.Text = "";

                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (kode_presensi.Text == "" || nama_karyawan.Text == "" || jammasuk.Text == "" || jamkeluar.Text == "" || tanggal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Presensi prs = new Presensi();
                m_prs.Kode_presensi = kode_presensi.Text;
                m_prs.Nama_karyawan = nama_karyawan.Text;
                m_prs.Jammasuk = jammasuk.Text;
                m_prs.Jamkeluar = jamkeluar.Text;
                m_prs.Tanggal = tanggal.Text;

                prs.Update(m_prs, id);

                kode_presensi.Text = "";
                nama_karyawan.Text = "";
                jammasuk.Text = "";
                jamkeluar.Text = "";
                tanggal.Text = "";

                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Presensi prs = new Presensi();
                prs.Delete(id);

                kode_presensi.Text = "";
                nama_karyawan.Text = "";
                jammasuk.Text = "";
                jamkeluar.Text = "";
                tanggal.Text = "";
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            kode_presensi.Text = "";
            nama_karyawan.Text = "";
            jammasuk.Text = "";
            jamkeluar.Text = "";
            tanggal.Text = "";

            Tampil();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search data
            DataPresensi.DataSource = koneksi.ShowData("SELECT * FROM presensi WHERE nama_karyawan LIKE '%' '" + tbCariData.Text + "' '%' OR tanggal LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void DataPresensi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataPresensi.Rows[e.RowIndex].Cells[0].Value.ToString();
            kode_presensi.Text = DataPresensi.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama_karyawan.Text = DataPresensi.Rows[e.RowIndex].Cells[1].Value.ToString();
            jammasuk.Text = DataPresensi.Rows[e.RowIndex].Cells[2].Value.ToString();
            jamkeluar.Text = DataPresensi.Rows[e.RowIndex].Cells[3].Value.ToString();
            tanggal.Text = DataPresensi.Rows[e.RowIndex].Cells[4].Value.ToString();
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
