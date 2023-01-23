using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TuBes_1214057_1214079.controller;
using TuBes_1214057_1214079.model;

namespace TuBes_1214057_1214079.view
{
    public partial class FormRegister : Form
    {
        Koneksi koneksi = new Koneksi();
        M_admin m_adm = new M_admin();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Close();
        }
        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tbCPassword.Text == tbPassword.Text)
                {
                    Admin adm = new Admin();
                    m_adm.Nama = tbNama.Text;
                    m_adm.Username = tbUsername.Text;
                    m_adm.Password = tbPassword.Text;


                    adm.Insert(m_adm);

                    tbNama.Text = "";
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                    tbCPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Password tidak sama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbNama.Text == "" || tbUsername.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (tbCPassword.Text == tbPassword.Text)
                    {
                        Admin adm = new Admin();
                        m_adm.Nama = tbNama.Text;
                        m_adm.Username = tbUsername.Text;
                        m_adm.Password = tbPassword.Text;

                        adm.Insert(m_adm);

                        tbNama.Text = "";
                        tbUsername.Text = "";
                        tbPassword.Text = "";
                        tbCPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Password tidak sama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
            this.Close();
        }
    }
}
