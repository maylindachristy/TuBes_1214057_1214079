using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuBes_1214057_1214079.model;

namespace TuBes_1214057_1214079.controller
{
    internal class Konsumen
    {
        //Memanggil class Koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        //Method Insert
        public bool Insert(M_konsumen konsumen)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO konsumen (nomor_pesanan, nama_konsumen, nomor_telepon, alamat, email) VALUES('" + konsumen.Nomor_pesanan + "','" + konsumen.Nama_konsumen + "','" + konsumen.Nomor_telepon + "','" + konsumen.Alamat + "','" + konsumen.Email + "')");
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
        public bool Update(M_konsumen konsumen, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE konsumen SET nomor_pesanan='" + konsumen.Nomor_pesanan + "'," + "nama_konsumen='" + konsumen.Nama_konsumen + "'," + "nomor_telepon='" + konsumen.Nomor_telepon + "'," + "alamat='" + konsumen.Alamat + "'," + "email='" + konsumen.Email + "' WHERE nomor_pesanan='" + id + "'");
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
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM konsumen where nomor_pesanan='" + id + "'");
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
