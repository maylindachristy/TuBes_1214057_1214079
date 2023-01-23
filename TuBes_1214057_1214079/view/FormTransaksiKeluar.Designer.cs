namespace TuBes_1214057_1214079.view
{
    partial class FormTransaksiKeluar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMn = new System.Windows.Forms.Button();
            this.btMx = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.excel = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbKonsumen = new System.Windows.Forms.ComboBox();
            this.tanggal = new System.Windows.Forms.TextBox();
            this.jumlah_obat = new System.Windows.Forms.TextBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.harga_penjualan = new System.Windows.Forms.TextBox();
            this.harga_jual = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.konsumen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTransaksiKeluar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nama_obat = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiKeluar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btMn);
            this.panel1.Controls.Add(this.btMx);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 59);
            this.panel1.TabIndex = 79;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btMn
            // 
            this.btMn.BackColor = System.Drawing.Color.LightBlue;
            this.btMn.Location = new System.Drawing.Point(621, 13);
            this.btMn.Name = "btMn";
            this.btMn.Size = new System.Drawing.Size(30, 30);
            this.btMn.TabIndex = 32;
            this.btMn.UseVisualStyleBackColor = false;
            this.btMn.Click += new System.EventHandler(this.btMn_Click);
            // 
            // btMx
            // 
            this.btMx.BackColor = System.Drawing.Color.DodgerBlue;
            this.btMx.Location = new System.Drawing.Point(672, 13);
            this.btMx.Name = "btMx";
            this.btMx.Size = new System.Drawing.Size(30, 30);
            this.btMx.TabIndex = 31;
            this.btMx.UseVisualStyleBackColor = false;
            this.btMx.Click += new System.EventHandler(this.btMx_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(721, 13);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(30, 30);
            this.btExit.TabIndex = 30;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaksi Keluar";
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(623, 213);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(144, 34);
            this.excel.TabIndex = 112;
            this.excel.Text = "Export To Excel";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(539, 160);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(212, 26);
            this.total.TabIndex = 111;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(418, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 110;
            this.label8.Text = "Total";
            // 
            // cbKonsumen
            // 
            this.cbKonsumen.FormattingEnabled = true;
            this.cbKonsumen.Location = new System.Drawing.Point(191, 77);
            this.cbKonsumen.Name = "cbKonsumen";
            this.cbKonsumen.Size = new System.Drawing.Size(212, 28);
            this.cbKonsumen.TabIndex = 109;
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(539, 113);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(212, 26);
            this.tanggal.TabIndex = 108;
            // 
            // jumlah_obat
            // 
            this.jumlah_obat.Location = new System.Drawing.Point(191, 160);
            this.jumlah_obat.Name = "jumlah_obat";
            this.jumlah_obat.Size = new System.Drawing.Size(212, 26);
            this.jumlah_obat.TabIndex = 107;
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(549, 260);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(212, 26);
            this.tbCariData.TabIndex = 106;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 105;
            this.label5.Text = "Cari Data";
            // 
            // harga_penjualan
            // 
            this.harga_penjualan.Location = new System.Drawing.Point(539, 71);
            this.harga_penjualan.Name = "harga_penjualan";
            this.harga_penjualan.Size = new System.Drawing.Size(212, 26);
            this.harga_penjualan.TabIndex = 104;
            // 
            // harga_jual
            // 
            this.harga_jual.AutoSize = true;
            this.harga_jual.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga_jual.Location = new System.Drawing.Point(418, 77);
            this.harga_jual.Name = "harga_jual";
            this.harga_jual.Size = new System.Drawing.Size(115, 23);
            this.harga_jual.TabIndex = 103;
            this.harga_jual.Text = "Harga Jual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 102;
            this.label4.Text = "Jumlah Obat";
            // 
            // konsumen
            // 
            this.konsumen.AutoSize = true;
            this.konsumen.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konsumen.Location = new System.Drawing.Point(21, 74);
            this.konsumen.Name = "konsumen";
            this.konsumen.Size = new System.Drawing.Size(109, 23);
            this.konsumen.TabIndex = 101;
            this.konsumen.Text = "Konsumen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 100;
            this.label6.Text = "Tanggal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnHapus);
            this.groupBox2.Controls.Add(this.btnUbah);
            this.groupBox2.Controls.Add(this.btnSimpan);
            this.groupBox2.Location = new System.Drawing.Point(13, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 80);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(379, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(256, 25);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(92, 30);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(137, 25);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(92, 30);
            this.btnUbah.TabIndex = 1;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(21, 25);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(92, 30);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightPink;
            this.label9.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 23);
            this.label9.TabIndex = 98;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTransaksiKeluar);
            this.groupBox1.Location = new System.Drawing.Point(13, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 251);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            // 
            // DataTransaksiKeluar
            // 
            this.DataTransaksiKeluar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTransaksiKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksiKeluar.Location = new System.Drawing.Point(6, 15);
            this.DataTransaksiKeluar.Name = "DataTransaksiKeluar";
            this.DataTransaksiKeluar.RowHeadersWidth = 62;
            this.DataTransaksiKeluar.RowTemplate.Height = 28;
            this.DataTransaksiKeluar.Size = new System.Drawing.Size(742, 227);
            this.DataTransaksiKeluar.TabIndex = 0;
            this.DataTransaksiKeluar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksiKeluar_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightPink;
            this.label2.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 114;
            this.label3.Text = "Nama Obat";
            // 
            // nama_obat
            // 
            this.nama_obat.FormattingEnabled = true;
            this.nama_obat.Location = new System.Drawing.Point(191, 113);
            this.nama_obat.Name = "nama_obat";
            this.nama_obat.Size = new System.Drawing.Size(212, 28);
            this.nama_obat.TabIndex = 115;
            // 
            // FormTransaksiKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.nama_obat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbKonsumen);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.jumlah_obat);
            this.Controls.Add(this.tbCariData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.harga_penjualan);
            this.Controls.Add(this.harga_jual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.konsumen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransaksiKeluar";
            this.Text = "FormTransaksiKeluar";
            this.Load += new System.EventHandler(this.FormTransaksiKeluar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiKeluar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btMn;
        private System.Windows.Forms.Button btMx;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbKonsumen;
        private System.Windows.Forms.TextBox tanggal;
        private System.Windows.Forms.TextBox jumlah_obat;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox harga_penjualan;
        private System.Windows.Forms.Label harga_jual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label konsumen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataTransaksiKeluar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nama_obat;
    }
}