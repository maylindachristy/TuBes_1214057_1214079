using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuBes_1214057_1214079.model;

namespace TuBes_1214057_1214079.controller
{
    internal class TransaksiMasuk
    {
        Koneksi koneksi = new Koneksi();

        //Method Insert
        public bool Insert(M_transaksimasuk transaksimasuk)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO transaksimasuk (perusahaan, jumlah_obat, harga_pembelian, tanggal) VALUES('" + transaksimasuk.Perusahaan + "', '" + transaksimasuk.Jumlah_obat + "','" + transaksimasuk.Harga_pembelian + "','" + transaksimasuk.Tanggal + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        //Method Update
        public bool Update(M_transaksimasuk transaksimasuk, string id_transaksi)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE transaksimasuk SET perusahaan='" + transaksimasuk.Perusahaan + "'," + "jumlah_obat='" + transaksimasuk.Jumlah_obat + "'," + "harga_pembelian='" + transaksimasuk.Harga_pembelian + "'," + "tanggal='" + transaksimasuk.Tanggal + "' WHERE id_transaksi='" + id_transaksi + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        //Method Delete
        public bool Delete(string id_transaksi)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM transaksimasuk where id_transaksi='" + id_transaksi + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
