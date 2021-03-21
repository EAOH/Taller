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
    public partial class gcliente : Form
    {

        public int? id;
        Cliente clitabla = null;
        public gcliente(int? id=null)
        {
            InitializeComponent();
            this.txtIdentidad.KeyPress += new KeyPressEventHandler(Utileria.NumerosGuiones);
            this.txtTelefono.KeyPress += new KeyPressEventHandler(Utileria.NumerosTelefono);
            this.txtNombre1.KeyPress += new KeyPressEventHandler(Utileria.SoloLetras);
            this.txtNombre2.KeyPress += new KeyPressEventHandler(Utileria.SoloLetras);
            this.txtApellido1.KeyPress += new KeyPressEventHandler(Utileria.SoloLetras);
            this.txtApellido2.KeyPress += new KeyPressEventHandler(Utileria.SoloLetras);

            this.id = id;
            if (id != null)
            {
                CargaDatos();
            }
        }
        private void CargaDatos()
        {
            using (DBTallerFEntities db = new DBTallerFEntities())
            {
                clitabla = db.Cliente.Find(id);
                txtNombre1.Text = clitabla.ClienteNombre1;
                txtNombre2.Text = clitabla.ClienteNombre2;
                txtApellido1.Text = clitabla.ClienteApellido1;
                txtApellido2.Text = clitabla.ClienteApellido2;
                txtIdentidad.Text = clitabla.ClienteIdentificacion;
                txtTelefono.Text = clitabla.ClienteTelefono;
                txtDireccion.Text = clitabla.ClienteDireccion;
            }
        }
        private void btnGuardarCl_Click(object sender, EventArgs e)
        {
            string Faltantes;
            if ((Faltantes = Utileria.Requeridos(this.splitContainer1.Panel2)) != "")
            {
                MessageBox.Show("Se necesita llenar los campos de:" + Faltantes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                /*
             */
                using (DBTallerFEntities db = new DBTallerFEntities())
                {
                    if (id == null)
                        clitabla = new Cliente();

                    //T_Cliente tcliente = new T_Cliente();
                    clitabla.ClienteNombre1 = txtNombre1.Text;
                    clitabla.ClienteNombre2 = txtNombre2.Text;
                    clitabla.ClienteApellido1 = txtApellido1.Text;
                    clitabla.ClienteApellido2 = txtApellido2.Text;
                    clitabla.ClienteIdentificacion = txtIdentidad.Text;
                    clitabla.ClienteTelefono = txtTelefono.Text;
                    clitabla.ClienteDireccion = txtDireccion.Text;

                    if (id == null)
                        db.Cliente.Add(clitabla);
                    else
                    {
                        db.Entry(clitabla).State = System.Data.Entity.EntityState.Modified;
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

    }
}
