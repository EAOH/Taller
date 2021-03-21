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
    public partial class mUsuario : Form
    {
        public ServiciosUsuario servicios = new ServiciosUsuario();
        public mUsuario()
        {
            InitializeComponent();
        }
        private void mUsuario_Load(object sender, EventArgs e)
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

            //limitar
            btnAgregarUsuario.Visible = false;
            btnEditarUsuario.Visible = false;
            btnBuscarUsuario.Visible = false;
            //throw new NotImplementedException();
        }
        private void CargarInterfazCajero()//caso 2
        {
            // ver

            // limitar
            btnAgregarUsuario.Visible = false;
            btnEditarUsuario.Visible = false;
            btnBuscarUsuario.Visible = false;


            //throw new NotImplementedException();
        }

        private void CargarInterfazMecanico()//caso 3
        {
            //ver

            //limitar
            btnAgregarUsuario.Visible = false;
            btnEditarUsuario.Visible = false;
            btnBuscarUsuario.Visible = false;
            //throw new NotImplementedException();
        }

        private void CargarInterfazRRHH()//caso 4
        {
            //ver
            btnAgregarUsuario.Visible = true;
            btnEditarUsuario.Visible = true;
            btnBuscarUsuario.Visible = true;
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
                var usuario = servicios.getUsuario();
                dataGridView1.DataSource = usuario;
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
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Gestion.gUsuario gUsuario = new Gestion.gUsuario();
            gUsuario.ShowDialog();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            int? id = getid();
            if (id!=null)
            {
                Gestion.gUsuario gUsuario = new Gestion.gUsuario(id);
                gUsuario.ShowDialog();

                refrescar();
            }
        }
    }
}
