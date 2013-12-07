using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SARH_ASISTENCIA.BE;
using SARH_ASISTENCIA.BL;  

namespace SARH_ASISTENCIA.UI
{
    public partial class MarcarAsistencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            registrarAsistencia();
        }
        protected void txtCodigoEmpleado_TextChanged(object sender, EventArgs e)
        {
           // registrarAsistencia();
        }
        public void registrarAsistencia()
        {
            AsistenciaBL asistenciaBL = new AsistenciaBL();
            String strEmpleado = this.txtCodigoEmpleado.Text;
            int resultado = asistenciaBL.registraAsistencia(strEmpleado);
            this.lblMensaje.Visible = false;
            if (resultado == 0)
            {
                this.lblMensaje.Visible = true;
                this.txtCodigoEmpleado.Text = "";
                this.lblMensaje.Text = "Se Guardo con exito";
            }
            else if (resultado == 1)
            {
                this.lblMensaje.Visible = true;
                this.lblMensaje.Text = "El empleado no existe";
            }
            else if (resultado == -1)
            {
                this.lblMensaje.Visible = true;
                this.lblMensaje.Text = "Ocurrio un error";
            }
        }
    }
}