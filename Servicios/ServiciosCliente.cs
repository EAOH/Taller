using CheckEngineTaller.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosCliente
    {
        public ServiciosCliente()
        {
        }
        public bool AgregarCliente(string nombre1, string nombre2, string apellido1, string apellido2, string identidad, string telefono, string direccion)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var clientes = new Cliente
                    {
                        ClienteNombre1 = nombre1,
                        ClienteNombre2 = nombre2,
                        ClienteApellido1 = apellido1,
                        ClienteApellido2 = apellido2,
                        ClienteIdentificacion = identidad,
                        ClienteTelefono = telefono,
                        ClienteDireccion = direccion
                    };
                    contexto.Cliente.Add(clientes);
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

        public object getClientes()
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var ListaClientes = contexto.Cliente.Select(s => new
                    {
                        ClienteID = s.ClienteID,
                        ClienteNombre1 = s.ClienteNombre1,
                        ClienteNombre2 = s.ClienteNombre2,
                        ClienteApellido1 = s.ClienteApellido1,
                        ClienteApellido2 = s.ClienteApellido2,
                        ClienteIdentificacion = s.ClienteIdentificacion,
                        ClienteTelefono = s.ClienteTelefono,
                        ClienteDireccion = s.ClienteDireccion
                    }).ToList();
                    return ListaClientes;
                }
                
            }
            catch(Exception ex)
            {
                return null;
                throw ex;
            }
        }
        public Cliente ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities()) //LA TUYA ZUCKARITAS //terminame el proyecto we :v
                {
                    var clientes = contexto.Cliente.Find(id);
                    return clientes;
                }
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }
        public bool EliminarCliente(int? id)
        {
            try
            {
                using  (var contexto = new DBTallerFEntities()) 
                {
                    var clientes = contexto.Cliente.Find(id);
                    contexto.Cliente.Remove(clientes);
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
        public bool EditarCliente(int? id, string nombre1, string nombre2, string apellido1, string apellido2, string identidad, string telefono, string direccion)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var clientes = contexto.Cliente.Find(id);
                    if (clientes == null) return false;
                    clientes.ClienteNombre1 = nombre1;
                    clientes.ClienteNombre2 = nombre2;
                    clientes.ClienteApellido1 = apellido1;
                    clientes.ClienteApellido2 = apellido2;
                    clientes.ClienteIdentificacion = identidad;
                    clientes.ClienteTelefono = telefono;
                    clientes.ClienteDireccion = direccion;
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
