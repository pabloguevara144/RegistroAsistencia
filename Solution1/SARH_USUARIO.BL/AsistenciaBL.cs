using System;
using System.Collections.Generic;
using System.Text;
using SARH_ASISTENCIA.BE;
using SARH_ASISTENCIA.DA;

namespace SARH_ASISTENCIA.BL
{
    public class AsistenciaBL
    {
        AsistenciaDA asistenciaDA = new AsistenciaDA();
        public int registraAsistencia(String strEmpleado)
        {
            try
            {
                return asistenciaDA.registraAsistencia(strEmpleado);
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public List<Asistencia> ListarAsistencia()
        {
            try
            {
                return asistenciaDA.ListarAsistencia();
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
