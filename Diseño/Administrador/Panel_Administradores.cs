using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Transversal;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelo_Negocio;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Input;
using System.Globalization;

using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Runtime.InteropServices;
using Diseño.Administrador;
using Diseño.Garzones_r;
using Diseño.Bodega_r;
using Diseño.Reportes;
using Diseño.Finanzas_r;
using Diseño.Cocinero_r;

namespace Diseño.Administrador
{
    public partial class Panel_Administradores : MaterialForm
    {
        public Panel_Administradores()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configurar esquema de color
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
            informacion_usuario();


        }

            private void Panel_Administradores_Load(object sender, EventArgs e)
            {
            btninicio_Click(null, e);
               
           
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void btnproductos_Click(object sender, EventArgs e)

        {
            AbrirFormEnPanel(new productos());

        }




        private void AbrirFormEnPanel(object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnproductos_Click_1(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Empleados());
        }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnproductos_Click_2(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new productos());
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            string message = "¿Estas seguro de cerrar la aplicacion?.";
            string caption = "Cierre de aplicacion.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            //btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Caja());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void PnlInformacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblInformacion_Click(object sender, EventArgs e)
        {

        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio());
        }

        private void btninicio_MouseLeave(object sender, EventArgs e)
        {
            PnlInformacion.Visible = false;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btninicio_MouseEnter(object sender, EventArgs e)
        {
            PnlInformacion.Visible = true;
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormEnPanel(new Reporte_ventas());
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormEnPanel(new Reporte_stock());
        }

        private void BtnCocina_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Pedidos_Cocina());
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Registro_Clientes());
        }

        private void BTNventas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ingresar_Pedido());
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Stock());
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Compra_Stock());
        }

        private void BtnAjustesUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ajuste_usuario());
        }




        private void informacion_usuario()
        {
            LblNombre.Text = CacheInicioSesion.Nombres;
            LblRol.Text = CacheInicioSesion.Rol;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            string message = "¿Estas seguro de cerrar sesion?";
            string caption = "Cierre de sesion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ajustes());
        }
    }


}



