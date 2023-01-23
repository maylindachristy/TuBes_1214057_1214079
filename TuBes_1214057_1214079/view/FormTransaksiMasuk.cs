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
using MySql.Data.MySqlClient;
using System.IO;

namespace TuBes_1214057_1214079.view
{
    public partial class FormTransaksiMasuk : Form
    {
        Koneksi koneksi = new Koneksi();
        M_transaksimasuk m_tsm = new M_transaksimasuk();
        string id_transaksi;

        public void Tampil()
        {
            //Query DB
            DataTransaksiMasuk.DataSource = koneksi.ShowData("SELECT id_transaksi, transaksimasuk.perusahaan, jumlah_obat, harga_pembelian, tanggal, nama_obat FROM transaksimasuk JOIN supplier ON supplier.nama_perusahaan = transaksimasuk.perusahaan");

            //Mengubah Nama Kolom Tabel
            DataTransaksiMasuk.Columns[0].HeaderText = "ID Transaksi";
            DataTransaksiMasuk.Columns[1].HeaderText = "Nama Perusahaan";
            DataTransaksiMasuk.Columns[2].HeaderText = "Jumlah Obat";
            DataTransaksiMasuk.Columns[3].HeaderText = "Harga Pembelian";
            DataTransaksiMasuk.Columns[4].HeaderText = "Tanggal";
            DataTransaksiMasuk.Columns[5].HeaderText = "Nama Obat";
        }
        public FormTransaksiMasuk()
        {
            InitializeComponent();
        }

        private void FormTransaksiMasuk_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
            GetDataTsm();
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
            if (perusahaan.SelectedIndex == -1 || jumlah_obat.Text == "" || harga_pembelian.Text == "" || tanggal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiMasuk tsm = new TransaksiMasuk();
                m_tsm.Perusahaan = perusahaan.Text;
                m_tsm.Jumlah_obat = jumlah_obat.Text;
                m_tsm.Harga_pembelian = harga_pembelian.Text;
                m_tsm.Tanggal = tanggal.Text;

                tsm.Insert(m_tsm);

                perusahaan.SelectedIndex = -1;
                jumlah_obat.Text = "";
                harga_pembelian.Text = "";
                tanggal.Text = "";
                total.Text = "";

                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (perusahaan.SelectedIndex == -1 || jumlah_obat.Text == "" || harga_pembelian.Text == "" || tanggal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiMasuk tsm = new TransaksiMasuk();
                m_tsm.Perusahaan = perusahaan.Text;
                m_tsm.Jumlah_obat = jumlah_obat.Text;
                m_tsm.Harga_pembelian = harga_pembelian.Text;
                m_tsm.Tanggal = tanggal.Text;

                tsm.Update(m_tsm, id_transaksi);

                perusahaan.SelectedIndex = -1;
                jumlah_obat.Text = "";
                harga_pembelian.Text = "";
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

                perusahaan.SelectedIndex = -1;
                jumlah_obat.Text = "";
                harga_pembelian.Text = "";
                tanggal.Text = "";
                total.Text = "";

                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            perusahaan.SelectedIndex = -1;
            jumlah_obat.Text = "";
            harga_pembelian.Text = "";
            tanggal.Text = "";
            total.Text = "";

            Tampil();
        }

        private void DataTransaksiMasuk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksiMasuk.Rows[e.RowIndex].Cells[0].Value.ToString();
            perusahaan.Text = DataTransaksiMasuk.Rows[e.RowIndex].Cells[1].Value.ToString();
            jumlah_obat.Text = DataTransaksiMasuk.Rows[e.RowIndex].Cells[2].Value.ToString();
            harga_pembelian.Text = DataTransaksiMasuk.Rows[e.RowIndex].Cells[3].Value.ToString();
            tanggal.Text = DataTransaksiMasuk.Rows[e.RowIndex].Cells[4].Value.ToString();
            total.Text = DataTransaksiMasuk.Rows[e.RowIndex].Cells[5].Value.ToString();
        }


        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataTransaksiMasuk.DataSource = koneksi.ShowData("SELECT * FROM transaksimasuk WHERE nama_perusahaan LIKE '%' '" + tbCariData.Text + "' '%' OR tanggal LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        public void GetDataTsm()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM supplier");
            while (reader.Read())
            {
                perusahaan.Items.Add(reader.GetString("nama_perusahaan"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            total.Enabled = true;
            total.Text = (int.Parse(harga_pembelian.Text) * int.Parse(jumlah_obat.Text)).ToString();
            total.Enabled = false;
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
            save.FileName = "Data Transaksi Masuk.xls";

            if (save.ShowDialog() == DialogResult.OK)
            {
                ExportExcel(DataTransaksiMasuk, save.FileName);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
