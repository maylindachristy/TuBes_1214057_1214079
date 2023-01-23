using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuBes_1214057_1214079.model
{
    internal class M_presensi
    {
        string kode_presensi, nama_karyawan, jammasuk, jamkeluar, tanggal;

        public M_presensi()
        {

        }

        public M_presensi(string kode_presensi, string nama_karyawan, string jammasuk, string jamkeluar, string tanggal)
        {
            this.Kode_presensi = kode_presensi;
            this.Nama_karyawan = nama_karyawan;
            this.Jammasuk = jammasuk;
            this.Jamkeluar = jamkeluar;
            this.Tanggal = tanggal;
        }

        public string Kode_presensi { get => kode_presensi; set => kode_presensi = value; }
        public string Nama_karyawan { get => nama_karyawan; set => nama_karyawan = value; }
        public string Jammasuk { get => jammasuk; set => jammasuk = value; }
        public string Jamkeluar { get => jamkeluar; set => jamkeluar = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
    }
}
