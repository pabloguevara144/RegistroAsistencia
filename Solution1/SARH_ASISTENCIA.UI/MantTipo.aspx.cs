using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SARH_ASISTENCIA.BL;
using SARH_ASISTENCIA.BE;

namespace SARH_ASISTENCIA.UI
{
    public partial class MantTipo : System.Web.UI.Page
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
            List<Tipo> ar = new TipoBL().List();
            if (ar.ToList().Count() > 0)
            {
                GridView1.DataSource = ar.ToList();
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("ManRegTipo.aspx");
            }
            catch (Exception)
            {
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow fila = GridView1.SelectedRow;
                String n = fila.Cells[2].Text;
                String s = fila.Cells[3].Text;
                Response.Redirect("ManRegTipo.aspx?id=" + n + "&desc=" + s);
            }
            catch (Exception)
            {
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int i;
                TipoBL a = new TipoBL();
                int index = Convert.ToInt32(e.RowIndex);
                i = a.Eliminar(Convert.ToInt32(GridView1.Rows[index].Cells[2].Text.ToString()));
                if (i > 0)
                {
                    Listar();
                }
            }
            catch (Exception)
            {
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                GridView gv = (GridView)sender;
                gv.PageIndex = e.NewPageIndex;
                Listar();
            }
            catch (Exception)
            {
            }
        }
    }
}