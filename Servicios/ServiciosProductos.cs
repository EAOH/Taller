using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosProductos
    {
        public ServiciosProductos()
        {
        }
        public bool AgregarProducto(int ide, string descripcion, int existencia, string marca, string nombre, double preciounitario, double descuento, int existenciaminima)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Producto = new Producto
                    {
                        ProveedorId= ide,
                        ProductoDescripcion = descripcion,
                        ProductoExistencia= existencia,
                        ProductoMarca = marca,
                        ProductoNombre = nombre,
                        ProductoPrecioUnitario = (decimal)preciounitario,
                        ProductoDescuento = (decimal)descuento,
                        ProductoExistenciaMin = existenciaminima
                        
                    };
                    contexto.Producto.Add(Producto);
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

        public List<Producto> GetAllProductos()
        {
            try
            {
                using (var context = new DBTallerFEntities())
                {
                    var result = context.Producto.Where(p => p.ProductoDescripcion == "P").ToList();//expresion con operador lambda donde devuelve todos los registros que su expesion sea verdadera (descripcion = "PRODUCTO")
                    return result;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        
        public ICollection<ProductoVm> GetAllServicios()
        {
            try
            {
                using (var context = new DBTallerFEntities())
                {
                    var result = context.Producto.Where(s => s.ProductoDescripcion == "S").ToList().Select(s => MapProducto(s)).ToList();

                    return result;
                }

                var facturaEntity = new Factura();
                var factura = new FacturaVm
                {
                    FacturaTotal = facturaEntity.FacturaTotal,
                    FacturaSubtotal = facturaEntity.FacturaSubtotal
                };
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public ProductoVm MapProducto(Producto producto)
        {
            var vm = new ProductoVm
            {
                ProveedorId = producto.ProveedorId,
                ProductoId = producto.ProductoId,
                ProductoDescripcion = producto.ProductoDescripcion,
                ProductoExistencia = producto.ProductoExistencia,
                ProductoMarca = producto.ProductoMarca,
                ProductoNombre = producto.ProductoNombre,
                ProductoPrecioUnitario = producto.ProductoPrecioUnitario,
                ProductoDescuento = producto.ProductoDescuento,
                ProductoExistenciaMin = producto.ProductoExistenciaMin
            };
            
            return vm;
        }
        public object getProducto()
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var ListaProducto = contexto.Producto.Select(s => new
                    {
                        ProveedorId = s.ProveedorId,
                        ProductoId = s.ProductoId,
                        ProductoDescripcion = s.ProductoDescripcion,
                        ProductoExistencia = s.ProductoExistencia,
                        ProductoMarca = s.ProductoMarca,
                        ProductoNombre = s.ProductoNombre,
                        ProductoPrecioUnitario = s.ProductoPrecioUnitario,
                        ProductoDescuento = s.ProductoDescuento,
                        ProductoExistenciaMin = s.ProductoExistenciaMin
                    }).ToList();
                    return ListaProducto;
                }

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        /**/
        public List<ProductoVm> getProductos()
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var ListaProducto = contexto.Producto.Select(s => new ProductoVm
                    {
                        ProveedorId = s.ProveedorId,
                        ProductoId = s.ProductoId,
                        ProductoDescripcion = s.ProductoDescripcion,
                        ProductoExistencia = s.ProductoExistencia,
                        ProductoMarca = s.ProductoMarca,
                        ProductoNombre = s.ProductoNombre,
                        ProductoPrecioUnitario = s.ProductoPrecioUnitario,
                        ProductoDescuento = s.ProductoDescuento,
                        ProductoExistenciaMin = s.ProductoExistenciaMin
                    }).ToList();
                    return ListaProducto;
                }

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public Producto ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Producto = contexto.Producto.Find(id);
                    return Producto;
                }
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }
        public bool EliminarProducto(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Producto = contexto.Producto.Find(id);
                    contexto.Producto.Remove(Producto);
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
        public bool EditarProducto(int? id, int ide, int codigorefaccion, string descripcion, int existencia, string marca, string nombre, double preciounitario, double descuento, int existenciaminima)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Producto = contexto.Producto.Find(id);
                    if (Producto == null) return false;
                    Producto.ProveedorId = ide;
                    Producto.ProductoDescripcion = descripcion;
                    Producto.ProductoExistencia = existencia;
                    Producto.ProductoMarca = marca;
                    Producto.ProductoNombre = nombre;
                    Producto.ProductoPrecioUnitario = (decimal)preciounitario;
                    Producto.ProductoDescuento = (decimal)descuento;
                    Producto.ProductoExistenciaMin = existenciaminima;
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

