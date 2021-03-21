using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;
namespace CheckEngineTaller.Servicios
{
    public class ServiciosPedidos
    {
        public ServiciosPedidos()
        {
        }
        public bool AgregarPedido(int ide, int cantidad, string descripcion, double preciounitario)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Pedido = new Pedido
                    {
                        ProductoId = ide,
                        PedidoCantidad = cantidad,
                        PedidoDescripcion = descripcion,
                        PedidoPrecioUnitario = (decimal)preciounitario
                    };
                    contexto.Pedido.Add(Pedido);
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

        public object getPedido()
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var ListaPedido = contexto.Pedido.Select(s => new
                    {
                        PedidoId = s.PedidoId,
                        ProductoId = s.ProductoId,
                        PedidoCantidad = s.PedidoCantidad,
                        PedidoDescripcion = s.PedidoDescripcion,
                        PedidoPrecioUnitario = s.PedidoPrecioUnitario
                    }).ToList();
                    return ListaPedido;
                }

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        public Pedido ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Pedido = contexto.Pedido.Find(id);
                    return Pedido;
                }
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }
        public bool EliminarPedido(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Pedido = contexto.Pedido.Find(id);
                    contexto.Pedido.Remove(Pedido);
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
        public bool EditarPedido(int? id, int ide, int cantidad, string descripcion, double preciounitario)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Pedido = contexto.Pedido.Find(id);
                    if (Pedido == null) return false;
                    Pedido.ProductoId = ide;
                    Pedido.PedidoCantidad = cantidad;
                    Pedido.PedidoDescripcion = descripcion;
                    Pedido.PedidoPrecioUnitario = (decimal)preciounitario;
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

