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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void facturacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet.ListadeCuentas' Puede moverla o quitarla según sea necesario.
            this.listadeCuentasTableAdapter.Fill(this.proyectoDataSet.ListadeCuentas);
            comboBoxTipo.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedIndex==0)
            {
                MessageBox.Show("No ha elegido un tipo de ticket. Por favor, seleccione uno y vuelva a intentarlo.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (comboBoxTipo.SelectedIndex == 1)
                {
                    int v1 = 0;
                    v1=2700*(Convert.ToInt32(txtCantidadTickets));
                    txtPrecio.Text = "PRECIO ESTIMADO: $"+Convert.ToString(v1);
                }
                else
                {
                    if(comboBoxTipo.SelectedIndex == 2)
                    {
                        int v2 = 0;
                        v2 = 4000 * (Convert.ToInt32(txtCantidadTickets));
                        txtPrecio.Text = "PRECIO ESTIMADO: $" + Convert.ToString(v2);
                    }
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
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

        public void RegistrarFactura(string TipoTicket)
        {
            Controladora.ControladoraFacturas Facturas = new Controladora.ControladoraFacturas();
            int v1 = Facturas.validarFactura(txtNombre.Text,txtApellido.Text,txtUser.Text,TipoTicket,txtCantidadTickets.Text,FechadeIngreso.Value); //revisar si ha guardado el texto del datetime
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
                        //código para mandar los datos de la factura al SQL
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un problema al momento de registrar su factura. Le pedimos que verifique los datos introducidos anteriormente y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
    }
}
