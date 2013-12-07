using System;
using System.Collections.Generic;
using System.Text;

namespace SARH_ASISTENCIA.BE
{
    public class Tardanza
    {
        private int codigo_Asistencia;
        private int codigo_empleado;
        private String nombres;
        private String dni;
        private String fecha;
        private String hora_ingreso;
        private String hora_salida;
        private int timpo_trabajado;
        private int minutos_extra;
        private int marcaciones;

        public int Codigo_empleado
        {
            get { return codigo_empleado; }
            set { codigo_empleado = value; }
        }
        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public String Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public int Codigo_Asistencia
        {
            get { return codigo_Asistencia; }
            set { codigo_Asistencia = value; }
        }


        public String Hora_salida
        {
            get { return hora_salida; }
            set { hora_salida = value; }
        }

        public String Hora_ingreso
        {
            get { return hora_ingreso; }
            set { hora_ingreso = value; }
        }

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Marcaciones
        {
            get { return marcaciones; }
            set { marcaciones = value; }
        }

        public int Minutos_extra
        {
            get { return minutos_extra; }
            set { minutos_extra = value; }
        }

        public int Timpo_trabajado
        {
            get { return timpo_trabajado; }
            set { timpo_trabajado = value; }
        }
    }
}
