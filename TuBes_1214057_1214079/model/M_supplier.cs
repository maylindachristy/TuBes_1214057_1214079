using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuBes_1214057_1214079.model
{
    internal class M_supplier
    {
        string nama_perusahaan, nama_obat, nomor_telepon, alamat, email;

        public M_supplier()
        {

        }

        public M_supplier(string nama_perusahaan, string nama_obat, string nomor_telepon, string alamat, string email)
        {
            this.Nama_perusahaan = nama_perusahaan;
            this.Nama_obat = nama_obat;
            this.Nomor_telepon = nomor_telepon;
            this.Alamat = alamat;
            this.Email = email;
        }

        public string Nama_perusahaan { get => nama_perusahaan; set => nama_perusahaan = value; }
        public string Nama_obat { get => nama_obat; set => nama_obat = value; }
        public string Nomor_telepon { get => nomor_telepon; set => nomor_telepon = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Email { get => email; set => email = value; }
    }
}
