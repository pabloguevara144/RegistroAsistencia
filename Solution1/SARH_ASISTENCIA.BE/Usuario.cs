using System;
using System.Collections.Generic;
using System.Text;

namespace SARH_ASISTENCIA.BE
{
    public class Usuario
    {
        private int usu_id;
        private String usu_alias;
        private String usu_clave;

  
        public int Usu_id { set { usu_id = value; } get { return usu_id; } }
        public String Usu_alias { set { usu_alias = value; } get {return usu_alias; } }
        public String Usu_clave { set { usu_clave = value; } get { return usu_clave; } }
        /*public String Usu_nombre { set; get; }
        public String Usu_apellido { set; get; }
        public String Usu_tipo { set; get; }
        public String Usu_dni { set; get; }
        public String Usu_fecha_creacion { set; get; }
        public int area_id { set; get; }*/
    }
}
