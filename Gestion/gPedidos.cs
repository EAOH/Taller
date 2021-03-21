using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckEngineTaller.Modelo;
using CheckEngineTaller.Servicios;

namespace CheckEngineTaller.Gestion
{
    public partial class gPedidos : Form
    {
        public int? id;
        Pedido petabla = null;
        public gPedidos(int?id=null)
        {
            InitializeComponent();
            this.txtCodigoProductoPedido.KeyPress += new KeyPressEventHandler(Utileria.NumerosEnteros);
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
                petabla = db.Pedido.Find(id);
                txtCodigoProductoPedido.Text = petabla.ProductoId.ToString();
                txtDescripcionPedido.Text = petabla.PedidoDescripcion;
                nudCantidadPedido.Value = petabla.PedidoCantidad;
                nudPrecioUnitarioPedido.Value = petabla.PedidoPrecioUnitario;

            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardadPedido_Click(object sender, EventArgs e)
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
                        petabla = new Pedido();

                    petabla.ProductoId = Int32.Parse(txtCodigoProductoPedido.Text);
                    petabla.PedidoDescripcion = txtDescripcionPedido.Text;
                    petabla.PedidoCantidad = (int)nudCantidadPedido.Value;
                    petabla.PedidoPrecioUnitario = (decimal)nudPrecioUnitarioPedido.Value;

                    if (id == null)
                        petabla = new Pedido();
                    else
                    {
                        db.Entry(petabla).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
            
        }
    }
}
