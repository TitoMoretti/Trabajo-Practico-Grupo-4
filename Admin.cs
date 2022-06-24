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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            /*
            try
            {

                List<Modelo.Usuario> listaUsuarios = Controladora.ControladoraUsuarios.obtener_instancia().Listar_Usuarios();
                dgvGestionarUsuarios.DataSource = listaUsuarios;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al cargar los usuario" + Ex.Message);
                //Para cerrar el form cuando hay un error
                //this.Close();
            }
            */
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Registro register = new Registro();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            /*
            Modelo.Usuario selected = dgvGestionarUsuarios.SelectedRows[0].DataBoundItem as Modelo.Usuario;
            Controladora.ControladoraUsuarios.obtener_instancia().Eliminar_Usuario(selected);
            dgvGestionarUsuarios.DataSource = null;
            List<Modelo.Usuario> listaUsuarios = Controladora.ControladoraUsuarios.obtener_instancia().Listar_Usuarios();
            dgvGestionarUsuarios.DataSource = listaUsuarios;
            */
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            
            /*
            int id = (Convert.ToInt32(dgvGestionarUsuarios.CurrentRow.Cells[0].Value));
            Modelo.Usuario selected = Controladora.ControladoraUsuarios.obtener_instancia().Obtener_Usuario(id);
            
            //MODELO.Usuario selected = dgvGestionarUsuarios.SelectedRows[0].DataBoundItem as MODELO.Usuario;


            AlterarUsuario modifyuser = new AlterarUsuario(selected);
            modifyuser.Show();
            */
        }
    }
}
