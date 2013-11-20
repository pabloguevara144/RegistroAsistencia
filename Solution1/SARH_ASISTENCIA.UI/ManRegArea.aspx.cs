using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SARH_ASISTENCIA.BE;
using SARH_ASISTENCIA.BL;

namespace SARH_ASISTENCIA.UI
{
    public partial class ManRegArea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                LblResult.Text = "";
                String n = Request.QueryString["nombre"];
                String s = Request.QueryString["sigla"];
                if (n == null) { n = ""; }
                if (s == null) { s = ""; }
                Txt_Area.Text = n;
                Txt_Sigla.Text = s;
                if (n.Trim().Equals("") || s.Trim().Equals(""))
                {
                    Registrar.Text = "Registrar";
                    Txt_Area.Enabled = true;
                }
                else { 
                    Registrar.Text = "Modificar";
                    Txt_Area.Enabled = false;
                }
                Txt_Area.Focus();
            }
        }

        protected void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                AreaBL a = new AreaBL();
                i = a.Registrar(Txt_Area.Text.Trim(),Txt_Sigla.Text.Trim());
                if (i > 0) {
                    LblResult.CssClass = "text-success"; 
                    LblResult.Text = "La operación se realizó exitosamente.";
                }
                else { 
                    LblResult.CssClass = "text-error";
                    LblResult.Text = "Ocurrio un error, Comuníquese con soporte tecnico.";
                }
            }
            catch(Exception) { }
        }

        protected void Retornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MantArea.aspx");
        }
    }
}