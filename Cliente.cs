using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using System.Data.SqlClient;

namespace Trabajo_POO_Grupo_4
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprarTickets_Click(object sender, EventArgs e)
        {
            facturacion Facturar= new facturacion();
            this.Hide();
            Facturar.ShowDialog();
            this.Show();
        }

        private void BoxCliente_Enter(object sender, EventArgs e)
        {

        }
    }
}
