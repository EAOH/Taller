using CheckEngineTaller.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckEngineTaller.Formularios;

namespace CheckEngineTaller.Gestion
{
    public partial class gFactura : Form
    {
        public gFactura()
        {
            InitializeComponent();
            
            

        }



        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbbServicio_DropDown(object sender, EventArgs e)
        {
                // TODO: esta línea de código carga datos en la tabla 'dS.SoloServicios' Puede moverla o quitarla según sea necesario.
                this.soloServiciosTableAdapter.Fill(this.dS.SoloServicios);
                btnAgregarServicio.Enabled = true;
            
        }

        private void cbbProducto_DropDown(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS.SoloProductos' Puede moverla o quitarla según sea necesario.
            this.soloProductosTableAdapter.Fill(this.dS.SoloProductos);
                button1.Enabled = true;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (nudProductoCantidad.Value < int.Parse(productoExistenciaLabel1.Text))
            {
                this.ListaDetalle.Rows.Add(productoIdTextBox.Text, cbbProducto.Text, string.Format("{0}", nudProductoCantidad.Value), string.Format("{0}", double.Parse(productoPrecioUnitarioTextBox.Text) - double.Parse(productoDescuentoLabel1.Text)).ToString(), string.Format("{0}", (double.Parse(productoPrecioUnitarioTextBox.Text) - double.Parse(productoDescuentoLabel1.Text)) * double.Parse(string.Format("{0}", nudProductoCantidad.Value))).ToString(), productoExistenciaLabel1.Text, productoExistenciaMinLabel1.Text);
            }
            else { MessageBox.Show("Lo sentimos pero no hay suficiente producto", "Falta de inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            this.ListaDetalle.Rows.Add(productoIdTextBox1.Text, cbbServicio.Text, string.Format("{0}", qtyServicio.Value), string.Format("{0}", double.Parse(productoPrecioUnitarioTextBox1.Text) - double.Parse(productoDescuentoLabel2.Text)).ToString(), string.Format("{0}", (double.Parse(productoPrecioUnitarioTextBox1.Text) - double.Parse(productoDescuentoLabel2.Text)) * double.Parse(string.Format("{0}", qtyServicio.Value))).ToString(),"0","-1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.ListaDetalle.Rows.Count > 0)
            {
                Utileria.Llenar();
                foreach (DataGridViewRow Fila in ListaDetalle.Rows)
                {
                    Utileria.Listado.Rows.Add(Fila.Cells[0].Value, Fila.Cells[1].Value, Fila.Cells[2].Value, Fila.Cells[3].Value, Fila.Cells[4].Value, Fila.Cells[5].Value, Fila.Cells[6].Value);
                }
                mFactura Formulario = new mFactura(1);
                Formulario.Show();
                this.Visible = false;
            } else { MessageBox.Show("No se puede generar una factura vacia", "Agregar productos o servicios", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
