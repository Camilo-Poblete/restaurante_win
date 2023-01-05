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
using System.Drawing.Imaging;
using System.IO;

namespace Diseño.Bodega_r
{
    public partial class Compra_Stock : MaterialForm
    {
        public Compra_Stock()
        {
            InitializeComponent();
            CargarStock();
            CargarProveedores();
            DtStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void CargarCbxStock(string producto)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select id_producto,nombre from producto where nombre like '%" + producto + "%' order by id_producto asc";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DataRow fila = dt.NewRow();
            fila["nombre"] = "-- Seleccione un producto --";
            dt.Rows.InsertAt(fila, 0);

            CbxProducto.DataSource = dt;
            CbxProducto.DisplayMember = "nombre";
            CbxProducto.ValueMember = "id_producto";
        }

        private void TxtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            CargarCbxStock(TxtProducto.Text);
        }

        private void CargarProveedores()
        {


            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            DataTable dt = new DataTable();
            string query = "select id_proveedor,rut,razon_social,direccion,telefono,email,descripcion from proveedor";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtProveedores.DataSource = dt;
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



        private void TxtFiltroStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            DataTable dt = new DataTable();
            string query = "select id_producto,nombre,stock,stock_critico from producto where nombre like '%" + TxtFiltroStock.Text + "%' order by id_producto asc";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtStock.DataSource = dt;
        }



        private void TxtFiltroStock_MouseClick(object sender, MouseEventArgs e)
        {
            TxtFiltroStock.ForeColor = Color.Black;
            TxtFiltroStock.Text = "";
        }

        private void TxtFiltroStock_Leave(object sender, EventArgs e)
        {
            if (TxtFiltroStock.Text == "")
            {
                TxtFiltroStock.Text = "Ingrese nombre un nombre de producto para filtrar.";
            }
        }





        private void BtnCancelarCompra_Click(object sender, EventArgs e)
        {
            BtnCancelarCompra.Visible = false;
            BtnIngresarCompra.Visible = false;

            TxtNombreStock.Text = "";
            TxtIDStock.Text = "";
        }

        private void BtnIngresarProveedor_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            string message = "¿Estas seguro de agregar el proveedor?.";
            string caption = "Añadir proveedor.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                using (OracleCommand command = new OracleCommand("INSERTAR_PROVEEDOR", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("V_RUT", OracleDbType.Varchar2).Value = TxtRut.Text;
                    command.Parameters.Add("V_RAZON", OracleDbType.Varchar2).Value = TxtRazonSocial.Text;
                    command.Parameters.Add("V_DIRECCION", OracleDbType.Varchar2).Value = TxtDireccion.Text;
                    command.Parameters.Add("V_TELEFONO", OracleDbType.Varchar2).Value = TxtTelefono.Text;
                    command.Parameters.Add("V_EMAIL", OracleDbType.Varchar2).Value = TxtEmail.Text;
                    command.Parameters.Add("V_DESCRIPCION", OracleDbType.Varchar2).Value = TxtDescripcion.Text;



                    command.ExecuteNonQuery();

                    BtnStockProveedor.Visible = true;
                    BtnIngresarProveedor.Visible = false;

                    TxtProducto.Enabled = true;
                    CbxProducto.Enabled = true;
                    TxtPrecio.Enabled = true;

