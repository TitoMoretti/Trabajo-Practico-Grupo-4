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
        char passwordchar;
        bool passwordEyeOn = false;
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
            passwordchar = txtContra.PasswordChar;
            icoBtnOjo.Visible = false;
            txtContra.PasswordChar = '*';
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Controladora.ControladoraUsuarios usuarios = new Controladora.ControladoraUsuarios();
            int v1 = 0;
            v1 = usuarios.validarRegister(txtNombre.Text,txtApellido.Text,txtUsuario.Text,txtEmail.Text,txtContra.Text);
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
                    string admin = "NO";
                    ConexionSQL agregar = new ConexionSQL();
                    agregar.Agregar(txtID.Text, txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtContra.Text, admin);
                    break;
            }
        }
        public void passwordCHAR(int caso)
        {

            switch (caso)
            {
                case 1:
                    txtContra.Text = "";
                    txtContra.PasswordChar = '*';
                    txtContra.ForeColor = Color.Black;

                    break;
                case 2:
                    txtContra.Text = "Contraseña";
                    txtContra.PasswordChar = passwordchar;
                    txtContra.ForeColor = Color.Silver;

                    break;
                case 3:
                    icoBtnOjo.Visible = true;
                    break;
                case 4:
                    icoBtnOjo.Visible = false;
                    break;
                case 5:
                    icoBtnOjo.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    passwordEyeOn = false;
                    icoBtnOjo.Visible = false;
                    break;
                case 6:
                    txtContra.PasswordChar = passwordchar;
                    txtContra.ForeColor = Color.Black;
                    break;
                case 7:
                    txtContra.PasswordChar = '*';
                    txtContra.ForeColor = Color.Black;
                    break;

            }

        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                passwordCHAR(1);
            }
            if (txtContra.Text != String.Empty && passwordEyeOn == false)
            {
                passwordCHAR(3);
                passwordCHAR(7);
            }
            if (txtContra.Text != String.Empty && passwordEyeOn == true)
            {
                passwordCHAR(3);
                passwordCHAR(6);
            }

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            if (txtContra.Text != String.Empty)
            {
                if (txtContra.ForeColor == Color.Silver)
                {
                    passwordCHAR(4);
                }
                else
                {
                    passwordCHAR(3);
                }

            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                passwordCHAR(2);
            }

            if (txtContra.Text != String.Empty && passwordEyeOn == true)
            {
                passwordCHAR(3);
            }
            if (passwordEyeOn == true && txtContra.Text == "Contraseña")
            {
                passwordCHAR(5);
            }
            if (passwordEyeOn == false && txtContra.Text == "Contraseña")
            {
                passwordCHAR(4);
            }
        }

        private void icoBtnOjo_MouseEnter(object sender, EventArgs e)
        {
            icoBtnOjo.IconFont = FontAwesome.Sharp.IconFont.Solid;

        }

        private void icoBtnOjo_MouseLeave(object sender, EventArgs e)
        {
            icoBtnOjo.IconFont = FontAwesome.Sharp.IconFont.Regular;
        }

        private void icoBtnOjo_Click(object sender, EventArgs e)
        {
            if (icoBtnOjo.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                icoBtnOjo.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                passwordEyeOn = true;
                passwordCHAR(6);
            }
            else
            {
                if (icoBtnOjo.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
                {
                    icoBtnOjo.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    passwordEyeOn = false;
                    passwordCHAR(7);
                }
            }
        }
    }
}
