using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraUsuarios
    {
        private static ControladoraUsuarios _instancia;

        private ControladoraUsuarios() { }

        public static ControladoraUsuarios obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraUsuarios();
            }
            return _instancia;
        }

        public List<Modelo.Usuario> Listar_Usuarios()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.Usuarios.ToList();
        }

        public void Agregar_Usuario(Modelo.Usuario usuario)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.Usuarios.Add(usuario);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
        public void Eliminar_Usuario(Modelo.Usuario usuario)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.Usuarios.Remove(usuario);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
        public Modelo.Usuario Obtener_Usuario(int CODIGO)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.Usuarios.Find(CODIGO);
        }
    }
}
