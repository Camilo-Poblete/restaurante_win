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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            Esconder_Elementos();
            Cargar_Grilla();
            DtStock.ReadOnly = true;
            DtStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void Esconder_Elementos()
        {
            BtnModificar.Visible = false;
            BtnVolver.Visible = false;
            BtnAgregarCategoria.Visible = false;
        }

        string v_categoria;


        private void Stock_Load(object sender, EventArgs e)
        {
            CbxCategoria.DataSource = Datos();
            CbxCategoria.DisplayMember = "familia";
            CbxCategoria.ValueMember = "id_familia";
        }

   
        private void BtnCategoria_Click(object sender, EventArgs e)
        {

        }




        private void Cargar_Grilla()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("fn_mostrar_stock", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    List<CacheStock> lista = new List<CacheStock>();

                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();

                    while (reader.Read())
                    {
                        CacheStock caus = new CacheStock();

                        caus.Id_Producto = reader.GetInt32(0);
                        caus.Nombre = reader.GetString(1);
                        caus.Descripcion = reader.GetString(2);
                        caus.Fecha_Vencimiento = reader.GetString(3);
                        caus.Stock = reader.GetInt32(4);
                        caus.Stock_Critico = reader.GetInt32(5);
                        caus.Id_Familia = reader.GetInt32(6);
                        caus.Familia = reader.GetString(7);



                        lista.Add(caus);
                    }
                    DtStock.DataSource = lista;
                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }




        public DataTable Datos()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select id_familia,familia from familiaproducto order by id_familia asc";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);
            return dt;
        }

        private void BtnCategoria_Click_1(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            string message = "¿Estas seguro de agregar el producto?.";
            string caption = "Añadir nuevo producto.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            try
            {
                if (CbxCategoria.SelectedIndex == 0)
                {
                    string message1 = "Debe Seleccionar una categoria.";
                    string title = "Error al agregar producto.";
                    MessageBox.Show(message1, title);
                }
                else
                {
                    if (PicImagen.Image == null)
                    {
                        string message1 = "Debe Seleccionar una imagen.";
                        string title = "Error al agregar producto.";
                        MessageBox.Show(message1, title);
                    }
                    else
                    {
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {

                            string destino = @"C:\Users\camil\Downloads\Windows Forms Version Final\Sistema de gestion\Imagenes_Oracle\Imagenes_Stock" + TxtNombre.Text + ".Jpeg";
                            PicImagen.Image.Save(destino, ImageFormat.Jpeg);

                            using (OracleCommand command = new OracleCommand("INSERTAR_STOCK", conn))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("V_NOMBRE", OracleDbType.Varchar2).Value = TxtNombre.Text;
                                command.Parameters.Add("V_DESCRIPCION", OracleDbType.Varchar2).Value = TxtDescripcion.Text;
                                command.Parameters.Add("V_FECHA", OracleDbType.Varchar2).Value = DtpFecha.Text;
                                command.Parameters.Add("V_STOCK", OracleDbType.Int32).Value = TxtStock.Text;
                                command.Parameters.Add("V_STOCK_CRITICO", OracleDbType.Int32).Value = TxtStockCritico.Text;
                                command.Parameters.Add("V_ID_FAMILIA", OracleDbType.Int32).Value = v_categoria;
                                command.Parameters.Add("V_IMAGEN", OracleDbType.Varchar2).Value = destino;

                                command.ExecuteNonQuery();
                                conn.Close();
                                Limpiar_formulario();

                                Cargar_Grilla();
                                CbxCategoria.SelectedIndex = 0;
                            }


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Porfavor complete todos los campos: " + ex, "Error al insertar STOCK.");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            try
            {
                using (OracleCommand command = new OracleCommand("modificar_stock", conn))
                {
                    if (CbxCategoria.SelectedIndex == 0)
                    {
                        string message1 = "Debe Seleccionar una categoria.";
                        string title = "Error al modificar stock.";
                        MessageBox.Show(message1, title);
                    }
                    else
                    {
                        string message = "¿Estas seguro de modificar el stock?.";
                        string caption = "Modificacion de stock.";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("V_ID", OracleDbType.Int32).Value = TxtID.Text;
                            command.Parameters.Add("V_NOMBRE", OracleDbType.Varchar2).Value = TxtNombre.Text;
                            command.Parameters.Add("V_DESCRIPCION", OracleDbType.Varchar2).Value = TxtDescripcion.Text;
                            command.Parameters.Add("V_FECHA", OracleDbType.Varchar2, 12).Value = DtpFecha.Text;
                            command.Parameters.Add("V_STOCK", OracleDbType.Varchar2).Value = TxtStock.Text;
                            command.Parameters.Add("V_STOCK_CRITICO", OracleDbType.Varchar2).Value = TxtStockCritico.Text;
                            command.Parameters.Add("V_ID_FAM", OracleDbType.Varchar2).Value = CbxCategoria.SelectedIndex;


                            command.ExecuteNonQuery();
                            Cargar_Grilla();
                            Limpiar_formulario();
                            CbxCategoria.SelectedIndex = 0;
                            BtnAgregar.Visible = true;
                            BtnImagen.Visible = true;
                            BtnVolver.Visible = false;
                            BtnModificar.Visible = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Porfavor complete todos los campos: " + ex, "Error al modificar STOCK.");
            }
        }

        private void Limpiar_formulario()
        {
            TxtID.Text = "";
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            TxtStock.Text = "";
            TxtStockCritico.Text = "";
            CbxCategoria.SelectedIndex = 0;
            if (PicImagen.Image != null)
            {
                PicImagen.Image.Dispose();
                PicImagen.Image = null;
            }
        }

        private void CbxCategoria_TextChanged(object sender, EventArgs e)
        {
            v_categoria = CbxCategoria.SelectedIndex.ToString();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            string message = "¿Estas seguro de agregar el producto?.";
            string caption = "Añadir nuevo producto.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            try
            {
                if (CbxCategoria.SelectedIndex == 0)
                {
                    string message1 = "Debe Seleccionar una categoria.";
                    string title = "Error al agregar producto.";
                    MessageBox.Show(message1, title);
                }
                else
                {
                    if (PicImagen.Image == null)
                    {
                        string message1 = "Debe Seleccionar una imagen.";
                        string title = "Error al agregar producto.";
                        MessageBox.Show(message1, title);
                    }
                    else
                    {
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {

                            string destino = @"C:\Sistema gestion\Imagenes oracle\Imagenes stock" + TxtNombre.Text + ".Jpeg";
                            PicImagen.Image.Save(destino, ImageFormat.Jpeg);

                            using (OracleCommand command = new OracleCommand("INSERTAR_STOCK", conn))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("V_NOMBRE", OracleDbType.Varchar2).Value = TxtNombre.Text;
                                command.Parameters.Add("V_DESCRIPCION", OracleDbType.Varchar2).Value = TxtDescripcion.Text;
                                command.Parameters.Add("V_FECHA", OracleDbType.Varchar2).Value = DtpFecha.Text;
                                command.Parameters.Add("V_STOCK", OracleDbType.Int32).Value = TxtStock.Text;
                                command.Parameters.Add("V_STOCK_CRITICO", OracleDbType.Int32).Value = TxtStockCritico.Text;
                                command.Parameters.Add("V_ID_FAMILIA", OracleDbType.Int32).Value = v_categoria;
                                command.Parameters.Add("V_IMAGEN", OracleDbType.Varchar2).Value = destino;

                                command.ExecuteNonQuery();
                                conn.Close();
                                Limpiar_formulario();

                                Cargar_Grilla();
                                CbxCategoria.SelectedIndex = 0;
                            }


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Porfavor complete todos los campos: " + ex, "Error al insertar STOCK.");
            }



        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {

            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            string message = "¿Estas seguro de agregar la categoria?.";
            string caption = "Añadir nueva categoria.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(message, caption, buttons);

            if (TxtNombre.Text == "")
            {
                string message1 = "Debe asignar un nombre a la categoria.";
                string title = "Error al agregar categoria.";
                MessageBox.Show(message1, title);
            }
            else
            {
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    using (OracleCommand command = new OracleCommand("AGREGAR_CATEGORIA_STOCK", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("V_CATEGORIA", OracleDbType.Varchar2).Value = TxtNombre.Text;

                        command.ExecuteNonQuery();
                        conn.Close();
                        Limpiar_formulario();

                        Cargar_Grilla();
                        CbxCategoria.SelectedIndex = 0;

                        Limpiar_formulario();
                        BtnModificar.Visible = false;
                        BtnImagen.Visible = true;
                        BtnVolver.Visible = false;
                        BtnAgregar.Visible = true;

                        LblCategoria.Visible = true;
                        LblDescripcion.Visible = true;
                        LblFechaV.Visible = true;
                        LblStock.Visible = true;
                        LblStockCritico.Visible = true;
                        CbxCategoria.Visible = true;
                        TxtDescripcion.Visible = true;
                        DtpFecha.Visible = true;
                        TxtStock.Visible = true;
                        TxtStockCritico.Visible = true;
                        PicImagen.Visible = true;
                        BtnAgregar.Visible = true;
                        BtnImagen.Visible = true;
                        BtnCategoria.Visible = true;
                        BtnVolver.Visible = false;
                        BtnAgregarCategoria.Visible = false;
                        LblNombre.Text = "Nombre: ";
                        CbxCategoria.DataSource = Datos();

                    }
                }
            }

        }

        private void BtnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    PicImagen.Image = Image.FromFile(imagen);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen valido");
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Limpiar_formulario();
            BtnModificar.Visible = false;
            BtnImagen.Visible = true;
            BtnVolver.Visible = false;
            BtnAgregar.Visible = true;

            LblCategoria.Visible = true;
            LblDescripcion.Visible = true;
            LblFechaV.Visible = true;

            LblStock.Visible = true;
            LblStockCritico.Visible = true;
            CbxCategoria.Visible = true;
            TxtDescripcion.Visible = true;
            DtpFecha.Visible = true;
            TxtStock.Visible = true;
            TxtStockCritico.Visible = true;
            PicImagen.Visible = true;
            BtnAgregar.Visible = true;
            BtnImagen.Visible = true;
            BtnCategoria.Visible = true;
            BtnAgregarCategoria.Visible = false;
            LblNombre.Text = "Nombre: ";


        }

        private void DtStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StretchImage(object sender, EventArgs e)
        {

        }

        private void DtStock_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

                BtnModificar.Visible = true;
                BtnImagen.Visible = false;
                BtnVolver.Visible = true;
                BtnAgregar.Visible = false;
                int FilaActual;
                FilaActual = DtStock.CurrentRow.Index;

                string id;
                id = DtStock.Rows[FilaActual].Cells[0].Value.ToString();
                TxtID.Text = id;

                string nombre;
                nombre = DtStock.Rows[FilaActual].Cells[1].Value.ToString();
                TxtNombre.Text = nombre;

                string descripcion_plato;
                descripcion_plato = DtStock.Rows[FilaActual].Cells[2].Value.ToString();
                TxtDescripcion.Text = descripcion_plato;

                string fecha;
                fecha = DtStock.Rows[FilaActual].Cells[3].Value.ToString();
                DtpFecha.Text = fecha;

                string stock;
                stock = DtStock.Rows[FilaActual].Cells[4].Value.ToString();
                TxtStock.Text = stock;

                string stock_critico;
                stock_critico = DtStock.Rows[FilaActual].Cells[5].Value.ToString();
                TxtStockCritico.Text = stock_critico;

                string id_familia;
                int id_familia1;
                id_familia = DtStock.Rows[FilaActual].Cells[6].Value.ToString();
                id_familia1 = Int32.Parse(id_familia);
                CbxCategoria.SelectedIndex = id_familia1;

                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();

                string query = "select imagen from producto where id_producto = " + TxtID.Text;
                string ruta;
                OracleCommand command = new OracleCommand(query, conn);
                OracleDataReader reg = command.ExecuteReader();
                try
                {
                    if (reg.Read())
                    {
                        ruta = reg["imagen"].ToString();
                        PicImagen.Image = Image.FromFile(@"" + ruta);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede encontrar la imagen en la ruta: " + ex.Message, "Error al abrir imagen del stock: " + nombre);
                }
            }
        }
    }

