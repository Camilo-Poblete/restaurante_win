using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using Capa_Transversal;

namespace Acceso_Datos
{
    public class UserDao : Conexion_Oracle
    {

        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = ("SELECT us.id_usuario, us.nombres, us.apellidos, us.rut, us.login, us.clave, us.email, us.fono, us.id_rol, ro.nombre_rol, us.estado, us.fecha_creacion, us.fecha_modificacion FROM usuario US JOIN ROL RO ON US.ID_ROL = RO.ID_ROL where us.login=:usuario and us.clave=:contrasena");

                command.Parameters.Add(":usuario", user);
                command.Parameters.Add(":contrasena", pass);
                command.CommandType = System.Data.CommandType.Text;

                OracleDataReader reader;
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        CacheInicioSesion.ID = reader.GetInt32(0);
                        CacheInicioSesion.Nombres = reader.GetString(1);
                        CacheInicioSesion.Apellidos = reader.GetString(2);
                        CacheInicioSesion.Rut = reader.GetString(3);
                        CacheInicioSesion.Login = reader.GetString(4);
                        CacheInicioSesion.Clave = reader.GetString(5);
                        CacheInicioSesion.Email = reader.GetString(6);
                        CacheInicioSesion.Fono = reader.GetString(7);
                        CacheInicioSesion.Rol_id = reader.GetInt32(8);
                        CacheInicioSesion.Rol = reader.GetString(9);
                        CacheInicioSesion.Estado = reader.GetString(10);

                    }
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}


