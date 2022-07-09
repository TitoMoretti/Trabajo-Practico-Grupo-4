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
                SqlCommand cmd = new SqlCommand("update ListadeCuentas set Nombre= '" + Nombre + "', Apellido='" + Apellido + "', Usuario='" + Usuario + "', Email='" + Email + "', Contrasena='" + Contrasena + "'where Usuario='" + Usuario + "'", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                actualizarlista();
            }
        }

        public void Eliminar(string Usuario)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("delete from ListadeCuentas where Usuario =" + Usuario, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
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
