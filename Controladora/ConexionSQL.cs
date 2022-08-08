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
        private string CadenaConexion = "Data Source=LAPTOP-SANTI;Initial Catalog=Proyecto;Integrated Security=True;Pooling=False"; //Esta cadena nos permitirá establecer una conexión con una Base de Datos, en este caso con LAPTOP-SANTI 

        public void Agregar(string ID, string Nombre, string Apellido, string Usuario, string Email, string Contrasena) //Subrutina para agregar una cuenta al SQL
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion)) //Nos conectaremos con LAPTOP-SANTI
            {
                SqlCommand cmd = new SqlCommand("Insert into ListadeCuentas(ID,Nombre,Apellido,Usuario,Email,Contrasena) values ('" + ID + "','" + Nombre + "','" + Apellido + "','" + Usuario + "','" + Email + "','" + Contrasena + "')", conn); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                conn.Open(); //Abre la conexión con el SQL
                cmd.ExecuteNonQuery(); //Ejecuta el comando 
                actualizarlista(); //Invoca una función para poder actualizar el DataGridView del formulario "Admin.cs" (dvgGestionarUsuarios)
            }   
        }

        public void Modificar(string ID, string Nombre, string Apellido, string Usuario, string Email, string Contrasena) //Subrutina para modificar una cuenta del SQL
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion)) //Nos conectaremos con LAPTOP-SANTI
            {
                SqlCommand cmd = new SqlCommand("Update ListadeCuentas set ID= '" + ID + "',Nombre= '" + Nombre + "', Apellido='" + Apellido + "', Usuario='" + Usuario + "', Email='" + Email + "', Contrasena='" + Contrasena + "' where ID='" + ID + "'", conn); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                conn.Open(); //Abre la conexión con el SQL
                cmd.ExecuteNonQuery(); //Ejecuta el comando 
                actualizarlista(); //invoca una función para poder actualizar el DataGridView del formulario "Admin.cs" (dvgGestionarUsuarios)
            }
        }

        public void Eliminar(string ID, string Nombre, string Apellido, string Usuario, string Email, string Contrasena) //Subrutina para eliminar una cuenta del SQL
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion)) //Nos conectaremos con LAPTOP-SANTI
            {
                SqlCommand cmd = new SqlCommand("Delete from ListadeCuentas where ID='" + ID + "'", conn); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                conn.Open(); //Abre la conexión con el SQL
                cmd.ExecuteNonQuery(); //Ejecuta el comando 
                actualizarlista(); //invoca una función para poder actualizar el DataGridView del formulario "Admin.cs" (dvgGestionarUsuarios)
            }
        }

        public DataTable actualizarlista() //Subrutina para poder actualizar el DataGridView del formulario "Admin.cs" (dvgGestionarUsuarios)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(CadenaConexion)) //Nos conectaremos con LAPTOP-SANTI
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from ListadeCuentas ORDER BY 1", conn); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                conn.Open(); //Abre la conexión con el SQL
                da.Fill(dt); //Obtiene los datos de la tabla
                return dt; //Envia los datos de la tabla
            }
        }

        public bool FacturasUser(string Usuario) //Subrutina para verificar si el Usuario insertado en la factura se encuentra dentro del SQL
        {
            SqlConnection conn = new SqlConnection(CadenaConexion); //Nos conectaremos con LAPTOP-SANTI
            SqlCommand cmd = new SqlCommand("Select * from ListadeCuentas where Usuario=@u", conn); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
            cmd.Parameters.AddWithValue("@u", Usuario);
            conn.Open(); //Abre la conexión con el SQL
            SqlDataReader dr = cmd.ExecuteReader(); //Ejecuta el comando 
            if (dr.Read()) //Si encuentra al Usuario dentro del SQL
            {
                return true; //Devuelve un valor booleano como respuesta
            }
            else //Si no encuentra al Usuario dentro del SQL
            {
                return false; //Devuelve un valor booleano como respuesta
            }
        }

        public bool loginAdminlocal(string Usuario, string Contrasena) //Subrutina para verificar si el Nombre de Usuario y la Contraseña, ingresadas en el formulario "Login.cs", son "admin"
        {
            bool valido = false;
            if (Usuario == "admin" && Contrasena == "admin") //Si son admin
            {
                valido = true;
            }
            else //Si no son admin
            {
                valido = false;
            }
            return valido; //Devuelve un valor booleano como respuesta
        }
        public bool Logear(string Usuario, string Contrasena)
        {
            SqlConnection conn = new SqlConnection(CadenaConexion); //Nos conectaremos con LAPTOP-SANTI
            SqlCommand cmd = new SqlCommand("Select * from ListadeCuentas where Usuario=@u and Contrasena=@p", conn); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
            cmd.Parameters.AddWithValue("@u", Usuario); //Establecemos el Nombre de Usuario que queremos buscar en el SQL
            cmd.Parameters.AddWithValue("@p", Contrasena); //Establecemos la Contraseña que queremos buscar en el SQL
            conn.Open(); //Abre la conexión con el SQL
            SqlDataReader dr = cmd.ExecuteReader(); //Ejecuta el comando 
            if (dr.Read()) //Si encuentra estos datos en el SQL
            {
                return true;
            }
            else //Si no encuentra estos datos en el SQL
            {
                return false;
            }
        }
        public int ObtenerID()
        {
            int id = 0; //Variable donde guardaremos el ID más grande que se encuentra en el SQL
            using (SqlConnection conn = new SqlConnection(CadenaConexion)) //Nos conectaremos con LAPTOP-SANTI
            {
                try 
                {
                    SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM ListadeCuentas", conn); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                    conn.Open(); //Abre la conexión con el SQL
                    string id1 = cmd.ExecuteScalar().ToString(); //Ejecuta el comando y guardo el valor más grande del ID en un string
                    id = id + Convert.ToInt32(id1); //Sumo el ID más grande del SQL y lo guardo en la variable "id"
                    return id; //Envio la variable "id"
                }
                catch(Exception)
                {
                    return id; //Envio la variable "id"
                }
            }
        }
    }
}
