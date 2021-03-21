//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckEngineTaller.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Actividad = new HashSet<Actividad>();
            this.FacturaDetalle = new HashSet<FacturaDetalle>();
            this.Pedido = new HashSet<Pedido>();
        }
    
        public int ProductoId { get; set; }
        public int ProveedorId { get; set; }
        public string ProductoDescripcion { get; set; }
        public int ProductoExistencia { get; set; }
        public string ProductoMarca { get; set; }
        public string ProductoNombre { get; set; }
        public decimal ProductoPrecioUnitario { get; set; }
        public decimal ProductoDescuento { get; set; }
        public int ProductoExistenciaMin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actividad> Actividad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaDetalle> FacturaDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
