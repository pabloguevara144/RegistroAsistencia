using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using SARH_ASISTENCIA.BE;  
namespace SARH_ASISTENCIA.DA
{
    public class TardanzaDA
    {
        private readonly string _CadenaConexion;
        public TardanzaDA()
        {
            _CadenaConexion =  ConfigurationManager.AppSettings["conexion"];
        }



        //'listar Asistencia
        public List<Tardanza> ListarTardanza(int mes)
        {
            var bus = new List<Tardanza>();
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("LISTAR_TARDANZA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MES", SqlDbType.Int);
                cmd.Parameters[0].Value = mes;
                try
                {
                    var read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        bus.Add(new Tardanza
                        {
                            Codigo_Asistencia = read.GetInt32(read.GetOrdinal("CODIGO_ASISTENCIA") ), 
                            Codigo_empleado = read.GetInt32(read.GetOrdinal("N_CODIGO_EMPLEADO")),
                            Nombres = read.GetString(read.GetOrdinal("NOMBRES")),
                            Dni = read.GetString(read.GetOrdinal("DNI")),
                            Fecha = read.GetString(read.GetOrdinal("D_FECHA")),
                            Hora_ingreso = read.GetString(read.GetOrdinal("D_HORA_INGRESO")),
                            Hora_salida = read.GetString(read.GetOrdinal("D_HORA_SALIDA")),
                            Timpo_trabajado = read.GetInt32(read.GetOrdinal("N_TIEMPO_TRABAJADO")),
                            Marcaciones = read.GetInt32(read.GetOrdinal("MARCACIONES"))
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
