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


namespace Diseño.Administrador
{
    public partial class productos : Form
    {

        public string v_cbx_filtro;
        public string v_cbx_tipo;


        public productos()
        {

            InitializeComponent();
            limpiar_formulario();
            CargarGrilla();
            DtPreparaciones.ReadOnly = true;
            Esconder_Elementos();


            DtPreparaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void productos_Load(object sender, EventArgs e)
        {
            CbxFiltro.DisplayMember = "categoria";
            CbxFiltro.ValueMember = "id_categoria";

            CbxTipoPlato.DataSource = Datos();
            CbxTipoPlato.DisplayMember = "categoria";
            CbxTipoPlato.ValueMember = "id_categoria";
        }


        public DataTable Datos()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select id_categoria, categoria from categoria";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);
            return dt;
        }


        private void Esconder_Elementos()
        {
            BtnModificar_Preparacion.Visible = false;
            BtnVolver.Visible = false;
            BtnEliminar.Visible = false;

        }

       
        private void BtnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    PicFotoPlato.Image = Image.FromFile(imagen);

                  
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

     
        private void limpiar_formulario()
        {
            TxtNombrePlato.Text = "";
            TxtDescPlato.Text = "";
            TxtPrecio.Text = "";
            CbxTipoPlato.Text = "-Seleccione un tipo de plato-";
            TxtTiempo.Text = "";
            CbxDisponibilidad.Text = "-- Seleccione si esta disponible el plato --";
            if (PicFotoPlato.Image != null)
            {
                PicFotoPlato.Image.Dispose();
                PicFotoPlato.Image = null;
            }
        }

     
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            string message = "¿Estas seguro de agregar el plato?.";
            string caption = "Añadir nuevo plato.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            try
            {

                if (CbxTipoPlato.SelectedIndex == 0)
                {
                    string message1 = "Debe Seleccionar una categoria.";
                    string title = "Error al agregar preparacion.";
                    MessageBox.Show(message1, title);
                }
                else
                {
                    if (PicFotoPlato.Image == null)
                    {
                        string message1 = "Debe Seleccionar una imagen.";
                        string title = "Error al agregar preparacion.";
                        MessageBox.Show(message1, title);
                    }
                    else
                    {
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {

                            string destino = @"C:\Sistema gestion\Imagenes oracle\Imagenes_preparaciones\" + TxtNombrePlato.Text + ".Jpeg";
                            PicFotoPlato.Image.Save(destino, ImageFormat.Jpeg);


                            using (OracleCommand command = new OracleCommand("INSERTAR_MENU", conn))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("V_NOMBRE", OracleDbType.Varchar2).Value = TxtNombrePlato.Text;
                                command.Parameters.Add("V_DESCRIPCION", OracleDbType.Varchar2).Value = TxtDescPlato.Text;
                                command.Parameters.Add("V_TIEMPO", OracleDbType.Int32).Value = TxtTiempo.Text;
                                command.Parameters.Add("V_VALOR", OracleDbType.Int32).Value = TxtPrecio.Text;
                                command.Parameters.Add("V_DISPONIBILIDAD", OracleDbType.Varchar2).Value = CbxDisponibilidad.Text;
                                command.Parameters.Add("V_ID_CATEGORIA", OracleDbType.Int32).Value = v_cbx_tipo;
                                command.Parameters.Add("V_IMAGEN", OracleDbType.Varchar2).Value = destino;



                                command.ExecuteNonQuery();
                                limpiar_formulario();
                            }

                            CargarGrilla();
                        }
                        CbxTipoPlato.SelectedIndex = 0;
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Porfavor complete todos los campos para agregar el producto: " + ex, "Error al agregar producto.");
            }







        }

        
        private void CargarGrilla()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("FN_MOSTRAR_PREPARACIONES", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    List<CachePreparaciones> lista = new List<CachePreparaciones>();

                    OracleParameter output = command.Parameters.Add("L_CURSOR", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();

                    while (reader.Read())
                    {
                        CachePreparaciones caus = new CachePreparaciones();

                        caus.Id_plato = reader.GetInt32(0);
                        caus.Nombre_Plato = reader.GetString(1);
                        caus.Descripcion = reader.GetString(2);
                        caus.Tiempo_Preparacion = reader.GetInt32(3);
                        caus.Valor = reader.GetInt32(4);
                        caus.Disponibilidad = reader.GetString(5);
                        caus.Id_tipo_preparacion = reader.GetInt32(6);
                        caus.Categoria = reader.GetString(7);



                        lista.Add(caus);
                    }
                    DtPreparaciones.DataSource = lista;
                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }

        
        private void BtnModificar_Preparacion_Click(object sender, EventArgs e)
        {

            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string message = "¿Estas seguro de modificar la preparacion?.";
            string caption = "Modificar preparacion.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            try
            {
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (CbxDisponibilidad.Text == "-- Seleccione si esta disponible el plato --")
                    {
                        string message1 = "Debe Seleccionar disponibilidad del plato.";
                        string title = "Error al modificar plato.";
                        MessageBox.Show(message1, title);
                    }
                    else
                    {
                        if (CbxTipoPlato.SelectedIndex == 0)
                        {
                            string message1 = "Debe Seleccionar una categoria.";
                            string title = "Error al modificar plato.";
                            MessageBox.Show(message1, title);
                        }
                        else
                        {
                            using (OracleCommand command = new OracleCommand("MODIFICAR_PREPARACION", conn))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("V_ID_PLATO", OracleDbType.Int32).Value = TxtId_Plato.Text;
                                command.Parameters.Add("V_NOMBRE", OracleDbType.Varchar2).Value = TxtNombrePlato.Text;
                                command.Parameters.Add("V_DESCRIPCION", OracleDbType.Varchar2).Value = TxtDescPlato.Text;
                                command.Parameters.Add("V_TIEMPO", OracleDbType.Int32).Value = TxtTiempo.Text;
                                command.Parameters.Add("V_VALOR", OracleDbType.Int32).Value = TxtPrecio.Text;
                                command.Parameters.Add("V_DISP", OracleDbType.Varchar2).Value = CbxDisponibilidad.Text;
                                command.Parameters.Add("V_ID_CAT", OracleDbType.Int32).Value = v_cbx_tipo;



                                command.ExecuteNonQuery();

                                limpiar_formulario();
                                BtnImagen.Visible = true;
                                CargarGrilla();
                                BtnEliminar.Visible = false;
                                BtnVolver.Visible = false;
                                BtnAgregarProducto.Visible = true;
                                BtnModificar_Preparacion.Visible = false;

                                BtnImagen.Visible = true;
                                CbxTipoPlato.Text = "-Seleccione un tipo de plato-";
                                CbxDisponibilidad.Text = "-- Seleccione si esta disponible el plato --";
                            }
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Porfavor complete todos los campos: " + er.Message, "Error al modificar producto.");
            }

        }

 
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            string message = "¿Estas seguro de no modificar la preparacion?.";
            string caption = "Modificacion de preparacion.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                BtnImagen.Visible = true;
                limpiar_formulario();
                BtnAgregarProducto.Visible = true;
                BtnModificar_Preparacion.Visible = false;
                BtnVolver.Visible = false;
                BtnImagen.Visible = true;
                BtnEliminar.Visible = false;
                CbxTipoPlato.SelectedIndex = 0;

            }



        }

