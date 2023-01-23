using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuBes_1214057_1214079.model;

namespace TuBes_1214057_1214079.controller
{
    internal class TransaksiKeluar
    {
        Koneksi koneksi = new Koneksi();

        //Method Insert
        public bool Insert(M_transaksikeluar transaksikeluar)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO transaksikeluar (nama_konsumen, nama_obat, jumlah_obat, harga_jual, tanggal) VALUES('" + transaksikeluar.Nama_konsumen + "','" + transaksikeluar.Nama_obat + "', '" + transaksikeluar.Jumlah_obat + "','" + transaksikeluar.Harga_jual + "','" + transaksikeluar.Tanggal + "')");
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
        public bool Update(M_transaksikeluar transaksikeluar, string id_transaksi)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE transaksikeluar SET nama_konsumen='" + transaksikeluar.Nama_konsumen + "'," + "nama_obat='" + transaksikeluar.Nama_obat + "'," + "jumlah_obat='" + transaksikeluar.Jumlah_obat + "'," + "harga_jual='" + transaksikeluar.Harga_jual + "'," + "tanggal='" + transaksikeluar.Tanggal + "' WHERE id_transaksi='" + id_transaksi + "'");
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
                koneksi.ExecuteQuery("DELETE FROM transaksikeluar where id_transaksi='" + id_transaksi + "'");
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
