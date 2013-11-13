using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;

namespace SARH_ASISTENCIA.UI.Utils
{
    public class Validaciones
    {
        public enum TipoDato
        {
            Entero,
            Decimal,
            Double,
            Datetime,
            Boolean
        };

        public static bool EsCorreo(string correo)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, expresion))
            {
                if (Regex.Replace(correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool EsTipoDato(TipoDato valorTipoDato, string valor)
        {
            bool resultado = false;

            switch (valorTipoDato)
            {
                case TipoDato.Entero:
                    long entero;
                    resultado = long.TryParse(valor, out entero);
                    break;
                case TipoDato.Datetime:
                    DateTime fecha;
                    resultado = DateTime.TryParse(valor, out fecha);
                    break;
                case TipoDato.Decimal:
                    decimal dDecimal;
                    resultado = decimal.TryParse(valor, out dDecimal);
                    break;
                case TipoDato.Double:
                    double dDouble;
                    resultado = double.TryParse(valor, out dDouble);
                    break;
                case TipoDato.Boolean:
                    bool bBool;
                    resultado = bool.TryParse(valor, out bBool);
                    break;
            }

            return resultado;
        }
    }
}