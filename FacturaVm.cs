using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEngineTaller
{
    public class FacturaVm
    {
        public string Cliente { get; set; }


        public List<FacturaProductosVm> DetalleFactura { get; set; }
        public decimal FacturaTotal { get; internal set; }
        public decimal FacturaSubtotal { get; internal set; }

        public bool CalculateTotal()
        {
            try
            {
                decimal subtotal = 0.00m;
                foreach (var item in DetalleFactura)
                {
                    subtotal += item.ProductoPrecioUnitario;
                }

                FacturaSubtotal = subtotal;
                FacturaTotal = (subtotal + subtotal * 0.15m); // - Descuento 

                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

    }
}
