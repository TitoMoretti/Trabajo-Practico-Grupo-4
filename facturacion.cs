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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
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
            int v1 = Facturas.validarFactura(txtNombre.Text, txtApellido.Text, txtUser.Text, TipoTicket, txtCantidadTickets.Text, FechadeIngreso.Value); //revisar si ha guardado el texto del datetime
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

/*
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

            dgvGestionarFacturas.Columns.Add("Nombre", "Nombre");
            dgvGestionarFacturas.Columns.Add("Apellido", "Apellido");
          
            dgvGestionarFacturas.Columns.Add("Tipo", "Tipo");
            dgvGestionarFacturas.Columns.Add("Cantidad", "Cantidad");
            dgvGestionarFacturas.Columns.Add("Importe", "Importe");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int IndiceFila = dgvGestionarFacturas.Rows.Add();
            string tipoT="";
            int importe = 0;
            if (comboBoxTipo.SelectedIndex == 0)
            {
                MessageBox.Show("No ha elegido un tipo de ticket. Por favor, seleccione uno y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{ 
                if (comboBoxTipo.SelectedIndex ==1)
                {
                    tipoT = "Entrada general";
                    
                    importe = 2700 * (Convert.ToInt32(txtCantidadTickets));
                    
                }
                else
                {
                    if (comboBoxTipo.SelectedIndex == 2)
                    {
                        tipoT= "Entrada VIP ";
                        
                         importe= 4000 * (Convert.ToInt32(txtCantidadTickets));
                    }
                    
                }

            }
           
            
            DataGridViewRow fila = dgvGestionarFacturas.Rows[IndiceFila];
            fila.Cells["Nombre"].Value = txtNombre.Text;
            fila.Cells["Apellido"].Value = txtApellido.Text;
            fila.Cells["Tipo"].Value = tipoT;
            fila.Cells["Cantidad"].Value = txtCantidadTickets.Text;
            fila.Cells["Importe"].Value =   importe  ;

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


                        //crear un pdf
                        SaveFileDialog Guardar = new SaveFileDialog();
                        Guardar.FileName = txtApellido.Text+ DateTime.Now.ToString("ddmmyyyy")+".pdf";
                        Guardar.ShowDialog();

                        string PaginaHTML_Texto = Properties.Resources.plantilla.ToString();
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA",DateTime.Now.ToString("dd/MM/yyyy"));
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VENDEDOR",txtUser.Text );
                        string filas = string.Empty;
                        decimal total = 0;

                        foreach(DataGridViewRow row in dgvGestionarFacturas.Rows)
                        {
                            filas += "<tr>";
                            filas += "<td>" + row.Cells["Nombre"].Value.ToString()+"</td>" ;
                            filas += "<td>" + row.Cells["Apellido"].Value.ToString() + "</td>";
                            filas += "<td>" + row.Cells["Tipo"].Value.ToString() + "</td>";
                            filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                            filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                            filas += "<tr>";
                            total += decimal.Parse(row.Cells["Importe"].Value.ToString());
                        }
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS",filas);
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());


                        if (Guardar.ShowDialog() == DialogResult.OK)
                        {

                            using (FileStream stream =new FileStream(Guardar.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream); 
                                pdfDoc .Open();

                                pdfDoc.Add(new Phrase(" "));

                                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.naga, System.Drawing.Imaging.ImageFormat.Png);
                                img.ScaleToFit(80, 60);
                                img.Alignment = iTextSharp.text.Image.UNDERLYING;
                                img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                                pdfDoc.Add(img);

                                using (StringReader sr = new StringReader(PaginaHTML_Texto))
                                {
                                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);

                                }

                                pdfDoc .Close();
                                stream.Close();
                            }
                                

                        }
                        
                        
                        //código para mandar los datos de la factura al SQL
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

        
    }
}
*/