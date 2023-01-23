using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuBes_1214057_1214079.controller;
using TuBes_1214057_1214079.model;

namespace TuBes_1214057_1214079.view
{
    public partial class FormTransaksiKeluar : Form
    {
        Koneksi koneksi = new Koneksi();
        M_transaksikeluar m_tsk = new M_transaksikeluar();
        string id_transaksi;
        public void Tampil()
        {
            //Query DB
            DataTransaksiKeluar.DataSource = koneksi.ShowData("SELECT id_transaksi, transaksikeluar.nama_konsumen, nama_obat, jumlah_obat, harga_jual, tanggal, alamat FROM transaksikeluar JOIN konsumen ON konsumen.nama_konsumen = transaksikeluar.nama_konsumen");

            //Mengubah Nama Kolom Tabel
            DataTransaksiKeluar.Columns[0].HeaderText = "ID Transaksi";
            DataTransaksiKeluar.Columns[1].HeaderText = "Nama Konsumen";
            DataTransaksiKeluar.Columns[2].HeaderText = "Nama Obat";
            DataTransaksiKeluar.Columns[3].HeaderText = "Jumlah Obat";
            DataTransaksiKeluar.Columns[4].HeaderText = "Harga Jual";
            DataTransaksiKeluar.Columns[5].HeaderText = "Tanggal";
            DataTransaksiKeluar.Columns[6].HeaderText = "Alamat";
        }
        public FormTransaksiKeluar()
        {
            InitializeComponent();
        }

        private void FormTransaksiKeluar_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
            GetDataTsk();
            GetDataTsko();
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbKonsumen.SelectedIndex == -1 || nama_obat.SelectedIndex == -1 || jumlah_obat.Text == "" || harga_penjualan.Text == "" || tanggal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiKeluar tsk = new TransaksiKeluar();
                m_tsk.Nama_konsumen = cbKonsumen.Text;
                m_tsk.Nama_obat = nama_obat.Text;
                m_tsk.Jumlah_obat = jumlah_obat.Text;
                m_tsk.Harga_jual = harga_penjualan.Text;
                m_tsk.Tanggal = tanggal.Text;

                tsk.Insert(m_tsk);

                cbKonsumen.SelectedIndex = -1;
                nama_obat.SelectedIndex = -1;
                jumlah_obat.Text = "";
                harga_penjualan.Text = "";
                tanggal.Text = "";
                total.Text = "";

                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (cbKonsumen.SelectedIndex == -1 || nama_obat.SelectedIndex == -1 || jumlah_obat.Text == "" || harga_penjualan.Text == "" || tanggal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiKeluar tsk = new TransaksiKeluar();
                m_tsk.Nama_konsumen = cbKonsumen.Text;
                m_tsk.Nama_obat = nama_obat.Text;
                m_tsk.Jumlah_obat = jumlah_obat.Text;
                m_tsk.Harga_jual = harga_penjualan.Text;
                m_tsk.Tanggal = tanggal.Text;

                tsk.Update(m_tsk, id_transaksi);

                cbKonsumen.SelectedIndex = -1;
                nama_obat.SelectedIndex = -1;
                jumlah_obat.Text = "";
                harga_penjualan.Text = "";
                tanggal.Text = "";
                total.Text = "";

                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                TransaksiMasuk tsm = new TransaksiMasuk();
                tsm.Delete(id_transaksi);

                cbKonsumen.SelectedIndex = -1;
                nama_obat.SelectedIndex = -1;
                jumlah_obat.Text = "";
                harga_penjualan.Text = "";
                tanggal.Text = "";
                total.Text = "";

                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbKonsumen.SelectedIndex = -1;
            nama_obat.SelectedIndex = -1;
            jumlah_obat.Text = "";
            harga_penjualan.Text = "";
            tanggal.Text = "";
            total.Text = "";

            Tampil();
        }

        private void DataTransaksiKeluar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksiKeluar.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbKonsumen.Text = DataTransaksiKeluar.Rows[e.RowIndex].Cells[1].Value.ToString();
            nama_obat.Text = DataTransaksiKeluar.Rows[e.RowIndex].Cells[2].Value.ToString();
            jumlah_obat.Text = DataTransaksiKeluar.Rows[e.RowIndex].Cells[3].Value.ToString();
            harga_penjualan.Text = DataTransaksiKeluar.Rows[e.RowIndex].Cells[4].Value.ToString();
            tanggal.Text = DataTransaksiKeluar.Rows[e.RowIndex].Cells[5].Value.ToString();
            total.Text = DataTransaksiKeluar.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            total.Enabled = true;
            total.Text = (int.Parse(harga_penjualan.Text) * int.Parse(jumlah_obat.Text)).ToString();
            total.Enabled = false;
        }
        public void GetDataTsk()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM konsumen");
            while (reader.Read())
            {
                cbKonsumen.Items.Add(reader.GetString("nama_konsumen"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetDataTsko()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM obat");
            while (reader.Read())
            {
                nama_obat.Items.Add(reader.GetString("nama_obat"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataTransaksiKeluar.DataSource = koneksi.ShowData("SELECT * FROM transaksikeluar WHERE nama_konsumen LIKE '%' '" + tbCariData.Text + "' '%' OR nama_obat LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void ExportExcel(DataGridView dataGrid, string searchData)
        {
            string Output = "";
            string Headers = "";

            // Exporting Title
            for (int j = 0; j < dataGrid.ColumnCount; j++)
            {
                Headers = Headers.ToString() + Convert.ToString(dataGrid.Columns[j].HeaderText) + "\t";

            }
            Output += Headers + "\r\n";

            // Export Data
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                string Line = "";
                for (int j = 0; j < dataGrid.Rows[i].Cells.Count; j++)
                {
                    Line = Line.ToString() + Convert.ToString(dataGrid.Rows[i].Cells[j].Value) + "\t";
                }
                Output += Line + "\r\n";
            }
            Encoding encoding = Encoding.GetEncoding(1254);
            // array dgn tipe byte
            byte[] outputs = encoding.GetBytes(Output);
            FileStream file = new FileStream(searchData, FileMode.Create);
            BinaryWriter binary = new BinaryWriter(file);

            binary.Write(outputs, 0, outputs.Length);
            binary.Flush();
            binary.Close();
            file.Close();
        }

        private void excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xls)|*.xls";
            save.FileName = "Data Transaksi Keluar.xls";

            if (save.ShowDialog() == DialogResult.OK)
            {
                ExportExcel(DataTransaksiKeluar, save.FileName);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
