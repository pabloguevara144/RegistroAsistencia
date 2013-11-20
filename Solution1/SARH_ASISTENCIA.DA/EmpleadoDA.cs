using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using SARH_ASISTENCIA.BE;

namespace SARH_ASISTENCIA.DA
{
    public class EmpleadoDA
    {
        private readonly string _CadenaConexion;
        public EmpleadoDA()
        {
            _CadenaConexion =  ConfigurationManager.AppSettings["conexion"];
        }

        public List<Empleado> List()
        {
            var bus = new List<Empleado>();
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("LISTAREMPLEADO", conn);
                try
                {
                    var read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        bus.Add(new Empleado
                        {
                            Cod_empl = read.GetInt32(read.GetOrdinal("CODIGO")),
                            Nom_emp = read.GetString(read.GetOrdinal("NOMBRES")),
                            Ape_pat = read.GetString(read.GetOrdinal("APEPAT")),
                            Ape_mat = read.GetString(read.GetOrdinal("APEMAT")),
                            Dni = read.GetString(read.GetOrdinal("DNI")),
                            Fec_nac = read.GetString(read.GetOrdinal("FECNAC")),
                            Tel_cel = read.GetString(read.GetOrdinal("CEL")),
                            Sex_emp = read.GetString(read.GetOrdinal("SEXO")),
                            Est_emp = read.GetString(read.GetOrdinal("ESTADO")),
                            Hora_id = read.GetString(read.GetOrdinal("HORARIO")),
                            Area_id = read.GetString(read.GetOrdinal("AREA"))
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

        public int Registrar(int ce, String ar, String ch,String ap,String am,String no, String dn,String fe,String tc,String se,String es)
        {
            int i = 0;
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("REGISTRAREMPLEADO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@COD_EMP", SqlDbType.Int, 4);
                cmd.Parameters.Add("@ID_AREA", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@COD_HOR", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@APE_PAT", SqlDbType.VarChar, 100);
                cmd.Parameters.Add("@APE_MAT", SqlDbType.VarChar, 100);
                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 100);
                cmd.Parameters.Add("@DNI", SqlDbType.VarChar, 8);
                cmd.Parameters.Add("@FEC_NAC", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@TEL_CEL", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@SEXO", SqlDbType.VarChar, 1);
                cmd.Parameters.Add("@ESTADO", SqlDbType.VarChar, 1);                
                cmd.Parameters[0].Value = ce;
                cmd.Parameters[1].Value = ar;
                cmd.Parameters[2].Value = ch;
                cmd.Parameters[3].Value = ap;
                cmd.Parameters[4].Value = am;
                cmd.Parameters[5].Value = no;
                cmd.Parameters[6].Value = dn;
                cmd.Parameters[7].Value = fe;
                cmd.Parameters[8].Value = tc;
                cmd.Parameters[9].Value = se;
                cmd.Parameters[10].Value = es;
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

        public int Eliminar(int n)
        {
            int i = 0;
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ELIMINAREMPLEADO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@COD_EMP", SqlDbType.Int, 4);
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
