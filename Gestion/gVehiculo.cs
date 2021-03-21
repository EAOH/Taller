using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CheckEngineTaller.Modelo;
using CheckEngineTaller.Servicios;
namespace CheckEngineTaller.Gestion
{
    public partial class gVehiculo : Form
    {
        public int? id;
        Vehiculo vitabla = null;
        public gVehiculo(int? id=null)
        {
            InitializeComponent();
            this.txtCodigoClienteVehiculo.KeyPress +=new KeyPressEventHandler(Utileria.NumerosEnteros);
            cbbColorVehiculo.Items.Add("Negro");
            cbbMarcaVehiculo.Items.Add("Honda");
            this.id = id;
            if (id != null)
            {
                CargarDatos();
            }
        }
        private void CargarDatos()
        {
            using (DBTallerFEntities db = new DBTallerFEntities())
            {
                vitabla = db.Vehiculo.Find(id);
                txtCodigoClienteVehiculo.Text = vitabla.ClienteID.ToString();
                cbbColorVehiculo.SelectedItem = vitabla.VehiculoColor;
                cbbMarcaVehiculo.SelectedItem = vitabla.VehiculoMarca;
                txtModeloVehiculo.Text = vitabla.VehiculoModelo;
                txtPlacaVehiculo.Text = vitabla.VehiculoPlaca;
                chkEstadoVehiculo.Text = vitabla.VehiculoEstado;
                //rbtRevision.Checked = bool.Parse( vitabla.VehiculoEstado);
            }
        }
        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarVehiculo_Click(object sender, EventArgs e)
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
                        vitabla = new Vehiculo();
                    vitabla.ClienteID = Int32.Parse(txtCodigoClienteVehiculo.Text);
                    vitabla.VehiculoColor = (string)cbbColorVehiculo.SelectedItem;
                    vitabla.VehiculoMarca = (string)cbbMarcaVehiculo.SelectedItem;
                    vitabla.VehiculoModelo = txtModeloVehiculo.Text;
                    vitabla.VehiculoPlaca = txtPlacaVehiculo.Text;
                    vitabla.VehiculoEstado = chkEstadoVehiculo.Text;
                   // vitabla.VehiculoEstado = rbtRevision.Text;

                    if (id == null)
                        db.Vehiculo.Add(vitabla);
                    else
                    {
                        db.Entry(vitabla).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
            
        }
    }
}
