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
using LibPrintTicket;

namespace Diseño.Reportes
{
    public partial class Reporte_stock : MaterialForm
    {
        public Reporte_stock()
        {
            InitializeComponent();

            Cargar_Critico();
            Cargar_Vencidos();
            Datos_Stock_Cantidad();
            Datos_Stock_critico();
            Impresora();
            Datos_empresa();
            Impresora();


            Dtcritico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dtcritico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtVencido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void Cargar_Critico()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("FN_REPORTE_STOCK_BAJO", conn))
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
                        Dtcritico.DataSource = tabla;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }






        private void Cargar_Vencidos()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("FN_REPORTE_STOCK_VENCIDO", conn))
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
                        DtVencido.DataSource = tabla;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }




        private void Datos_Stock_Vencido()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string query = "SELECT count(id_producto) as cantidad FROM PRODUCTO WHERE fecha_vencimiento < sysdate";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                NumVencidos.Text = reg["cantidad"].ToString();

            }

        }
        private void Datos_Stock_critico()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string query = "SELECT Count(id_producto) as cantidad FROM PRODUCTO WHERE STOCK < stock_critico";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                NumCritico.Text = reg["cantidad"].ToString();

            }
        }

        private void Datos_Stock_Cantidad()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string query = "SELECT Sum(stock) as cantidad FROM PRODUCTO";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                NumDisponible.Text = reg["cantidad"].ToString();

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


        private void Reporte_stock_Load(object sender, EventArgs e)
        {

        }


        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Reporte Stock Num " + string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.Plantilla_Reporte_Stock.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NombreEmpresa", Nombre);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Direccion", Direccion);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Comuna", Comuna);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Region", Region1);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Fono", Fono);

            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", CacheInicioSesion.Nombres + " " + CacheInicioSesion.Apellidos);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            foreach (DataGridViewRow row in Dtcritico.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[2].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[3].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            string filas1 = string.Empty;
            foreach (DataGridViewRow row1 in DtVencido.Rows)
            {
                filas1 += "<tr>";
                filas1 += "<td>" + row1.Cells[0].Value.ToString() + "</td>";
                filas1 += "<td>" + row1.Cells[1].Value.ToString() + "</td>";
                filas1 += "<td>" + row1.Cells[2].Value.ToString() + "</td>";
                filas1 += "<td>" + row1.Cells[3].Value.ToString() + "</td>";
                filas1 += "</tr>";
            }

            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILASCRITICO", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILASVENCIDO", filas1);


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
               // ticket.HeaderImage = Properties.Resources.impresora;
                ticket.AddHeaderLine(Nombre);
                ticket.AddHeaderLine("Direccion: " + Direccion);
                ticket.AddHeaderLine("Comuna: " + Comuna);
                ticket.AddHeaderLine("Región: " + Region1);
                ticket.AddHeaderLine("Fono: " + Fono);
                ticket.AddHeaderLine("");
                ticket.AddHeaderLine("Productos Vencidos : " + NumVencidos.Text);
                ticket.AddHeaderLine("Productos Criticos: " + NumCritico.Text);
                ticket.AddHeaderLine("Productos Disponibles: " + NumDisponible.Text);

                ticket.AddSubHeaderLine("Fecha: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

                ticket.AddSubHeaderLine("Productos Criticos.");
                ticket.AddSubHeaderLine("Nombre.     StockAct.     StockCri.");
                foreach (DataGridViewRow row in Dtcritico.Rows)
                {
                    string cantidad = row.Cells[1].Value.ToString();
                    string desc = row.Cells[2].Value.ToString();
                    string valor = row.Cells[3].Value.ToString();
                    ticket.AddSubHeaderLine("" + cantidad + "   " + "   " + desc + "" + "   " + valor + "");

                }
                ticket.AddSubHeaderLine(" ");
                ticket.AddSubHeaderLine(" ");
                ticket.AddSubHeaderLine(" ");
                ticket.AddSubHeaderLine("Productos Vencidos.");
                ticket.AddSubHeaderLine("Nombre.     StockAct.     StockCri.");
                foreach (DataGridViewRow row1 in DtVencido.Rows)
                {

                    string cantidad1 = row1.Cells[1].Value.ToString();
                    string desc1 = row1.Cells[2].Value.ToString();
                    string valor1 = row1.Cells[3].Value.ToString();
                    ticket.AddSubHeaderLine("" + cantidad1 + "   " + "   " + desc1 + "" + "   " + valor1 + "");

                }


                ticket.AddFooterLine("Revise Constantemente el stock.");

                ticket.PrintTicket(printer); //Nombre de la impresora de tickets

            }
        

        
       

            }


        } 
}
