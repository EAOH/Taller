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

namespace CheckEngineTaller.Formularios
{
    public partial class mProductos : Form        
    {
        public ServiciosProductos ServiciosProducto = new ServiciosProductos();
        public mProductos()
        {
            InitializeComponent();
        }
        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mProductos_Load(object sender, EventArgs e)
        {
            refrescar();
            PrepararInterfazRoles(Servicios.Utileria.Tipo);
        }
        private void PrepararInterfazRoles(int RolId)
        {
            switch (RolId)
            {
                case 0:
                    CargarInterfazAdministrador();
                    break;
                case 1:
                    CargarInterfazAtencionAlCliente();
                    break;
                case 2:
                    CargarInterfazCajero();
                    break;
                case 3:
                    CargarInterfazMecanico();
                    break;
                case 4:
                    CargarInterfazRRHH();
                    break;

                default:
                    break;
            }
        }
        private void CargarInterfazAdministrador()// caso 0
        {
            //ver
            btnBuscarrProducto.Visible = true;
            btnAgregarProducto.Visible = true;
            btnEditarProducto.Visible = true;
            //limitar

            //throw new NotImplementedException();
        }
        private void CargarInterfazAtencionAlCliente()//caso 1
        {
            //ver
            btnBuscarrProducto.Visible = true;
            btnAgregarProducto.Visible = true;
            btnEditarProducto.Visible = true;
            //limitar

            //throw new NotImplementedException();
        }
        private void CargarInterfazCajero()//caso 2
        {
            // ver

            // limitar
            btnBuscarrProducto.Visible = false;
            btnAgregarProducto.Visible = false;
            btnEditarProducto.Visible = false;
            //throw new NotImplementedException();
        }

        private void CargarInterfazMecanico()//caso 3
        {
            //ver

            //limitar
            btnBuscarrProducto.Visible = false;
            btnAgregarProducto.Visible = false;
            btnEditarProducto.Visible = false;
            //throw new NotImplementedException();
        }

        private void CargarInterfazRRHH()//caso 4
        {
            //ver

            //limitar
            btnBuscarrProducto.Visible = false;
            btnAgregarProducto.Visible = false;
            btnEditarProducto.Visible = false;
            //throw new NotImplementedException();
        }

        #region helper
        private void refrescar()
        {
            try
            {
                var Producto = ServiciosProducto.getProducto();
                dataGridView1.DataSource = Producto;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private int? getid()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //agregar
            Gestion.gProductos gProductos = new Gestion.gProductos();
            gProductos.ShowDialog();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            //editar
            int? id = getid();
            if (id!=null)
            {
                Gestion.gProductos gProductos = new Gestion.gProductos();
                gProductos.ShowDialog();

                refrescar();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            //eliminar
            int? id = getid();
            if (id==null)
            {
                DisplayErrorSelect();
                return;
            }
            var respuesta = ServiciosProducto.EliminarProducto(id);
            if (respuesta==false)
            {
                DisplayError();
                return;
            }
            refrescar();
        }

        private void btnBuscarrProducto_Click(object sender, EventArgs e)
        {
            //buscar

        }
        private void DisplayErrorSelect()
        {
            MessageBox.Show("Seleccione un Cliente.");
        }

        private void DisplayError()
        {
            MessageBox.Show("Ha ocurrido un error.");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            refrescar();
        }
    }
}
