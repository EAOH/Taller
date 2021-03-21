using CheckEngineTaller.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckEngineTaller.Formularios
{
    public partial class mBitacora : Form
    {
        public mBitacora()
        {
            InitializeComponent();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mBitacora_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS.Bitacora' Puede moverla o quitarla según sea necesario.
            this.bitacoraTableAdapter.Fill(this.dS.Bitacora);
            refrescar();
        }

        private void refrescar()
        {
            using (DBTallerFEntities db = new DBTallerFEntities())
            {
                /*var bitacora = db.Bitacora.Include("Bitacora")
                    .ToList();
                var Detalle = bitacora.Select(t => new { 
                    BitacoraFormulario = t.BitacoraFormulario, 
                    BitacoraFuncion = t.BitacoraFuncion, 
                    BitacoraLlave = t.BitacoraLlave
                    }).ToList();
                */
                //dataGridView1.DataSource = Detalle;

            }
        }

    }
}
