using CheckEngineTaller.Formularios;
using CheckEngineTaller.Gestion;
using CheckEngineTaller.Reportes;
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


namespace CheckEngineTaller.formularios
{
    public partial class principal : Form
    {
        public principal(string nombre)
        {
            InitializeComponent();
            lblidentificador.Text = nombre;
        }

        private void principal_Load(object sender, EventArgs e)
        {
            PrepararInterfazRoles(Servicios.Utileria.Tipo);//obtener valor desde utileria utileria.getroll
            
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //reportes
            //MessageBox.Show("Aun no Se Han Generado Reportes.");
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = Application.OpenForms.OfType<mClientes>().FirstOrDefault();//Evita que los formularios se habran mas de una vez buscando si el formulario existe

            mClientes Entrada = Formulario ?? new mClientes(0); //Condicion de validacion del formulario
            //?? Condicion SI Si Form es nulo quiere decir que jamas de ha creado la instancia por lo cual toma valor formulario de lo contrario hace referencia a Form
            //? Si simplificado (Condicion)? True :False
            Abrir(Entrada);

        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = Application.OpenForms.OfType<mVehiculos>().FirstOrDefault();//Evita que los formularios se habran mas de una vez buscando si el formulario existe

            mVehiculos Entrada = Formulario ?? new mVehiculos(); //Condicion de validacion del formulario
            //?? Condicion SI Si Form es nulo quiere decir que jamas de ha creado la instancia por lo cual toma valor formulario de lo contrario hace referencia a Form
            //? Si simplificado (Condicion)? True :False
            Abrir(Entrada);
           
        }

        private void proyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void estacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = Application.OpenForms.OfType<mEstacion>().FirstOrDefault();//Evita que los formularios se habran mas de una vez buscando si el formulario existe

            mEstacion Entrada = Formulario ?? new mEstacion(); //Condicion de validacion del formulario
            //?? Condicion SI Si Form es nulo quiere decir que jamas de ha creado la instancia por lo cual toma valor formulario de lo contrario hace referencia a Form
            //? Si simplificado (Condicion)? True :False
            Abrir(Entrada);
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = Application.OpenForms.OfType<mProveedor>().FirstOrDefault();//Evita que los formularios se habran mas de una vez buscando si el formulario existe

            mProveedor Entrada = Formulario ?? new mProveedor(); //Condicion de validacion del formulario
            //?? Condicion SI Si Form es nulo quiere decir que jamas de ha creado la instancia por lo cual toma valor formulario de lo contrario hace referencia a Form
            //? Si simplificado (Condicion)? True :False
            Abrir(Entrada);
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = Application.OpenForms.OfType<mProductos>().FirstOrDefault();//Evita que los formularios se habran mas de una vez buscando si el formulario existe

            mProductos Entrada = Formulario ?? new mProductos(); //Condicion de validacion del formulario
            //?? Condicion SI Si Form es nulo quiere decir que jamas de ha creado la instancia por lo cual toma valor formulario de lo contrario hace referencia a Form
            //? Si simplificado (Condicion)? True :False
            Abrir(Entrada);

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = Application.OpenForms.OfType<mPedidos>().FirstOrDefault();//Evita que los formularios se habran mas de una vez buscando si el formulario existe

            mPedidos Entrada = Formulario ?? new mPedidos(); //Condicion de validacion del formulario
            //?? Condicion SI Si Form es nulo quiere decir que jamas de ha creado la instancia por lo cual toma valor formulario de lo contrario hace referencia a Form
            //? Si simplificado (Condicion)? True :False
            Abrir(Entrada);
        }

        

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = Application.OpenForms.OfType<mUsuario>().FirstOrDefault();//Evita que los formularios se habran mas de una vez buscando si el formulario existe

            mUsuario Entrada = Formulario ?? new mUsuario(); //Condicion de validacion del formulario
            //?? Condicion SI Si Form es nulo quiere decir que jamas de ha creado la instancia por lo cual toma valor formulario de lo contrario hace referencia a Form
            //? Si simplificado (Condicion)? True :False
            Abrir(Entrada);
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = Application.OpenForms.OfType<mBitacora>().FirstOrDefault();//Evita que los formularios se habran mas de una vez buscando si el formulario existe

