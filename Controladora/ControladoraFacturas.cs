using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Controladora
{
    //Validamos que los campos para generar una factura no esten vacíos
    public class ControladoraFacturas
    {
        public int validarFactura(string Nombre, string Apellido, string Usuario, string TipoTicket, string CantidadTicket, DateTime FechadeIngreso)
        {
            string fecha = Convert.ToString(FechadeIngreso);
            int valido = 0;
            if (Usuario==string.Empty)
            {
                valido = 3;
            }
            else
            {
                if (Nombre == string.Empty)
                {
                    valido = 1;
                }
                else
                {
                    if(Apellido == string.Empty)
                    {
                        valido = 2;
                    }
                    else
                    {
                        if(CantidadTicket == string.Empty)
                        {
                            valido = 4;
                        }
                        else
                        {
                            valido = 5;
                        }
                    }
                }
            }
            return valido;
        }
    }
}
