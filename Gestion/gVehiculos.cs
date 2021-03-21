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
namespace CheckEngineTaller.Cruds
{
    public partial class gVehiculos : Form
    {
        public int? id;
        Vehiculo vitabla = null;
        public gVehiculos(int? id= null)
        {
            InitializeComponent();
            this.txtCodigoClienteVehiculo.KeyPress +=new KeyPressEventHandler(Utileria.NumerosEnteros);
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
                vitabla = db.Vehiculo.Find(id);
                txtCodigoClienteVehiculo.Text = vitabla.ClienteID.ToString();
                cbbColorVehiculo.SelectedItem = vitabla.VehiculoColor;
                cbbMarcaVehiculo.SelectedItem = vitabla.VehiculoMarca;
                txtModeloVehiculo.Text = vitabla.VehiculoModelo;
                txtPlacaVehiculo.Text = vitabla.VehiculoPlaca;
                rbtRevision.Checked = bool.Parse(vitabla.VehiculoEstado);
            }
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
                    vitabla.VehiculoEstado = rbtRevision.Text;

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
