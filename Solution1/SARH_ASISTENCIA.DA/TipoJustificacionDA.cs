using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using SARH_ASISTENCIA.BE;  

namespace SARH_ASISTENCIA.DA
{
    public class TipoJustificacionDA
    {
        private readonly string _CadenaConexion;
        public TipoJustificacionDA()
        {
            _CadenaConexion =  ConfigurationManager.AppSettings["conexion"];
        }
        public List<TipoJustificacion> List()
        {
            var bus = new List<TipoJustificacion>();
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("LISTARTIPOJUSTIFICACION", conn);
                try
                {
                    var read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        bus.Add(new TipoJustificacion
                        {
                            Codigo_Estado = read.GetInt32(read.GetOrdinal("N_CODIGO_TIPO_JUSTIFICACION")),
                            Descripcion = read.GetString(read.GetOrdinal("C_NOMBRE_LARGO_JUSTIFICACION"))
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


        public List<TipoJustificacion> ListEstado()
        {
            var bus = new List<TipoJustificacion>();
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("LISTARESTADOJUSTIFICACION", conn);
                try
                {
                    var read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        bus.Add(new TipoJustificacion
                        {
                            Codigo_Estado = read.GetInt32(read.GetOrdinal("N_CODIGO_ESTADO")),
                            Descripcion = read.GetString(read.GetOrdinal("C_DESCRIPCION"))
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
