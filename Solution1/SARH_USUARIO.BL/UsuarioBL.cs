using System;
using System.Collections.Generic;
using System.Text;
using SARH_ASISTENCIA.BE;
using SARH_ASISTENCIA.DA;

namespace SARH_ASISTENCIA.BL
{
    public class UsuarioBL
    {
        public Boolean existeUsuario(String strUsuario,String strClave){
            try 
            {
                UsuarioDA usuarioDA = new UsuarioDA();
                return usuarioDA.existeUsuario(strUsuario, strClave);
            }
            catch(Exception){
                    
                return false; 
            }
        }
    }
}
