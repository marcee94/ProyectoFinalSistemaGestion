using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBusiness
{
    public class ProductoVendidoBusiness
    {
        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.CrearProductoVendido(productoVendido);
        }
        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }
        public static void EliminarProductoVendido(int Id)
        {
            ProductoVendidoData.EliminarProductoVendido(Id);
        }
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }
        public static ProductoVendido ObtenerProductoVendido(int IdProductoVendido)
        {
            return ProductoVendidoData.ObtenerProductoVendido(IdProductoVendido);
        }
    }
}
