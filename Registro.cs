using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using System.Net.Mail;

namespace Trabajo_POO_Grupo_4
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        int bandera = 0;
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContra.Text = string.Empty;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContra.Text = string.Empty;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Controladora.ConexionSQL user = new Controladora.ConexionSQL();
            user.NombreLogin(txtUsuario.Text);
            user.ContraLogin(txtContra.Text);
            Controladora.ControladoraUsuarios usuarios = new Controladora.ControladoraUsuarios();
            int v1 = usuarios.validarRegister(txtNombre.Text,txtApellido.Text,txtUsuario.Text,txtEmail.Text,txtContra.Text);
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
                    MessageBox.Show("No se ha insertado un correo electrónico. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5:
                    MessageBox.Show("No se ha insertado un correo electrónico válido. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 6:
                    MessageBox.Show("No se ha insertado una contraseña. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 7:
                    MessageBox.Show("No se ha insertado una contraseña valida. La contraseña solo puede ser entre 5 a 15 caracteres.\nPor favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 8:
                    MessageBox.Show("No se ha insertado una contraseña valida. La contraseña debe incluir al menos un número.\nPor favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 9:
                    MessageBox.Show("No se ha insertado una contraseña valida. La contraseña debe incluir al menos una letra.\nPor favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 10:
                    MailMessage msg = new MailMessage();
                    msg.To.Add(txtEmail.Text);
                    msg.Subject = "NagaPark: Se ha creado una cuenta con este correo electrónico";
                    msg.SubjectEncoding = Encoding.UTF8;
                    msg.Body = "Hola!!! Queremos informarle que se ha creado una cuenta de empleado para el parque NagaPark con los siguientes datos: <br><br>Nombre: " +txtNombre.Text+ "<br>Apellido: " +txtApellido.Text+ "<br>Nombre de Usuario: " +txtUsuario.Text+ "<br>Email: " + txtEmail.Text+ "<br>Contraseña:" + txtContra.Text+ "<br><br>Ante cualquier duda sobre la cuenta, no dude en visitar nuestra oficina de atención para recibir más información. <br><br>Esperamos que tenga un buen día y saludos desde NagaPark!<br><br>Nagatoro Ichirō";
                    msg.BodyEncoding = Encoding.UTF8;
                    msg.IsBodyHtml = true;

                    msg.From = new MailAddress("nagaparkentertainment@gmail.com");
                    SmtpClient cliente = new SmtpClient();
                    cliente.Credentials = new System.Net.NetworkCredential("nagaparkentertainment@gmail.com", "icoelpvrwnoankop"); 
                    cliente.Port = 587;
                    cliente.EnableSsl = true;
                    cliente.Host = "smtp.gmail.com";
                    try
                    {
                        cliente.Send(msg);
                        try
                        {
                            ConexionSQL agregar = new ConexionSQL();
                            agregar.Agregar(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text);
                            MessageBox.Show("El usuario se ha registrado con éxito. Ahora por favor inicie sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login login = new Login();
                            this.Hide();
                            login.ShowDialog();
                            this.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ha ocurrido un problema al momento de crear su cuenta. Le pedimos que verifique los datos introducidos anteriormente y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error al enviar el mail, por lo tanto no podemos crear la cuenta. Por favor, introduzca su correo nuevamente y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = string.Empty;
                    }
                    break;     
            }
        }

        public void btnOjito_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
            {
                btnOjito.BackgroundImage = Properties.Resources.Ojito_cerrado;
                txtContra.PasswordChar = '*';
                bandera = 1;
            }
            else
            {
                btnOjito.BackgroundImage = Properties.Resources.ojito;
                bandera = 0;
                txtContra.PasswordChar = '\0';
            }   
        }
    }
}
