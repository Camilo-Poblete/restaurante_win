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

using LibPrintTicket;

namespace Diseño.Finanzas_r
{
    public partial class Caja : MaterialForm
    {
        public Caja()
        {
            InitializeComponent();
            CbxPropina.SelectedIndex = 0;
            CbxTipoPago.SelectedIndex = 0;
            LblPersonal.Text = "Personal de venta: " + CacheInicioSesion.Nombres + " " + CacheInicioSesion.Apellidos;
            CargarPedidos();
            DtActivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtVentasDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CbxPropina.Enabled = false;
            CbxTipoPago.Enabled = false;
            Total_Efectivo();
            Total_Debito_Credito();
            Total_Transferencias();
            Total_Propinas();
            CargarPedidos_dia();
            Datos_empresa();


        }
        string Nombre;
        string Direccion;
        string Comuna;
        string Region1;
        string Fono;
        private void Datos_empresa()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = ("Select nombre_empresa,direccion,comuna,region,fono from informacion_empresa where id_empresa = 1");

            command.CommandType = System.Data.CommandType.Text;

            OracleDataReader reader;
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Nombre = reader.GetString(0);
                    Direccion = reader.GetString(1);
                    Comuna = reader.GetString(2);
                    Region1 = reader.GetString(3);
                    Fono = reader.GetString(4);

                }
            }
            else
            {

            }

        }


        private void CargarPedidos()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select us.nombres||' '||us.apellidos as nombre,me.nro_mesa,me.num_asientos as nro_personas,ped.id_pedido from pedido ped JOIN mesa me on ped.id_mesa = me.id_mesa join cliente cl on ped.id_cliente = cl.id_cliente join usuario us on ped.id_cliente = cl.id_cliente and us.id_usuario = cl.id_usuario WHERE ped.estado = 'Pagar'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtActivos.DataSource = dt;
        }



        private void CargarPedidos_dia()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select bol.id_boleta as Num_Boleta, bol.id_pedido as Pedido ,usu.nombres as Cliente, bol.total as Total from boleta bol join pedido ped on ped.id_pedido = bol.id_pedido join cliente cli on ped.id_cliente = cli.id_cliente join usuario usu on usu.id_usuario = cli.id_usuario where TO_CHAR(bol.fecha_hora, 'dd/mm/yyyy') like TO_CHAR(sysdate, 'dd/mm/yyyy')";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtVentasDia.DataSource = dt;

        }



        private void Total_Efectivo()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string query = "select sum(total) as total from boleta where to_char(fecha_hora,'DD-MON-YYYY') = TO_CHAR(SYSTIMESTAMP,'DD-MON-YYYY') and medio_pago = 'EFECTIVO'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                TxtEfectivo.Text = "$ " + reg["Total"].ToString();
            }

        }




        private void Total_Debito_Credito()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string query = "select sum(total) as total from boleta where to_char(fecha_hora,'DD-MON-YYYY') = TO_CHAR(SYSTIMESTAMP,'DD-MON-YYYY') and medio_pago = 'DEBITO/CREDITO'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                TxtDebitoCredito.Text = "$ " + reg["Total"].ToString();
            }
        }

        private void Total_Transferencias()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string query = "select sum(total) as total from boleta where to_char(fecha_hora,'DD-MON-YYYY') = TO_CHAR(SYSTIMESTAMP,'DD-MON-YYYY') and medio_pago = 'TRANSFERENCIA'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                TxtTransferencia.Text = "$ " + reg["Total"].ToString();
            }


        }

        private void Total_Propinas()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string query = "select sum(atencion) as total from boleta where to_char(fecha_hora,'DD-MON-YYYY') = TO_CHAR(SYSTIMESTAMP,'DD-MON-YYYY')";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                TxtPropinasDia.Text = "$ " + reg["Total"].ToString();
            }

        }







        private void Caja_Load(object sender, EventArgs e)
        {

        }

        private void PnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlActivos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlActivos_Paint_1(object sender, PaintEventArgs e)
        {


        }



        string nombre = "";
        string id;

        private void DtActivos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            CbxPropina.Enabled = true;
            CbxTipoPago.Enabled = true;
            BtnVolver.Visible = true;
            CbxTipoPago.SelectedIndex = 0;
            CbxPropina.SelectedIndex = 0;
            LblMesa.Text = "Mesa:";
            LblIDpedido.Text = "N° Pedido: ";
            TxtSubTotal.Text = "";
            TxtDcto.Text = "";
            TxtTotal.Text = "";
            TxtPropina.Text = "0";
            TxtMesa.Text = "";


            int fila = e.RowIndex;

            if (fila != -1)
            {
                nombre = DtActivos.Rows[fila].Cells[0].Value.ToString();

                string mesa;
                mesa = DtActivos.Rows[fila].Cells[1].Value.ToString();
                LblMesa.Text = "Mesa: " + mesa;

                string categoria;
                categoria = DtActivos.Rows[fila].Cells[3].Value.ToString();
                LblIDpedido.Text = "N° Pedido: " + categoria;

                string categoria2;
                categoria2 = DtActivos.Rows[fila].Cells[1].Value.ToString();
                TxtMesa.Text = categoria2;

                string categoria1;
                categoria1 = DtActivos.Rows[fila].Cells[3].Value.ToString();
                TxtId.Text = categoria;

                id = DtActivos.Rows[fila].Cells[3].Value.ToString();

                TxtSubTotal.Text = sub_total(TxtId.Text);

                CargarPlatos(id);
            }


        }



        private void CargarPlatos_dia(string id)
        {

            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            DataTable dt = new DataTable();
            string query = "select pl.nombre_plato as Plato ,cat.categoria as categoria, ped.id as ID_Comanda , ped.cantidad As Cantidad ,ped.cantidad*pl.valor_plato as Total from pedidoplato ped join plato pl on ped.id_plato = pl.id_plato join categoria cat on pl.id_categoria = cat.id_categoria where ped.id_pedido = " + id;
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtVentasDia.DataSource = dt;
        }


        private string sub_total(string id)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            string query = "select SUM(ped.cantidad*pl.valor_plato) as Total from pedidoplato ped join plato pl on pl.id_plato = ped.id_plato WHERE ped.id_pedido = " + id + " GROUP BY ped.id_pedido";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                return reg["Total"].ToString();
            }
            else
            {
                return "0";
            }
        }


        private void CargarPlatos(string id)
        {

            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            DataTable dt = new DataTable();
            string query = "select pl.nombre_plato as Plato, ped.id_plato as codigo_plato, pl.id_categoria as codigo_categoria, ped.id as ID_Comanda , ped.cantidad As Cantidad, pl.valor_plato As Valor, ped.cantidad*pl.valor_plato from pedidoplato ped join plato pl on ped.id_plato = pl.id_plato where ped.id_pedido = " + id;
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtActivos.DataSource = dt;
        }



        private void DtVentasDia_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }




        string rut_cliente = "";
        //Listo
        string printer;
        private void Impresora()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string query = "select impresora from informacion_empresa where id_empresa = 1";
            OracleCommand commandd = new OracleCommand(query, conn);
            OracleDataReader reg1 = commandd.ExecuteReader();
            if (reg1.Read())
            {
                printer = reg1["Total"].ToString();

            }
            else
            {
                printer = "0";
            }
        }






        private void Obtener_Boleta()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            string query = "select max(id_boleta) as boleta from boleta";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                TxtIdBoleta.Text = reg["boleta"].ToString();

                string query1 = "select us.rut as rut  from boleta bo join pedido ped on ped.id_pedido = bo.id_pedido join cliente cl on ped.id_cliente = cl.id_cliente join usuario us on us.id_usuario = cl.id_usuario where bo.id_boleta=" + TxtIdBoleta.Text;
                OracleCommand command1 = new OracleCommand(query1, conn);
                OracleDataReader reg1 = command1.ExecuteReader();

                if (reg1.Read())
                {
                    rut_cliente = reg1["rut"].ToString();

                }

            }
            else
            {
                TxtIdBoleta.Text = "0";
            }
        }

        private void DtVentasDia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DtVentasDia.Enabled = false;
            int fila = e.RowIndex;

            if (fila != -1)
            {
                string id;
                id = DtVentasDia.Rows[fila].Cells[1].Value.ToString();

                CargarPlatos_dia(id);
            }
            BtnVolver_peddias.Visible = true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            CbxTipoPago.SelectedIndex = 0;
            CbxPropina.SelectedIndex = 0;
            CbxTipoPago.Enabled = false;
            CbxPropina.Enabled = false;
            LblMesa.Text = "Mesa:";
            LblIDpedido.Text = "N° Pedido";
            TxtSubTotal.Text = "";
            TxtDcto.Text = "";
            TxtTotal.Text = "";
            TxtPropina.Text = "0";
            TxtMesa.Text = "";
            TxtId.Text = "";
            TxtIdBoleta.Text = "";
            rut_cliente = "";
            CargarPedidos();
            id = "";

            BtnVolver.Visible = false;
            btndescargar.Visible = false;
            BtnPagar.Visible = true;
        }

        private void BtnVolver_peddias_Click(object sender, EventArgs e)
        {
            DtVentasDia.Visible = true;
            CargarPedidos_dia();
            BtnVolver_peddias.Visible = false;
        }




        private void BtnPagar_Click(object sender, EventArgs e)
        {

            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            try
            {
                if (CbxPropina.SelectedIndex != 0)
                {
                    if (CbxTipoPago.SelectedIndex != 0)
                    {
                        if (TxtDcto.Text == "")
                        {
                            string message1 = "Debe declarar un descuento, si no se aplicara descuento indique 0.";
                            string title = "Error al pagar.";
                            MessageBox.Show(message1, title);
                        }
                        else
                        {

                            string message = "¿Estas seguro de PAGAR el pedido?.";
                            string caption = "Pago de pedido.";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;

                            result = MessageBox.Show(message, caption, buttons);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {

                                using (OracleCommand command = new OracleCommand("INSERTAR_BOLETA", conn))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.Add("V_SUBTOTAL", OracleDbType.Int32).Value = TxtSubTotal.Text;
                                    command.Parameters.Add("V_PROPINA", OracleDbType.Int32).Value = TxtPropina.Text;
                                    command.Parameters.Add("V_DCTO", OracleDbType.Int32).Value = TxtDcto.Text;
                                    command.Parameters.Add("V_TOTAL", OracleDbType.Int32).Value = TxtTotal.Text;
                                    command.Parameters.Add("V_PAGO", OracleDbType.Varchar2).Value = CbxTipoPago.Text;
                                    command.Parameters.Add("V_ID_PEDIDO", OracleDbType.Int32).Value = TxtId.Text;


                                    command.ExecuteNonQuery();


                                }

                                using (OracleCommand command = new OracleCommand("RETIRO_PEDIDO_MESA", conn))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.Add("V_ID_MESA", OracleDbType.Int32).Value = TxtMesa.Text;

                                    command.ExecuteNonQuery();

                                }
                                using (OracleCommand command = new OracleCommand("TERMINO_PEDIDO", conn))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.Add("V_ID", OracleDbType.Int32).Value = TxtId.Text;

                                    command.ExecuteNonQuery();

                                }

                                Total_Efectivo();
                                Total_Debito_Credito();
                                Total_Transferencias();
                                Total_Propinas();
                                Obtener_Boleta();
                                CargarPedidos_dia();

                                BtnPagar.Visible = false;
                                btndescargar.Visible = true;
                                BtnBoletaElec.Visible = true;

                            }

                        }
                    }
                    else
                    {
                        string message1 = "Debe Seleccionar un tipo de pago.";
                        string title = "Error al pagar.";
                        MessageBox.Show(message1, title);
                    }
                }
                else
                {
                    string message1 = "Debe Seleccionar si el cliente desea agregar propina";
                    string title = "Error al pagar.";
                    MessageBox.Show(message1, title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Porfavor verifique los datos proporcionados: " + ex, "Error al pagar pedido.");
            }




        }

        private void CbxPropina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxPropina.SelectedIndex == 1)
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();

                string query = "select (SUM(ped.cantidad*pl.valor_plato))*1.1 as Total from pedidoplato ped join plato pl on pl.id_plato = ped.id_plato WHERE ped.id_pedido = " + TxtId.Text + " GROUP BY ped.id_pedido";
                OracleCommand command = new OracleCommand(query, conn);
                OracleDataReader reg = command.ExecuteReader();

                if (reg.Read())
                {
                    TxtTotal.Text = reg["Total"].ToString();
                }

                else
                {
                    TxtTotal.Text = "0";
                }

                string query1 = "select (SUM(ped.cantidad*pl.valor_plato))*0.1 as Total from pedidoplato ped join plato pl on pl.id_plato = ped.id_plato WHERE ped.id_pedido = " + TxtId.Text + " GROUP BY ped.id_pedido";
                OracleCommand commandd = new OracleCommand(query1, conn);
                OracleDataReader reg1 = commandd.ExecuteReader();

                if (reg1.Read())
                {
                    TxtPropina.Text = reg1["Total"].ToString();
                }
                else
                {
                    TxtPropina.Text = "0";
                }



            }
            else
            {
                TxtTotal.Text = TxtSubTotal.Text;
            }
            if (CbxPropina.SelectedIndex == 2)
            {
                TxtPropina.Text = "0";
            }
        }

        private void BtnBoletaElec_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Boleta Num " + string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



                //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
                string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NombreEmpresa", Nombre);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Direccion", Direccion);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Comuna", Comuna);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Region", Region1);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Fono", Fono);

                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", nombre);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@BOLETA", TxtIdBoleta.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", rut_cliente);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in DtActivos.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells[4].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells[5].Value.ToString() + "</td>";
                    filas += "</tr>";
                }

                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);

                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SUBTOTAL", TxtSubTotal.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PROPINA", TxtPropina.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", TxtTotal.Text);

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        //Crear documento y lo definir como PDF
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        //agregar la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.restaurant, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        //img.SetAbsolutePosition(10,100);
                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img);

                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();


                        CbxTipoPago.SelectedIndex = 0;
                        CbxPropina.SelectedIndex = 0;
                        CbxTipoPago.Enabled = false;
                        CbxPropina.Enabled = false;
                        LblMesa.Text = "Mesa:";
                        LblIDpedido.Text = "N° Pedido: ";
                        TxtSubTotal.Text = "";
                        TxtDcto.Text = "";
                        TxtTotal.Text = "";
                        TxtPropina.Text = "0";
                        TxtMesa.Text = "";
                        TxtId.Text = "";
                        TxtIdBoleta.Text = "";
                        rut_cliente = "";
                        CargarPedidos();
                        id = "";

                        btndescargar.Visible = false;
                        BtnPagar.Visible = true;
                        BtnBoletaElec.Visible = false;
                    }
                }

            }



        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            string message = "¿Estas seguro de imprimir la boleta?.";
            string caption = "Impresion de Boleta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Ticket ticket = new Ticket();
                ticket.FontSize = 6;
                ticket.MaxChar = 35;
                ticket.MaxCharDescription = 16;
                //  ticket.HeaderImage = Properties.Resources.impresora;
                ticket.AddHeaderLine(Nombre);
                ticket.AddHeaderLine("Direccion: " + Direccion);
                ticket.AddHeaderLine("Comuna: " + Comuna);
                ticket.AddHeaderLine("Región: " + Region1);
                ticket.AddHeaderLine("Fono: " + Fono);
                ticket.AddHeaderLine("");
                ticket.AddHeaderLine("Cliente: " + nombre);
                ticket.AddHeaderLine("Medio de pago: " + CbxTipoPago.Text);

                ticket.AddSubHeaderLine("Boleta N°: " + TxtIdBoleta.Text);
                ticket.AddSubHeaderLine("Fecha: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                foreach (DataGridViewRow row in DtActivos.Rows)
                {
                    string cantidad = row.Cells[4].Value.ToString();
                    string desc = row.Cells[0].Value.ToString();
                    string valor = row.Cells[6].Value.ToString();
                    ticket.AddItem("" + cantidad + "", "" + desc + "", "$" + valor + "");

                }

                ticket.AddTotal("SUBTOTAL:", " $" + TxtSubTotal.Text + "");
                ticket.AddTotal("PROPINA (10%):", " $" + TxtPropina.Text + "");
                ticket.AddTotal("IVA", "0");
                ticket.AddTotal("TOTAL:", " $" + TxtTotal.Text + "");
                ticket.AddTotal("", "");

                ticket.AddFooterLine("Vuelva pronto.");

                ticket.PrintTicket(printer); //Nombre de la impresora de tickets
                CbxTipoPago.SelectedIndex = 0;
                CbxPropina.SelectedIndex = 0;
                CbxTipoPago.Enabled = false;
                CbxPropina.Enabled = false;
                LblMesa.Text = "Mesa:";
                LblIDpedido.Text = "N° Pedido: ";
                TxtSubTotal.Text = "";
                TxtDcto.Text = "";
                TxtTotal.Text = "";
                TxtPropina.Text = "0";
                TxtMesa.Text = "";
                TxtId.Text = "";
                TxtIdBoleta.Text = "";
                rut_cliente = "";
                CargarPedidos();
                id = "";

                BtnVolver.Visible = false;
                btndescargar.Visible = false;
                BtnPagar.Visible = true;
                BtnBoletaElec.Visible = false;
            }
        }
    }


}





                

            

            