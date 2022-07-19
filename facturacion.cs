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
using System.IO;


namespace Trabajo_POO_Grupo_4
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void facturacion_Load(object sender, EventArgs e)
        {
            comboBoxTipo.SelectedIndex = 0;
            ConexionSQLFacturas actualizar = new ConexionSQLFacturas();
            dgvGestionarFacturas.DataSource = actualizar.actualizarlista();
            txtUser.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            comboBoxTipo.SelectedIndex = 0;
            txtCantidadTickets.Text = string.Empty;
            FechadeIngreso.ResetText();
            txtPrecio.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedIndex == 0)
            {
                MessageBox.Show("No ha elegido un tipo de ticket. Por favor, seleccione uno y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtCantidadTickets.Text == String.Empty)
                {
                    MessageBox.Show("No ha escrito cuantos tickets. Por favor, seleccione uno y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBoxTipo.SelectedIndex == 1)
                    {
                        int v1 = 0;
                        v1 = 2700 * (Convert.ToInt32(txtCantidadTickets.Text));
                        txtPrecio.Text = "PRECIO ESTIMADO: $" + Convert.ToString(v1);
                    }
                    else
                    {
                        if (comboBoxTipo.SelectedIndex == 2)
                        {
                            int v2 = 0;
                            v2 = 4000 * (Convert.ToInt32(txtCantidadTickets.Text));
                            txtPrecio.Text = "PRECIO ESTIMADO: $" + Convert.ToString(v2);
                        }
                    }
                }
            }
        }

        public void RegistrarFactura(string TipoTicket)
        {
            Controladora.ControladoraFacturas Facturas = new Controladora.ControladoraFacturas();
            int v1 = Facturas.validarFactura(txtNombre.Text, txtApellido.Text, txtUser.Text, TipoTicket, txtCantidadTickets.Text, FechadeIngreso.Value);
            switch (v1)
            {
                case 1:
                    MessageBox.Show("No se ha insertado ningún nombre. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("No se ha insertado ningún apellido. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("No se ha insertado ningún nombre de usuario. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("No se ha insertado la cantidad de tickets. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5:
                    try
                    {
                        ConexionSQLFacturas agregar = new ConexionSQLFacturas();
                        agregar.AgregarFactura(txtNombre.Text, txtApellido.Text, txtUser.Text, TipoTicket, txtCantidadTickets.Text, FechadeIngreso.Value);
                        dgvGestionarFacturas.DataSource = agregar.actualizarlista();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un problema al momento de registrar su factura. Le pedimos que verifique los datos introducidos anteriormente y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Controladora.ConexionSQL user = new Controladora.ConexionSQL();
            bool v1 = user.FacturasUser(txtUser.Text);
            if (v1)
            {
                string TipoTicket;
                if (comboBoxTipo.SelectedIndex == 0)
                {
                    MessageBox.Show("No ha elegido un tipo de ticket. Por favor, seleccione uno y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBoxTipo.SelectedIndex == 1)
                    {
                        TipoTicket = "GENERAL";
                        RegistrarFactura(TipoTicket);
                    }
                    else
                    {
                        if (comboBoxTipo.SelectedIndex == 2)
                        {
                            TipoTicket = "VIP";
                            RegistrarFactura(TipoTicket);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El usuario no está registrado en el sistema. Por favor, ingrese un usuario existente y vuelva a intentarlo.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConexionSQLFacturas eliminar = new ConexionSQLFacturas();
            eliminar.Eliminar(FechadeIngreso.Value);
            dgvGestionarFacturas.DataSource = eliminar.actualizarlista();
            txtUser.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            comboBoxTipo.SelectedIndex = 0;
            txtCantidadTickets.Text = string.Empty;
            FechadeIngreso.ResetText();
            txtPrecio.Text = string.Empty;
        }

        private void dgvGestionarFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUser.Text = dgvGestionarFacturas.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgvGestionarFacturas.SelectedCells[1].Value.ToString();
            txtApellido.Text = dgvGestionarFacturas.SelectedCells[2].Value.ToString();
            if (dgvGestionarFacturas.SelectedCells[3].Value.ToString() == "GENERAL")
            {
                comboBoxTipo.SelectedIndex = 1;
            }
            else
            {
                if (dgvGestionarFacturas.SelectedCells[3].Value.ToString() == "VIP")
                {
                    comboBoxTipo.SelectedIndex = 2;
                }
            }
            txtCantidadTickets.Text = dgvGestionarFacturas.SelectedCells[4].Value.ToString();
            FechadeIngreso.Text = dgvGestionarFacturas.SelectedCells[5].Value.ToString();
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            txtUser.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            comboBoxTipo.SelectedIndex = 0;
            txtCantidadTickets.Text = string.Empty;
            FechadeIngreso.ResetText();
            txtPrecio.Text = string.Empty;
        }
    }
}