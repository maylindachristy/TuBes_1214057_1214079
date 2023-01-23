using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuBes_1214057_1214079.model
{
    internal class M_jenisobat
    {
        string jenis_obat, keterangan;

        public M_jenisobat()
        {

        }

        public M_jenisobat(string jenis_obat, string keterangan)
        {
            this.Jenis_obat = jenis_obat;
            this.Keterangan = keterangan;
        }

        public string Jenis_obat { get => jenis_obat; set => jenis_obat = value; }
        public string Keterangan { get => keterangan; set => keterangan = value; }
    }
}
