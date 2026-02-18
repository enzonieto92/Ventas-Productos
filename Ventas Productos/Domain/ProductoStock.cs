using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas_Productos.Domain
{
    public class ProductoStock
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string CodigoBarras { get; set; }
        public int Stock {  get; set; }
    }
}
