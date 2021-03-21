using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace CheckEngineTaller.Servicios
{
    class Utileria
    {
        public static string Usuario;//Registrar los 3 datos del usuario
        public static DataTable Listado; //Para gestionar el listado de la factura
        public static string Codigo, Nombre, Identidad;
        public static int Tipo;
       public static string Requeridos(Control Formulario)
        {
            string Validacion = "";
            foreach (Control Controles in Formulario.Controls)
            {
                if ((Controles is TextBox || Controles is ComboBox) & string.IsNullOrWhiteSpace(Controles.Text)){
                    if (Validacion != "") { Validacion += String.Format(", {0}", Controles.Tag); }
                    else { Validacion += String.Format(" {0}", Controles.Tag); }
                }
            }

            return Validacion; 
        }

        public static void SoloLetras(object sender, KeyPressEventArgs Caracter)
        {
            if (char.IsControl(Caracter.KeyChar) || char.IsLetter(Caracter.KeyChar)) { Caracter.Handled = false; }
            else
            {
                Caracter.Handled = true;
                MessageBox.Show("Lo que esta tratando de ingresar no es acorde al dato solicitado", "Solo Caracteres", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public static void NumerosEnteros(object sender, KeyPressEventArgs Caracter)
        {
            if (char.IsControl(Caracter.KeyChar) || char.IsDigit(Caracter.KeyChar)){Caracter.Handled = false;}
            else { Caracter.Handled = true;
                MessageBox.Show("Lo que esta tratando de ingresar no es acorde al dato solicitado", "Solo Caracteres numericos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            
        }

        public static void NumerosDecimales(object sender, KeyPressEventArgs Caracter)
        {
            if((Char.IsDigit(Caracter.KeyChar)) || (Char.IsControl(Caracter.KeyChar)) || (Caracter.KeyChar== 46)){ 
               Caracter.Handled = false; 
                }  else { Caracter.Handled = true;
                MessageBox.Show("Lo que esta tratando de ingresar no es acorde al dato solicitado", "Solo numeros caracteres decimales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if(((Control)sender).Text.Length>1 && Caracter.KeyChar == 46)
            {
                for (int i = 0; i <((Control)sender).Text.Length-1; i++)
                {
                    if (((Control)sender).Text.ElementAt(i) == Caracter.KeyChar)
                    {
                        Caracter.Handled = true;
                        MessageBox.Show("No puede ingresar 2 puntos decimal en este campo", "Solo un punto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public static void NumerosGuiones(object sender, KeyPressEventArgs Caracter)
        {
            if ((Char.IsDigit(Caracter.KeyChar)) || (Char.IsControl(Caracter.KeyChar))) { Caracter.Handled = false;
                if ((((Control)sender).Text.Length == 4 || ((Control)sender).Text.Length == 9) && !Char.IsControl(Caracter.KeyChar))
                {
                    ((Control)sender).Text = ((Control)sender).Text + "-";
                    ((TextBox)sender).Select(((Control)sender).Text.Length, 0);
                }
            }
            else
            {
                Caracter.Handled = true;
                MessageBox.Show("Lo que esta tratando de ingresar no es acorde al dato solicitado", "Ingrese su numero de identidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public static void NumerosTelefono(object sender, KeyPressEventArgs Caracter)
        {
            if ((Char.IsDigit(Caracter.KeyChar)) || (Char.IsControl(Caracter.KeyChar)) || ((Caracter.KeyChar == 43 ) && ((Control)sender).Text.Length==0)) { Caracter.Handled = false; }
            else
            {
                Caracter.Handled = true;
                MessageBox.Show("Lo que esta tratando de ingresar no es acorde al dato solicitado", "Su numero telefonico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void Llenar()
        {
            Listado = new DataTable();
            Utileria.Listado.Columns.Add("Codigo", typeof(System.String));
            Utileria.Listado.Columns.Add("Nombre", typeof(System.String));
            Utileria.Listado.Columns.Add("Cantidad", typeof(System.String));
            Utileria.Listado.Columns.Add("Precio", typeof(System.String));
            Utileria.Listado.Columns.Add("SubTotal", typeof(System.String));
            Utileria.Listado.Columns.Add("Existencia", typeof(System.String));
            Utileria.Listado.Columns.Add("Minima", typeof(System.String));
        }

        public static void FocoOff (object sender, EventArgs Caracter)
        {
            if (!string.IsNullOrWhiteSpace(((Control)sender).Text))
            {
                if (((Control)sender).Text.ElementAt(0) == 46) { ((Control)sender).Text = "0" + ((Control)sender).Text; }
                if(((Control)sender).Text.ElementAt(((Control)sender).Text.Length-1) == 46) { ((Control)sender).Text = ((Control)sender).Text + "00"; }
                if (((Control)sender).Text.Length >= 2)
                {
                    if (((Control)sender).Text.ElementAt(((Control)sender).Text.Length - 2) == 46 && ((Control)sender).Text.ElementAt(((Control)sender).Text.Length - 1) == 48)
                    { ((Control)sender).Text = ((Control)sender).Text + "0"; }
                }
            }
        }

       // private const string EMAILSENDER = "checktaller1@gmail.com";
        //private const string PASSWORDSENDER = "TestTaller1";

        public static bool RecoveryPassword(string UsuarioUsuario)
        {
            string EMAILSENDER = "checkengine.noreply@gmail.com";
            string PASSWORDSENDER = "poi16poi16";
            var service = new ServiciosUsuario();
            var user = service.GetUsuarioByUser(UsuarioUsuario);
            if (user == null) return false;


            //var token = "enduro";

            MailMessage mailMessage = new MailMessage(
                from: EMAILSENDER,
                to: "armando.clarosh@gmail.com", //cliente.CI_Email,
                subject: "Ha solicitado restablecer su password en Check Engine",
                body: $"Su usuario es: {user.UsuarioUsuario} \n Por favor inicie sesion con este password : {user.UsuarioPassword}"
                );

            mailMessage.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential credential = new NetworkCredential(EMAILSENDER, PASSWORDSENDER);
            smtpClient.Credentials = credential;
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
            return true;

        }



    }
}
