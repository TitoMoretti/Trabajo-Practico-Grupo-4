using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_POO_Grupo_4
{
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Evento que abre un formulario para poder iniciar sesión.
            Login iniciarsesion = new Login(); //Creamos una instancia para pdoer reconocer el formulario "Login.cs"
            this.Hide(); //Esconde el form actual "Bienvenido.cs"
            iniciarsesion.ShowDialog(); //Abre "Login.cs"
            this.Show(); //Cuando se cierra el form "Login.cs", el form "Bienvenido.cs" volverá a mostrarse.
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Evento que abre un formulario para poder crear una cuenta.
            Registro crearcuenta = new Registro(); //Creamos una instancia para pdoer reconocer el formulario "Registro.cs"
            this.Hide(); //Esconde el form actual "Bienvenido.cs"
            crearcuenta.ShowDialog(); //Abre "Resgistro.cs"
            this.Show(); //Cuando se cierra el form "Registro.cs", el form "Bienvenido.cs" volverá a mostrarse.
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra el formulario actual
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            FAQ FAQ = new FAQ(); //Creamos una instancia para pdoer reconocer el formulario "FAQ.cs"
            this.Hide(); //Esconde el form actual "Bienvenido.cs"
            FAQ.ShowDialog(); //Abre "FAQ.cs"
            this.Show(); //Cuando se cierra el form "FAQ.cs", el form "Bienvenido.cs" volverá a mostrarse.
        }
    }
}
