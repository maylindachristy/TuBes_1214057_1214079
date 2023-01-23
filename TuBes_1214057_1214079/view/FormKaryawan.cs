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
    public partial class FormKaryawan : Form
    {
        Koneksi koneksi = new Koneksi();
        M_karyawan m_kry = new M_karyawan();
        string id;
        public void Tampil()
        {
            //Query DB
            DataKaryawan.DataSource = koneksi.ShowData("SELECT *FROM karyawan");

            //Mengubah Nama Kolom Tabel
            DataKaryawan.Columns[0].HeaderText = "Nama Karyawan";
            DataKaryawan.Columns[1].HeaderText = "Tempat Tanggal Lahir";
            DataKaryawan.Columns[2].HeaderText = "Email";
            DataKaryawan.Columns[3].HeaderText = "Alamat";
        }
        public FormKaryawan()
        {
            InitializeComponent();
        }

        private void FormKaryawan_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (nama_karyawan.Text == "" || ttl.Text == "" || email.Text == "" || alamat.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Karyawan kry = new Karyawan();
                m_kry.Nama_karyawan = nama_karyawan.Text;
                m_kry.Ttl = ttl.Text;
                m_kry.Email = email.Text;
                m_kry.Alamat = alamat.Text;

                kry.Insert(m_kry);

                nama_karyawan.Text = "";
                ttl.Text = "";
                email.Text = "";
                alamat.Text = "";

                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (nama_karyawan.Text == "" || ttl.Text == "" || email.Text == "" || alamat.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Karyawan kry = new Karyawan();
                m_kry.Nama_karyawan = nama_karyawan.Text;
                m_kry.Ttl = ttl.Text;
                m_kry.Email = email.Text;
                m_kry.Alamat = alamat.Text;

                kry.Update(m_kry, id);

                nama_karyawan.Text = "";
                ttl.Text = "";
                email.Text = "";
                alamat.Text = "";

                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Karyawan kry = new Karyawan();
                kry.Delete(id);

                nama_karyawan.Text = "";
                ttl.Text = "";
                email.Text = "";
                alamat.Text = "";
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            nama_karyawan.Text = "";
            ttl.Text = "";
            email.Text = "";
            alamat.Text = "";

            Tampil();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search data
            DataKaryawan.DataSource = koneksi.ShowData("SELECT * FROM karyawan WHERE nama_karyawan LIKE '%' '" + tbCariData.Text + "' '%' OR email LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void DataKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataKaryawan.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama_karyawan.Text = DataKaryawan.Rows[e.RowIndex].Cells[0].Value.ToString();
            ttl.Text = DataKaryawan.Rows[e.RowIndex].Cells[1].Value.ToString();
            email.Text = DataKaryawan.Rows[e.RowIndex].Cells[2].Value.ToString();
            alamat.Text = DataKaryawan.Rows[e.RowIndex].Cells[3].Value.ToString();
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
