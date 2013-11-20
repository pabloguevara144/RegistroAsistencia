using System;
using System.Collections.Generic;
using System.Text;
using SARH_ASISTENCIA.BE;
using SARH_ASISTENCIA.DA;

namespace SARH_ASISTENCIA.BL
{
    public class EmpleadoBL
    {
        EmpleadoDA ar = new EmpleadoDA();

        public List<Empleado> List()
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

        public int Registrar(int ce, String ar, String ch, String ap, String am, String no, String dn, String fe, String tc, String se, String es)                            
        {
            try
            {
                EmpleadoDA af = new EmpleadoDA();
                return af.Registrar(ce, ar, ch, ap, am, no, dn, fe, tc, se, es);                
            }
            catch (Exception) { return 0; }
        }

        public int Eliminar(int n)
        {
            try
            {
                return ar.Eliminar(n);                
            }
            catch (Exception) { return 0; }
        }


    }
}
