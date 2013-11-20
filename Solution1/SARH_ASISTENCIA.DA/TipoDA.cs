using System;
using System.Collections.Generic;
using System.Text;
using SARH_ASISTENCIA.BE;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SARH_ASISTENCIA.DA
{
    public class TipoDA
    {
        private readonly string _CadenaConexion;
        public TipoDA()
        {
            _CadenaConexion =  ConfigurationManager.AppSettings["conexion"];
        }
        
        public List<Tipo> List(){
            var bus = new List<Tipo>();
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("LISTARTIPO", conn);
                try
                {
                    var read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        bus.Add(new Tipo
                        {
                            Tipo_id = read.GetInt32(read.GetOrdinal("CODIGO")),
                            Nom_tipo = read.GetString(read.GetOrdinal("NOMBRE"))
                        });
                    }
                }
                catch (Exception)
                {
                    bus = null;
                }
                finally
                {
                    conn.Close();
                }
                return bus;
            }
        }

        public int Registrar(Int32 n,String s) {
            int i = 0;
             using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("REGISTRARTIPO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TIPOID", SqlDbType.Int, 4);
                cmd.Parameters.Add("@NOM_TIPO", SqlDbType.VarChar, 50);
                cmd.Parameters[0].Value = n;
                cmd.Parameters[1].Value = s;
                try
                {
                    i = cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    i = 0;
                }
                finally
                {
                    conn.Close();
                }
                return i;
            }
        }

        public int Eliminar(Int32 n)
        {
            int i = 0;
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ELIMINARTIPO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TIPOID", SqlDbType.Int, 4);
                cmd.Parameters[0].Value = n;
                try
                {
                    i = cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    i = 0;
                }
                finally
                {
                    conn.Close();
                }
                return i;
            }
        }

    }
}
