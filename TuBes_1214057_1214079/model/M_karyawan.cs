using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuBes_1214057_1214079.model
{
    internal class M_karyawan
    {
        string nama_karyawan, ttl, email, alamat;

        public M_karyawan()
        {

        }

        public M_karyawan(string nama_karyawan, string ttl, string email, string alamat)
        {
            this.Nama_karyawan = nama_karyawan;
            this.Ttl = ttl;
            this.Email = email;
            this.Alamat = alamat;
        }

        public string Nama_karyawan { get => nama_karyawan; set => nama_karyawan = value; }
        public string Ttl { get => ttl; set => ttl = value; }
        public string Email { get => email; set => email = value; }
        public string Alamat { get => alamat; set => alamat = value; }
    }
}
