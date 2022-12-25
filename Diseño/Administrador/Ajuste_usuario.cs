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

namespace Diseño
{
    public partial class Ajuste_usuario : Form
    {
        public Ajuste_usuario()
        {
            InitializeComponent();
        }




        private void Ajuste_usuario_Load(object sender, EventArgs e)
        {
            Cargar_Informacion_Usuario();
        }

        private void Cargar_Informacion_Usuario()
        {
            TxtNombres.Text = CacheInicioSesion.Nombres;
            TxtApellidos.Text = CacheInicioSesion.Apellidos;
            TxtRut.Text = CacheInicioSesion.Rut;
            TxtLogin.Text = CacheInicioSesion.Login;
            TxtClave.Text = CacheInicioSesion.Clave;
            TxtFono.Text = CacheInicioSesion.Fono;
            TxtEmail.Text = CacheInicioSesion.Email;
            CbxEstado.Text = CacheInicioSesion.Estado;
            CbxRol.Text = CacheInicioSesion.Rol;

        }


        public class Rut
        {
            public String formatear(String rut)
            {
                int cont = 0;
                String format;
                if(rut.Length == 0)
                {
                    return "";
                }
                else
                {
                    rut = rut.Replace(".", "");
                    rut = rut.Replace(".", "");
                    format = "." + rut.Substring(rut.Length - 1);
                    for (int i = rut.Length - 2; i>= 0; i--)
                    {
                        format = rut.Substring(i, 1) + format;

                        cont++;
                        if (cont == 3 && i != 0)
                        {
                            format = "." + format;
                            cont = 0;
                        }

                    }
                }
                return format;
            }
        }


        private void TxtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            using (OracleCommand command = new OracleCommand("modificar_usuarios", conn))
            {
                string message = "¿Estas seguro de modificar el usuario?.";
                string caption = "Modificacion de usuarios.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                int id = CacheInicioSesion.ID;
                int rol = CacheInicioSesion.Rol_id;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("v_id", OracleDbType.Int32).Value = id;
                    command.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = TxtNombres.Text;
                    command.Parameters.Add("v_apellido", OracleDbType.Varchar2).Value = TxtApellidos.Text;
                    command.Parameters.Add("v_rut", OracleDbType.Varchar2,12).Value = TxtRut.Text;
                    command.Parameters.Add("v_login", OracleDbType.Varchar2).Value = TxtLogin.Text;
                    command.Parameters.Add("v_clave", OracleDbType.Varchar2).Value = TxtClave.Text;
                    command.Parameters.Add("v_email", OracleDbType.Varchar2).Value = TxtEmail.Text;
                    command.Parameters.Add("v_fono", OracleDbType.Varchar2).Value = TxtFono.Text;
                    command.Parameters.Add("c_rol", OracleDbType.Int32).Value = rol;
                    command.Parameters.Add("c_estado", OracleDbType.Varchar2).Value = CbxEstado.Text;

                    command.ExecuteNonQuery();
                    MessageBox.Show("Se modificaron correctamente los registros.");

                }


            }



        }
    }
}
