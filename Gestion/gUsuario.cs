using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckEngineTaller.Modelo;
using CheckEngineTaller.Servicios;
namespace CheckEngineTaller.Gestion
{
    public partial class gUsuario : Form
    {
        public int? id;
        Usuario ustabla = null;
        public gUsuario(int? id=null)
        {
            InitializeComponent();
            this.txtIdentificacionUsuario.KeyPress += new KeyPressEventHandler(Utileria.NumerosGuiones);
            this.txtSalarioUsuario.KeyPress += new KeyPressEventHandler(Utileria.NumerosDecimales);
            this.txtSalarioUsuario.LostFocus += new EventHandler(Utileria.FocoOff);
            this.txtTelefonoUsuario.KeyPress += new KeyPressEventHandler(Utileria.NumerosTelefono);
            this.txtRollUsuario.KeyPress += new KeyPressEventHandler(Utileria.NumerosEnteros);
            this.txtNombre1Usuario.KeyPress += new KeyPressEventHandler(Utileria.SoloLetras);
            this.txtNombre2Usuario.KeyPress += new KeyPressEventHandler(Utileria.SoloLetras);
            this.txtApellido1Usuario.KeyPress += new KeyPressEventHandler(Utileria.SoloLetras);
            this.txtApellido2Usuario.KeyPress += new KeyPressEventHandler(Utileria.SoloLetras);
            this.id = id;
            if (id!=null)
            {
                CargarDatos();
            }
            
        }
        private void CargarDatos()
        {
            using (DBTallerFEntities db = new DBTallerFEntities())
            {
                ustabla = db.Usuario.Find(id);
                txtNombre1Usuario.Text = ustabla.UsuarioNombre1;
                txtNombre2Usuario.Text = ustabla.UsuarioNombre2;
                txtApellido1Usuario.Text = ustabla.UsuarioApellido1;
                txtApellido2Usuario.Text = ustabla.UsuarioApellido2;
                txtIdentificacionUsuario.Text = ustabla.UsuarioIdentificacion;
                txtDireccionUsuario.Text = ustabla.UsuarioDireccion;
                txtSalarioUsuario.Text = ustabla.UsuarioSalario.ToString();
                cbbTipoSalarioUsuario.SelectedItem = ustabla.UsuarioTipoSalario;
                txtRollUsuario.Text = ustabla.UsuarioRolID.ToString();
                txtTelefonoUsuario.Text = ustabla.UsuarioTelefono;
                txtUsuarioUsuario.Text = ustabla.UsuarioUsuario;
                txtPasswordUsuario.Text = ustabla.UsuarioPassword;
                TxtDescripcion.Text = ustabla.UsuarioDescripcion;
                chkEstadoUsuario.Checked = ustabla.UsuarioEstado;
                //rbtEstadoUsuario.Checked = ustabla.UsuarioEstado;
            }
        }
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            string Faltantes;
            if ((Faltantes = Utileria.Requeridos(this)) != "")
            {
                MessageBox.Show("Se necesitan el llenado de todos los datos:" + Faltantes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (DBTallerFEntities db = new DBTallerFEntities())
                {
                    if (id == null)
                        ustabla = new Usuario();

                    ustabla.UsuarioNombre1 = txtNombre1Usuario.Text;
                    ustabla.UsuarioNombre2 = txtNombre2Usuario.Text;
                    ustabla.UsuarioApellido1 = txtApellido1Usuario.Text;
                    ustabla.UsuarioApellido2 = txtApellido2Usuario.Text;
                    ustabla.UsuarioIdentificacion = txtIdentificacionUsuario.Text;
                    ustabla.UsuarioDireccion = txtDireccionUsuario.Text;
                    ustabla.UsuarioSalario = decimal.Parse(txtSalarioUsuario.Text);
                    ustabla.UsuarioTipoSalario = cbbTipoSalarioUsuario.Text;
                    ustabla.UsuarioRolID = Int32.Parse(txtRollUsuario.Text);
                    ustabla.UsuarioTelefono = txtTelefonoUsuario.Text;
                    ustabla.UsuarioUsuario = txtUsuarioUsuario.Text;
                    ustabla.UsuarioPassword = txtPasswordUsuario.Text;
                    ustabla.UsuarioDescripcion = TxtDescripcion.Text;
                    ustabla.UsuarioEstado = chkEstadoUsuario.Checked;
                   // ustabla.UsuarioEstado = rbtEstadoUsuario.Checked;

                    if (id == null)
                        db.Usuario.Add(ustabla);
                    else
                    {
                        db.Entry(ustabla).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
            
        }
        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRollUsuario.Text = TxtDescripcion.SelectedIndex.ToString();
            //txtRollUsuario.Text = string.Format("{0}", TxtDescripcion.SelectedItem);
            /*if (TxtDescripcion.SelectedIndex == 0)
            {
                MessageBox.Show("favor seleccione una opcion valida","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDescripcion.SelectedIndex = 1;
            }*/
        }
    }
}
