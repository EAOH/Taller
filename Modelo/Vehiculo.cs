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
    
    public partial class Vehiculo
    {
        public int ClienteID { get; set; }
        public int VehiculoID { get; set; }
        public string VehiculoColor { get; set; }
        public string VehiculoEstado { get; set; }
        public string VehiculoMarca { get; set; }
        public string VehiculoModelo { get; set; }
        public string VehiculoPlaca { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}