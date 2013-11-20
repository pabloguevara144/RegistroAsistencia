using System;
using System.Collections.Generic;
using System.Text;

namespace SARH_ASISTENCIA.BE
{
    public class Empleado
    {
        private int cod_empl;
        private String ar_id;
        private String hora_id;
        private String ape_pat;
        private String ape_mat;
        private String dni;
        private String nom_emp;
        private String fec_nac;
        private String tel_cel;
        private String sex_emp;
        private String est_emp;

        public int Cod_empl { set { cod_empl = value; } get { return cod_empl; } }
        public String Area_id { set { ar_id = value; } get { return ar_id; } }
        public String Hora_id { set { hora_id = value; } get { return hora_id; } }
        public String Ape_pat { set { ape_pat = value; } get { return ape_pat; } }
        public String Ape_mat { set { ape_mat = value; } get { return ape_mat; } }
        public String Dni { set { dni = value; } get { return dni; } }
        public String Nom_emp { set { nom_emp = value; } get { return nom_emp; } }
        public String Fec_nac { set { fec_nac = value; } get { return fec_nac; } }
        public String Tel_cel { set { tel_cel = value; } get { return tel_cel; } }
        public String Sex_emp { set { sex_emp = value; } get { return sex_emp; } }
        public String Est_emp { set { est_emp = value; } get { return est_emp; } }

    }
}
