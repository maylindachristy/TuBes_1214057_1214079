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
    public partial class FormKonsumen : Form 
    {
        Koneksi koneksi = new Koneksi();
        M_konsumen m_ksm = new M_konsumen();
        string id;
        public void Tampil()
        {
            //Query DB
            DataKonsumen.DataSource = koneksi.ShowData("SELECT *FROM konsumen");

            //Mengubah Nama Kolom Tabel
            DataKonsumen.Columns[0].HeaderText = "Nomor Pesanan";
            DataKonsumen.Columns[1].HeaderText = "Nama Konsumen";
            DataKonsumen.Columns[2].HeaderText = "Nomor Telepon";
            DataKonsumen.Columns[3].HeaderText = "Alamat";
            DataKonsumen.Columns[4].HeaderText = "Email";
        }
        public FormKonsumen()
        {
            InitializeComponent();
        }

        private void FormKonsumen_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (nomor_pesanan.Text == "" || nama_konsumen.Text == "" || no_telepon.Text == "" || alamat.Text == "" || email.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Konsumen ksm = new Konsumen();
                m_ksm.Nomor_pesanan = nomor_pesanan.Text;
                m_ksm.Nama_konsumen = nama_konsumen.Text;
                m_ksm.Nomor_telepon = no_telepon.Text;
                m_ksm.Alamat = alamat.Text;
                m_ksm.Email = email.Text;

                ksm.Insert(m_ksm);

                nomor_pesanan.Text = "";
                nama_konsumen.Text = "";
                no_telepon.Text = "";
                alamat.Text = "";
                email.Text = "";

                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (nomor_pesanan.Text == "" || nama_konsumen.Text == "" || no_telepon.Text == "" || alamat.Text == "" || email.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Konsumen ksm = new Konsumen();
                m_ksm.Nomor_pesanan = nomor_pesanan.Text;
                m_ksm.Nama_konsumen = nama_konsumen.Text;
                m_ksm.Nomor_telepon = no_telepon.Text;
                m_ksm.Alamat = alamat.Text;
                m_ksm.Email = email.Text;

                ksm.Update(m_ksm, id);

                nomor_pesanan.Text = "";
                nama_konsumen.Text = "";
                no_telepon.Text = "";
                alamat.Text = "";
                email.Text = "";

                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Konsumen ksm = new Konsumen();
                ksm.Delete(id);

                nomor_pesanan.Text = "";
                nama_konsumen.Text = "";
                no_telepon.Text = "";
                alamat.Text = "";
                email.Text = "";
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            nomor_pesanan.Text = "";
            nama_konsumen.Text = "";
            no_telepon.Text = "";
            alamat.Text = "";
            email.Text = "";

            Tampil();
        }

        private void DataKonsumen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataKonsumen.Rows[e.RowIndex].Cells[0].Value.ToString();
            nomor_pesanan.Text = DataKonsumen.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama_konsumen.Text = DataKonsumen.Rows[e.RowIndex].Cells[1].Value.ToString();
            no_telepon.Text = DataKonsumen.Rows[e.RowIndex].Cells[2].Value.ToString();
            alamat.Text = DataKonsumen.Rows[e.RowIndex].Cells[3].Value.ToString();
            email.Text = DataKonsumen.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search data
            DataKonsumen.DataSource = koneksi.ShowData("SELECT * FROM konsumen WHERE nama_konsumen LIKE '%' '" + tbCariData.Text + "' '%' OR nomor_pesanan LIKE '%' '" + tbCariData.Text + "' '%'");
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
