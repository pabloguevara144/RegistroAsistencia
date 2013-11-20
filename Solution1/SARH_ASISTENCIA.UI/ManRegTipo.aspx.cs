using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SARH_ASISTENCIA.BL;

namespace SARH_ASISTENCIA.UI
{
    public partial class ManRegTipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblResult.Text = "";
                String n = Request.QueryString["id"];
                String s = Request.QueryString["desc"];
                if (n == null) { n = "0"; }
                if (s == null) { s = ""; }
                LblCodigo.Text = n;
                Txt_Desc.Text = s;
                if (n.Trim().Equals("0") || s.Trim().Equals(""))
                {
                    Registrar.Text = "Registrar";
                    LblCodigo.Visible = false;
                    lblCod.Visible = false;
                }
                else { Registrar.Text = "Modificar";
                LblCodigo.Visible = true;
                lblCod.Visible = true;
                }
                Txt_Desc.Focus();
            }
        }

        protected void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                TipoBL a = new TipoBL();
                i = a.Registrar(Convert.ToInt32(LblCodigo.Text.Trim().ToString()), Txt_Desc.Text.Trim());
                if (i > 0)
                {
                    LblResult.CssClass = "text-success";
                    LblResult.Text = "La operación se realizó exitosamente.";
                }
                else
                {                    
                    LblResult.CssClass = "text-error";
                    LblResult.Text = "Ocurrio un error, Comuníquese con soporte tecnico.";
                }
            }
            catch (Exception) { }
        }

        protected void Retornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MantTipo.aspx");
        }
    }
}