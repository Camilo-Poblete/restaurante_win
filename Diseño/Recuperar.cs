using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelo_Negocio;
using Oracle.ManagedDataAccess.Client;
using Capa_Transversal;
using System.Runtime.InteropServices;
using Acceso_Datos;
namespace Diseño
{
    public partial class Recuperar : MaterialForm
    {
        public Recuperar()
        {
            InitializeComponent();
           
           // this.ActiveControl = BtnAcceder;
        }


        private void Recuperar_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    

    

       
    
   
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            string message = "¿Estas seguro de cerrar la aplicacion?.";
            string caption = "Cierre de aplicacion.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }

    

        



        // Envio de contraseña ---------------------------------
        private void EnviarCorreoContrasena(int contrasenaNueva, string correo)
        {
            string contraseña = "frutilla#";
            string mensaje = string.Empty;
            //Creando el correo electronico
            string destinatario = correo;
            string remitente = "restaurantsiglo@gmail.com";
            string asunto = "Nueva contraseña Restaurante XXI";
            string cuerpoDelMesaje = "Se ha actualizado su contraseña, podrá actualizarla dentro de los ajuste de su cuenta en la aplicacion. Su nueva contraseña es: " + " " + Convert.ToString(contrasenaNueva);
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("restaurantsiglo@gmail.com", contraseña);

            try
            {
                Task.Run(() =>
                {

                    smtp.Send(ms);
                    ms.Dispose();
                    MessageBox.Show("Correo enviado, sirvase revisar su bandeja de entrada");
                }
                );

                MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo electronico: " + ex.Message);
            }
        }


        public void GenerarNuevaContrasena(string email)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();


            Random rd = new Random(DateTime.Now.Millisecond);
            int nuevaContrasena = rd.Next(100000, 999999);
            OracleCommand cmd = new OracleCommand("NuevaContrasena", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new OracleParameter("v_correo", OracleDbType.Varchar2)).Value = TxtCorreo.Text;
            cmd.Parameters.Add(new OracleParameter("v_contra", OracleDbType.Varchar2)).Value = Convert.ToString(nuevaContrasena);
            try
            {
                conn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas != 0)
                {
                    EnviarCorreoContrasena(nuevaContrasena, email);
                }
            }
            catch
            {

            }
        }



        private void BtnEnviar_Clave_Click(object sender, EventArgs e)
        {
            GenerarNuevaContrasena(TxtCorreo.Text);

            PnlRecuperar.Visible = false;
            TxtCorreo.Text = "";
        }

     



        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Login pagina_administrador = new Login();
            pagina_administrador.Show();
            this.Hide();
        }

  
   
        private void TxtCorreo_Click(object sender, EventArgs e)
        {
            TxtCorreo.Text = "";
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            if (TxtCorreo.Text == "")
            {
                TxtCorreo.Text = "Ingrese su correo.";
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

    
      
    }
}