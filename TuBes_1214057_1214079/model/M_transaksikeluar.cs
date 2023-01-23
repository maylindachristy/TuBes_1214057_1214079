using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuBes_1214057_1214079.model
{
    internal class M_transaksikeluar
    {
        string nama_konsumen, nama_obat,jumlah_obat, harga_jual, tanggal;

        public M_transaksikeluar()
        {

        }

        public M_transaksikeluar(string nama_konsumen, string nama_obat, string jumlah_obat, string harga_jual, string tanggal)
        {
            this.Nama_konsumen = nama_konsumen;
            this.Nama_obat = nama_obat;
            this.Jumlah_obat = jumlah_obat;
            this.Harga_jual = harga_jual;
            this.Tanggal = tanggal;
        }

        public string Nama_konsumen { get => nama_konsumen; set => nama_konsumen = value; }
        public string Nama_obat { get => nama_obat; set => nama_obat = value; }
        public string Jumlah_obat { get => jumlah_obat; set => jumlah_obat = value; }
        public string Harga_jual { get => harga_jual; set => harga_jual = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
    }
}
