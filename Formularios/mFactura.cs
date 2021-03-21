using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckEngineTaller.Gestion;
using CheckEngineTaller.Servicios;
using CheckEngineTaller.Formularios ;


namespace CheckEngineTaller.Formularios
{
    public partial class mFactura : Form
    {
        public mFactura(int X)
        {
            InitializeComponent();
            Tap_Factura.SelectedIndex = 1;
            if (X == 1)
            {
                regresarToolStripMenuItem.Text = "Regresar";
                Tap_Factura.SelectedIndex = 0;
                ListaDetalle.DataSource = Utileria.Listado;
                Btn_Crear.Visible = true;
                Btn_Cliente.Visible = true;
                Txt_Descuento.Enabled = true;
                Date_Fecha.Enabled = true;
                Txt_Subtotal.Text = String.Format("{0}", ListaDetalle.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[4].Value)));
                Txt_Impuesto.Text = string.Format("{0}", double.Parse(Txt_Subtotal.Text) * 0.15);
                Txt_Impuesto.Text = string.Format("{0}",Math.Round(double.Parse(Txt_Impuesto.Text), 2));
                Txt_Total.Text = string.Format("{0}", double.Parse(Txt_Subtotal.Text) + double.Parse(Txt_Impuesto.Text) - double.Parse(Txt_Descuento.Text));
                
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (regresarToolStripMenuItem.Text == "Regresar")
            {
                var Formulario = Application.OpenForms.OfType<gFactura>().FirstOrDefault();
                Formulario.Show();
            }
            this.Close();
        }

        private void mFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.FillBy(this.dS.Factura);
            Date_Fecha.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void Btn_Cliente_Click(object sender, EventArgs e)
        {
            mClientes Formulario = new mClientes(1);
            Formulario.ShowDialog();
            Txt_Cliente.Text = Utileria.Codigo;
            Txt_Identidad.Text = Utileria.Identidad;
            Txt_Nombre.Text = Utileria.Nombre;
        }

        private void Txt_Descuento_Leave(object sender, EventArgs e)
        {
            if(Txt_Descuento.Text.Equals("")){
                Txt_Descuento.Text = "0.00";
            }
            if (Txt_Descuento.Text == "%")
            {
                Txt_Descuento.Text = "0%";
            }
            if (Txt_Descuento.Text[0] == '.')
            {
                Txt_Descuento.Text = "0" + Txt_Descuento.Text;
            }
            if (Txt_Descuento.Text[Txt_Descuento.Text.Length - 1] == '%' && Txt_Descuento.Text[Txt_Descuento.Text.Length - 2] == '.')
            {
                Txt_Descuento.Text = Txt_Descuento.Text.Remove(Txt_Descuento.Text.Length - 1, 1) + "00%";
            }
            if (Txt_Descuento.Text[Txt_Descuento.Text.Length - 1] == '%')
            {
                Txt_Descuento.Text = Txt_Descuento.Text.Remove(Txt_Descuento.Text.Length - 1, 1);
                Txt_Descuento.Text = string.Format("{0}", double.Parse(Txt_Subtotal.Text) * (double.Parse(Txt_Descuento.Text) / 100));
                
            }
            Txt_Descuento.Text = string.Format("{0}", Math.Round(double.Parse(Txt_Descuento.Text), 2));
            Txt_Total.Text = string.Format("{0}", double.Parse(Txt_Subtotal.Text) + double.Parse(Txt_Impuesto.Text) - double.Parse(Txt_Descuento.Text));
        }

