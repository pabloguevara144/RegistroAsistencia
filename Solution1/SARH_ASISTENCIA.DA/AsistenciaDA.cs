using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using SARH_ASISTENCIA.BE;  

namespace SARH_ASISTENCIA.DA
{
    public class AsistenciaDA
    {
        private readonly string _CadenaConexion;
        public AsistenciaDA ()
        {
            _CadenaConexion =  ConfigurationManager.AppSettings["conexion"];
        }

        public int registraAsistencia(String strEmpleado)
        {
            int intAsistencia;
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_ASISTENCIA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CODIGO_EMPLEADO", SqlDbType.Int);
                cmd.Parameters[0].Value = strEmpleado;
               /// cmd.Parameters[1].Value = strClave;
                try
                {
                    int valorDevuelto = int.Parse(cmd.ExecuteScalar().ToString());
                    intAsistencia = valorDevuelto;
                    return intAsistencia;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
        //'listar Asistencia
        public List<Asistencia> ListarAsistencia()
        {
            var bus = new List<Asistencia>();
            using (SqlConnection conn = new SqlConnection(_CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("LISTAR_ASISTENCIA", conn);
                try
                {
                    var read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        bus.Add(new Asistencia
                        {
                            Codigo_empleado  = read.GetInt32(read.GetOrdinal("N_CODIGO_EMPLEADO")),
                            Nombres  = read.GetString(read.GetOrdinal("NOMBRES")),
                            Dni = read.GetString(read.GetOrdinal("DNI")),
                            Fecha = read.GetString(read.GetOrdinal("D_FECHA")),
                            Hora_ingreso = read.GetString(read.GetOrdinal("D_HORA_INGRESO")),
                            Hora_salida = read.GetString(read.GetOrdinal("D_HORA_SALIDA")),
                            Timpo_trabajado = read.GetInt32(read.GetOrdinal("N_TIEMPO_TRABAJADO"))
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
