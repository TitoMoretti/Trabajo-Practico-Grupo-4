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
using System.Data.SqlClient;
using Controladora; //Nos permite usar subrutinas del proyecto "Controladora"

namespace Trabajo_POO_Grupo_4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        int bandera = 0; //variable utilizada para definir propiedades del "Ojito", para así ocultar o no la contraseña.

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Controladora.ConexionSQL usuarios = new Controladora.ConexionSQL(); //Creamos una instancia para poder utilizar la clase "ConexiónSQL.cs", la cual está en "Controladora"
            Controladora.ControladoraUsuarios user = new Controladora.ControladoraUsuarios(); //Creamos una instancia para poder utilizar la clase "ControladoraUsuarios.cs", la cual está en "Controladora"
            int v1 = user.validarLogin(txt_user.Text, txt_password.Text); //Mandamos los datos del usuario (Nombre de Usuario y Contraseña) para ver si falta alguno de estos dos. De acuerdo a la situación, la variable v1 recibirá un valor.
            if (v1 == 1) //Situación donde no ha escrito el Nombre de Usuario
            {
                MessageBox.Show("No se ha insertado ningún nombre de usuario. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (v1 == 2) //Situación donde no ha escrito la Contraseña
                {
                    MessageBox.Show("No se ha insertado ninguna contraseña. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (v1 == 3) //Situación donde no falta nada
                    {
                        try //Intentará iniciar sesión, de acuerdo a los datos que hayan sido ingresados
                        {
                            bool v2 = false;
                            v2 = usuarios.loginAdminlocal(txt_user.Text, txt_password.Text); //Mandamos los datos del usuario (Nombre de Usuario y Contraseña) para ver si ambos datos son "admin". De acuerdo a la situación, el booleano v2 recibirá un valor true o false
                            if (v2) //Situación donde ambos datos del usuario eran "admin"
                            {
                                Admin root = new Admin(); //Creamos una instancia para pdoer reconocer el formulario "Admin.cs"
                                this.Hide(); //Esconde el form actual "Login.cs"
                                root.ShowDialog(); //Abre "Admin.cs"
                                this.Close(); //Cuando se cierra el form "Admin.cs", el form "Login.cs" también se cerrará.
                            }
                            else //Situación donde ambos datos del usuario no eran "admin"
                            { 
                                string contraencriptada = user.Encriptar(txt_password.Text); //Mandamos la contraseña a la subrutina "Encriptar", dentro de ControladoraUsuarios, para así poder enciptar la misma y guardarla en un string
                                bool validologin = usuarios.Logear(txt_user.Text, contraencriptada); //Mandamos el Nombre de Usuario y la Contraseña encriptada para poder ver si estos están presentes en el SQL. De acuerdo a la situación, el booleano validologin recibirá un valor true o false
                                if (validologin) //Situación donde ambos datos se encontraban dentro del SQL
                                {
                                    Admin root = new Admin(); //Creamos una instancia para pdoer reconocer el formulario "Admin.cs"
                                    this.Hide(); //Esconde el form actual "Login.cs"
                                    root.ShowDialog(); //Abre "Admin.cs"
                                    this.Close(); //Cuando se cierra el form "Admin.cs", el form "Login.cs" también se cerrará.
                                }
                                else //Situación donde ambos datos no se encontraban dentro del SQL
                                {
                                    MessageBox.Show("Nombre de usuario y contraseña incorrectos. Le pedimos que verifique los datos introducidos anteriormente y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception) //En caso de que no se haya podido iniciar sesión por cualquier razón, se mostrará un mensaje de error
                        {
                            MessageBox.Show("Ha ocurrido un problema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }  
                    }
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Evento que abre un formulario para poder crear una cuenta.
            Registro crearcuenta = new Registro(); //Creamos una instancia para pdoer reconocer el formulario "Registro.cs"
            this.Hide(); //Esconde el form actual "Bienvenido.cs"
            crearcuenta.ShowDialog(); //Abre "Resgistro.cs"
            this.Show(); //Cuando se cierra el form "Registro.cs", el form "Bienvenido.cs" volverá a mostrarse.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra el formulario actual
        }

        private void btnOjito_Click(object sender, EventArgs e)
        {
            //De acuerdo al valor de la variable "bandera", se cambia el logo del "Ojito" y la contraseña se oculta o no
            if (bandera == 1) //Si la variable es igual a 1, se oculta la contraseña y se pone un ojo cerrado
            {
                btnOjito.BackgroundImage = Properties.Resources.Ojito_cerrado; //Se pone un ojo cerrado
                txt_password.PasswordChar = '*'; //Se oculta la contraseña
                bandera = 0; //cambia el valor de la variable, para así poder mostrar la contraseña cuando haga click en el "Ojito"
            }
            else //Si la variable es distinto de 1, se muestra la contraseña y se pone un ojo abierto
            {
                btnOjito.BackgroundImage = Properties.Resources.ojito; //Se pone un ojo abierto
                bandera = 1;  //cambia el valor de la variable, para así poder ocultar la contraseña cuando haga click en el "Ojito"
                txt_password.PasswordChar = '\0'; //Se muestra la contraseña
            }

        }
    }
}
