using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosUsuario
    {
        public ServiciosUsuario()
        {
        }

        public bool AgregarUsuario(String nombre1, string nombre2, string apellido1, string apellido2, string identificacion, string direccion, double salario, string tipoSalario, int roll, string telefono, string usuario, string password, string descripcion, bool estado )
        {
            try
            {
                using(var contexto = new DBTallerFEntities())
                {
                    var usuarios = new Usuario
                    {
                        UsuarioNombre1 = nombre1,
                        UsuarioNombre2 = nombre2,
                        UsuarioApellido1 = apellido1,
                        UsuarioApellido2 = apellido2,
                        UsuarioIdentificacion = identificacion,
                        UsuarioDireccion = direccion,
                        UsuarioSalario = (decimal)salario,
                        UsuarioTipoSalario = tipoSalario,
                        UsuarioRolID = roll,
                        UsuarioTelefono = telefono,
                        UsuarioUsuario = usuario,
                        UsuarioPassword = password,
                        UsuarioDescripcion=descripcion,
                        UsuarioEstado = estado
                    };
                    contexto.Usuario.Add(usuarios);
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
        public object getUsuario()
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var ListaUsuario = contexto.Usuario.Select(s => new
                    {
                        UsuarioNombre1 = s.UsuarioNombre1,
                        UsuarioNombre2 = s.UsuarioNombre2,
                        UsuarioApellido1 = s.UsuarioApellido1,
                        UsuarioApellido2 = s.UsuarioApellido2,
                        UsuarioIdentificacion = s.UsuarioIdentificacion,
                        UsuarioDireccion = s.UsuarioDireccion,
                        UsuarioSalario = s.UsuarioSalario,
                        UsuarioTipoSalario = s.UsuarioTipoSalario,
                        UsuarioRolID = s.UsuarioRolID,
                        UsuarioTelefono = s.UsuarioTelefono,
                        UsuarioUsuario = s.UsuarioUsuario,
                        UsuarioPassword = s.UsuarioPassword,
                        UsuarioDescripcion=s.UsuarioDescripcion,
                        UsuarioEstado = s.UsuarioEstado
                    }).ToList();
                    return ListaUsuario;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        public Usuario ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var usuario = contexto.Usuario.Find(id);
                    return usuario;
                }
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }
        public bool EliminarUsuario(int? id)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var usuario = contexto.Usuario.Find(id);
                    contexto.Usuario.Remove(usuario);
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
        public bool EditarUsuario(int? id, String nombre1, string nombre2, string apellido1, string apellido2, string identificacion, string direccion, double salario, string tipoSalario, int roll, string telefono, string usuario, string password,string descripcion, bool estado)
        {
            try
            {
                using (var contexto = new DBTallerFEntities())
                {
                    var usuarios = contexto.Usuario.Find(id);
                    if (usuarios == null) return false;
                    usuarios.UsuarioNombre1 = nombre1;
                    usuarios.UsuarioNombre2 = nombre2;
                    usuarios.UsuarioApellido1 = apellido1;
                    usuarios.UsuarioApellido2 = apellido2;
                    usuarios.UsuarioIdentificacion = identificacion;
                    usuarios.UsuarioDireccion = direccion;
                    usuarios.UsuarioSalario = (decimal)salario;
                    usuarios.UsuarioTipoSalario = tipoSalario;
                    usuarios.UsuarioRolID = roll;
                    usuarios.UsuarioTelefono = telefono;
                    usuarios.UsuarioUsuario = usuario;
                    usuarios.UsuarioPassword = password;
                    usuarios.UsuarioDescripcion = descripcion;
                    usuarios.UsuarioEstado = estado;
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

        public string GetPassword(string usuarioPassword)
        {
            return null;
            //throw new NotImplementedException();
        }

        public Usuario GetUsuarioByUser(string usuario)
        {
            try
            {
                using (var db= new DBTallerFEntities())
                {
                    var user = db.Usuario.FirstOrDefault(c => c.UsuarioUsuario == usuario);
                    if (user == null) return null;
                    return user;
                }
            }
            catch (Exception e)
            {
                               
                throw e;
            }
            
            //throw new NotImplementedException();
        }
    }
}
