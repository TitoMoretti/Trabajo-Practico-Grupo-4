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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool valido = false;
            valido = validaciones();
            if (valido)
            {

            }
        }

        private bool validaciones()
        {
            bool valido=false;
            if (txt_user.Text==string.Empty)
            {
                MessageBox.Show("No se ha insertado ningún nombre de usuario. Por favor, revise la información y vuelva a intentarlo.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (txt_password.Text == string.Empty)
                {
                    MessageBox.Show("No se ha insertado ninguna contraseña. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string password = txt_password.Text;
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
            return valido;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Registro crearcuenta  = new Registro();
            this.Hide();
            crearcuenta.ShowDialog();
            this.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
