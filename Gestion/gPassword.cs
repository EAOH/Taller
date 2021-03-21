using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckEngineTaller.Servicios;

namespace CheckEngineTaller.Gestion
{
    public partial class gPassword : Form
    {
        public gPassword()
        {
            InitializeComponent();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Faltantes;
            if ((Faltantes = Utileria.Requeridos(this.splitContainer1.Panel2)) != "")
            {
                MessageBox.Show("Se necesitan el llenado de todos los datos:" + Faltantes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //aqui implementa todo el codigo
            }
        }
    }
}
