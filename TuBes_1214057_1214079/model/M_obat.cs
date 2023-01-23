using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuBes_1214057_1214079.model
{
    internal class M_obat
    {
        string nama_obat, jenis_obat, stok, keterangan;

        public M_obat()
        {

        }

        public M_obat(string nama_obat, string jenis_obat, string stok, string keterangan)
        {
            this.Nama_obat = nama_obat;
            this.Jenis_obat = jenis_obat;
            this.Stok = stok;
            this.Keterangan = keterangan;
        }
        public string Nama_obat { get => nama_obat; set => nama_obat = value; }
        public string Jenis_obat { get => jenis_obat; set => jenis_obat = value; }
        public string Stok { get => stok; set => stok = value; }
        public string Keterangan { get => keterangan; set => keterangan = value; }
    }
}
