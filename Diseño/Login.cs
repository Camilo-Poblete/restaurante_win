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
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            ocultar_elementos();
            this.ActiveControl = BtnAcceder;
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        public void ocultar_elementos()
        {
            lblError.Visible = false;
        }





        private void BtnOlvidarContra_MouseEnter(object sender, EventArgs e)
        {
            BtnOlvidarContra.ForeColor = Color.Red;
        }

        private void BtnOlvidarContra_MouseLeave(object sender, EventArgs e)
        {
            BtnOlvidarContra.ForeColor = Color.Black;
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void TxtContrasena_Click(object sender, EventArgs e)
        {
            TxtContrasena.Text = "";
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario")
            {
                if (TxtContrasena.Text != "Contraseña")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUsuario.Text, TxtContrasena.Text);

                    string V_Estado = CacheInicioSesion.Estado;

                    if (validLogin == true)
                    {
                        if (V_Estado == "Activo")
                        {
                            switch (CacheInicioSesion.Rol_id)
                            {
                                case 1:
                                    Panel_Administradores pagina_administrador = new Panel_Administradores();
                                    pagina_administrador.Show();
                                    pagina_administrador.FormClosed += CerrarSesion;
                                    this.Hide();
                                    break;
                                case 2:
                                    Cocinero cocinero = new Cocinero();
                                    cocinero.Show();
                                    cocinero.FormClosed += CerrarSesion;
                                    this.Hide();
                                    break;
                                case 3:
                                    Recepcion recepcion = new Recepcion();
                                    recepcion.Show();
                                    recepcion.FormClosed += CerrarSesion;
                                    this.Hide();
                                    break;
                                case 4:

                                case 5:
                                    Garzones garzon = new Garzones();
                                    garzon.Show();
                                    garzon.FormClosed += CerrarSesion;
                                    this.Hide();
                                    break;
                                case 6:
                                    Bodega_restau bodega = new Bodega_restau();
                                    bodega.Show();
                                    bodega.FormClosed += CerrarSesion;
                                    this.Hide();
                                    break;
                                case 7:
                                    string message = "Los clientes no pueden ingresar al sistema administrativo.";
                                    string caption = "Error de ingreso.";
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                                    DialogResult result;
                                    result = MessageBox.Show(message, caption, buttons);
                                    break;


                            }
                        }
                        else
                        {
                            string message = "¿El usuario esta activo?.";
                            string caption = "Erro al iniciar sesion.";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result;
                            result = MessageBox.Show(message, caption, buttons);

                        }
                    }
                    else
                    {
                        ErrorLogin("Usuario o Contraseña invalido.");
                        TxtContrasena.Text = "Contraseña";
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    ErrorLogin("Porfavor ingrese su contraseña");
                }
            }
            else
            {
                ErrorLogin("Porfavor Ingrese su usuario");
            }
        }

        private void ErrorLogin(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }

        public void CerrarSesion(object sender, EventArgs e)
        {
            txtUsuario.Text = "Usuario";
            TxtContrasena.Text = "Contraseña";
            lblError.Visible = false;
            this.Show();

        }

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

        private void BtnOlvidarContra_Click(object sender, EventArgs e)
        {


            Recuperar pagina_administrador = new Recuperar();
            pagina_administrador.Show();
            this.Hide();
        }

        // Recuperar contraseña -------------------------------------------------------



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





        private void ChkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            TxtContrasena.PasswordChar = ChkMostrar.Checked ? '\0' : '*';
        }

        private void TxtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (TxtContrasena.Text != "Contraseña")
            {
                TxtContrasena.PasswordChar = '*';
            }
            else
            {
                TxtContrasena.PasswordChar = '\0';
            }
        }


        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void TxtContrasena_Leave(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "")
            {
                TxtContrasena.Text = "Contraseña";
            }
        }



        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtContrasena_TextChanged_1(object sender, EventArgs e)
        {
            if (TxtContrasena.Text != "Contraseña")
            {
                TxtContrasena.PasswordChar = '*';
            }
            else
            {
                TxtContrasena.PasswordChar = '\0';
            }
        }

        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void TxtContrasena_Leave_1(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "")
            {
                TxtContrasena.Text = "Contraseña";
            }
        }

        private void txtUsuario_Click_1(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void TxtContrasena_Click_1(object sender, EventArgs e)
        {
            TxtContrasena.Text = "";
        }
    }

}