using System;
using System.Collections.Generic;
using System.Text;

namespace SARH_ASISTENCIA.BE
{
    public class Justificacion
    {
        private int codigo_asistencia;
        private int codigo_tipo_justificacion;
        private String motivo;
        private int codigo_estado;
        private String archivo;
        private String respuesta;
        private String nombres;
        private String dni;
        private String d_fecha;
        private String estado_text;

        public String Estado_text
        {
            get { return estado_text; }
            set { estado_text = value; }
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
        

        public String D_fecha
        {
            get { return d_fecha; }
            set { d_fecha = value; }
        }

        public int Codigo_asistencia
        {
            get { return codigo_asistencia; }
            set { codigo_asistencia = value; }
        }
        

        public int Codigo_tipo_justificacion
        {
            get { return codigo_tipo_justificacion; }
            set { codigo_tipo_justificacion = value; }
        }
        

        public String Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }
        

        public int Codigo_estado
        {
            get { return codigo_estado; }
            set { codigo_estado = value; }
        }
        

        public String Archivo
        {
            get { return archivo; }
            set { archivo = value; }
        }
        

        public String Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }
    }
}
