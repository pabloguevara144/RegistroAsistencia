using System;
using System.Collections.Generic;
using System.Text;
using SARH_ASISTENCIA.BE;
using SARH_ASISTENCIA.DA;

namespace SARH_ASISTENCIA.BL
{
    public class TipoBL
    {
        TipoDA ar = new TipoDA();
        public List<Tipo> List()
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

        public int Registrar(Int32 n,String s) {
            try {
                
                return ar.Registrar(n,s);                
            }
            catch (Exception) { return 0; }
        }

        public int Eliminar(Int32 n)
        {
            try
            {
                return ar.Eliminar(n);
            }
            catch (Exception) { return 0; }
        }

       
    }
}
