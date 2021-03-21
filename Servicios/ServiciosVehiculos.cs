using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosVehiculos
    {
        public ServiciosVehiculos()
        {
        }
        public bool AgregarVehiculo(int idcliente, string color, string estado, string marca, string modelo, string placa)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Vehiculo = new Vehiculo
                    {
                        ClienteID= idcliente,
                        VehiculoColor = color,
                        VehiculoEstado = estado,
                        VehiculoMarca = marca,
                        VehiculoModelo = modelo,
                        VehiculoPlaca = placa
                    };
                    contexto.Vehiculo.Add(Vehiculo);
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

        public object getVehiculo()
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var ListaVehiculo = contexto.Vehiculo.Select(s => new
                    {
                        ClienteID = s.ClienteID,
                        VehiculoID = s.VehiculoID,
                        VehiculoColor = s.VehiculoColor,
                        VehiculoEstado = s.VehiculoEstado,
                        VehiculoMarca = s.VehiculoMarca,
                        VehiculoModelo = s.VehiculoModelo,
                        VehiculoPlaca = s.VehiculoPlaca
                    }).ToList();
                    return ListaVehiculo;
                }

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        public Vehiculo ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Vehiculo = contexto.Vehiculo.Find(id);
                    return Vehiculo;
                }
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }
        public bool EliminarVehiculo(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Vehiculo = contexto.Vehiculo.Find(id);
                    contexto.Vehiculo.Remove(Vehiculo);
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
        public bool EditarVehiculo(int? id, int idcliente, string color, string estado, string marca, string modelo, string placa)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Vehiculo = contexto.Vehiculo.Find(id);
                    if (Vehiculo == null) return false;
                    Vehiculo.ClienteID = idcliente;
                    Vehiculo.VehiculoColor = color;
                    Vehiculo.VehiculoEstado = estado;
                    Vehiculo.VehiculoMarca = marca;
                    Vehiculo.VehiculoModelo = modelo;
                    Vehiculo.VehiculoPlaca = placa;
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

