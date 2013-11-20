using System;
using System.Collections.Generic;
using System.Text;
using SARH_ASISTENCIA.BE;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SARH_ASISTENCIA.DA
{
    public class AreaDA
    {
        private readonly string _CadenaConexion;
        public AreaDA()
        {
            _CadenaConexion =  ConfigurationManager.AppSettings["conexion"];
        }
        
        public List<Area> List(){
            var bus = new List<Area>();
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("LISTARAREA", conn);
                try
                {
                    var read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        bus.Add(new Area
                        {
                            Nom_area = read.GetString(read.GetOrdinal("AREA")),
                            Sigla_area = read.GetString(read.GetOrdinal("SIGLA"))
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

        public int Registrar(String n,String s) {
            int i = 0;
             using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERTAREA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMAREA", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@SIGLA", SqlDbType.VarChar, 5);
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

        public int Eliminar(String n)
        {
            int i = 0;
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ELIMINARAREA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMAREA", SqlDbType.VarChar, 50);
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
