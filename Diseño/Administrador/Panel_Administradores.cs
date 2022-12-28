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

namespace Diseño
{
    public partial class Panel_Administradores : Form
    {
        public Panel_Administradores()
        {
            InitializeComponent();
            informacion_usuario();
        }

      
       


        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            string message = "¿Estas seguro de cerrar la aplicacion?.";
            string caption = "Cierre de aplicacion.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel_Administrador_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

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



        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormEnPanel(new Reporte_ventas());
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void informacion_usuario()
        {
            LblNombre.Text = CacheInicioSesion.Nombres;
            LblRol.Text = CacheInicioSesion.Rol;
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new productos());
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Registro_Cliente());
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

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Caja());
        }

        private void BtnCocina_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Pedidos_Cocina());
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Empleados());
        }

        private void BtnAjustesUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ajuste_usuario());

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ajustes());
        }
    }
}
