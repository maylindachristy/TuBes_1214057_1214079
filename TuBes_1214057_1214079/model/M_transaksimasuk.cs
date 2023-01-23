using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuBes_1214057_1214079.model
{
    internal class M_transaksimasuk
    {
        string perusahaan, jumlah_obat, harga_pembelian, tanggal;

        public M_transaksimasuk()
        {

        }

        public M_transaksimasuk(string perusahaan, string jumlah_obat, string harga_pembelian, string tanggal)
        {
            this.Perusahaan = perusahaan;
            this.Jumlah_obat = jumlah_obat;
            this.Harga_pembelian = harga_pembelian;
            this.Tanggal = tanggal;
        }

        public string Perusahaan { get => perusahaan; set => perusahaan = value; }
        public string Jumlah_obat { get => jumlah_obat; set => jumlah_obat = value; }
        public string Harga_pembelian { get => harga_pembelian; set => harga_pembelian = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
    }
}
