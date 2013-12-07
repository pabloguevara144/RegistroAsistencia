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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // this.Label1.Text = "Hola Mundo Cruel"; 
           }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UsuarioBL usuarioBL = new UsuarioBL();
            String strUsuario = txtUsername.Value;
            String strPassword = txtPassword.Value;
            if (usuarioBL.existeUsuario(strUsuario, strPassword))
            {
                Session["s"] = strUsuario;
                Response.Redirect("~/Menu.aspx");                
            }
        }
    }
}
