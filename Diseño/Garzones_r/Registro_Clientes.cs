using Capa_Transversal;
using Modelo_Negocio;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño.Garzones_r
{
    public partial class Registro_Clientes : Form
    {
        public Registro_Clientes()
        {
            InitializeComponent();
            CargarGrilla();
        }




        private void Dtclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void DtClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void DtClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LblTitulo.Text = "EDICION DE USUARIOS.";
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
            email = DtClientes.Rows[FilaActual].Cells[6].Value.ToString();
            TxtEmail.Text = email;

            string fono;
            fono = DtClientes.Rows[FilaActual].Cells[7].Value.ToString();
            TxtFono.Text = fono;

       
            string direccion;
            direccion = DtClientes.Rows[FilaActual].Cells[8].Value.ToString();
            TxtDireccion.Text = direccion ;



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


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            PnlFormulario.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PnlFormulario.Visible = true;
            PnlFormulario.Visible = true;
            LblTitulo.Text = "AÑADIR USUARIO";
            BtnGuardarCambios.Visible = false;
            BtnGuardar.Visible = true;
            limpiar_formulario();
        }



        public void limpiar_formulario()
        {
            TxtID.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtRut.Text = "";
        //    TxtUsuario.Text = "";
        //    TxtContrasena.Text = "";
            TxtFono.Text = "";
            TxtEmail.Text = "";
            TxtDireccion.Text = "";

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
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
                tableLayoutPanel1.Visible = false;
                DtClientes.Visible = true;
                CargarGrilla();
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
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

                using (OracleCommand command = new OracleCommand("MODIFICACION_CLIENTES", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("V_IDCLIENTE", OracleDbType.Int32).Value = TxtID.Text;
                    command.Parameters.Add("V_DIRECCION", OracleDbType.Varchar2).Value = TxtDireccion.Text;

                    command.ExecuteNonQuery();
                }

                tableLayoutPanel1.Visible = false;
                CargarGrilla();
                limpiar_formulario();
            }

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            DtEliminados.Visible = false;
            DtClientes.Visible = true;
           
            BtnVolver.Visible = false;
            CargarGrilla();
            limpiar_formulario();
            PnlFormulario.Visible = false;
        }

        private void TxtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            string busqueda = (CultureInfo.InvariantCulture.TextInfo.ToTitleCase(TxtBuscar.Text.ToLower()));

            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            OracleDataAdapter adaptador = new OracleDataAdapter("select us.id_usuario,us.nombres,us.apellidos,us.rut,us.email,us.fono, cli.direccion,to_char(us.fecha_creacion, 'dd-mm-yyyy hh24:mi:ss') as Fecha_creacion,to_char(us.fecha_modificacion, 'dd-mm-yyyy hh24:mi:ss') as Fecha_modificacion FROM usuario US JOIN ROL RO ON US.ID_ROL = RO.ID_ROL JOIN CLIENTE CLI ON US.ID_USUARIO=cli.id_usuario where us.estado = 'Activo' and us.id_rol = 7 and us.nombres LIKE '%" + busqueda + "%'", conn);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DtClientes.DataSource = tabla;
            conn.Close();
        }
    }
    }

