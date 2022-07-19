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


namespace Trabajo_POO_Grupo_4
{
    public partial class Admin : Form
    {
        
        public Admin()
        {
            InitializeComponent();
        }
        int identificador = 1;

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet.ListadeCuentas' table. You can move, or remove it, as needed.
            //this.listadeCuentasTableAdapter.Fill(this.proyectoDataSet.ListadeCuentas);
            ConexionSQL actualizar = new ConexionSQL();
            dgvGestionarUsuarios.DataSource = actualizar.actualizarlista();
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContra.Text = string.Empty;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Controladora.ConexionSQL user = new Controladora.ConexionSQL();
            user.NombreLogin(txtUsuario.Text);
            user.ContraLogin(txtContra.Text);
            Controladora.ControladoraUsuarios usuarios = new Controladora.ControladoraUsuarios();
            int v1 = usuarios.validarRegister(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text);
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
                    msg.Body = "Hola!!! Queremos informarle que se ha creado una cuenta de empleado para el parque NagaPark con los siguientes datos: <br><br>Nombre: " + txtNombre.Text + "<br>Apellido: " + txtApellido.Text + "<br>Nombre de Usuario: " + txtUsuario.Text + "<br>Email: " + txtEmail.Text + "<br><br>Ante cualquier duda sobre la cuenta, no dude en visitar nuestra oficina de atención para recibir más información. <br><br>Esperamos que tenga un buen día y saludos desde NagaPark!<br><br>Nagatoro Ichirō";
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
                            identificador = 1;
                            ConexionSQL Obteneridentificacion = new ConexionSQL();
                            identificador = identificador + Obteneridentificacion.ObtenerID();
                            string id = Convert.ToString(identificador);
                            ConexionSQL agregar = new ConexionSQL();
                            agregar.Agregar(id, txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text);
                            dgvGestionarUsuarios.DataSource = agregar.actualizarlista();
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
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            ConexionSQL eliminar = new ConexionSQL();
            eliminar.Eliminar(txtID.Text,txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text);
            dgvGestionarUsuarios.DataSource = eliminar.actualizarlista();
        }

        private void btnModificarUsuario_Click_1(object sender, EventArgs e)
        {
            ConexionSQL modificar = new ConexionSQL();
            modificar.Modificar(txtID.Text,txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text);
            dgvGestionarUsuarios.DataSource = modificar.actualizarlista();
        }

        private void dgvGestionarUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvGestionarUsuarios.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgvGestionarUsuarios.SelectedCells[1].Value.ToString();
            txtApellido.Text = dgvGestionarUsuarios.SelectedCells[2].Value.ToString();
            txtUsuario.Text = dgvGestionarUsuarios.SelectedCells[3].Value.ToString();
            txtEmail.Text = dgvGestionarUsuarios.SelectedCells[4].Value.ToString();
            txtContra.Text = dgvGestionarUsuarios.SelectedCells[5].Value.ToString();
        }

        private void Facturación_Click(object sender, EventArgs e)
        {
            Facturacion facturas = new Facturacion();
            this.Hide();
            facturas.ShowDialog();
            this.Show();
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContra.Text = string.Empty;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
