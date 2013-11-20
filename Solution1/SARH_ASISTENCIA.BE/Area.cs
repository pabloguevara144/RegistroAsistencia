using System;
using System.Collections.Generic;
using System.Text;

namespace SARH_ASISTENCIA.BE
{
    public class Area
    {
        private String nom_area;
        private String sigla_area;

        public String Nom_area { set { nom_area = value; } get { return nom_area; } }
        public String Sigla_area { set { sigla_area = value; } get { return sigla_area; } }
    }
}
