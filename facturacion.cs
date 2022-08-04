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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;


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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("No se puede escribir números aquí.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("No se puede escribir números aquí.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            ConexionSQLFacturas actualizar = new ConexionSQLFacturas();
            dgvGestionarFacturas.DataSource = actualizar.actualizarlista();

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            
            string paginahtml_texto = Properties.Resources.plantilla.ToString();

            paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;

            try
            {
                for (int fila = 0; fila < dgvGestionarFacturas.Rows.Count - 1; fila++)
                {
                    filas += "<tr>";
                    for (int col = 0; col < dgvGestionarFacturas.Rows[fila].Cells.Count; col++)
                    {
                        string valor = dgvGestionarFacturas.Rows[fila].Cells[col].Value.ToString();
                        filas += "<td>" + valor + "</td>";

                    }
                    filas += "</tr>";
                }
                paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        Document pdfDOC = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDOC, stream);

                        pdfDOC.Open();
                        pdfDOC.Add(new Phrase(""));

                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.naga, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(80, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDOC.LeftMargin,pdfDOC.Top -60);
                        pdfDOC.Add(img);

                        using (StringReader sr = new StringReader(paginahtml_texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDOC, sr);
                        }

                        pdfDOC.Close();
                        stream.Close();
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No se pudo descargar pdf.");
            }
        }
    }
}