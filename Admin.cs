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
using System.Net.Mail;
using System.Security.Cryptography;


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
            //Cuando se abre el formulario, se asegura que todos los TextBoxs estén vacios y que el DataGridView esté actualizado con la información del SQL

            ConexionSQL actualizar = new ConexionSQL(); //Creamos una instancia para poder utilizar la clase "ConexiónSQL.cs", la cual está en "Controladora"
            dgvGestionarUsuarios.DataSource = actualizar.actualizarlista(); //Pedimos los datos de la tabla del SQL para poder actualizar el DataGridView
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContra.Text = string.Empty;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            //Evento realizado para poder agregar una nueva cuenta al SQL

            Controladora.ConexionSQL user = new Controladora.ConexionSQL(); //Creamos una instancia para poder utilizar la clase "ConexiónSQL.cs", la cual está en "Controladora"
            Controladora.ControladoraUsuarios usuarios = new Controladora.ControladoraUsuarios(); //Creamos una instancia para poder utilizar la clase "ControladoraUsuarios.cs", la cual está en "Controladora"
            int v1 = usuarios.validarRegister(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text); //Mandamos todos los datos insertados para ver si falta alguno de estos o si el email y la contraseña insertadas son válidas. De acuerdo a la situación, la variable v1 recibirá un valor
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
                case 4: //Situación donde no ha escrito el Correo Electrónico
                    MessageBox.Show("No se ha insertado un correo electrónico. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5: //Situación donde no ha escrito un Correo Electrónico válido
                    MessageBox.Show("No se ha insertado un correo electrónico válido. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 6: //Situación donde no ha escrito la Contraseña
                    MessageBox.Show("No se ha insertado una contraseña. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 7: //Situación donde no ha escrito una Contraseña válida, debido a que la insertada es menor a 5 caracteres o mayor a 15 caracteres
                    MessageBox.Show("No se ha insertado una contraseña valida. La contraseña solo puede ser entre 5 a 15 caracteres.\nPor favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 8: //Situación donde no ha escrito una Contraseña válida, debido a que esta debe tener un número
                    MessageBox.Show("No se ha insertado una contraseña valida. La contraseña debe incluir al menos un número.\nPor favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 9: //Situación donde no ha escrito una Contraseña válida, debido a que esta debe tener una letra
                    MessageBox.Show("No se ha insertado una contraseña valida. La contraseña debe incluir al menos una letra.\nPor favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 10: //Situación donde no falta nada
                    MailMessage msg = new MailMessage(); //Instancia para poder crear un mensaje de Correo Electrónico
                    msg.To.Add(txtEmail.Text); //Inserta el destinatario del mensaje
                    msg.Subject = "NagaPark: Se ha creado una cuenta con este correo electrónico"; //Inserta el asunto del mensaje
                    msg.SubjectEncoding = Encoding.UTF8; //Codifica el asunto para mayor seguridad
                    msg.Body = "Hola!!! Queremos informarle que se ha creado una cuenta de empleado para el parque NagaPark con los siguientes datos: <br><br>Nombre: " + txtNombre.Text + "<br>Apellido: " + txtApellido.Text + "<br>Nombre de Usuario: " + txtUsuario.Text + "<br>Email: " + txtEmail.Text + "<br><br>Ante cualquier duda sobre la cuenta, no dude en visitar nuestra oficina de atención para recibir más información. <br><br>Esperamos que tenga un buen día y saludos desde NagaPark!<br><br>Nagatoro Ichirō"; //Inserta el cuerpo del mensaje
                    msg.BodyEncoding = Encoding.UTF8; //Codifica el cuerpo para mayor seguridad
                    msg.IsBodyHtml = true; //Aclara si se utiliza HTML en el cuerpo del mensaje

                    msg.From = new MailAddress("nagaparkentertainment@gmail.com"); //Inserta el Correo Electrónico que se utilizará para enviar el mail
                    SmtpClient cliente = new SmtpClient(); //Instancia para poder darle al programa las credenciales de un Correo Electrónico, para así poder enviar mails
                    cliente.Credentials = new System.Net.NetworkCredential("nagaparkentertainment@gmail.com", "icoelpvrwnoankop"); //Inserta los datos del Correo Electrónico
                    cliente.Port = 587; //Inserta el puerto que se utilizará
                    cliente.EnableSsl = true; //Condición utilizada para poder cifrar la conexión al Correo Electrónico
                    cliente.Host = "smtp.gmail.com"; //Inserta la IP del host que utilizará el programa para poder conectarse al Correo Electrónico
                    try //Intentará enviar el mail
                    {
                        cliente.Send(msg);
                        try //Intentará guardar los datos de la cuenta en el SQL
                        {
                            int identificador = 1;
                            identificador = identificador + user.ObtenerID(); //A la variable "identificador" se le sumará el ID más grande que se encuentre en el SQL, para así asegurarse que cada cuenta tenga su propio ID
                            string id = Convert.ToString(identificador); //Guardamos la variable "identificador" en un string
                            string contraencriptada = usuarios.Encriptar(txtContra.Text);  //Mandamos la contraseña a la subrutina "Encriptar", dentro de ControladoraUsuarios, para así poder enciptar la misma y guardarla en un string
                            user.Agregar(id, txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, contraencriptada); //Mandamos todos los datos de la cuenta (y la contraseña encriptada) para poder incorporar la misma dentro del SQL
                            dgvGestionarUsuarios.DataSource = user.actualizarlista(); //Pedimos los datos de la tabla del SQL para poder actualizar el DataGridView
                        }
                        catch (Exception) //En caso de que no se haya podido guardar los datos por cualquier razón, se mostrará un mensaje de error
                        {
                            MessageBox.Show("Ha ocurrido un problema al momento de crear su cuenta. Le pedimos que verifique los datos introducidos anteriormente y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception) //En caso de que no se haya podido enviar el mail por cualquier razón, se mostrará un mensaje de error
                    {
                        MessageBox.Show("Ha ocurrido un error al enviar el mail, por lo tanto no podemos crear la cuenta. Por favor, introduzca su correo nuevamente y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = string.Empty;
                    }
                    break;
            }
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            //Evento realizado para poder eliminar una cuenta que esté dentro del SQL (haciendo click en alguna casilla del DataGridView)

            ConexionSQL eliminar = new ConexionSQL(); //Creamos una instancia para poder utilizar la clase "ConexiónSQL.cs", la cual está en "Controladora"
            eliminar.Eliminar(txtID.Text, txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text); //Mandamos el ID de la cuenta para que se busque en el SQL. Al encontrarlos eliminara toda la fila donde está el mismo
            dgvGestionarUsuarios.DataSource = eliminar.actualizarlista(); //Pedimos los datos de la tabla del SQL para poder actualizar el DataGridView
        }

        private void btnModificarUsuario_Click_1(object sender, EventArgs e)
        {
            //Evento realizado para poder modificar una cuenta que esté dentro del SQL (haciendo click en alguna casilla del DataGridView)

            ConexionSQL modificar = new ConexionSQL(); //Creamos una instancia para poder utilizar la clase "ConexiónSQL.cs", la cual está en "Controladora"
            Controladora.ControladoraUsuarios usuarios = new Controladora.ControladoraUsuarios(); //Creamos una instancia para poder utilizar la clase "ControladoraUsuarios.cs", la cual está en "Controladora"
            string contraencriptada = usuarios.Encriptar(txtContra.Text); //Mandamos la contraseña a la subrutina "Encriptar", dentro de ControladoraUsuarios, para así poder enciptar la misma y guardarla en un string
            modificar.Modificar(txtID.Text, txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, contraencriptada); //Mandamos todos los datos de la cuenta (y la contraseña encriptada) para poder buscar la fila donde tenga los datos del SQL, para así incorporar los cambios ingresados
            dgvGestionarUsuarios.DataSource = modificar.actualizarlista(); //Pedimos los datos de la tabla del SQL para poder actualizar el DataGridView
        }

        private void dgvGestionarUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento donde al hacer click en una fila del DataGridView, toda la información de la misma se pueda ver en los TextBoxs de al lado

            txtID.Text = dgvGestionarUsuarios.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgvGestionarUsuarios.SelectedCells[1].Value.ToString();
            txtApellido.Text = dgvGestionarUsuarios.SelectedCells[2].Value.ToString();
            txtUsuario.Text = dgvGestionarUsuarios.SelectedCells[3].Value.ToString();
            txtEmail.Text = dgvGestionarUsuarios.SelectedCells[4].Value.ToString();
            Controladora.ControladoraUsuarios desencriptacion = new Controladora.ControladoraUsuarios(); //Creamos una instancia para poder utilizar la clase "ControladoraUsuarios.cs", la cual está en "Controladora"
            string contradesencriptada = desencriptacion.Desencriptar(dgvGestionarUsuarios.SelectedCells[5].Value.ToString());  //Mandamos la contraseña a la subrutina "Desencriptar", dentro de ControladoraUsuarios, para así poder desenciptar la almacenada en el SQL y guardarla en un string
            txtContra.Text = contradesencriptada;
        }

        private void Facturación_Click(object sender, EventArgs e)
        {
            //Evento que abre un formulario para poder realizar facturas

            Facturacion facturas = new Facturacion();
            this.Hide();
            facturas.ShowDialog();
            this.Show();
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            //Evento que limpia todos los TextBoxs

            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContra.Text = string.Empty;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra el formulario actual
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condición utilizada para asegurarse que no pueda escribir números dentro del Nombre

            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("No se puede escribir números aquí.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condición utilizada para asegurarse que no pueda escribir números dentro del Apellido

            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("No se puede escribir números aquí.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvGestionarUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento realizado para que no puedar cambiar datos desde el DataGridView

            dgvGestionarUsuarios.ReadOnly = true;
        }
    }
}
