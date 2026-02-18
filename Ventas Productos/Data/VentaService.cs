using System.Collections.Generic;
using Ventas_Productos.Data;
using Ventas_Productos.Domain;

namespace Ventas_Productos.Data
{
    internal class VentaService
    {
        private readonly DatabaseService dbService;

        public VentaService(DatabaseService dbService)
        {
            this.dbService = dbService;
        }

        public void ConfirmarVenta(IEnumerable<ProductoVenta> seleccionados, decimal total)
        {
            var venta = new Venta
            {
                Total = total
            };

            var items = new List<VentaItem>();

            foreach (var item in seleccionados)
            {
                items.Add(new VentaItem(item));
            }

            dbService.GuardarVenta(venta, items);
        }
    }
}
