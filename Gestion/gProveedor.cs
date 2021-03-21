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
    public partial class gProveedor : Form
    {
        public int? id;
        Proveedor provtabla = null;
        public gProveedor(int? id= null)
        {
            InitializeComponent();
            this.id = id;
            if (id!=null)
            {
                CargarDatos();
            }
        }
        private void CargarDatos()
        {
            using(DBTallerFEntities db = new DBTallerFEntities())
            {
                provtabla = db.Proveedor.Find(id);
                txtNombreProveedor.Text = provtabla.ProveedorNombre;
                cbbFormaPagoProveedor.SelectedItem = provtabla.ProveedorFormaPago;
                txtDescripcionProveedor.Text = provtabla.ProveedorDescripcion;
            }            
        }
        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            string Faltantes;
            if ((Faltantes = Utileria.Requeridos(this.splitContainer1.Panel2)) != "")
            {
                MessageBox.Show("Se necesitan el llenado de todos los datos:" + Faltantes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (DBTallerFEntities db = new DBTallerFEntities())
                {
                    if (id == null)
                        provtabla = new Proveedor();

                    provtabla.ProveedorNombre = txtNombreProveedor.Text;
                    provtabla.ProveedorFormaPago = cbbFormaPagoProveedor.Text;
                    provtabla.ProveedorDescripcion = txtDescripcionProveedor.Text;

                    if (id == null)
                        provtabla = new Proveedor();
                    else
                    {
                        db.Entry(provtabla).State = System.Data.Entity.EntityState.Modified;
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
