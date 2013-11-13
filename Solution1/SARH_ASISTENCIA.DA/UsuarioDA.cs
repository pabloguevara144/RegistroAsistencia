using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using SARH_ASISTENCIA.BE;  

namespace SARH_ASISTENCIA.DA
{
    public class UsuarioDA
    {
        private readonly string _CadenaConexion;
        public UsuarioDA()
        {
            _CadenaConexion =  ConfigurationManager.AppSettings["conexion"];
        }
        public Boolean existeUsuario(String strUsuario, String strClave)
        {
            Boolean booUsuario = false; 
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("VerificarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@Clave", SqlDbType.VarChar, 50);
                cmd.Parameters[0].Value = strUsuario;
                cmd.Parameters[1].Value = strClave;
                try
                {
                    int valorDevuelto = int.Parse(cmd.ExecuteScalar().ToString());
                    booUsuario = valorDevuelto == 1;
                    return booUsuario;
                }
                catch (Exception)
                {
                    booUsuario = false;
                    return booUsuario;
                   
                }

            }
        }
    }
}
