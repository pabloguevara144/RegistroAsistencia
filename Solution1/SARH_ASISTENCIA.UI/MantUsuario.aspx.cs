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
    public partial class MantUsuario : System.Web.UI.Page
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
            List<Usuario> ar = new UsuarioBL().List();
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

        public void Formato() { 
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
                Response.Redirect("ManRegUsuarios.aspx");
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
                String al = fila.Cells[2].Text;
                String tp = fila.Cells[3].Text;
                String es = fila.Cells[4].Text;
                String em = fila.Cells[5].Text;
                Response.Redirect("ManRegUsuarios.aspx?al=" + al + "&tp=" + tp + "&es=" + es + "&em=" + em);
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
                UsuarioBL a = new UsuarioBL();
                int index = Convert.ToInt32(e.RowIndex);
                i = a.Eliminar(GridView1.Rows[index].Cells[2].Text.ToString());
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