﻿using System;
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
            Controladora.ControladoraUsuarios usuarios = new Controladora.ControladoraUsuarios();
            int v1 = 0;
            v1 = usuarios.validarLogin(txt_user.Text, txt_password.Text);
            if (v1 == 1)
            {
                MessageBox.Show("No se ha insertado ningún nombre de usuario. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (v1 == 2)
                {
                    MessageBox.Show("No se ha insertado ninguna contraseña. Por favor, revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (v1 == 3)
                    {
                        bool v2 = false;
                        v2 = usuarios.loginear(txt_user.Text, txt_password.Text);
                        if (v2)
                        {
                            Admin root = new Admin();
                            this.Hide();
                            root.ShowDialog();
                            this.Close();

                        }
                    }
                }
            }
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
