using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> Get()
        {
            return VentaBusiness.ListarVenta()
            .ToArray();
        }

        [HttpDelete(Name = "EliminarVenta")]
        public void Delete([FromBody] int Id)
        {
            VentaBusiness.EliminarVenta(Id);
        }

        [HttpPut(Name = "ModificarVenta")]
        public void Put([FromBody] Venta venta)
        {
            VentaBusiness.ModificarVenta(venta);
        }

        [HttpPost(Name = "CrearVenta")]
        public void Post([FromBody] Venta venta)
        {
            VentaBusiness.CrearVenta(venta);
        }
    }
}
