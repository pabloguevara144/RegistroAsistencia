using System;
using System.Collections.Generic;
using System.Text;

namespace SARH_ASISTENCIA.BE
{
    public class TipoJustificacion
    {
        private int codigo_Estado;
        private String descripcion;

        public int Codigo_Estado
        {
            get { return codigo_Estado; }
            set { codigo_Estado = value; }
        }
        

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

    }
}
