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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Collections;
using LibPrintTicket;



namespace Diseño.Reportes
{
    public partial class Reporte_ventas : MaterialForm
    {
        public Reporte_ventas()
        {
            InitializeComponent();
            Cargar_ventas_diarias();
            Cargar_Ventas_Anuales();
            Cargar_ventas_mensuales();
            Datos_empresa();
            Impresora();
        }


        private void Reporte_ventas_Load(object sender, EventArgs e)
        {
            Ventas_Mensuales();
            Ventas_Diarias();
            Ventas_Anuales();
            Total_Dia();


        }

        private void Cargar_Ventas_Anuales()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("FN_MOSTRAR_VENTAS_ANUALES", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();
                    DataTable tabla = new DataTable();
                    OracleDataAdapter adaptador = new OracleDataAdapter(command);
                    adaptador.Fill(tabla);

                    while (reader.Read())
                    {
                        DtVentasAnuales.DataSource = tabla;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }

        private void Cargar_ventas_mensuales()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("FN_MOSTRAR_VENTAS_MENSUALES", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();
                    DataTable tabla = new DataTable();
                    OracleDataAdapter adaptador = new OracleDataAdapter(command);
                    adaptador.Fill(tabla);

                    while (reader.Read())
                    {
                        DtVentasMensuales.DataSource = tabla;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }

        private void Cargar_ventas_diarias()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("FN_MOSTRAR_VENTAS_DIARIAS", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();
                    DataTable tabla = new DataTable();
                    OracleDataAdapter adaptador = new OracleDataAdapter(command);
                    adaptador.Fill(tabla);

                    while (reader.Read())
                    {
                        DtVentasDiarias.DataSource = tabla;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }

        private void Ventas_Mensuales()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("FN_MOSTRAR_VENTAS_MENSUALES", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    ArrayList Mes = new ArrayList();
                    ArrayList Monto = new ArrayList();

                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();

                    while (reader.Read())
                    {

                        Mes.Add(reader.GetString(0));
                        Monto.Add(reader.GetInt32(1));
                    }
                    ChartVentasMensuales.Series[0].Points.DataBindXY(Mes, Monto);
                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en el grafico: Ventas Mensuales");
            }
        }

        private void Ventas_Diarias()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("FN_MOSTRAR_VENTAS_DIARIAS", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    ArrayList Mes = new ArrayList();
                    ArrayList Monto = new ArrayList();

                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();

                    while (reader.Read())
                    {

                        Mes.Add(reader.GetString(0));
                        Monto.Add(reader.GetInt32(1));
                    }
                    ChartVentasDiarias.Series[0].Points.DataBindXY(Mes, Monto);
                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en el grafico: Ventas Mensuales");
            }
        }


        private void Ventas_Anuales()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("FN_MOSTRAR_VENTAS_ANUALES", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    ArrayList Mes = new ArrayList();
                    ArrayList Monto = new ArrayList();

                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();

                    while (reader.Read())
                    {

                        Mes.Add(reader.GetString(0));
                        Monto.Add(reader.GetInt32(1));
                    }
                    ChartVentasAnuales.Series[0].Points.DataBindXY(Mes, Monto);
                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en el grafico: Ventas Mensuales");
            }
        }

        private void Total_Dia()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string query = "select sum(total) as cantidad  from boleta where to_char(fecha_hora, 'Day-dd-Mon-yyyy') = to_char(sysdate, 'Day-dd-Mon-yyyy') group by to_char(fecha_hora, 'Day-dd-Mon-yyyy') ";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                LblTotal.Text = "$ " + reg["cantidad"].ToString();

            }
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
        }

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
                printer = reg1["impresora"].ToString();

            }
            else
            {
                printer = "0";
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            string message = "¿Estas seguro de imprimir el reporte?.";
            string caption = "Impresion de reporte";
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
                ticket.AddHeaderLine("VENTAS TOTALES DE HOY : " + LblTotal.Text);

                ticket.AddSubHeaderLine("Fecha: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

                ticket.AddSubHeaderLine("VENTAS ANUALES.");
                ticket.AddSubHeaderLine("Año.      Monto.");

                foreach (DataGridViewRow row in DtVentasAnuales.Rows)
                {
                    string ano = row.Cells[0].Value.ToString();
                    string mont = row.Cells[1].Value.ToString();
                    ticket.AddSubHeaderLine("" + ano + "   " + "    " + mont + "   ");

                }
                ticket.AddSubHeaderLine(" ");
                ticket.AddSubHeaderLine(" ");
                ticket.AddSubHeaderLine(" ");
                ticket.AddSubHeaderLine("VENTAS MENSUALES.");
                ticket.AddSubHeaderLine("MES.         MONTO.");
                foreach (DataGridViewRow row1 in DtVentasMensuales.Rows)
                {

                    string Mess = row1.Cells[0].Value.ToString();
                    string Mont = row1.Cells[1].Value.ToString();
                    ticket.AddSubHeaderLine("" + Mess + "   " + "   " + Mont + "   ");

                }

                ticket.AddSubHeaderLine(" ");
                ticket.AddSubHeaderLine(" ");
                ticket.AddSubHeaderLine(" ");
                ticket.AddSubHeaderLine("VENTAS DIARIAS (MES).");
                ticket.AddSubHeaderLine("DIA.         MONTO.");
                foreach (DataGridViewRow row1 in DtVentasDiarias.Rows)
                {

                    string Mess = row1.Cells[0].Value.ToString();
                    string Mont = row1.Cells[1].Value.ToString();
                    ticket.AddSubHeaderLine("" + Mess + "   " + "   " + Mont + "   ");

                }


                ticket.AddFooterLine("Asegurese de crear reportes periodicamente");

                ticket.PrintTicket(printer); //Nombre de la impresora de tickets

            }
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Reporte ventas Num " + string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.Plantilla_Reporte_Ventas.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NombreEmpresa", Nombre);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Direccion", Direccion);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Comuna", Comuna);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Region", Region1);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Fono", Fono);

            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", CacheInicioSesion.Nombres + " " + CacheInicioSesion.Apellidos);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            foreach (DataGridViewRow row in DtVentasAnuales.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            string filas1 = string.Empty;
            foreach (DataGridViewRow row1 in DtVentasMensuales.Rows)
            {
                filas1 += "<tr>";
                filas1 += "<td>" + row1.Cells[0].Value.ToString() + "</td>";
                filas1 += "<td>" + row1.Cells[1].Value.ToString() + "</td>";
                filas1 += "</tr>";
            }

            string filas2 = string.Empty;
            foreach (DataGridViewRow row2 in DtVentasDiarias.Rows)
            {
                filas2 += "<tr>";
                filas2 += "<td>" + row2.Cells[0].Value.ToString() + "</td>";
                filas2 += "<td>" + row2.Cells[1].Value.ToString() + "</td>";
                filas2 += "</tr>";
            }

            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VENTASANUALES", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VENTASMENSUALES", filas1);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VENTASDIARIAS", filas2);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VENTADIA", LblTotal.Text);


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



                }

            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
