using System.Security.Policy;

namespace Ventas_Productos.Domain

{
    public class VentaItem
    {
        private int VentaId { get; set; }
        public int IdProducto {  get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }

        public VentaItem()
        {

        }
        public VentaItem(ProductoVenta p) 
        {
            IdProducto = p.Id;
            NombreProducto = p.Nombre;
            Cantidad = p.Cantidad;
            PrecioUnitario = p.Precio;
        }

    }

}