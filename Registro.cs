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
            bool valido = false;
            valido = validaciones();
            if (valido)
            {

            }
        }

        private bool validaciones()
        {
            bool valido = false;
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("No se ha insertado ningún nombre. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtApellido.Text == string.Empty)
                {
                    MessageBox.Show("No se ha insertado ningún apellido. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtUsuario.Text == string.Empty)
                    {
                        MessageBox.Show("No se ha insertado ningún nombre de usuario. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtEmail.Text == string.Empty)
                        {
                            MessageBox.Show("No se ha insertado un correo electrónico. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Regex mRegxExpression;
                            mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                            if (!mRegxExpression.IsMatch(txtEmail.Text))
                            {
                                //Email no válido
                                MessageBox.Show("No se ha insertado un correo electrónico válido. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //Email válido
                                if(txtContra.Text == string.Empty)
                                {
                                    MessageBox.Show("No se ha insertado una contraseña. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string password = txtContra.Text;
                                    Regex len = new Regex("^.{6,15}$");
                                    Regex num = new Regex("\\d");
                                    Regex alpha = new Regex("\\D");

                                    if (len.IsMatch(password))
                                    {
                                        //Password Válido
                                        if (num.IsMatch(password))
                                        {
                                            if (alpha.IsMatch(password))
                                            {
                                                valido = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("No se ha insertado una contraseña valida. La contraseña debe incluir al menos una letra.\nPor favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se ha insertado una contraseña valida. La contraseña debe incluir al menos un número.\nPor favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se ha insertado una contraseña valida. La contraseña solo puede ser entre 6 a 15 caracteres.\nPor favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return valido;
        }
    }
}
