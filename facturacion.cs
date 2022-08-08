using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora; //Nos permite usar subrutinas del proyecto "Controladora"
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
            //Cuando se abre el formulario, se asegura que todos los TextBoxs, ComboBox y DateTimePicker estén vacios y que el DataGridView esté actualizado con la información del SQL

            comboBoxTipo.SelectedIndex = 0;
            ConexionSQLFacturas actualizar = new ConexionSQLFacturas(); // Se genera la conexion con FacturasSQL
            dgvGestionarFacturas.DataSource = actualizar.actualizarlista(); // Muestra los datos que guardaron en sql en el datagridview
            txtUser.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            comboBoxTipo.SelectedIndex = 0;
            txtCantidadTickets.Text = string.Empty;
            FechadeIngreso.ResetText();
            txtPrecio.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e) // Botón para validar y calcular el precio del ticket 
        {
            if (comboBoxTipo.SelectedIndex == 0) //Situación donde no ha seleccionado ninguna opción en el ComboBox "Tipo de Ticket"
            {
                MessageBox.Show("No ha elegido un tipo de ticket. Por favor, seleccione uno y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtCantidadTickets.Text == String.Empty) //Situación donde no ha escrito la cantidad de tickets en el TextBox correspondiente
                {
                    MessageBox.Show("No ha escrito cuantos tickets. Por favor, seleccione uno y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBoxTipo.SelectedIndex == 1) //Situación donde ha seleccionado opción GENERAL en el ComboBox "Tipo de Ticket"
                    {
                        int v1 = 0;
                        v1 = 2700 * (Convert.ToInt32(txtCantidadTickets.Text));
                        txtPrecio.Text = "PRECIO ESTIMADO: $" + Convert.ToString(v1);// si aprueba todo los validaciones, muestra valor de los tickets en un TextBox
                    }
                    else
                    {
                        if (comboBoxTipo.SelectedIndex == 2) //Situación donde ha seleccionado opción VIP en el ComboBox "Tipo de Ticket"
                        {
                            int v2 = 0;
                            v2 = 4000 * (Convert.ToInt32(txtCantidadTickets.Text));
                            txtPrecio.Text = "PRECIO ESTIMADO: $" + Convert.ToString(v2);// si aprueba todo los validaciones, muestra valor de los tickets en un TextBox
                        }
                    }
                }
            }
        }

        // Función que valida que los campos no estén vacios y manda los datos al SQL
        public void RegistrarFactura(string TipoTicket)
        {
            Controladora.ControladoraFacturas Facturas = new Controladora.ControladoraFacturas();
            int v1 = Facturas.validarFactura(txtNombre.Text, txtApellido.Text, txtUser.Text, TipoTicket, txtCantidadTickets.Text, FechadeIngreso.Value);
            switch (v1)
            {
                case 1: //Situación donde no ha escrito el Nombre
                    MessageBox.Show("No se ha insertado ningún nombre. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2: //Situación donde no ha escrito el Apellido
                    MessageBox.Show("No se ha insertado ningún apellido. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3: //Situación donde no ha escrito el Nombre de Usuario
                    MessageBox.Show("No se ha insertado ningún nombre de usuario. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4: //Situación donde no ha escrito la Cantidad de Tickets
                    MessageBox.Show("No se ha insertado la cantidad de tickets. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5: //Situación donde no falta nada
                    try //Intentará guardar los datos de la factura en el SQL
                    {
                        ConexionSQLFacturas agregar = new ConexionSQLFacturas(); //Creamos una instancia para poder utilizar la clase "ConexiónSQLFacturas.cs", la cual está en "Controladora"
                        agregar.AgregarFactura(txtNombre.Text, txtApellido.Text, txtUser.Text, TipoTicket, txtCantidadTickets.Text, FechadeIngreso.Value);  //Mandamos todos los datos de la factura para poder incorporar la misma dentro del SQL
                        dgvGestionarFacturas.DataSource = agregar.actualizarlista(); //Pedimos los datos de la tabla del SQL para poder actualizar el DataGridView
                    }
                    catch (Exception) //En caso de que no se haya podido guardar los datos por cualquier razón, se mostrará un mensaje de error
                    {
                        MessageBox.Show("Ha ocurrido un problema al momento de registrar su factura. Le pedimos que verifique los datos introducidos anteriormente y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        // Función para verificar que el usuario exista en la base de datos y que haya seleccionado una opción en el ComboBox "Tipo de Ticket". Al analizar eso, se procede a la subrutina "RegistrarFactura" 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Controladora.ConexionSQL user = new Controladora.ConexionSQL(); //Creamos una instancia para poder utilizar la clase "ConexiónSQL.cs", la cual está en "Controladora"
            bool v1 = user.FacturasUser(txtUser.Text); //Mando el Nombre de Usuario para poder ver si esté está en el SQL. De acuerdo al resultado, se le asignara un valor booleano a "v1"
            if (v1) //Validación realizada para ver si el usuario existe en el SQL
            {
                string TipoTicket;
                if (comboBoxTipo.SelectedIndex == 0) //Situación donde no ha seleccionado ninguna opción en el ComboBox "Tipo de Ticket"
                {
                    MessageBox.Show("No ha elegido un tipo de ticket. Por favor, seleccione uno y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBoxTipo.SelectedIndex == 1) //Situación donde ha seleccionado opción GENERAL en el ComboBox "Tipo de Ticket"
                    {
                        TipoTicket = "GENERAL";
                        RegistrarFactura(TipoTicket);
                    }
                    else
                    {
                        if (comboBoxTipo.SelectedIndex == 2) //Situación donde ha seleccionado opción VIP en el ComboBox "Tipo de Ticket"
                        {
                            TipoTicket = "VIP";
                            RegistrarFactura(TipoTicket);
                        }
                    }
                }
            }
            else //En caso de que el ususario no esté en el SQL, se mostrará un mensaje de error
            {
                MessageBox.Show("El usuario no está registrado en el sistema. Por favor, ingrese un usuario existente y vuelva a intentarlo.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra el formulario actual
        }

        // Función para eliminar una factura
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConexionSQLFacturas eliminar = new ConexionSQLFacturas(); //Creamos una instancia para poder utilizar la clase "ConexiónSQL.cs", la cual está en "Controladora"
            eliminar.Eliminar(FechadeIngreso.Value); //Mandamos la fecha de ingreso para encontrar la fila que tenga la misma fecha. Al encontrarla, la borrará
            dgvGestionarFacturas.DataSource = eliminar.actualizarlista(); //Pedimos los datos de la tabla del SQL para poder actualizar el DataGridView
            
            //Limpiamos todos los TextBoxs, ComboBox y DateTimePicker

            txtUser.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            comboBoxTipo.SelectedIndex = 0;
            txtCantidadTickets.Text = string.Empty;
            FechadeIngreso.ResetText();
            txtPrecio.Text = string.Empty;
        }


        // Completa los campos automaticamente con los valores de la fila que este seleccionando en el datagridview
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
            //Evento que limpia todos los TextBoxs, ComboBox y DateTimePicker

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
            //Condición utilizada para asegurarse que no pueda escribir números dentro del Nombre

            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)) //Solo admite Letras, el Espacio y el Retroceso
            {
                MessageBox.Show("No se puede escribir números aquí.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condición utilizada para asegurarse que no pueda escribir números dentro del Apellido

            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)) //Solo admite Letras, el Espacio y el Retroceso
            {
                MessageBox.Show("No se puede escribir números aquí.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCantidadTickets_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condición utilizada para asegurarse que no pueda escribir letras dentro de la Cantidad de Tickets

            if (e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar != (char)Keys.Back || e.KeyChar != (char)Keys.Space)) //Solo admite Números, el Espacio y el Retroceso
            {
                MessageBox.Show("No se puede escribir letras aquí.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botón para descargar la factura
        private void btnDescargar_Click(object sender, EventArgs e)
        {
            ConexionSQLFacturas actualizar = new ConexionSQLFacturas();
            dgvGestionarFacturas.DataSource = actualizar.actualizarlista(); // Actualizamos con los ultimos datos de la base de datos

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf"; // Guardamos el archivo en formato de pdf con el nombre de la fecha del día (se puede cambiar)
            
            string paginahtml_texto = Properties.Resources.plantilla.ToString();//utilizamos la plantilla de html que guardamos en resources

            paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));//asignar la fecha del dia para mostrar en  pdf 

            string filas = string.Empty; // definir un variable de filas para guardar los datos de datogridview

            // Recorremos el datagridview para poder cargar los datos y que estos se vean replicados en la factura que descargamos
            try //Intentará recorrer todas las filas 
            {
                for (int fila = 0; fila < dgvGestionarFacturas.Rows.Count - 1; fila++)// recorrer todas las filas de datogridview
                {
                    filas += "<tr>";//arrancar una fila
                    for (int col = 0; col < dgvGestionarFacturas.Rows[fila].Cells.Count; col++)//recorrer todos los columnas de la fila definido
                    {
                        string valor = dgvGestionarFacturas.Rows[fila].Cells[col].Value.ToString();// transformar datos a string para puede guardar
                        filas += "<td>" + valor + "</td>";// guardar todos los valores de fila en variable" fila "

                    }
                    filas += "</tr>";//cerrar la fila 
                }
                paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);//pasar datos que se almacena fila a la tabla de HTML

                // Aca se crea el pdf y se cargan algunos datos más, como la imagen que nosotros queremos para la factura
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        Document pdfDOC = new Document(PageSize.A4, 25, 25, 25, 25);//dar tamaño y detalle de pdf

                        PdfWriter writer = PdfWriter.GetInstance(pdfDOC, stream);// dar escritura en documentos que definimos 

                        pdfDOC.Open();
                        pdfDOC.Add(new Phrase(""));
                        //dar icono para pdf
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.naga, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(80, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDOC.LeftMargin,pdfDOC.Top -60);
                        pdfDOC.Add(img);
                        // transformar la pagina de html con los datos  a pdf 
                        using (StringReader sr = new StringReader(paginahtml_texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDOC, sr);
                        }

                        pdfDOC.Close();
                        stream.Close();
                    }
                }
            }
            catch(Exception) //En caso de que no se haya podido crear el PDF, se mostrará un mensaje de error
            {
                MessageBox.Show("No se pudo descargar el PDF. Por favor, vuelva a intentarlo","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        } 
    }
}