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


        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
