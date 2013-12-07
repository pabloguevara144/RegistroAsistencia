using System;
using System.Collections.Generic;
using System.Text;
using SARH_ASISTENCIA.BE;
using SARH_ASISTENCIA.DA;
namespace SARH_ASISTENCIA.BL
{

    public class TardanzaBL
    {
        TardanzaDA tardanzaDA = new TardanzaDA();

        public List<Tardanza> ListarTardanza(int mes)
        {
            try
            {
                return tardanzaDA.ListarTardanza(mes);
            }
            catch (Exception)
            {
                return null;
            }
        }   
    }
}