        private void Txt_Descuento_KeyPress(object sender, KeyPressEventArgs Caracter)
        {
            if ((Char.IsDigit(Caracter.KeyChar)) || (Char.IsControl(Caracter.KeyChar)) || (Caracter.KeyChar == 46) || (Caracter.KeyChar == '%'))
            {
                Caracter.Handled = false;
            }
            else
            {
                Caracter.Handled = true;
                MessageBox.Show("Lo que esta tratando de ingresar no es acorde al dato solicitado", "Solo numeros caracteres decimales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (((Control)sender).Text.Length > 0 && (Caracter.KeyChar == 46 || Caracter.KeyChar == '%'))
            {
                for (int i = 0; i < ((Control)sender).Text.Length - 1; i++)
                {
                    if (((Control)sender).Text.ElementAt(i) == Caracter.KeyChar)
                    {
                        Caracter.Handled = true;
                        MessageBox.Show("No puede ingresar 2 puntos decimal o 2 porcentajes en este campo", "Solo un punto o un porcentaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (((Control)sender).Text.Length > 0) { 
            if (Txt_Descuento.Text[Txt_Descuento.Text.Length - 1] == '%' && !char.IsControl(Caracter.KeyChar))
            {
                Caracter.Handled = true;
                MessageBox.Show("No se puede ingresar ningun valor despues del simbolo porcentual", "Porcentaje al final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            if (this.Txt_Cliente.Text.Length!=0 && Btn_Crear.Text=="Crear")
            {
                facturaTableAdapter.I_Factura(Convert.ToDecimal(Txt_Impuesto.Text), Convert.ToDecimal(Txt_Total.Text), Date_Fecha.Value, Convert.ToDecimal(Txt_Descuento.Text), Convert.ToDecimal(Txt_Subtotal.Text), int.Parse(Txt_Cliente.Text));
                this.facturaTableAdapter.FillBy(this.dS.Factura);
                txt_Factura.Text = string.Format("{0}",dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value);
                foreach (DataGridViewRow Fila in ListaDetalle.Rows)
                {
                    facturaDetalleTableAdapter.I_Detalle(Convert.ToInt32 (Fila.Cells[0].Value), Convert.ToInt32(Fila.Cells[2].Value), Convert.ToInt32(txt_Factura.Text), Convert.ToDecimal(Fila.Cells[4].Value));
                }
                Tap_Factura.SelectedIndex = 2;
                facturaDetalleTableAdapter.FillBy(this.dS.FacturaDetalle, int.Parse(txt_Factura.Text));
                regresarToolStripMenuItem.Text = "Cerrar ventana";
                Btn_Crear.Text = "Volver";
                Txt_Descuento.Enabled = false;
                Btn_Cliente.Visible = false;
                Date_Fecha.Enabled = false;
				var Formulario = Application.OpenForms.OfType<gFactura>().FirstOrDefault();
                Formulario.Close();
            }
            else if (Btn_Crear.Text == "Volver")
            {
                Date_Fecha.Value = DateTime.Now;
                txt_Factura.Text =Txt_Cliente.Text=Txt_Nombre.Text=Txt_Identidad.Text= "";
                Txt_Subtotal.Text = Txt_Impuesto.Text = Txt_Descuento.Text = Txt_Total.Text = "0.00";
                Tap_Factura.SelectedIndex = 1;
                Btn_Crear.Visible = false;
            }
            else { MessageBox.Show("Indique a nombre de quien esta la factura", "Falta nombre", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Crear.Text = "Volver";
            Btn_Crear.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
               txt_Factura.Text= string.Format("{0}",dataGridView1.SelectedRows[0].Cells[0].Value);
                Date_Fecha.Value = Convert.ToDateTime( dataGridView1.SelectedRows[0].Cells[1].Value);
                Txt_Cliente.Text = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[2].Value);
                Txt_Nombre.Text = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[3].Value);
                Txt_Identidad.Text = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[4].Value);
                Txt_Subtotal.Text= string.Format("{0}", dataGridView1.SelectedRows[0].Cells[5].Value);
                Txt_Impuesto.Text = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[6].Value);
                Txt_Descuento.Text = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[7].Value);
                Txt_Total.Text = string.Format("{0}", dataGridView1.SelectedRows[0].Cells[8].Value);
            }
            Tap_Factura.SelectedIndex = 2;
            facturaDetalleTableAdapter.FillBy(this.dS.FacturaDetalle, int.Parse(txt_Factura.Text));
            
        }

        private void mFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (regresarToolStripMenuItem.Text == "Regresar")
            {
                var Formulario = Application.OpenForms.OfType<gFactura>().FirstOrDefault();
                Formulario.Close();
            }
        }
    }
}
