using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuario")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBusiness.ListarUsuario()
            .ToArray();
        }

        [HttpDelete(Name = "EliminarUsuario")]
        public void Delete([FromBody] int Id)
        {
            UsuarioBusiness.EliminarUsuario(Id);
        }

        [HttpPut(Name = "ModificarUsuario")]
        public void Put([FromBody] Usuario usuario)
        {
            UsuarioBusiness.ModificarUsuario(usuario);
        }

        [HttpPost(Name = "CrearUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBusiness.CrearUsuario(usuario);
        }
        [HttpPost]
        [Route("autenticar")]
        public IActionResult Autenticar([FromBody] Usuario usuarioLogin)
        {
            Usuario usuarioAutenticado = UsuarioBusiness.AutenticarUsuario(usuarioLogin);

            if (usuarioAutenticado != null)
            {
                return Ok("Autenticación exitosa");
            }

            return Unauthorized("Credenciales incorrectas");
        }

    }
}
