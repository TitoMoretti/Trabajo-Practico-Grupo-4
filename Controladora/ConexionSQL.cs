using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;


namespace Controladora
{
    public class ConexionSQL
    {
        private string CadenaConexion = "Data Source=DESKTOP-2F4NVAS\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True;Pooling=False";

        public void Agregar(string Nombre, string Apellido, string Usuario, string Email, string Contrasena)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("Insert into ListadeCuentas(Nombre,Apellido,Usuario,Email,Contrasena) values ('" + Nombre + "','" + Apellido + "','" + Usuario + "','" + Email + "','" + Contrasena + "')", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                actualizarlista();
            }   
        }

        public void Modificar(string Nombre, string Apellido, string Usuario, string Email, string Contrasena)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("Update ListadeCuentas set Nombre= '" + Nombre + "', Apellido='" + Apellido + "', Usuario='" + Usuario + "', Email='" + Email + "', Contrasena='" + Contrasena + "' where Usuario='" + Usuario + "'", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                actualizarlista();
            }
        }

        public void Eliminar(string N)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("Delete from ListadeCuentas where N='" + N + "'", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                actualizarlista();
            }
        }

        public DataTable actualizarlista()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from ListadeCuentas", conn);
                da.SelectCommand.CommandType = CommandType.Text;
                conn.Open();
                da.Fill(dt);
                return dt;
            }
        }
        public bool NombreLogin(string Usuario)
        {
            SqlConnection conn = new SqlConnection(CadenaConexion);
            try
            {
                SqlCommand user = new SqlCommand("Select * from ListadeCuentas where Usuario='" + Usuario + "'", conn);
                SqlDataReader rta;
                rta = user.ExecuteReader();
                if (rta.Read())
                {
                    return true;
                }
                rta.Close();
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool ContraLogin(string Contrasena)
        {
            SqlConnection conn = new SqlConnection(CadenaConexion);
            try
            {
                SqlCommand pass = new SqlCommand("Select * from ListadeCuentas where Contrasena='" + Contrasena + "'", conn);
                SqlDataReader rta;
                rta = pass.ExecuteReader();
                if (rta.Read())
                {
                    return true;
                }
                rta.Close();
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool loginAdminlocal(string Usuario, string Contrasena)
        {
            bool valido = false;
            if (Usuario == "admin" && Contrasena == "admin")
            {
                valido = true;
            }
            else
            {
                valido = false;
            }
            return valido;
        }
    }
}
