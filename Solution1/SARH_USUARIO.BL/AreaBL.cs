using System;
using System.Collections.Generic;
using System.Text;
using SARH_ASISTENCIA.BE;
using SARH_ASISTENCIA.DA;

namespace SARH_ASISTENCIA.BL
{
    public class AreaBL
    {
        AreaDA ar = new AreaDA();
        public List<Area> List()
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

        public int Registrar(String n,String s) {
            try {
                return ar.Registrar(n,s);                
            }
            catch (Exception) { return 0; }
        }

        public int Eliminar(String n)
        {
            try
            {
                return ar.Eliminar(n);
            }
            catch (Exception) { return 0; }
        }

       
    }
}
