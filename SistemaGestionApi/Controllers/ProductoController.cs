using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "GetProducto")]
        public IEnumerable<Producto> Get()
        {
            return ProductoBusiness.ListarProductos()
            .ToArray();
        }

        [HttpDelete(Name = "EliminarProducto")]
        public void Delete([FromBody] int Id)
        {
            ProductoBusiness.EliminarProducto(Id);
        }

        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody] Producto producto)
        {
            ProductoBusiness.ModificarProducto(producto);
        }

        [HttpPost(Name = "CrearProducto")]
        public void Post([FromBody] Producto producto)
        {
            ProductoBusiness.CrearProducto(producto);
        }
    }
}
