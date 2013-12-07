using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SARH_ASISTENCIA.BL;
using SARH_ASISTENCIA.BE;
using System.IO;
using System.Text;

namespace SARH_ASISTENCIA.UI
{
    public partial class ListarAsistencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    Listar();
                }
                catch (Exception)
                {

                }
            }
        }

        public void Listar()
        {
            List<Asistencia> ar = new AsistenciaBL().ListarAsistencia();
            if (ar.ToList().Count() > 0)
            {
                gdAsistencia.DataSource = ar.ToList();
                gdAsistencia.DataBind();
            }
            else
            {
                gdAsistencia.DataSource = null;
                gdAsistencia.DataBind();
            }
        }

        private void ExportToExcel(string nameReport, GridView wControl)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            Page page = new Page();
            ListarAsistencia form = new ListarAsistencia();
            wControl.EnableViewState = false;
            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;
            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();
            page.Controls.Add(form);
            form.Controls.Add(wControl);
            page.RenderControl(htw);
            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=data.xls");
            Response.Charset = "UTF-8";
            Response.ContentEncoding = Encoding.Default;
            Response.Write(sb.ToString());
            Response.End();
        }

        protected void BtnExportar_Click(object sender, EventArgs e)
        {
            ExportGridView();
        }

        private void ExportGridView()
        {
            string attachment = "attachment; filename=Asistencia.xls";
            Response.ClearContent();
            Response.AddHeader("content-disposition", attachment);
            Response.ContentType = "application/ms-excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            gdAsistencia.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //return;
        }
    }
}