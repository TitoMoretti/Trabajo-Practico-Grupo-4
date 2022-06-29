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
        private string CadenaConexion = "Data Source=LAPTOP-SANTI;Initial Catalog=Proyecto;Integrated Security=True;Pooling=False";

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
                SqlCommand cmd = new SqlCommand("Update into ListadeCuentas(Nombre,Apellido,Usuario,Email,Contrasena) values ('" + Nombre + "','" + Apellido + "','" + Usuario + "','" + Email + "','" + Contrasena + "')", conn);
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
                SqlDataAdapter da = new SqlDataAdapter("select * from ListadeCuentas", conn);
                da.SelectCommand.CommandType = CommandType.Text;
                conn.Open();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
