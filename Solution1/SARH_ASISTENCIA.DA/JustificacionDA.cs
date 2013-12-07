using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using SARH_ASISTENCIA.BE;  
namespace SARH_ASISTENCIA.DA
{
    public class JustificacionDA
    {
        private readonly string _CadenaConexion;
        public JustificacionDA()
        {
            _CadenaConexion =  ConfigurationManager.AppSettings["conexion"];
        }

        public int registrar(Justificacion objJust)
        {

            int i = 0;
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_REGISTAR_JUSTIFICACION_ASIS", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@COD_ASIS", SqlDbType.Int, 4);
                cmd.Parameters.Add("@TIPO_JUSTIFICACION", SqlDbType.Int, 50);
                cmd.Parameters.Add("@MOTIVO", SqlDbType.VarChar, 255);
                cmd.Parameters.Add("@CODIGO_ESTADO", SqlDbType.Int, 4);
                cmd.Parameters.Add("@ARCHIVO", SqlDbType.VarChar, 255);
                cmd.Parameters.Add("@RESPUESTA", SqlDbType.VarChar, 255);
                cmd.Parameters[0].Value = objJust.Codigo_asistencia;
                cmd.Parameters[1].Value = objJust.Codigo_tipo_justificacion;
                cmd.Parameters[2].Value = objJust.Motivo;
                cmd.Parameters[3].Value = objJust.Codigo_estado;
                cmd.Parameters[4].Value = objJust.Archivo;
                cmd.Parameters[5].Value = objJust.Respuesta ;
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


        public List<Justificacion> Listar()
        {
            var bus = new List<Justificacion>();
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("LISTARJUSTIFICACION", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    var read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        bus.Add(new Justificacion
                        {
                            Codigo_asistencia  = read.GetInt32(read.GetOrdinal("CODIGO_ASISTENCIA")),
                            D_fecha  = read.GetString (read.GetOrdinal("D_FECHA")),
                            Nombres = read.GetString(read.GetOrdinal("NOMBRES")),
                            Dni = read.GetString(read.GetOrdinal("DNI")),
                            Estado_text = read.GetString(read.GetOrdinal("ESTADO"))
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

        public List<Justificacion> getJustificar(int cod_asis)
        {
            var bus = new List<Justificacion>();
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_GETJUSTIFICACION", conn);
                cmd.Parameters.Add("@COD_ASIS", SqlDbType.Int, 4);

                cmd.Parameters[0].Value = cod_asis;
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    var read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        bus.Add(new Justificacion
                        {
                            Codigo_asistencia = read.GetInt32(read.GetOrdinal("CODIGO_ASISTENCIA")),
                            Codigo_tipo_justificacion = read.GetInt32(read.GetOrdinal("N_CODIGO_TIPO_JUSTIFICACION")),
                            Motivo  = read.GetString(read.GetOrdinal("MOTIVO")),
                            Codigo_estado = read.GetInt32(read.GetOrdinal("N_CODIGO_ESTADO")),
                            Archivo = read.GetString(read.GetOrdinal("ARCHIVO")),
                            Respuesta = read.GetString(read.GetOrdinal("RESPUESTA_JUSTIFICACION"))
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


    }
}
