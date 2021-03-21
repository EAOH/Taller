using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosProveedor
    {
        public ServiciosProveedor()
        {
        }
        public bool AgregarProveedores(string descripcion, string formapago, string nombre)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Proveedores = new Proveedor
                    {
                        ProveedorDescripcion = descripcion,
                        ProveedorFormaPago = formapago,
                        ProveedorNombre = nombre
                    };
                    contexto.Proveedor.Add(Proveedores);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public object getProveedores()
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var ListaProveedores = contexto.Proveedor.Select(s => new
                    {
                        ProveedorId = s.ProveedorId,
                        ProveedorDescripcion = s.ProveedorDescripcion,
                        ProveedorFormaPagoP_FormaPago = s.ProveedorFormaPago,
                        ProveedorNombre = s.ProveedorNombre
                    }).ToList();
                    return ListaProveedores;
                }

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        public Proveedor ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Proveedores = contexto.Proveedor.Find(id);
                    return Proveedores;
                }
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }
        public bool EliminarProveedores(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Proveedores = contexto.Proveedor.Find(id);
                    contexto.Proveedor.Remove(Proveedores);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }
        public bool EditarProveedores(int? id, string descripcion, string formapago, string nombre)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Proveedores = contexto.Proveedor.Find(id);
                    if (Proveedores == null) return false;
                    Proveedores.ProveedorDescripcion = descripcion;
                    Proveedores.ProveedorFormaPago = formapago;
                    Proveedores.ProveedorNombre = nombre;
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }
    }
}