            mBitacora Entrada = Formulario ?? new mBitacora(); //Condicion de validacion del formulario
            //?? Condicion SI Si Form es nulo quiere decir que jamas de ha creado la instancia por lo cual toma valor formulario de lo contrario hace referencia a Form
            //? Si simplificado (Condicion)? True :False
            Abrir(Entrada);
        }

        private void Abrir(Form Formulario)
        {
            Formulario.TopLevel = false;
            this.panel1.Controls.Add(Formulario);
            Formulario.Show();
            Formulario.BringToFront();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = Application.OpenForms.OfType<gFactura>().FirstOrDefault();//Evita que los formularios se habran mas de una vez buscando si el formulario existe

            gFactura Entrada = Formulario ?? new gFactura(); //Condicion de validacion del formulario
            //?? Condicion SI Si Form es nulo quiere decir que jamas de ha creado la instancia por lo cual toma valor formulario de lo contrario hace referencia a Form
            //? Si simplificado (Condicion)? True :False
            Abrir(Entrada);
        }

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Formulario = Application.OpenForms.OfType<mFactura>().FirstOrDefault();//Evita que los formularios se habran mas de una vez buscando si el formulario existe

            mFactura Entrada = Formulario ?? new mFactura(0); //Condicion de validacion del formulario
            //?? Condicion SI Si Form es nulo quiere decir que jamas de ha creado la instancia por lo cual toma valor formulario de lo contrario hace referencia a Form
            //? Si simplificado (Condicion)? True :False
            Abrir(Entrada);
        }

        private void PrepararInterfazRoles(int RolId)
        {
            switch (RolId)
            {
                case 0: CargarInterfazAdministrador();
                    break;
                case 1: CargarInterfazAtencionAlCliente();
                    break;
                case 2:CargarInterfazCajero();
                    break;
                case 3: CargarInterfazMecanico();
                    break;
                case 4: CargarInterfazRRHH();
                    break;
                
                default:MessageBox.Show("Roll no encontrado.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    break;
            }
        }
        private void CargarInterfazAdministrador()//caso 0 Admin/gerente
        {
            //ver todo, limitar nada.
            //throw new NotImplementedException();
        }
        private void CargarInterfazAtencionAlCliente()//caso 1 Atencion al cliente
        {
            //ver
            clienteToolStripMenuItem.Visible = true;
            vehiculoToolStripMenuItem.Visible = true;
            facturaToolStripMenuItem.Visible = true;

            //limitar
            usuarioToolStripMenuItem.Visible = false;
            bitacoraToolStripMenuItem.Visible = false;
            crearToolStripMenuItem.Visible = false;
            ReportesToolStripMenuItem1.Visible = false;

            //throw new NotImplementedException();
        }
        private void CargarInterfazCajero()//caso 2 Cajero
        {
            // ver
            facturaToolStripMenuItem.Visible = true;
            crearToolStripMenuItem.Visible = true;
            verToolStripMenuItem.Visible = true;
            clienteToolStripMenuItem.Visible = true;
            //limitar
            vehiculoToolStripMenuItem.Visible = false;  
            usuarioToolStripMenuItem.Visible = false;
            productosToolStripMenuItem.Visible = false;
            proveedorToolStripMenuItem.Visible = false;
            estacionToolStripMenuItem.Visible = false;
            pedidosToolStripMenuItem.Visible = false;
            bitacoraToolStripMenuItem.Visible = false;
            ReportesToolStripMenuItem1.Visible = false;
            //throw new NotImplementedException();
        }

        private void CargarInterfazMecanico()//caso 3 Mecanico
        {
            // ver
            vehiculoToolStripMenuItem.Visible = true;
            //limitar
            clienteToolStripMenuItem.Visible = false;
            usuarioToolStripMenuItem.Visible = false;
            facturaToolStripMenuItem.Visible = false;
            crearToolStripMenuItem.Visible = false;
            verToolStripMenuItem1.Visible = false;
            productosToolStripMenuItem.Visible = false;
            proveedorToolStripMenuItem.Visible = false;
            productosToolStripMenuItem.Visible = false;
            pedidosToolStripMenuItem.Visible = false;
            bitacoraToolStripMenuItem.Visible = false;
            ReportesToolStripMenuItem1.Visible = false;

            //throw new NotImplementedException();
        }

        private void CargarInterfazRRHH()//caso 4 Recursos Humanos
        {
            //visible
            usuarioToolStripMenuItem.Visible = true;
            // no accesible
            ReportesToolStripMenuItem1.Visible = false;
            clienteToolStripMenuItem.Visible = false;
            vehiculoToolStripMenuItem.Visible = false;
            pedidosToolStripMenuItem.Visible = false;
            proveedorToolStripMenuItem.Visible = false;
            bitacoraToolStripMenuItem.Visible = false;
            estacionToolStripMenuItem.Visible = false;
            facturaToolStripMenuItem.Visible = false;
            productosToolStripMenuItem.Visible = false;
        }

        private void reporteFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = Application.OpenForms.OfType<RFactura>().FirstOrDefault();
            RFactura Entrada = Formulario ?? new RFactura();
        }
    }
}
