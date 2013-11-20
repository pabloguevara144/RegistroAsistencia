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
    public partial class MantEmpleado : System.Web.UI.Page
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
            List<Empleado> ar = new EmpleadoBL().List();
            if (ar.ToList().Count() > 0)
            {
                GridView1.DataSource = ar.ToList();
                GridView1.DataBind();
                //Formato();
            }
            else
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
        }

        public void Formato()
        {
            //	Usu_id	Usu_alias	Usu_clave	Usu_nombre	Usu_apellido	Usu_tipo	Usu_dni	Area_id	Usu_estado	Usu_area
            GridView1.Columns[2].Visible = false;
            GridView1.Columns[3].HeaderText = "Usuario";
            GridView1.Columns[4].Visible = false;
            GridView1.Columns[5].HeaderText = "Nombre";
            GridView1.Columns[6].HeaderText = "Apellido";
            GridView1.Columns[7].HeaderText = "Tipo";
            GridView1.Columns[8].HeaderText = "DNI";
            GridView1.Columns[9].Visible = false;
            GridView1.Columns[10].HeaderText = "Estado";
            GridView1.Columns[11].HeaderText = "Área";
        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("ManRegEmpleado.aspx");
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
                String codem = fila.Cells[2].Text;
                String nomem = fila.Cells[3].Text;
                String appat = fila.Cells[4].Text;
                String apmat = fila.Cells[5].Text;
                String dnemp = fila.Cells[6].Text;
                String feemp = fila.Cells[7].Text;
                String teemp = fila.Cells[8].Text;
                String seemp = fila.Cells[9].Text;
                String esemp = fila.Cells[10].Text;
                String hoemp = fila.Cells[11].Text;
                String aremp = fila.Cells[12].Text;
                Response.Redirect("ManRegEmpleado.aspx?codem=" + codem + "&nomem=" + nomem + "&appat=" + appat + "&apmat=" + apmat+ "&dnemp=" + dnemp + "&feemp=" + feemp + "&teemp=" + teemp + "&seemp=" + seemp + "&esemp=" + esemp + "&hoemp=" + hoemp + "&aremp=" + aremp);
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
                EmpleadoBL a = new EmpleadoBL();
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