using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_POO_Grupo_4
{
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login iniciarsesion = new Login();
            this.Hide();
            iniciarsesion.ShowDialog();
            this.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro crearcuenta = new Registro();
            this.Hide();
            crearcuenta.ShowDialog();
            this.Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            FAQ FAQ = new FAQ();
            FAQ.ShowDialog();
        }
    }
}
