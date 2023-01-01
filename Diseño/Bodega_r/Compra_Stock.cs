using Modelo_Negocio;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño.Bodega_r
{
    public partial class Compra_Stock : Form
    {
        public Compra_Stock()
        {
            InitializeComponent();
            CargarStock();
            CargarProveedores();
            DtStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Compra_Stock_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresarProveedor_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnStockProveedor_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelarCompra_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresarProducto_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresarCompra_Click(object sender, EventArgs e)
        {

        }

        private void BtnEmitirOrden_Click(object sender, EventArgs e)
        {

        }


        private void CargarStock()
        {


            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            DataTable dt = new DataTable();
            string query = "select id_producto,nombre,stock,stock_critico from producto order by id_producto asc";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtStock.DataSource = dt;
        }



        private void CargarProveedores()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select id_proveedor,rut,razon_social,direccion,telefono,email,descripcion from proveedor";
            OracleCommand command = new OracleCommand(query,conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);
            DtProveedores.DataSource = dt;

        }
    }




}
