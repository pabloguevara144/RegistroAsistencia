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
    public partial class ManRegEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblResult.Text = "";
                String codem = Request.QueryString["codem"];
                String nomem = Request.QueryString["nomem"];
                String appat = Request.QueryString["appat"];
                String apmat = Request.QueryString["apmat"];
                String dnemp = Request.QueryString["dnemp"];
                String feemp = Request.QueryString["feemp"];
                String teemp = Request.QueryString["teemp"];
                String seemp = Request.QueryString["seemp"];
                String esemp = Request.QueryString["esemp"];
                String hoemp = Request.QueryString["hoemp"];
                String aremp = Request.QueryString["aremp"];
                if (codem == null) { codem = ""; }
                if (nomem == null) { nomem = ""; }
                if (appat == null) { appat = ""; }
                if (apmat == null) { apmat = ""; }
                if (dnemp == null) { dnemp = ""; }
                if (feemp == null) { feemp = ""; }
                if (teemp == null) { teemp = ""; }
                if (seemp == null) { seemp = ""; }
                if (esemp == null) { esemp = ""; }
                if (hoemp == null) { hoemp = ""; }
                if (aremp == null) { aremp = ""; }
                Txt_Empleado.Text = codem;
                Txt_Nombre.Text = nomem;
                Txt_ApPaterno.Text = appat;
                Txt_ApMaterno.Text = apmat;
                Txt_DNI.Text = dnemp;
                Txt_Fecha.Text = feemp;
                Txt_Tel.Text = teemp;                
                Txt_Horario.Text = hoemp;                
                ListarArea();
                ListarSexo();
                if (esemp.Equals("Activo"))
                {
                    CheckBox1.Checked = true; CheckBox2.Checked = false;
                }
                else if (esemp.Equals("Inactivo"))
                {
                    CheckBox2.Checked = true; CheckBox1.Checked = false;
                }
                else
                {
                    CheckBox2.Checked = false; CheckBox1.Checked = false;
                }

                if (codem.Trim().Equals(""))
                {
                    Registrar.Text = "Registrar";
                    Txt_Empleado.Enabled = true;
                    Txt_Empleado.Focus();
                }
                else
                {
                    Registrar.Text = "Modificar";
                    Txt_Empleado.Enabled = false;
                    CboSexo.SelectedItem.Text = seemp;
                    CboArea.SelectedValue = aremp;
                }

            }
        }

        protected void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                EmpleadoBL a = new EmpleadoBL();                
                String es;
                if (CheckBox1.Checked == true)
                {
                    es = "A";
                }
                else
                {
                    es = "I";
                }                
                i = a.Registrar(Convert.ToInt32(Txt_Empleado.Text.Trim()), CboArea.Text.Trim(), Txt_Horario.Text.Trim(), Txt_ApPaterno.Text.Trim(), 
                    Txt_ApMaterno.Text.Trim(),Txt_Nombre.Text.Trim(),Txt_DNI.Text.Trim(),Txt_Fecha.Text.Trim(),Txt_Tel.Text.Trim(),CboSexo.Text.Trim(),es );
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
            Response.Redirect("MantEmpleado.aspx");
        }

        public void ListarArea()
        {
            List<Area> ar = new AreaBL().List();
            if (ar.ToList().Count() > 0)
            {
                foreach (Area a in ar)
                {
                    CboArea.Items.Add(a.Nom_area);
                }
            }
            else
            {
                CboArea.DataSource = null;
            }
        }

        public void ListarSexo(){
            CboSexo.Items.Add("Masculino");
            CboSexo.Items.Add("Femenino");
        }

    }
}