using System;
using System.Collections.Generic;
using System.Text;
using SARH_ASISTENCIA.BE;
using SARH_ASISTENCIA.DA;
namespace SARH_ASISTENCIA.BL
{
    public class TipoJustificacionBL
    {
        TipoJustificacionDA ar = new TipoJustificacionDA();
        public List<TipoJustificacion> List()
        {
            try
            {
                return ar.List();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<TipoJustificacion> ListEstado()
        {
            try
            {
                return ar.ListEstado();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
