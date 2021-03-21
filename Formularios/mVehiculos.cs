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
    public partial class mVehiculos : Form
    {
        public ServiciosVehiculos ServiciosVehiculos = new ServiciosVehiculos();
        public mVehiculos()
        {
            InitializeComponent();
        }
        private void mVehiculos_Load_1(object sender, EventArgs e)
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

            //limitar

            //throw new NotImplementedException();
        }
        private void CargarInterfazAtencionAlCliente()//caso 1
        {
            //ver
            btnAgregarVehiculo.Visible = true;
            btnEditarVehiculo.Visible = true;
            button1.Visible = true;
            //limitar
            
            //throw new NotImplementedException();
        }
        private void CargarInterfazCajero()//caso 2
        {
            // ver

            // limitar
            
            //throw new NotImplementedException();
        }

        private void CargarInterfazMecanico()//caso 3
        {
            //ver
            button1.Visible = true;
            //limitar
            btnAgregarVehiculo.Visible = false;
            btnEditarVehiculo.Visible = false;   
            //throw new NotImplementedException();
        }

        private void CargarInterfazRRHH()//caso 4
        {
            //ver

            //limitar
            btnAgregarVehiculo.Visible = false;
            btnEditarVehiculo.Visible = false;
            button1.Visible = false;
            //throw new NotImplementedException();
        }
        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region helper
        private void refrescar()
        {
            try
            {
                var vehiculo = ServiciosVehiculos.getVehiculo();
                dataGridView1.DataSource = vehiculo;
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

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            Gestion.gVehiculo gVehiculo = new Gestion.gVehiculo();
            gVehiculo.ShowDialog();
            
        }

        private void btnEditarVehiculo_Click(object sender, EventArgs e)
        {
            int? id = getid();
            if (id != null)
            {
                Gestion.gVehiculo gVehiculo = new Gestion.gVehiculo(id);
                gVehiculo.ShowDialog();
                
                refrescar();
            }

        }
    }
}
