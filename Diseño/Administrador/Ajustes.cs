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
using System.Management;

namespace Diseño.Administrador
{
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
            GetAllPrinterList();
            Datos_empresa();
            this.ActiveControl = BtnGuardar;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            string message = "¿Estas seguro de modificar la informacion de la empresa?.";
            string caption = "Modificar datos.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                using (OracleCommand command = new OracleCommand("modificar_informacion_empresa", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("v_empresa", OracleDbType.Varchar2).Value = TxtNombre.Text;
                    command.Parameters.Add("v_direccion", OracleDbType.Varchar2).Value = TxtDireccion.Text;
                    command.Parameters.Add("v_comuna", OracleDbType.Varchar2).Value = TxtComuna.Text;
                    command.Parameters.Add("v_region", OracleDbType.Varchar2).Value = TxtRegion.Text;
                    command.Parameters.Add("v_fono", OracleDbType.Varchar2).Value = TxtFono.Text;
                    command.Parameters.Add("v_impresora", OracleDbType.Varchar2).Value = CbxImpresora.Text;

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }

        }


         private void Datos_empresa()
         {
            Acceso ac = new Acceso();
            var conn = ac.Conectar();
            conn.Open();

            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = ("Select nombre_empresa,direccion,comuna,region,fono,impresora from informacion_empresa where id_empresa = 1");

            command.CommandType = System.Data.CommandType.Text;

            OracleDataReader reader;
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TxtNombre.Text = reader.GetString(0);
                    TxtDireccion.Text = reader.GetString(1);
                    TxtComuna.Text = reader.GetString(2);
                    TxtRegion.Text = reader.GetString(3);
                    TxtFono.Text = reader.GetString(4);
                    CbxImpresora.Text = reader.GetString(5);

                }
            }
            else
            {

            }


        }










        private void GetAllPrinterList()
        {
            ManagementScope objScope = new ManagementScope(ManagementPath.DefaultPath);
            objScope.Connect();

            SelectQuery selectQuery = new SelectQuery();
            selectQuery.QueryString = "Select * from win32_Printer";
            ManagementObjectSearcher MOS = new ManagementObjectSearcher(objScope, selectQuery);
            ManagementObjectCollection MOC = MOS.Get();
            foreach (ManagementObject mo in MOC)
            {
                CbxImpresora.Items.Add(mo["Name"].ToString());
            }
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
