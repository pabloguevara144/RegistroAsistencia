using System;
using System.Collections.Generic;
using System.Text;

namespace SARH_ASISTENCIA.BE
{
    public class Tipo
    {
        private Int32 tipo_id;
        private String nom_tipo;

        public Int32 Tipo_id { set { tipo_id = value; } get { return tipo_id; } }
        public String Nom_tipo { set { nom_tipo = value; } get { return nom_tipo; } }
    }
}
