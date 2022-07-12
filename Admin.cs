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

namespace Trabajo_POO_Grupo_4
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet.ListadeCuentas' table. You can move, or remove it, as needed.
            this.listadeCuentasTableAdapter.Fill(this.proyectoDataSet.ListadeCuentas);

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            ConexionSQL agregar = new ConexionSQL();
            agregar.Agregar(txtID.Text, txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text, txtAdmin.Text);
            dgvGestionarUsuarios.DataSource = agregar.actualizarlista();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            ConexionSQL eliminar = new ConexionSQL();
            eliminar.Eliminar(txtID.Text);
            dgvGestionarUsuarios.DataSource = eliminar.actualizarlista();
        }

        private void btnModificarUsuario_Click_1(object sender, EventArgs e)
        {
            ConexionSQL modificar = new ConexionSQL();
            modificar.Modificar(txtID.Text, txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text, txtAdmin.Text);
            dgvGestionarUsuarios.DataSource = modificar.actualizarlista();
        }
        private void txtID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
