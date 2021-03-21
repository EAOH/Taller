using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosEstacion
    {
        public ServiciosEstacion()
        {
        }
        public bool AgregarEstacion(string nombre, int ide)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Estacion = new Estacion
                    {
                        EstacionNombre=nombre,
                        ActividadId=ide
                    };
                    contexto.Estacion.Add(Estacion);
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

        public object getEstacion()
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var ListaEstacion = contexto.Estacion.Select(s => new
                    {
                        EstacionId = s.EstacionId,
                        EstacionNombre = s.EstacionNombre,
                        ActividadId = s.ActividadId
                    }).ToList();
                    return ListaEstacion;
                }

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        public Estacion ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Estacion = contexto.Estacion.Find(id);
                    return Estacion;
                }
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }
        public bool EliminarEstacion(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Estacion = contexto.Estacion.Find(id);
                    contexto.Estacion.Remove(Estacion);
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
        public bool EditarEstacion(int? id, string nombre, int ide)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var Estacion = contexto.Estacion.Find(id);
                    if (Estacion == null) return false;
                    Estacion.EstacionNombre = nombre;
                    Estacion.ActividadId = ide;
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

