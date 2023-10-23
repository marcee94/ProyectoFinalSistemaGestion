using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBusiness
{
    public class UsuarioBusiness
    {
        public static void CrearUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }
        public static void ModificarUsuario(Usuario usuario)
        {
            UsuarioData.ModificarUsuario(usuario);
        }
        public static void EliminarUsuario(int Id)
        {
            UsuarioData.EliminarUsuario(Id);
        }
        public static List<Usuario> ListarUsuario()
        {
            return UsuarioData.ListarUsuarios();
        }
        public static Usuario ObtenerUsuario(int IdUsuario)
        {
            return UsuarioData.ObtenerUsuario(IdUsuario);
        }
        public static Usuario AutenticarUsuario(Usuario usuarioLogin)
        {
            Usuario usuario = UsuarioData.ObtenerUsuarioPorCredenciales(usuarioLogin.NombreUsuario, usuarioLogin.Contraseña);

            return usuario;
        }

    }
}
