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
    public partial class gProductos : Form
    {
        public int? id;
        Producto protabla = null;
        public gProductos(int? id=null)
        {
            InitializeComponent();
            this.txtCodigoProveedorProducto.KeyPress += new KeyPressEventHandler(Utileria.NumerosEnteros);

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
                protabla = db.Producto.Find(id);
                txtCodigoProveedorProducto.Text = protabla.ProveedorId.ToString();
                txtNombreProducto.Text = protabla.ProductoNombre;
                txtMarcaProducto.Text = protabla.ProductoMarca;
                nudExistenciaProducto.Value = protabla.ProductoExistencia;
                nudPrecioUnitarioProducto.Value = protabla.ProductoPrecioUnitario;
                nudExistenciaMinimaProducto.Value = protabla.ProductoExistenciaMin;
                nudDescuentoProducto.Value = protabla.ProductoDescuento;
                txtDescripcionProducto.Text = protabla.ProductoDescripcion;
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            string Faltantes;
            if ((Faltantes = Utileria.Requeridos(this.splitContainer1.Panel2)) != "")
            {
                MessageBox.Show("Se necesitan el llenado de todos los datos:" + Faltantes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //guardar
                using (DBTallerFEntities db = new DBTallerFEntities())
                {
                    if (ComboProducto.Text == "Servicios")
                    {
                        nudExistenciaMinimaProducto.Value = -1;
                    }
                    if (id == null)
                        protabla = new Producto();

                    protabla.ProveedorId = Int32.Parse(txtCodigoProveedorProducto.Text);
                    protabla.ProductoNombre = txtNombreProducto.Text;
                    protabla.ProductoMarca = txtMarcaProducto.Text;
                    protabla.ProductoExistencia = (int)nudExistenciaProducto.Value;
                    protabla.ProductoPrecioUnitario = (decimal)nudPrecioUnitarioProducto.Value;
                    protabla.ProductoExistenciaMin = (int)nudExistenciaMinimaProducto.Value;
                    protabla.ProductoDescuento = (decimal)nudDescuentoProducto.Value;
                    protabla.ProductoDescripcion = txtDescripcionProducto.Text;
                    if (id == null)
                        db.Producto.Add(protabla);
                    else
                    {
                        db.Entry(protabla).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
           
            
        }
    }
}
