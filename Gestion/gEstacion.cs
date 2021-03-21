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
    public partial class gEstacion : Form
    {
        public int? id;
        Estacion establa = null;
        public gEstacion(int? id=null)
        {
            InitializeComponent();
            this.txtCodigoActividadEstacion.KeyPress += new KeyPressEventHandler(Utileria.NumerosEnteros);
            this.id = id;
            if (id!=null)
            {
                CargarDatos();
            }
        }
        private void CargarDatos()
        {
            using (DBTallerFEntities db=new DBTallerFEntities())
            {
                establa = db.Estacion.Find(id);
                txtNombreEstacion.Text = establa.EstacionNombre;
                txtCodigoActividadEstacion.Text = establa.ActividadId.ToString();
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarEstacion_Click(object sender, EventArgs e)
        {
            string Faltantes;
            if ((Faltantes = Utileria.Requeridos(this.splitContainer1.Panel2)) != "")
            {
                MessageBox.Show("Se necesita el llenado de los campos:" + Faltantes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (DBTallerFEntities db = new DBTallerFEntities())
                {
                    if (id == null)
                        establa = new Estacion();


                    establa.EstacionNombre = txtNombreEstacion.Text;
                    establa.ActividadId = Int32.Parse(txtCodigoActividadEstacion.Text);

                    if (id == null)
                        establa = new Estacion();
                    else
                    {
                        db.Entry(establa).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
            
        }
    }
}
