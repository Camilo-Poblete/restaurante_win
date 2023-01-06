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

namespace Diseño.Cocinero_r
{
    public partial class Pedidos_Cocina : Form
    {
        public Pedidos_Cocina()
        {
            InitializeComponent();
            CargarPedidos();
            DtPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void CargarPedidos()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select us.nombres||' '||us.apellidos as nombre,me.nro_mesa,me.num_asientos as nro_personas,ped.id_pedido from pedido ped JOIN mesa me on ped.id_mesa = me.id_mesa join cliente cl on ped.id_cliente = cl.id_cliente join usuario us on ped.id_cliente = cl.id_cliente and us.id_usuario = cl.id_usuario WHERE ped.estado = 'Activo'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtPedidos.DataSource = dt;

        }


        private void CargarPlatos(string id)
        {

            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            DataTable dt = new DataTable();
            string query = "select pl.nombre_plato as Plato, ped.id_plato as codigo_plato, pl.id_categoria as codigo_categoria, ped.id as ID_Comanda , ped.cantidad As Cantidad, pl.valor_plato As Valor from pedidoplato ped join plato pl on ped.id_plato = pl.id_plato where ped.id_pedido = " + id;
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtPedidos.DataSource = dt;
        }





        private void BtnTerminar_Click_1(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string message = "¿Estas seguro de terminar el pedido?.";
            string caption = "Termino pedido.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                using (OracleCommand command = new OracleCommand("PEDIDO_COCINA_LISTO", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("V_ID", OracleDbType.Int32).Value = id;
                    command.ExecuteNonQuery();

                }
                id = "";
                CargarPedidos();
                BtnVolver.Visible = false;
                DtPedidos.Enabled = true;
                BtnTerminar.Visible = false;
            }
        }

        private void BtnVolver_Click_1(object sender, EventArgs e)
        {
            CargarPedidos();
            DtPedidos.Enabled = true;
            BtnVolver.Visible = false;
            BtnTerminar.Visible = false;
        }

        string id;
        private void DtPedidos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int FilaActual;
            FilaActual = DtPedidos.CurrentRow.Index;

            id = DtPedidos.Rows[FilaActual].Cells[3].Value.ToString();

            CargarPlatos(id);
            DtPedidos.Enabled = false;

            BtnVolver.Visible = true;
            BtnTerminar.Visible = true;
        }
    }
}