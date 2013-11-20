using System;
using System.Collections.Generic;
using System.Text;
using SARH_ASISTENCIA.BE;
using SARH_ASISTENCIA.DA;

namespace SARH_ASISTENCIA.BL
{
    public class UsuarioBL
    {
        UsuarioDA ar = new UsuarioDA();
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

        public List<Usuario> List()
        {
            try
            {
                return ar.List();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Registrar(String a, String t, String e, int em)
        {
            try
            {
                return ar.Registrar(a, t, e, em);
            }
            catch (Exception) { return 0; }
        }

        public int Eliminar(String n)
        {
            try
            {
                return ar.Eliminar(n);
            }
            catch (Exception) { return 0; }
        }


    }
}
