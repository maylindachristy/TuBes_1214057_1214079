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
    public partial class FormSupplier : Form
    {
        Koneksi koneksi = new Koneksi();
        M_supplier m_spl = new M_supplier();
        string id;
        public void Tampil()
        {
            //Query DB
            DataSupplier.DataSource = koneksi.ShowData("SELECT *FROM supplier");

            //Mengubah Nama Kolom Tabel
            DataSupplier.Columns[0].HeaderText = "Nama Perusahaan";
            DataSupplier.Columns[1].HeaderText = "Nama Obat";
            DataSupplier.Columns[2].HeaderText = "Nomor Telepon";
            DataSupplier.Columns[3].HeaderText = "Alamat";
            DataSupplier.Columns[4].HeaderText = "Email";
        }
        public FormSupplier()
        {
            InitializeComponent();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (nama_perusahaan.Text == "" || nama_obat.Text == "" || nomor_telepon.Text == "" || alamat.Text == "" || email.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Supplier spl = new Supplier();
                m_spl.Nama_perusahaan = nama_perusahaan.Text;
                m_spl.Nama_obat = nama_obat.Text;
                m_spl.Nomor_telepon = nomor_telepon.Text;
                m_spl.Alamat = alamat.Text;
                m_spl.Email = email.Text;

                spl.Insert(m_spl);

                nama_perusahaan.Text = "";
                nama_obat.Text = "";
                nomor_telepon.Text = "";
                alamat.Text = "";
                email.Text = "";

                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (nama_perusahaan.Text == "" || nama_obat.Text == "" || nomor_telepon.Text == "" || alamat.Text == "" || email.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Supplier spl = new Supplier();
                m_spl.Nama_perusahaan = nama_perusahaan.Text;
                m_spl.Nama_obat = nama_obat.Text;
                m_spl.Nomor_telepon = nomor_telepon.Text;
                m_spl.Alamat = alamat.Text;
                m_spl.Email = email.Text;

                spl.Update(m_spl, id);

                nama_perusahaan.Text = "";
                nama_obat.Text = "";
                nomor_telepon.Text = "";
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
                Supplier spl = new Supplier();
                spl.Delete(id);

                nama_perusahaan.Text = "";
                nama_obat.Text = "";
                nomor_telepon.Text = "";
                alamat.Text = "";
                email.Text = "";

                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            nama_perusahaan.Text = "";
            nama_obat.Text = "";
            nomor_telepon.Text = "";
            alamat.Text = "";
            email.Text = "";

            Tampil();
        }

        private void DataSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama_perusahaan.Text = DataSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama_obat.Text = DataSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
            nomor_telepon.Text = DataSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
            alamat.Text = DataSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
            email.Text = DataSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search data
            DataSupplier.DataSource = koneksi.ShowData("SELECT * FROM supplier WHERE nama_perusahaan LIKE '%' '" + tbCariData.Text + "' '%' OR nama_obat LIKE '%' '" + tbCariData.Text + "' '%'");
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
