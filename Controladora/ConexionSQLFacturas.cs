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
        private string CadenaConexion = "Data Source=LAPTOP-SANTI;Initial Catalog=Proyecto;Integrated Security=True;Pooling=False"; //Esta cadena nos permitirá establecer una conexión con una Base de Datos, en este caso con LAPTOP-SANTI 

        // Agregamos a la base de datos los datos proporcionados
        public void AgregarFactura(string Nombre, string Apellido, string Usuario, string TipoTicket, string Cantidad, DateTime Fecha) //Subrutina para agregar una factura al SQL
        {
            string Date=Convert.ToString(Fecha); //El valor del DateTime lo guardamos en un string
            using (SqlConnection conn = new SqlConnection(CadenaConexion)) //Nos conectaremos con LAPTOP-SANTI
            {
                SqlCommand cmd = new SqlCommand("Insert into ListadeFacturas(Usuario,Nombre,Apellido,Tipo,Cantidad,Fecha) values ('" + Usuario + "','" + Nombre + "','" + Apellido + "','" + TipoTicket + "','" + Cantidad + "','" + Date + "')", conn); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                conn.Open(); //Abre la conexión con el SQL
                cmd.ExecuteNonQuery(); //Ejecuta el comando
                actualizarlista(); //Invoca una función para poder actualizar el DataGridView del formulario "Facturacion.cs" (dgvGestionarFacturas)
            }
        }

        // Eliminamos una factura utilizando la fecha como identificador
        public void Eliminar(DateTime Fecha) //Subrutina para eliminar una cuenta del SQL
        {
            string Date = Convert.ToString(Fecha); //El valor del DateTime lo guardamos en un string
            using (SqlConnection conn = new SqlConnection(CadenaConexion)) //Nos conectaremos con LAPTOP-SANTI
            {
                SqlCommand cmd = new SqlCommand("Delete from ListadeFacturas where Fecha='" + Date + "'", conn); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                conn.Open(); //Abre la conexión con el SQL
                cmd.ExecuteNonQuery(); //Ejecuta el comando
                actualizarlista(); //Invoca una función para poder actualizar el DataGridView del formulario "Facturacion.cs" (dgvGestionarFacturas)
            }
        }

        // Actualiza la base de datos para traer los datos más recientes
        public DataTable actualizarlista()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(CadenaConexion)) //Nos conectaremos con LAPTOP-SANTI
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from ListadeFacturas", conn); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                conn.Open(); //Abre la conexión con el SQL
                da.Fill(dt); //Obtiene los datos de la tabla
                return dt; //Envia los datos de la tabla
            }
        }
    }
}
