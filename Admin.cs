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
        private int rowIndex = 0;
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
            agregar.Agregar(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text);
            dgvGestionarUsuarios.DataSource = agregar.actualizarlista();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            ConexionSQL eliminar = new ConexionSQL();
            eliminar.Eliminar(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text);
            dgvGestionarUsuarios.DataSource = eliminar.actualizarlista();
        }

        private void btnModificarUsuario_Click_1(object sender, EventArgs e)
        {
            ConexionSQL modificar = new ConexionSQL();
            modificar.Modificar(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text);
            dgvGestionarUsuarios.DataSource = modificar.actualizarlista();
        }

        private void dgvGestionarUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            txtID.Text = (rowIndex + 1).ToString();
        }

        private void Facturación_Click(object sender, EventArgs e)
        {
            Facturacion facturas = new Facturacion();
            this.Hide();
            facturas.ShowDialog();
            this.Close();
        }
    }
}