        private void DtPreparaciones_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string message = "¿Estas seguro de eliminar la preparacion?.";
            string caption = "Eliminar preparacion.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                using (OracleCommand command = new OracleCommand("ELIMINAR_PREPARACION", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("V_ID", OracleDbType.Int32).Value = TxtId_Plato.Text;
                    command.ExecuteNonQuery();
                    limpiar_formulario();
                    BtnEliminar.Visible = false;
                    CargarGrilla();
                }
            }
        }

       
        private void BtnRecargarGrilla_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CbxFiltro_TextChanged(object sender, EventArgs e)
        {
            v_cbx_filtro = CbxFiltro.SelectedIndex.ToString();
        }

        
        private void CbxTipoPlato_TextChanged(object sender, EventArgs e)
        {
            v_cbx_tipo = CbxTipoPlato.SelectedIndex.ToString();
        }

        private void DtPreparaciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void CbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxFiltro.SelectedIndex == 0)
            {
                CargarGrilla();
            }
            else
            {

                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();

                OracleDataAdapter adaptador = new OracleDataAdapter("select pl.id_plato,pl.nombre_plato,pl.descripcion,pl.tiempopreparacion,pl.valor_plato,pl.disponibilidad,pl.id_categoria,ca.categoria from plato pl join categoria ca on pl.id_categoria = ca.id_categoria where pl.id_categoria LIKE '%" + CbxFiltro.SelectedIndex + "%'", conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DtPreparaciones.DataSource = tabla;
                conn.Close();
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CbxDisponibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DtPreparaciones_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BtnEliminar.Visible = true;
            BtnModificar_Preparacion.Visible = true;
            BtnAgregarProducto.Visible = false;
            BtnVolver.Visible = true;
            BtnImagen.Visible = false;

            int FilaActual;
            FilaActual = DtPreparaciones.CurrentRow.Index;

            string id;
            id = DtPreparaciones.Rows[FilaActual].Cells[0].Value.ToString();
            TxtId_Plato.Text = id;

            string nombre;
            nombre = DtPreparaciones.Rows[FilaActual].Cells[1].Value.ToString();
            TxtNombrePlato.Text = nombre;

            string descripcion_plato;
            descripcion_plato = DtPreparaciones.Rows[FilaActual].Cells[2].Value.ToString();
            TxtDescPlato.Text = descripcion_plato;

            string tiempo;
            tiempo = DtPreparaciones.Rows[FilaActual].Cells[3].Value.ToString();
            TxtTiempo.Text = tiempo;

            string precio;
            precio = DtPreparaciones.Rows[FilaActual].Cells[4].Value.ToString();
            TxtPrecio.Text = precio;

            string disponibilidad;
            disponibilidad = DtPreparaciones.Rows[FilaActual].Cells[5].Value.ToString();
            CbxDisponibilidad.Text = disponibilidad;

            string Tipo_Plato;
            int Tipo_plato1;
            Tipo_Plato = DtPreparaciones.Rows[FilaActual].Cells[6].Value.ToString();
            Tipo_plato1 = Int32.Parse(Tipo_Plato);
            CbxTipoPlato.SelectedIndex = Tipo_plato1;



            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();
            string ruta;
            string query = "select imagen from plato where id_plato =" + TxtId_Plato.Text;
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();
            try
            {
                if (reg.Read())
                {
                    ruta = reg["imagen"].ToString();
                    PicFotoPlato.Image = Image.FromFile(@"" + ruta);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encuentra la imagen del producto en la ruta: " + ex.Message, "Error al cargar imagen del producto: " + nombre);
            }

        }

        private void CbxFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            v_cbx_filtro = CbxFiltro.SelectedIndex.ToString();
        }

        private void BtnModificar_Preparacion_Click_1(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string message = "¿Estas seguro de modificar la preparacion?";
            string caption = "Modificar la preparacion.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            try

            {
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    if (CbxDisponibilidad.Text == "--Seleccione si esta disponible el plato --")
                    {
                        string message1 = "Debe Selecciona disponibilidad del plato.";
                        string title = "Error al modificar plato.";
                        MessageBox.Show(message1, title);

                    }
                    else
                    {
                        if (CbxTipoPlato.SelectedIndex == 0)
                        {
                            string message1 = "Debe Seleccionar una categoria.";
                            string title = "Error al modificar plato.";
                            MessageBox.Show(message1, title);

                        }
                        else
                        {
                            using (OracleCommand command = new OracleCommand("MODIFICAR_PREPARACION", conn))
                            {


                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("V_ID_PLATO", OracleDbType.Int32).Value = TxtId_Plato.Text;
                                command.Parameters.Add("V_NOMBRE", OracleDbType.Varchar2).Value = TxtNombrePlato.Text;
                                command.Parameters.Add("V_DESCRIPCION", OracleDbType.Varchar2).Value = TxtDescPlato.Text;
                                command.Parameters.Add("V_TIEMPO", OracleDbType.Int32).Value = TxtTiempo.Text;
                                command.Parameters.Add("V_VALOR", OracleDbType.Int32).Value = TxtPrecio.Text;
                                command.Parameters.Add("V_DISP", OracleDbType.Varchar2).Value = CbxDisponibilidad.Text;
                                command.Parameters.Add("V_ID_CAT", OracleDbType.Int32).Value = v_cbx_tipo;

                                command.ExecuteNonQuery();


                                limpiar_formulario();
                                BtnImagen.Visible = true;
                                CargarGrilla();
                                BtnEliminar.Visible = false;
                                BtnVolver.Visible = false;
                                BtnAgregarProducto.Visible = true;
                                BtnModificar_Preparacion.Visible = false;

                                BtnImagen.Visible = true;
                                CbxTipoPlato.Text = "-Seleccione un tipo de plato-";
                                CbxDisponibilidad.Text = "-- Seleccione si esta disponible el plato --";

                            }
                        }

                    }

                }
            }
            catch (Exception er)
            {

                MessageBox.Show("Por favor complete todos los campos:" + er.Message, "Error al modificar el producto.");
            }




        }

        private void BtnRecargarGrilla_Click_1(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
