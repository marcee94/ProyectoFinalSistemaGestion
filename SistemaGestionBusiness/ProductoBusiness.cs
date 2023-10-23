using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBusiness
{
    public class ProductoBusiness
    {
        public static void CrearProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }
        public static void ModificarProducto(Producto producto)
        {
            ProductoData.ModificarProducto(producto);
        }
        public static void EliminarProducto(int Id)
        {
            ProductoData.EliminarProducto(Id);
        }
        public static List<Producto> ListarProductos()
        {
            return ProductoData.ListarProductos();
        }
        public static Producto ObtenerProducto(int IdProducto)
        {
            return ProductoData.ObtenerProducto(IdProducto);
        }
    }
}
