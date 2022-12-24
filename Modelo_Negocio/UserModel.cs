using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Transversal;
using Acceso_Datos;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

using System.Data;

namespace Modelo_Negocio
{
   public class UserModel
    {
        UserDao userdao = new UserDao();

        public bool LoginUser(string user,string pass)
        {
            return userdao.Login(user, pass);
        }



    }
}
