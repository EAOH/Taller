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
    public partial class mClientes : Form
    {
        public ServiciosCliente ServiciosClientes = new ServiciosCliente();
        public int x1;
        public mClientes(int x)
        {
            InitializeComponent();
            
            if (x == 1)
            {
                button2.Visible = button3.Visible = button4.Visible = false;
                button5.Visible = true;
                x1 = x;
            }
        }
        private void mClientes_Load(object sender, EventArgs e)
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
            button2.Visible = true;
            button3.Visible = true;
            button1.Visible = true;
            button4.Visible = false;
            //limitar

            //throw new NotImplementedException();
        }
        private void CargarInterfazCajero()//caso 2
        {
            if (x1 == 1)
            {
                button2.Visible = false;
                button3.Visible = false;
                button1.Visible = true;
                button4.Visible = false;
            }
            else
            {
                button2.Visible = true;
                button3.Visible = true;
                button1.Visible = true;
                button4.Visible = false;
            }
            // ver
            
            // limitar
            


            //throw new NotImplementedException();
        }

        private void CargarInterfazMecanico()//caso 3
        {
            //ver

            //limitar
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
            //throw new NotImplementedException();
        }

        private void CargarInterfazRRHH()//caso 4
        {
            //ver
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
            //limitar

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
                var clientes = ServiciosClientes.getClientes();
                dataGridView1.DataSource = clientes;
                pictureBox1.Visible = false;
                txtBuscarClientes.Text = "";

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
            Gestion.gcliente gcliente = new Gestion.gcliente();
            gcliente.ShowDialog();

            refrescar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //editar
            
            if(dataGridView1.SelectedRows.Count>0 )
            {
                int id = 0;
                if (pictureBox1.Visible == false)
                {
                    id = int.Parse(string.Format("{0}", dataGridView1.SelectedRows[0].Cells[0].Value));
                }
                else { 
                    id = int.Parse(string.Format("{0}", dataGridView1.SelectedRows[0].Cells[7].Value));
                }

                Gestion.gcliente gcliente = new Gestion.gcliente(id);
                gcliente.ShowDialog();
                
                refrescar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //eliminar
            int? id = getid();
            if (id == null)
            {
                DisplayErrorSelect();
                return;
            }
            var respuesta = ServiciosClientes.EliminarCliente(id);

            if (respuesta==false)
            {
                DisplayError();
                return;
            }
            refrescar();
        }
        private void DisplayErrorSelect()
        {
            MessageBox.Show("Seleccione un Cliente.");
        }

        private void DisplayError()
        {
            MessageBox.Show("Ha ocurrido un error.");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBuscarClientes.Text != "")
            {
                // TODO: esta línea de código carga datos en la tabla 'dS.Cliente' Puede moverla o quitarla según sea necesario.
                this.clienteTableAdapter.FillBy(this.dS.Cliente,txtBuscarClientes.Text);
                dataGridView1.DataSource = clienteBindingSource;
                pictureBox1.Visible = true;
            }else { refrescar(); }
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (pictureBox1.Visible == false) { 
                Utileria.Codigo = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[0].Value);
                Utileria.Nombre = string.Format("{0} {1}", dataGridView1.SelectedRows[0].Cells[1].Value, dataGridView1.SelectedRows[0].Cells[3].Value);
                Utileria.Identidad = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[5].Value);
                }
                else
                {
                    Utileria.Codigo = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[7].Value);
                    Utileria.Nombre = string.Format("{0} {1}", dataGridView1.SelectedRows[0].Cells[2].Value, dataGridView1.SelectedRows[0].Cells[4].Value);
                    Utileria.Identidad = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[1].Value);
                }
                this.Close();
            }
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}
