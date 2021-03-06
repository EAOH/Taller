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
    public partial class mEstacion : Form
    {
        public ServiciosEstacion ServiciosEstacion = new ServiciosEstacion();
        public mEstacion()
        {
            InitializeComponent();
        }
        private void mEstacion_Load(object sender, EventArgs e)
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
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            //limitar

            //throw new NotImplementedException();
        }
        private void CargarInterfazAtencionAlCliente()//caso 1
        {
            //ver
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            //limitar

            //throw new NotImplementedException();
        }
        private void CargarInterfazCajero()//caso 2
        {
            // ver

            // limitar
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            //throw new NotImplementedException();
        }

        private void CargarInterfazMecanico()//caso 3
        {
            //ver

            //limitar
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            //throw new NotImplementedException();
        }

        private void CargarInterfazRRHH()//caso 4
        {
            //ver

            //limitar
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
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
                var clientes = ServiciosEstacion.getEstacion();
                dataGridView1.DataSource = clientes;

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

        private void button2_Click(object sender, EventArgs e)
        {
            //agregar
            Gestion.gEstacion gEstacion = new Gestion.gEstacion();
            gEstacion.ShowDialog();

            refrescar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //editar
            int? id = getid();
            if (id!=null)
            {
                Gestion.gEstacion gEstacion = new Gestion.gEstacion(id);
                gEstacion.ShowDialog();

                refrescar();
            }
        }

       
    }
}
