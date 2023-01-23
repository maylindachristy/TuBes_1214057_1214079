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
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi(); 
        M_obat m_obt = new M_obat(); 
        string id;
        public void Tampil()
        {
            //Query DB
            DataObat.DataSource = koneksi.ShowData("SELECT *FROM obat");

            //Mengubah Nama Kolom Tabel
            DataObat.Columns[0].HeaderText = "Nama Obat";
            DataObat.Columns[1].HeaderText = "Jenis Obat";
            DataObat.Columns[2].HeaderText = "Stok";
            DataObat.Columns[3].HeaderText = "Keterangan";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (nama_obat.Text == "" || jenis_obat.SelectedIndex == -1 ||stok.Text == "" || keterangan.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obat obt = new Obat();
                m_obt.Nama_obat = nama_obat.Text;
                m_obt.Jenis_obat = jenis_obat.Text;
                m_obt.Stok = stok.Text;
                m_obt.Keterangan = keterangan.Text;

                obt.Insert(m_obt);

                nama_obat.Text = "";
                jenis_obat.SelectedIndex = -1;
                stok.Text = "";
                keterangan.Text = "";

                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (nama_obat.Text == "" || jenis_obat.SelectedIndex == -1 || stok.Text == "" || keterangan.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obat obt = new Obat();
                m_obt.Nama_obat = nama_obat.Text;
                m_obt.Jenis_obat = jenis_obat.Text;
                m_obt.Stok = stok.Text;
                m_obt.Keterangan = keterangan.Text;

                obt.Update(m_obt, id);

                nama_obat.Text = "";
                jenis_obat.SelectedIndex = -1;
                stok.Text = "";
                keterangan.Text = "";

                Tampil();
            }
        }

        private void DataObat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataObat.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama_obat.Text = DataObat.Rows[e.RowIndex].Cells[0].Value.ToString();
            jenis_obat.Text = DataObat.Rows[e.RowIndex].Cells[1].Value.ToString();
            stok.Text = DataObat.Rows[e.RowIndex].Cells[2].Value.ToString();
            keterangan.Text = DataObat.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            nama_obat.Text = "";
            jenis_obat.SelectedIndex = -1;
            stok.Text = "";
            keterangan.Text = "";

            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Obat obt = new Obat();
                obt.Delete(id);

                nama_obat.Text = "";
                jenis_obat.SelectedIndex = -1;
                stok.Text = "";
                keterangan.Text = "";

                Tampil();
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search data
            DataObat.DataSource = koneksi.ShowData("SELECT * FROM obat WHERE nama_obat LIKE '%' '" + tbCariData.Text + "' '%' OR keterangan LIKE '%' '" + tbCariData.Text + "' '%'");
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
