namespace Ventas_Productos.Domain
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string CodigoBarras { get; set; }
    }
}
