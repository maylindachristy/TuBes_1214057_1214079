using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuBes_1214057_1214079.model
{
    internal class M_konsumen
    {
        string nomor_pesanan, nama_konsumen, nomor_telepon, alamat, email;

        public M_konsumen()
        {

        }

        public M_konsumen(string nomor_pesanan, string nama_konsumen, string nomor_telepon, string alamat, string email)
        {
            this.Nomor_pesanan = nomor_pesanan;
            this.Nama_konsumen = nama_konsumen;
            this.Nomor_telepon = nomor_telepon;
            this.Alamat = alamat;
            this.Email = email;
        }

        public string Nomor_pesanan { get => nomor_pesanan; set => nomor_pesanan = value; }
        public string Nama_konsumen { get => nama_konsumen; set => nama_konsumen = value; }
        public string Nomor_telepon { get => nomor_telepon; set => nomor_telepon = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Email { get => email; set => email = value; }
    }
}
