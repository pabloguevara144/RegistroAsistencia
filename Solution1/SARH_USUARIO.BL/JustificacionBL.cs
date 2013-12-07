using System;
using System.Collections.Generic;
using System.Text;
using SARH_ASISTENCIA.BE;
using SARH_ASISTENCIA.DA;

namespace SARH_ASISTENCIA.BL
{
    public class JustificacionBL
    {
        JustificacionDA ar = new JustificacionDA();
        public int Registrar(Justificacion OBJjUst)
        {
            try
            {
                return ar.registrar(OBJjUst);
            }
            catch (Exception) { return 0; }
        }
        public List<Justificacion> List()
        {
            try
            {
                return ar.Listar();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Justificacion> getJustificar(int cod_asis)
        {
            try
            {
                return ar.getJustificar (cod_asis );
            }
            catch (Exception)
            {
                return null;
            }
        }
        



    }
}
