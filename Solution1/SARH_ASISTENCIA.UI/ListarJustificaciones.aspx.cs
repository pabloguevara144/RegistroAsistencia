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
    public partial class ListarJustificaciones : System.Web.UI.Page
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
            List<Justificacion> ar = new JustificacionBL().List();
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
    }
}