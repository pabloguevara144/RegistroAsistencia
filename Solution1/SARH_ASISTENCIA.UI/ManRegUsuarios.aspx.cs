using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SARH_ASISTENCIA.BL;
using SARH_ASISTENCIA.BE;
using System.Data;

namespace SARH_ASISTENCIA.UI
{
    public partial class ManRegUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblResult.Text = "";
                //al=" + al + "&no=" + no+"&ap="+ap+"&dn="+dn+"&tp="+tp+"&es="+es+"&ar="+ar
                String al = Request.QueryString["al"];
                String tp = Request.QueryString["tp"];
                String es = Request.QueryString["es"];
                String em = Request.QueryString["em"];
                if (al == null) { al = ""; }
                if (tp == null) { tp = ""; }
                if (es == null) { es = ""; }
                if (em == null) { em = ""; }
                Txt_Alias.Text = al;
                Txt_Empleado.Text = em;
                ListarTipo();
                if (es.Equals("Activo")) {
                    CheckBox1.Checked = true; CheckBox2.Checked = false;
                }
                else if (es.Equals("Inactivo"))
                {
                    CheckBox2.Checked = true; CheckBox1.Checked = false;
                }
                else {
                    CheckBox2.Checked = false; CheckBox1.Checked = false;
                }
                if (al.Trim().Equals(""))
                {
                    Registrar.Text = "Registrar";
                    Txt_Alias.Enabled = true;
                    Txt_Empleado.Focus();
                }
                else
                {
                    Registrar.Text = "Modificar";                    
                    CboTipUsuario.SelectedValue = tp;
                    Txt_Empleado.Enabled = false;
                    Txt_Alias.Enabled = false;
                    CboTipUsuario.Focus();
                }
                
            }
        }

        protected void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                int i=0;
                UsuarioBL a = new UsuarioBL();
                //String a, String n, String p, String t, String d, String e, Int32 r
                String es;
                if(CheckBox1.Checked==true){ 
                    es = "A"; 
                } else { 
                    es = "I";
                }
                i = a.Registrar(Txt_Alias.Text.Trim(),CboTipUsuario.Text,es,Convert.ToInt32(Txt_Empleado.Text.Trim()));
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
            Response.Redirect("MantUsuario.aspx");
        }

       

        public void ListarTipo()
        {
            List<Tipo> ar = new TipoBL().List();
            if (ar.ToList().Count() > 0)
            {
                foreach (Tipo a in ar)
                {
                    CboTipUsuario.Items.Add(a.Nom_tipo);
                }
            }
            else
            {
                CboTipUsuario.DataSource = null;
            }
        }

    }
}