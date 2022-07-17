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

        public void AgregarFactura(string Nombre, string Apellido, string Usuario, string TipoTicket, string Cantidad, DateTime Fecha)
        {
            string Date=Convert.ToString(Fecha);
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("Insert into ListadeFacturas(Nombre,Apellido,Usuario,Tipo,Cantidad,Fecha) values ('" + Nombre + "','" + Apellido + "','" + Usuario + "','" + TipoTicket + "','" + Cantidad + "','" + Date + "')", conn);
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
                SqlDataAdapter da = new SqlDataAdapter("Select * from ListadeFacturas", conn);
                da.SelectCommand.CommandType = CommandType.Text;
                conn.Open();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
