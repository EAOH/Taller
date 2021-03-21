using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CheckEngineTaller
{
    public class FacturaProductosVm
    {
        public int P_Id { get; internal set; }
        public string ProductoNombre { get; internal set; }
        public int ProductoId { get; internal set; }
        public decimal ProductoPrecioUnitario { get; internal set; }
        public int ProductoQty { get; set; }
        public String DetalleProducto { get; set; }
        public ProductoVm Producto { get; set; }

        public override string ToString()
        {

            return $"Cantidad: {ProductoQty} {Producto.ToString()}";
        }
    }
}
