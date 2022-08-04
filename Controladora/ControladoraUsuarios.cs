using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Controladora;
using System.Security.Cryptography;

namespace Controladora
{
    public class ControladoraUsuarios
    {
        public int validarLogin(string Usuario,string Contrasena)
        {
            int valido = 0;
            if (Usuario == string.Empty)
            {
                valido = 0 + 1;
            }
            else
            {
                if (Contrasena == string.Empty)
                {
                    valido = 0 + 2;
                }
                else
                {
                    valido = 0 + 3;
                }
            }
            return valido;
        }
        public int validarRegister(string Nombre, string Apellido, string Usuario, string Email, string Contrasena)
        {
            int valido = 0;
            if (Nombre == string.Empty)
            {
                valido = 0 + 1;
            }
            else
            {
                if (Apellido == string.Empty)
                {
                    valido = 0 + 2;
                }
                else
                {
                    if (Usuario == string.Empty)
                    {
                        valido = 0 + 3;
                    }
                    else
                    {
                        if (Email == string.Empty)
                        {
                            valido = 0 + 4;
                        }
                        else
                        {
                            Regex mRegxExpression;
                            mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                            if (!mRegxExpression.IsMatch(Email))
                            {
                                //Email no válido
                                valido = 0 + 5;
                            }
                            else
                            {
                                //Email válido
                                if (Contrasena == string.Empty)
                                {
                                    valido = 0 + 6;
                                }
                                else
                                {
                                    string password = Contrasena;
                                    Regex len = new Regex("^.{5,15}$");
                                    Regex num = new Regex("\\d");
                                    Regex alpha = new Regex("\\D");

                                    if (len.IsMatch(password))
                                    {
                                        //Password Válido
                                        if (num.IsMatch(password))
                                        {
                                            if (alpha.IsMatch(password))
                                            {
                                                valido = 0 + 10;
                                            }
                                            else
                                            {
                                                valido = 0 + 9;
                                            }
                                        }
                                        else
                                        {
                                            valido = 0 + 8;
                                        }
                                    }
                                    else
                                    {
                                        valido = 0 + 7;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return valido;
        }
        public string Encriptar(string contraseña)
        {
            //Encriptacion TripleDES(Triple Data Encryption Standard), creando instancia de la clase TripleDESCryptoServiceProvider, que le da la funcionalidad al algoritmo
            using (TripleDESCryptoServiceProvider servicioEncriptadoDES = new TripleDESCryptoServiceProvider())
            {
                //Calcula el valor del Hash
                using (MD5CryptoServiceProvider servicioProveedorMD5 = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = servicioProveedorMD5.ComputeHash(Encoding.UTF8.GetBytes("Grupo-4"));
                    servicioEncriptadoDES.Key = byteHash;
                    servicioEncriptadoDES.Mode = CipherMode.ECB; //Se elige el modo de descifrado de las contraseñas
                    byte[] dato = Encoding.Unicode.GetBytes(contraseña);
                    return Convert.ToBase64String(servicioEncriptadoDES.CreateEncryptor().TransformFinalBlock(dato, 0, dato.Length));
                }
            }
        }
        public string Desencriptar(string encriptado)
        {
            //Encriptacion TripleDES(Triple Data Encryption Standard), creando instancia de la clase TripleDESCryptoServiceProvider, que le da la funcionalidad al algoritmo
            using (TripleDESCryptoServiceProvider servicioEncriptadoDES = new TripleDESCryptoServiceProvider())
            {
                //Calcula el valor del Hash
                using (MD5CryptoServiceProvider servicioProveedorMD5 = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = servicioProveedorMD5.ComputeHash(Encoding.UTF8.GetBytes("Grupo-4"));
                    servicioEncriptadoDES.Key = byteHash;
                    servicioEncriptadoDES.Mode = CipherMode.ECB; //Se elige el modo de descifrado de las contraseñas
                    byte[] byteBuff = Convert.FromBase64String(encriptado);
                    return Encoding.Unicode.GetString(servicioEncriptadoDES.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                }
            }
        }
    }
}
