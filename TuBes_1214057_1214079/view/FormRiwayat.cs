using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuBes_1214057_1214079.view
{
    public partial class FormRiwayat : Form
    {
        Koneksi koneksi = new Koneksi();
        public void Tampil()
        {
            //Query DB
            DataRiwayat.DataSource = koneksi.ShowData("SELECT karyawan.nama_karyawan, karyawan.alamat, presensi.jammasuk, presensi.jamkeluar, presensi.tanggal FROM (karyawan INNER JOIN presensi ON karyawan.nama_karyawan = presensi.nama_karyawan);");

            //Mengubah Nama Kolom Tabel
            DataRiwayat.Columns[0].HeaderText = "Nama karyawan";
            DataRiwayat.Columns[1].HeaderText = "Email";
            DataRiwayat.Columns[2].HeaderText = "Jam Masuk";
            DataRiwayat.Columns[3].HeaderText = "Jam Keluar";
            DataRiwayat.Columns[4].HeaderText = "Tanggal"; 
        }
        public FormRiwayat()
        {
            InitializeComponent();
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

        private void FormRiwayat_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
        }

        private void DataRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
