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
    public class ConexionSQLFacturas
    {
        private string CadenaConexion = "Data Source=LAPTOP-SANTI;Initial Catalog=Proyecto;Integrated Security=True;Pooling=False";

        // Agregamos a la base de datos los datos proporcionados
        public void AgregarFactura(string Nombre, string Apellido, string Usuario, string TipoTicket, string Cantidad, DateTime Fecha)
        {
            string Date=Convert.ToString(Fecha);
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("Insert into ListadeFacturas(Usuario,Nombre,Apellido,Tipo,Cantidad,Fecha) values ('" + Usuario + "','" + Nombre + "','" + Apellido + "','" + TipoTicket + "','" + Cantidad + "','" + Date + "')", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                actualizarlista();
            }
        }

        // Eliminamos una factura utilizando la fecha como identificador
        public void Eliminar(DateTime Fecha)
        {
            string Date = Convert.ToString(Fecha);
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("Delete from ListadeFacturas where Fecha='" + Date + "'", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                actualizarlista();
            }
        }

        // Actualiza la base de datos para traer los datos más recientes
        public DataTable actualizarlista()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from ListadeFacturas", conn);
                da.SelectCommand.CommandType = CommandType.Text;
                conn.Open();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
