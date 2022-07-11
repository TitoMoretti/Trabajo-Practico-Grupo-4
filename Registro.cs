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

namespace Trabajo_POO_Grupo_4
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        
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
            switch(v1)
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
                    for (int i = 0; i < 10000; i++)
                    {
                        txtID.Text = i.ToString();
                    }
                    ConexionSQL agregar = new ConexionSQL();
                    agregar.Agregar(txtID.Text, txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text, txtAdmin.Text);
                    MessageBox.Show("Registro con éxito");
                    break;
            }
        }
    }
}
