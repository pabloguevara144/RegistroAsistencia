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

        public List<Usuario> List()
        {
            var bus = new List<Usuario>();
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("LISTARUSUARIO", conn);
                try
                {
                    var read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        bus.Add(new Usuario
                        {
                            Usu_alias = read.GetString(read.GetOrdinal("ALIAS")),
                            Usu_tipo = read.GetString(read.GetOrdinal("TIPO")),
                            Usu_estado = read.GetString(read.GetOrdinal("ESTADO")),
                            Cod_emp = read.GetInt32(read.GetOrdinal("EMPLEADO"))
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

        public int Registrar(String al,String ti,String es,int em)
        {
            int i = 0;
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("REGISTRARUSUARIO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usu_alias", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@usu_tipo", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@usu_est", SqlDbType.VarChar, 1);
                cmd.Parameters.Add("@cod_emp", SqlDbType.Int, 4);
                cmd.Parameters[0].Value = al;
                cmd.Parameters[1].Value = ti;
                cmd.Parameters[2].Value = es;
                cmd.Parameters[3].Value = em;
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
                SqlCommand cmd = new SqlCommand("ELIMINARUSUARIO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@alias", SqlDbType.VarChar, 50);
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
