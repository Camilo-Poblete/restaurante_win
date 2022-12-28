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

namespace Diseño.Garzones_r
{
    public partial class Registro_Cliente : Form
    {
        public Registro_Cliente()
        {
            InitializeComponent();
            CargarGrilla();
            DtClientes.Visible = true;
            PnlFormulario.Visible = true;
            TlpnlFormulario.Visible =true;

            DtClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void CargarGrilla()
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("FN_MOSTRAR_DATOS_CLIENTE", conn))
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
                        DtClientes.DataSource = tabla;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }

        public void limpiar_formulario()
        {
       
        }

        public class Rut
        {
            public String formatear(String rut)
            {
                int cont = 0;
                String format;
                if (rut.Length == 0)
                {
                    return "";
                }
                else
                {
                    rut = rut.Replace(".", "");
                    rut = rut.Replace("-", "");
                    format = "-" + rut.Substring(rut.Length - 1);
                    for (int i = rut.Length - 2; i >= 0; i--)
                    {

                        format = rut.Substring(i, 1) + format;

                        cont++;
                        if (cont == 3 && i != 0)
                        {
                            format = "." + format;
                            cont = 0;
                        }
                    }
                    return format;
                }
            }



            private void CargarGrilla()
            {
                try
                {
                    Acceso ac = new Acceso();
                    var conn = ac.Conectar();
                    conn.Open();
                    using (var command = new OracleCommand("FN_MOSTRAR_DATOS_CLIENTE", conn))
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
                           
                        }

                    }
                }
                catch
                {
                    MessageBox.Show("Error al mostrar datos en la grilla");
                }
            }
        }


       

        private void BtnGuardar_Click_2(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            string message = "¿Estas seguro de agregar el cliente?.";
            string caption = "Añadir Cliente.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                using (OracleCommand command = new OracleCommand("INSERTAR_CLIENTE_USUARIO", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("V_NOMBRE", OracleDbType.Varchar2).Value = TxtNombre.Text;
                    command.Parameters.Add("V_APELLIDO", OracleDbType.Varchar2).Value = TxtApellido.Text;
                    command.Parameters.Add("V_RUT", OracleDbType.Varchar2).Value = TxtRut.Text;
                    command.Parameters.Add("V_EMAIL", OracleDbType.Varchar2).Value = TxtEmail.Text;
                    command.Parameters.Add("V_FONO", OracleDbType.Varchar2).Value = TxtFono.Text;


                    command.ExecuteNonQuery();


                }

                DataTable dt = new DataTable();
                string query = "SELECT ID_USUARIO FROM USUARIO WHERE id_rol = 7 AND NOMBRES||' '||APELLIDOS = '" + TxtNombre.Text + " " + TxtApellido.Text + "'";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);

                CbxId.DataSource = dt;
                CbxId.DisplayMember = "ID_USUARIO";
                CbxId.ValueMember = "ID_USUARIO";

                using (OracleCommand cmd1 = new OracleCommand("INSERTAR_CLIENTE", conn))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("V_DIRECCION", OracleDbType.Varchar2).Value = TxtDireccion.Text;
                    cmd1.Parameters.Add("V_ID_USUARIO", OracleDbType.Int32).Value = CbxId.SelectedValue.ToString();

                    cmd1.ExecuteNonQuery();

                }

                limpiar_formulario();
                TlpnlFormulario.Visible = false;
                DtClientes.Visible = true;
                CargarGrilla();
            }
        }
    

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAñadir_Click_1(object sender, EventArgs e)
        {

        }

        private void DtClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PnlFormulario.Visible = false;
            TlpnlFormulario.Visible = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DtClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            BtnGuardarCambios.Visible = true;
            BtnGuardar.Visible = false;
            PnlFormulario.Visible = true;
            PnlFormulario.Visible = true;
            int FilaActual;
            FilaActual = DtClientes.CurrentRow.Index;

            string id;
            id = DtClientes.Rows[FilaActual].Cells[0].Value.ToString();
            TxtID.Text = id;

            string nombre;
            nombre = DtClientes.Rows[FilaActual].Cells[1].Value.ToString();
            TxtNombre.Text = nombre;

            string apellido;
            apellido = DtClientes.Rows[FilaActual].Cells[2].Value.ToString();
            TxtApellido.Text = apellido;

            string rut;
            rut = DtClientes.Rows[FilaActual].Cells[3].Value.ToString();
            TxtRut.Text = rut;

            string email;
            email = DtClientes.Rows[FilaActual].Cells[4].Value.ToString();
            TxtEmail.Text = email;

            string fono;
            fono = DtClientes.Rows[FilaActual].Cells[5].Value.ToString();
            TxtFono.Text = fono;

            string direccion;
            direccion = DtClientes.Rows[FilaActual].Cells[6].Value.ToString();
            TxtDireccion.Text = direccion;
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnGuardarCambios_Click_1(object sender, EventArgs e)
        {
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();

                string message = "¿Estas seguro de modificar el cliente?.";
                string caption = "Modificacion de cliente.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    using (OracleCommand command = new OracleCommand("MODIFICAR_CLIENTES", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("v_id", OracleDbType.Int32).Value = TxtID.Text;
                        command.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = TxtNombre.Text;
                        command.Parameters.Add("v_apellido", OracleDbType.Varchar2).Value = TxtApellido.Text;
                        command.Parameters.Add("v_rut", OracleDbType.Varchar2, 12).Value = TxtRut.Text;
                        command.Parameters.Add("v_email", OracleDbType.Varchar2).Value = TxtEmail.Text;
                        command.Parameters.Add("v_fono", OracleDbType.Varchar2).Value = TxtFono.Text;

                        command.ExecuteNonQuery();
                    }

                    using (OracleCommand command = new OracleCommand("MODIFICAR_CLIENTES_ClIENTE", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("v_id", OracleDbType.Int32).Value = TxtID.Text;
                        command.Parameters.Add("v_direccion", OracleDbType.Varchar2).Value = TxtDireccion.Text;

                        command.ExecuteNonQuery();
                    }

                    TlpnlFormulario.Visible = false;
                    CargarGrilla();
                    limpiar_formulario();
                }


            }
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            PnlFormulario.Visible = true;
            DtClientes.Visible = true;
            TlpnlFormulario.Visible = false;
        }

        private void DtClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click_2(object sender, EventArgs e)
        {
            PnlFormulario.Visible = true;
            DtClientes.Visible = true;
            TlpnlFormulario.Visible = false;
        }

        private void BtnGuardarCambios_Click_2(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string message = "¿Estas seguro de modificar el cliente?.";
            string caption = "Modificacion de cliente.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                using (OracleCommand command = new OracleCommand("MODIFICAR_CLIENTES", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("v_id", OracleDbType.Int32).Value = TxtID.Text;
                    command.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = TxtNombre.Text;
                    command.Parameters.Add("v_apellido", OracleDbType.Varchar2).Value = TxtApellido.Text;
                    command.Parameters.Add("v_rut", OracleDbType.Varchar2, 12).Value = TxtRut.Text;
                    command.Parameters.Add("v_email", OracleDbType.Varchar2).Value = TxtEmail.Text;
                    command.Parameters.Add("v_fono", OracleDbType.Varchar2).Value = TxtFono.Text;

                    command.ExecuteNonQuery();
                }

                using (OracleCommand command = new OracleCommand("MODIFICAR_CLIENTES_ClIENTE", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("v_id", OracleDbType.Int32).Value = TxtID.Text;
                    command.Parameters.Add("v_direccion", OracleDbType.Varchar2).Value = TxtDireccion.Text;

                    command.ExecuteNonQuery();
                }

                TlpnlFormulario.Visible = false;
                CargarGrilla();
                limpiar_formulario();
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

      
    }

