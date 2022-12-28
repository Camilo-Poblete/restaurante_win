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

namespace Diseño.Garzones_r
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            CargarGrilla();
            PnlFormulario.Visible = false;
            DtListaEmpleados.Visible = true;
            DtEliminados.Visible = false;
            DtListaEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            BtnVolver.Visible = false;
            CbxEstado.Text = "--SELECCIONE UN ESTADO--";
            DtEliminados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtListaEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public string v_rol_emp;



        private void Empleados_Load(object sender, EventArgs e)
        {
            CbxRol.DataSource = Datos();
            CbxRol.DisplayMember = "nombre_rol"; //campo que queres mostrar
            CbxRol.ValueMember = "id_rol"; //valor que capturas
        }

        //Listo
        public DataTable Datos()
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select id_rol, nombre_rol from rol";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);
            return dt;
        }

        //Listo
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
        }

        //Listo
        private void CargarGrilla()
        {
            DtListaEmpleados.Visible = true;
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("FN_MOSTRAR_DATOS", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    List<CacheLista> lista = new List<CacheLista>();

                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();

                    while (reader.Read())
                    {
                        CacheLista caus = new CacheLista();

                        caus.ID = reader.GetInt32(0);
                        caus.Nombres = reader.GetString(1);
                        caus.Apellidos = reader.GetString(2);
                        caus.Rut = reader.GetString(3);
                        caus.Login = reader.GetString(4);
                        caus.Clave = reader.GetString(5);
                        caus.Email = reader.GetString(6);
                        caus.Fono = reader.GetString(7);
                        caus.Rol_id = reader.GetInt32(8);
                        caus.Rol = reader.GetString(9);
                        caus.Estado = reader.GetString(10);
                        caus.Fecha_de_creacion = reader.GetString(11);
                        caus.Fecha_de_modificacion = reader.GetString(12);

                        lista.Add(caus);
                    }
                    DtListaEmpleados.DataSource = lista;
                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }

        //Listo
        private void CargarGrillaEliminados()
        {
            DtListaEmpleados.Visible = true;
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("fn_mostrar_datos_eliminados", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    List<CacheLista> lista = new List<CacheLista>();

                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();

                    while (reader.Read())
                    {
                        CacheLista caus = new CacheLista();

                        caus.ID = reader.GetInt32(0);
                        caus.Nombres = reader.GetString(1);
                        caus.Apellidos = reader.GetString(2);
                        caus.Rut = reader.GetString(3);
                        caus.Login = reader.GetString(4);
                        caus.Clave = reader.GetString(5);
                        caus.Email = reader.GetString(6);
                        caus.Fono = reader.GetString(7);
                        caus.Rol_id = reader.GetInt32(8);
                        caus.Rol = reader.GetString(9);
                        caus.Estado = reader.GetString(10);

                        lista.Add(caus);
                    }
                    DtListaEmpleados.DataSource = lista;
                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }

        //Listo
        private void DtListaEmpleados_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        //Listo
     
        //Listo
        public void limpiar_formulario()
        {
            TxtID.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtRut.Text = "";
            TxtUsuario.Text = "";
            TxtContrasena.Text = "";
            TxtFono.Text = "";
            TxtEmail.Text = "";
            CbxEstado.Text = "--SELECCIONE UN ESTADO--";
            CbxRol.SelectedIndex = 0;
        }

        //Listo
        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            PnlFormulario.Visible = true;
            PnlFormulario.Visible = true;
            LblTitulo.Text = "AÑADIR USUARIO";
            BtnGuardarCambios.Visible = false;
            BtnGuardar.Visible = true;
            limpiar_formulario();
        }

        //Listo
  

        // No terminado
        private void consultarDatos(string dato)
        {
            try
            {
                Acceso ac = new Acceso();
                var conn = ac.Conectar();
                conn.Open();
                using (var command = new OracleCommand("fn_busqueda_empleado", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    List<CacheLista> lista = new List<CacheLista>();

                    command.Parameters.Add(new OracleParameter("v_busqueda", OracleDbType.Varchar2)).Value = dato;
                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor); //%rowtype
                    output.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();

                    while (reader.Read())
                    {
                        CacheLista caus = new CacheLista();

                        caus.ID = reader.GetInt32(0);
                        caus.Nombres = reader.GetString(1);
                        caus.Apellidos = reader.GetString(2);
                        caus.Rut = reader.GetString(3);
                        caus.Login = reader.GetString(4);
                        caus.Clave = reader.GetString(5);
                        caus.Email = reader.GetString(6);
                        caus.Fono = reader.GetString(7);
                        caus.Rol_id = reader.GetInt32(8);
                        caus.Rol = reader.GetString(9);
                        caus.Estado = reader.GetString(10);

                        lista.Add(caus);
                    }
                    DtListaEmpleados.DataSource = lista;
                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos en la grilla");
            }
        }



        //Listo
        private void TxtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            string busqueda = (CultureInfo.InvariantCulture.TextInfo.ToTitleCase(TxtBuscarEmpleado.Text.ToLower()));

            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            OracleDataAdapter adaptador = new OracleDataAdapter("select us.id_usuario,us.nombres,us.apellidos,us.rut,us.login,us.clave,us.email,us.Fono,us.id_rol,ro.nombre_rol,us.estado,to_char(us.fecha_creacion, 'dd-mm-yyyy hh24:mi:ss') as Fecha_creacion,to_char(us.fecha_modificacion, 'dd-mm-yyyy hh24:mi:ss') as Fecha_modificacion FROM usuario US JOIN ROL RO ON US.ID_ROL = RO.ID_ROL where us.id_rol <> 7 and us.estado = 'Activo' and us.nombres LIKE '%" + busqueda + "%'", conn);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DtListaEmpleados.DataSource = tabla;
            conn.Close();

        }

        //Listo
        private void BtnEliminados_Click(object sender, EventArgs e)
        {
            DtListaEmpleados.Visible = false;
            DtEliminados.Visible = true;
            BtnEliminados.Visible = false;
            BtnVolver.Visible = true;
            CargarGrillaEliminados();
            limpiar_formulario();
            PnlFormulario.Visible = false;
        }

        //Listo
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            DtEliminados.Visible = false;
            DtListaEmpleados.Visible = true;
            BtnEliminados.Visible = true;
            BtnVolver.Visible = false;
            CargarGrilla();
            limpiar_formulario();
            PnlFormulario.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DtEliminados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

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

    

        private void DtListaEmpleados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void BtnCerrar_Click_3(object sender, EventArgs e)
        {
            PnlFormulario.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            using (OracleCommand command = new OracleCommand("insertar_usuario", conn))
            {
                string message = "¿Estas seguro de agregar el usuario?.";
                string caption = "Añadir nuevo usuario.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;




                string v_estado;
                v_estado = CbxEstado.Text;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (CbxRol.SelectedIndex == 0)
                    {
                        string message1 = "Debe Seleccionar un rol.";
                        string title = "Error al agregar usuario.";
                        MessageBox.Show(message1, title);
                    }
                    else
                    {
                        if (CbxEstado.Text == "--SELECCIONE UN ESTADO--")
                        {
                            string message1 = "Debe Seleccionar un rol.";
                            string title = "Error al agregar usuario.";
                            MessageBox.Show(message1, title);
                        }

                        else
                        {
                            string Fecha = DateTime.Now.ToString("dd-MM-yyyy");
                            string Hora = DateTime.Now.ToString("hh:mm:ss");

                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = TxtNombre.Text;
                            command.Parameters.Add("v_apellido", OracleDbType.Varchar2).Value = TxtApellido.Text;
                            command.Parameters.Add("v_rut", OracleDbType.Varchar2, 12).Value = TxtRut.Text;
                            command.Parameters.Add("v_login", OracleDbType.Varchar2).Value = TxtUsuario.Text;
                            command.Parameters.Add("v_clave", OracleDbType.Varchar2).Value = TxtContrasena.Text;
                            command.Parameters.Add("v_email", OracleDbType.Varchar2).Value = TxtEmail.Text;
                            command.Parameters.Add("v_fono", OracleDbType.Varchar2).Value = TxtFono.Text;
                            command.Parameters.Add("c_rol", OracleDbType.Int32).Value = v_rol_emp;
                            command.Parameters.Add("c_estado", OracleDbType.Varchar2).Value = v_estado;
                            command.Parameters.Add("v_fecha_c", OracleDbType.Varchar2).Value = Fecha;
                            command.Parameters.Add("v_hora_c", OracleDbType.Varchar2).Value = Hora;

                            command.ExecuteNonQuery();
                            CargarGrilla();
                            limpiar_formulario();
                            PnlFormulario.Visible = false;
                        }
                    }

                }

                CbxRol.SelectedIndex = 0;
            }

        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            BtnVolver.Visible = false;
            BtnEliminados.Visible = true;
            DtEliminados.Visible = false;
            LblTitulo.Text = "EDICION DE USUARIOS";
            BtnGuardarCambios.Visible = true;
            BtnGuardar.Visible = false;

            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            using (OracleCommand command = new OracleCommand("modificar_usuarios", conn))
            {
                string message = "¿Estas seguro de modificar el usuario?.";
                string caption = "Modificacion de usuarios.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                string v_estado;
                v_estado = CbxEstado.Text;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (CbxRol.SelectedIndex == 0)
                    {
                        string message1 = "Debe Seleccionar un rol.";
                        string title = "Error al modificar usuario.";
                        MessageBox.Show(message1, title);
                    }
                    else
                    {
                        if (CbxEstado.Text == "--SELECCIONE UN ESTADO--")
                        {
                            string message1 = "Debe Seleccionar un estado.";
                            string title = "Error al modificar usuario.";
                            MessageBox.Show(message1, title);
                        }
                        else
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("v_id", OracleDbType.Int32).Value = TxtID.Text;
                            command.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = TxtNombre.Text;
                            command.Parameters.Add("v_apellido", OracleDbType.Varchar2).Value = TxtApellido.Text;
                            command.Parameters.Add("v_rut", OracleDbType.Varchar2, 12).Value = TxtRut.Text;
                            command.Parameters.Add("v_login", OracleDbType.Varchar2).Value = TxtUsuario.Text;
                            command.Parameters.Add("v_clave", OracleDbType.Varchar2).Value = TxtContrasena.Text;
                            command.Parameters.Add("v_email", OracleDbType.Varchar2).Value = TxtEmail.Text;
                            command.Parameters.Add("v_fono", OracleDbType.Varchar2).Value = TxtFono.Text;
                            command.Parameters.Add("c_rol", OracleDbType.Int32).Value = v_rol_emp;
                            command.Parameters.Add("c_estado", OracleDbType.Varchar2).Value = v_estado;

                            command.ExecuteNonQuery();
                            CargarGrilla();
                            limpiar_formulario();
                            PnlFormulario.Visible = false;
                            PnlFormulario.Visible = false;
                        }
                    }


                }
                CbxRol.SelectedIndex = 0;
                DtListaEmpleados.Visible = true;
            }
        }

   
        private void DtListaEmpleados_CellMouseDoubleClick_2(object sender, DataGridViewCellMouseEventArgs e)
        {
            LblTitulo.Text = "EDICION DE USUARIOS.";
            BtnGuardarCambios.Visible = true;
            BtnGuardar.Visible = false;
            PnlFormulario.Visible = true;
            PnlFormulario.Visible = true;
            int FilaActual;
            FilaActual = DtListaEmpleados.CurrentRow.Index;

            string id;
            id = DtListaEmpleados.Rows[FilaActual].Cells[0].Value.ToString();
            TxtID.Text = id;

            string nombre;
            nombre = DtListaEmpleados.Rows[FilaActual].Cells[1].Value.ToString();
            TxtNombre.Text = nombre;

            string apellido;
            apellido = DtListaEmpleados.Rows[FilaActual].Cells[2].Value.ToString();
            TxtApellido.Text = apellido;

            string rut;
            rut = DtListaEmpleados.Rows[FilaActual].Cells[3].Value.ToString();
            TxtRut.Text = rut;

            string usuario;
            usuario = DtListaEmpleados.Rows[FilaActual].Cells[4].Value.ToString();
            TxtUsuario.Text = usuario;

            string contrasena;
            contrasena = DtListaEmpleados.Rows[FilaActual].Cells[5].Value.ToString();
            TxtContrasena.Text = contrasena;

            string email;
            email = DtListaEmpleados.Rows[FilaActual].Cells[6].Value.ToString();
            TxtEmail.Text = email;

            string fono;
            fono = DtListaEmpleados.Rows[FilaActual].Cells[7].Value.ToString();
            TxtFono.Text = fono;

            string rol;
            int rol1;
            rol = DtListaEmpleados.Rows[FilaActual].Cells[8].Value.ToString();
            rol1 = Int32.Parse(rol);
            CbxRol.SelectedIndex = rol1;

            string estado;
            estado = DtListaEmpleados.Rows[FilaActual].Cells[10].Value.ToString();
            CbxEstado.Text = estado;

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click_1(object sender, EventArgs e)
        {
            DtEliminados.Visible = false;
            DtListaEmpleados.Visible = true;
            BtnEliminados.Visible = true;
            BtnVolver.Visible = false;
            CargarGrilla();
            limpiar_formulario();
            PnlFormulario.Visible = false;
        }

        private void BtnEliminados_Click_1(object sender, EventArgs e)
        {
            DtListaEmpleados.Visible = false;
            DtEliminados.Visible = true;
            BtnEliminados.Visible = false;
            BtnVolver.Visible = true;
            CargarGrillaEliminados();
            limpiar_formulario();
            PnlFormulario.Visible = false;
        }

        private void CbxRol_TextChanged_1(object sender, EventArgs e)
        {
            v_rol_emp = CbxRol.SelectedIndex.ToString();
        }


        private void BtnGuardarCambios_Click_1(object sender, EventArgs e)
        {
            BtnVolver.Visible = false;
            BtnEliminados.Visible = true;
            DtEliminados.Visible = false;
            LblTitulo.Text = "EDICION DE USUARIOS";
            BtnGuardarCambios.Visible = true;
            BtnGuardar.Visible = false;

            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();


            using (OracleCommand command = new OracleCommand("modificar_usuarios", conn))
            {
                string message = "¿Estas seguro de modificar el usuario?.";
                string caption = "Modificacion de usuarios.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                string v_estado;
                v_estado = CbxEstado.Text;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (CbxRol.SelectedIndex == 0)
                    {
                        string message1 = "Debe Seleccionar un rol.";
                        string title = "Error al modificar usuario.";
                        MessageBox.Show(message1, title);
                    }
                    else
                    {
                        if (CbxEstado.Text == "--SELECCIONE UN ESTADO--")
                        {
                            string message1 = "Debe Seleccionar un estado.";
                            string title = "Error al modificar usuario.";
                            MessageBox.Show(message1, title);
                        }
                        else
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("v_id", OracleDbType.Int32).Value = TxtID.Text;
                            command.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = TxtNombre.Text;
                            command.Parameters.Add("v_apellido", OracleDbType.Varchar2).Value = TxtApellido.Text;
                            command.Parameters.Add("v_rut", OracleDbType.Varchar2, 12).Value = TxtRut.Text;
                            command.Parameters.Add("v_login", OracleDbType.Varchar2).Value = TxtUsuario.Text;
                            command.Parameters.Add("v_clave", OracleDbType.Varchar2).Value = TxtContrasena.Text;
                            command.Parameters.Add("v_email", OracleDbType.Varchar2).Value = TxtEmail.Text;
                            command.Parameters.Add("v_fono", OracleDbType.Varchar2).Value = TxtFono.Text;
                            command.Parameters.Add("c_rol", OracleDbType.Int32).Value = v_rol_emp;
                            command.Parameters.Add("c_estado", OracleDbType.Varchar2).Value = v_estado;

                            command.ExecuteNonQuery();
                            CargarGrilla();
                            limpiar_formulario();
                            PnlFormulario.Visible = false;
                            PnlFormulario.Visible = false;
                        }
                    }


                }
                CbxRol.SelectedIndex = 0;
                DtListaEmpleados.Visible = true;
            }
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {

            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            using (OracleCommand command = new OracleCommand("insertar_usuario", conn))
            {
                string message = "¿Estas seguro de agregar el usuario?.";
                string caption = "Añadir nuevo usuario.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;




                string v_estado;
                v_estado = CbxEstado.Text;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (CbxRol.SelectedIndex == 0)
                    {
                        string message1 = "Debe Seleccionar un rol.";
                        string title = "Error al agregar usuario.";
                        MessageBox.Show(message1, title);
                    }
                    else
                    {
                        if (CbxEstado.Text == "--SELECCIONE UN ESTADO--")
                        {
                            string message1 = "Debe Seleccionar un rol.";
                            string title = "Error al agregar usuario.";
                            MessageBox.Show(message1, title);
                        }

                        else
                        {
                            string Fecha = DateTime.Now.ToString("dd-MM-yyyy");
                            string Hora = DateTime.Now.ToString("hh:mm:ss");

                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = TxtNombre.Text;
                            command.Parameters.Add("v_apellido", OracleDbType.Varchar2).Value = TxtApellido.Text;
                            command.Parameters.Add("v_rut", OracleDbType.Varchar2, 12).Value = TxtRut.Text;
                            command.Parameters.Add("v_login", OracleDbType.Varchar2).Value = TxtUsuario.Text;
                            command.Parameters.Add("v_clave", OracleDbType.Varchar2).Value = TxtContrasena.Text;
                            command.Parameters.Add("v_email", OracleDbType.Varchar2).Value = TxtEmail.Text;
                            command.Parameters.Add("v_fono", OracleDbType.Varchar2).Value = TxtFono.Text;
                            command.Parameters.Add("c_rol", OracleDbType.Int32).Value = v_rol_emp;
                            command.Parameters.Add("c_estado", OracleDbType.Varchar2).Value = v_estado;
                            command.Parameters.Add("v_fecha_c", OracleDbType.Varchar2).Value = Fecha;
                            command.Parameters.Add("v_hora_c", OracleDbType.Varchar2).Value = Hora;

                            command.ExecuteNonQuery();
                            CargarGrilla();
                            limpiar_formulario();
                            PnlFormulario.Visible = false;
                        }
                    }

                }

                CbxRol.SelectedIndex = 0;
            }
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            PnlFormulario.Visible = false;
        }

        private void TxtRut_Leave(object sender, EventArgs e)
        {

        }

        private void TxtRut_MouseLeave(object sender, EventArgs e)
        {
            Rut auxR = new Rut();
            this.TxtRut.Text = auxR.formatear(this.TxtRut.Text);
        }
    }
    }



