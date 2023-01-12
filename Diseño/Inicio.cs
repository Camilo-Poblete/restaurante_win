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
using System.Collections;

namespace Diseño
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Top_Vendidos();
            Stock_Disponible();
            Total_Ventas();
            Total_Recaudado();
            Fecha();

        }

        private void Top_Vendidos()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("fn_top_vendidos", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    ArrayList Producto = new ArrayList();
                    ArrayList Cantidad = new ArrayList();

                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();

                    while (reader.Read())
                    {

                        Cantidad.Add(reader.GetInt32(0));
                        Producto.Add(reader.GetString(1));
                    }
                    ChartMasVendidos.Series[0].Points.DataBindXY(Producto, Cantidad);
                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }

        private void Stock_Disponible()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("FN_MOSTRAR_STOCK_DIA", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    ArrayList Nombre = new ArrayList();
                    ArrayList Cantidad = new ArrayList();

                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();

                    while (reader.Read())
                    {

                        Nombre.Add(reader.GetString(0));
                        Cantidad.Add(reader.GetInt32(1));
                    }
                    ChartStock.Series[0].Points.DataBindXY(Nombre, Cantidad);
                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }

        private void Total_Ventas()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string query = "select count(id_boleta) as total from boleta where to_char(fecha_hora,'dd-mm-yyyy') = to_char(sysdate,'dd-mm-yyyy')";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                LblVentasDia.Text = reg["Total"].ToString();

            }
        }

        private void Total_Recaudado()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string query = "select NVL(sum(total),0) as total from boleta where to_char(fecha_hora,'dd-mm-yyyy') = to_char(sysdate,'dd-mm-yyyy')";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                LblTotalDia.Text = "$" + reg["Total"].ToString();

            }
        }

        private void Fecha()
        {
            LblFecha.Text = "Fecha: " + (DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void ChartStock_Click(object sender, EventArgs e)
        {

        }

        private void ChartMasVendidos_Click(object sender, EventArgs e)
        {

        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }

        private void charMasVendidos_Click(object sender, EventArgs e)
        {

        }

        private void ChartMasVendidos_Click_1(object sender, EventArgs e)
        {

        }
    }
}