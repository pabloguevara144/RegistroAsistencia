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
        private String usu_nombre;
        private String usu_apellido;
        private String usu_tipo;
        private String usu_dni;
        private int area_id;
        private String usu_estado;
        private String usu_area;
        private int cod_emp;

  
        public int Usu_id { set { usu_id = value; } get { return usu_id; } }
        public String Usu_alias { set { usu_alias = value; } get {return usu_alias; } }
        public String Usu_clave { set { usu_clave = value; } get { return usu_clave; } }
        public String Usu_nombre { set { usu_nombre = value; } get { return usu_nombre; } }
        public String Usu_apellido { set { usu_apellido = value; } get { return usu_apellido; } }
        public String Usu_tipo { set { usu_tipo = value; } get { return usu_tipo; } }
        public String Usu_dni { set { usu_dni = value; } get { return usu_dni; } }
        /*public String Usu_fecha_creacion { set; get; }*/
        public int Area_id { set { area_id = value; } get { return area_id; } }
        public String Usu_estado { set { usu_estado = value; } get { return usu_estado; } }
        public String Usu_area { set { usu_area = value; } get { return usu_area; } }
        public int Cod_emp { set { cod_emp = value; } get { return cod_emp; } }
    }
}