                    CargarProveedores();
                }

                string query = "select id_proveedor from proveedor where razon_social = '" + TxtRazonSocial.Text + "'";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataReader reg = cmd.ExecuteReader();

                if (reg.Read())
                {
                    TxtIDproveedor.Text = reg["id_proveedor"].ToString();

                }
            }


        }

        private void BtnStockProveedor_Click(object sender, EventArgs e)
        {

            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            string message = "¿Estas seguro de agregar el pedido?.";
            string caption = "Añadir pedido.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                using (OracleCommand command = new OracleCommand("INSERTAR_PROVEEDOR_PRODUCTO", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("V_ID_PROVEEDOR", OracleDbType.Int32).Value = TxtIDproveedor.Text;
                    command.Parameters.Add("V_ID_PRODUCTO", OracleDbType.Int32).Value = TxtIdProducto.Text;
                    command.Parameters.Add("V_PRECIO", OracleDbType.Int32).Value = TxtPrecio.Text;



                    command.ExecuteNonQuery();

                    BtnStockProveedor.Visible = false;
                    BtnIngresarProveedor.Visible = true;

                    TxtProducto.Enabled = false;
                    CbxProducto.Enabled = false;
                    TxtPrecio.Enabled = false;
                    CargarProveedores();

                    TxtIDproveedor.Text = "";
                    CbxProducto.SelectedIndex = 0;
                    TxtProducto.Text = "";
                    TxtPrecio.Text = "";
                    TxtRut.Text = "";
                    TxtRazonSocial.Text = "";
                    TxtDireccion.Text = "";
                    TxtTelefono.Text = "";
                    TxtEmail.Text = "";
                    TxtDescripcion.Text = "";
                }
            }
        }



        private void CbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtIdProducto.Text = CbxProducto.SelectedValue.ToString();
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtIDproveedor.Text = "";
            TxtProducto.Text = "";
            TxtPrecio.Text = "";
            TxtRut.Text = "";
            TxtRazonSocial.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono.Text = "";
            TxtEmail.Text = "";
            TxtDescripcion.Text = "";
            LblCompraStock.Text = "INGRESAR ORDEN";

            BtnCancelar.Visible = false;
            BtnModificar.Visible = false;
            BtnIngresarProveedor.Visible = true;

            TxtProducto.Enabled = false;
            CbxProducto.Enabled = false;
            TxtPrecio.Enabled = false;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            string message = "¿Estas seguro de modificar el proveedor?.";
            string caption = "Modificar proveedor.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                using (OracleCommand command = new OracleCommand("ACTUALIZAR_PROVEEDOR", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("V_ID", OracleDbType.Int32).Value = TxtIDproveedor.Text;
                    command.Parameters.Add("V_RUT", OracleDbType.Varchar2).Value = TxtRut.Text;
                    command.Parameters.Add("V_RAZON", OracleDbType.Varchar2).Value = TxtRazonSocial.Text;
                    command.Parameters.Add("V_DIRECCION", OracleDbType.Varchar2).Value = TxtDireccion.Text;
                    command.Parameters.Add("V_TELEFONO", OracleDbType.Varchar2).Value = TxtTelefono.Text;
                    command.Parameters.Add("V_EMAIL", OracleDbType.Varchar2).Value = TxtEmail.Text;
                    command.Parameters.Add("V_DESCRIPCION", OracleDbType.Varchar2).Value = TxtDescripcion.Text;



                    command.ExecuteNonQuery();


                }
                TxtIDproveedor.Text = "";
                TxtProducto.Text = "";
                TxtPrecio.Text = "";
                TxtRut.Text = "";
                TxtRazonSocial.Text = "";
                TxtDireccion.Text = "";
                TxtTelefono.Text = "";
                TxtEmail.Text = "";
                TxtDescripcion.Text = "";

                BtnCancelar.Visible = false;
                BtnModificar.Visible = false;
                BtnIngresarProveedor.Visible = true;
                BtnStockProveedor.Visible = false;

                TxtProducto.Enabled = false;
                CbxProducto.Enabled = false;
                TxtPrecio.Enabled = false;

                CargarProveedores();
            }





            BtnIngresarProducto.Visible = true;
            BtnIngresarCompra.Visible = false;
            BtnCancelar.Visible = true;


            TxtCantidad.Enabled = true;
            TxtProveedor.Enabled = true;
            CbxProveedor.Enabled = true;
            CbxStockCompra.Enabled = true;

        }

        private void BtnEmitirOrden_Click(object sender, EventArgs e)
        {
            LblCompraStock.Text = "Lista Stock";

            CargarStock();
            TxtIDStock.Text = "";
            TxtIdCompra.Text = "";
            TxtNombreStock.Text = "";
            TxtCantidad.Text = "";
            TxtProveedor.Text = "";
            TxtComentarios.Text = "";
        }

        private void BtnIngresarProducto_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            string message = "¿Estas seguro de agregar el producto a la orden?.";
            string caption = "Añadir producto.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                using (OracleCommand command = new OracleCommand("INSERTAR_ORDEN_PRODUCTO", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("V_ID_ORDEN", OracleDbType.Int32).Value = TxtIdCompra.Text;
                    command.Parameters.Add("V_ID_PRODUCTO", OracleDbType.Int32).Value = CbxStockCompra.SelectedValue;
                    command.Parameters.Add("V_CANTIDAD", OracleDbType.Int32).Value = TxtCantidad.Text;

                    command.ExecuteNonQuery();

                }
                using (OracleCommand command = new OracleCommand("INSERTAR_PROVEEDOR_ORDEN", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("V_ID_PROVEEDOR", OracleDbType.Int32).Value = CbxProveedor.SelectedValue;
                    command.Parameters.Add("V_ID_ORDEN", OracleDbType.Int32).Value = TxtIdCompra.Text;


                    command.ExecuteNonQuery();

                }
                TxtNombreStock.Text = "";
                TxtCantidad.Text = "";
                TxtProveedor.Text = "";
                CbxStockCompra.SelectedIndex = 0;
                CbxProveedor.SelectedIndex = 0;

                BtnEmitirOrden.Visible = true;


            }


        }

        private void DtProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            if (fila != -1)
            {
                string id_proveedor;
                id_proveedor = DtProveedores.Rows[fila].Cells[0].Value.ToString();
                TxtIDproveedor.Text = id_proveedor;

                string Rut;
                Rut = DtProveedores.Rows[fila].Cells[1].Value.ToString();
                TxtRut.Text = Rut;

                string razon_social;
                razon_social = DtProveedores.Rows[fila].Cells[2].Value.ToString();
                TxtRazonSocial.Text = razon_social;

                string direccion;
                direccion = DtProveedores.Rows[fila].Cells[3].Value.ToString();
                TxtDireccion.Text = direccion;

                string telefono;
                telefono = DtProveedores.Rows[fila].Cells[4].Value.ToString();
                TxtTelefono.Text = telefono;

                string email;
                email = DtProveedores.Rows[fila].Cells[5].Value.ToString();
                TxtEmail.Text = email;

                string descripcion;
                descripcion = DtProveedores.Rows[fila].Cells[6].Value.ToString();
                TxtDescripcion.Text = descripcion;

                BtnCancelar.Visible = true;
                BtnModificar.Visible = true;
                BtnIngresarProveedor.Visible = false;
                BtnStockProveedor.Visible = true;

                TxtProducto.Enabled = true;
                CbxProducto.Enabled = true;
                TxtPrecio.Enabled = true;
            }
        }

        private void TxtFiltroProveedorDT_MouseClick(object sender, MouseEventArgs e)
        {

            TxtFiltroProveedorDT.ForeColor = Color.Black;
            TxtFiltroProveedorDT.Text = "";
        }

        private void TxtFiltroProveedorDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            DataTable dt = new DataTable();
            string query = "select id_proveedor,rut,razon_social,direccion,telefono,email,descripcion from proveedor where razon_social like '%" + TxtFiltroProveedorDT.Text + "%'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtProveedores.DataSource = dt;
        }

        private void BtnIngresarCompra_Click(object sender, EventArgs e)
        {

            LblCompraStock.Text = "INGRESE PRODUCTOS ORDEN";
            LblTituloListaStock.Text = "LISTA COMPRA";
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            string message = "¿Estas seguro de agregar el proveedor?.";
            string caption = "Añadir proveedor.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                using (OracleCommand command = new OracleCommand("INSERTAR_ORDEN_COMPRA", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("V_DESCRIPCION", OracleDbType.Varchar2).Value = TxtComentarios.Text;

                    command.ExecuteNonQuery();

                }

                string query = "select MAX(id_orden) as id_compra from ordencompra";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataReader reg = cmd.ExecuteReader();

                if (reg.Read())
                {
                    TxtIdCompra.Text = reg["id_compra"].ToString();
                    Cargar_orden_compra(TxtIdCompra.Text);



                }
            }
            BtnIngresarProducto.Visible = true;
            BtnIngresarCompra.Visible = false;
            BtnCancelar.Visible = true;


            TxtCantidad.Enabled = true;
            TxtProveedor.Enabled = true;
            CbxProveedor.Enabled = true;
            CbxStockCompra.Enabled = true;
        }


        private void Cargar_orden_compra(string v_id_compra)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            DataTable dt = new DataTable();
            string query = "select op.id_orden,pr.nombre,op.cantidad,pp.precio_compra from ordenproducto op join producto pr on pr.id_producto = op.id_producto join proveedorproducto pp on pp.id_producto = op.id_producto where op.id_orden = '" + v_id_compra + "'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtStock.DataSource = dt;
        }

        private void TxtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cargar_proveedores_orden(TxtProveedor.Text, TxtIDStock.Text);
        }



        private void Cargar_proveedores_orden(string v_nombre, string v_id)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select pr.id_proveedor,pr.razon_social from proveedor pr JOIN proveedorproducto prpp on prpp.id_proveedor = pr.id_proveedor where prpp.id_producto = " + v_id + " and pr.razon_social like '%" + v_nombre + "%'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DataRow fila = dt.NewRow();
            fila["razon_social"] = "-- Seleccione un proveedor --";
            dt.Rows.InsertAt(fila, 0);

            CbxProveedor.DataSource = dt;
            CbxProveedor.DisplayMember = "razon_social";
            CbxProveedor.ValueMember = "id_proveedor";
        }




        private void Cargar_stock_orden(string v_nombre)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select id_producto,nombre from producto where nombre like '%" + v_nombre + "%'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DataRow fila = dt.NewRow();
            fila["nombre"] = "-- Seleccione un producto --";
            dt.Rows.InsertAt(fila, 0);

            CbxStockCompra.DataSource = dt;
            CbxStockCompra.DisplayMember = "nombre";
            CbxStockCompra.ValueMember = "id_producto";
        }

        private void TxtNombreStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cargar_stock_orden(TxtNombreStock.Text);
        }

        private void CbxStockCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtIDStock.Text = CbxStockCompra.SelectedValue.ToString();
        }
    }

}