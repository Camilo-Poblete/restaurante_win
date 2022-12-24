using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos;

namespace Modelo_Negocio
{
   public class Acceso : Conexion_Oracle
   {
        public Oracle.ManagedDataAccess.Client.OracleConnection Conectar()
        {
            var conectar = GetConnection();

            return conectar;
        }



    }
}
