using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Permissions;
using CheckEngineTaller.formularios;
using CheckEngineTaller.Gestion;
//using CheckEngineTaller.model;
using CheckEngineTaller.Servicios;
using System.Net.Mail;
using System.Net;

namespace CheckEngineTaller
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            button1.Visible = false;
        }
        SqlConnection connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DBTallerF;Integrated Security=True");
        public void log(string Usuario, string Password)
        {
            try
            {
                connect.Open();
                SqlCommand comm = new SqlCommand("Select UsuarioUsuario,UsuarioRolId from Usuario where UsuarioUsuario = @usuario and UsuarioPassword = @contra", connect);
                comm.Parameters.AddWithValue("usuario", Usuario);
                comm.Parameters.AddWithValue("contra", Password);
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Utileria.Usuario = dt.Rows[0][0].ToString();
                    Utileria.Tipo = Int32.Parse(dt.Rows[0][1].ToString());
                    var principal = new principal(dt.Rows[0][0].ToString());
                    principal.Show();                 
                }
                else
                {
                    MessageBox.Show("Usuario o Password erroneo");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);                
            }
            finally
            {
                connect.Close();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log(this.txtUsuario.Text, this.txtPassword.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utileria.Llenar();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(((Int32)Keys.Enter)))
                txtPassword.Focus();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            gPassword gPassword = new gPassword();
            gPassword.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*gPassword gPassword = new gPassword();
            gPassword.Show();*/
            bool response = Utileria.RecoveryPassword(txtUsuario.Text);
            if (response)
            {
                MessageBox.Show("Se envio un correo con su solicitud","AVISO");
                return;
            }
            MessageBox.Show("Ha ocurrido un problema","ERROR");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
{

        /*string EMAILSENDER = "checktaller1@gmail.com";//
        string PASSWORDSENDER = "TestTaller1";*/
        
            //return true;

        }
    }
}
