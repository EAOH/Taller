using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEngineTaller
{
    public class ProductoVm
    {
        public int ProveedorId { get; internal set; }
        public int ProductoId { get; internal set; }
        public string ProductoDescripcion { get; internal set; }
        public int ProductoExistencia { get; internal set; }
        public string ProductoMarca { get; internal set; }
        public string ProductoNombre { get; internal set; }
        public decimal ProductoPrecioUnitario { get; internal set; }
        public decimal ProductoDescuento { get; internal set; }
        public int ProductoExistenciaMin { get; internal set; }

        public override string ToString()
        {
            return $"Producto {ProductoNombre} Precio Unitario: {ProductoPrecioUnitario} "; 
        }
    }
}