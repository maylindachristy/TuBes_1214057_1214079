using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuBes_1214057_1214079.view
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void dataObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
            form1.BringToFront();
        }

        private void dataJenisObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJenisObat formJenisObat = new FormJenisObat();
            formJenisObat.MdiParent = this;
            formJenisObat.Show();
        }

        private void dataKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKaryawan formKaryawan = new FormKaryawan();
            formKaryawan.MdiParent = this;
            formKaryawan.Show();
        }

        private void dataSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier formSupplier = new FormSupplier();
            formSupplier.MdiParent = this;
            formSupplier.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormPresensi formPresensi = new FormPresensi();
            formPresensi.MdiParent = this;
            formPresensi.Show();
        }

        private void transaksiMasukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksiMasuk formTransaksiMasuk = new FormTransaksiMasuk();
            formTransaksiMasuk.MdiParent = this;
            formTransaksiMasuk.Show();
        }

        private void transaksiKeluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksiKeluar formTransaksiKeluar = new FormTransaksiKeluar();
            formTransaksiKeluar.MdiParent = this;
            formTransaksiKeluar.Show();
        }

        private void dataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKonsumen formKonsumen = new FormKonsumen();
            formKonsumen.MdiParent = this;
            formKonsumen.Show();
        }

        private void riwayatPresensiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRiwayat formRiwayat = new FormRiwayat();
            formRiwayat.MdiParent = this;
            formRiwayat.Show();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.MdiParent = this;
            formInfo.Show();
        }
    }
}
