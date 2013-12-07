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
    public partial class ListarTardanza : System.Web.UI.Page
    {
        public string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre" };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {

                    this.lbltxtMes.Text = "Se filtra por el mes de : " + meses[Convert.ToInt32(DateTime.Now.Month.ToString()) - 1]; 
                    Listar(0);
                }
                catch (Exception)
                {

                }
            }
        }

        //llenamos el año actual
        public void llenarTreewView(TreeNode node)
        {
            TreeNode newNode = new TreeNode();
            newNode.Text = DateTime.Now.Year.ToString();
            newNode.Value = DateTime.Now.Year.ToString();
            newNode.PopulateOnDemand = true;
            newNode.SelectAction = TreeNodeSelectAction.Expand;
            node.ChildNodes.Add(newNode);
        }
        //Llenamos los meses
        public void llenarTreewViewMeses(TreeNode node)
        {
            
            for (int i = 0; i <= 11; i++)
            {
                TreeNode newNode = new TreeNode();
                newNode.Text = meses[i].ToString ();
                newNode.Value =i.ToString(); 
                newNode.PopulateOnDemand = true;
                newNode.SelectAction = TreeNodeSelectAction.SelectExpand;
                node.ChildNodes.Add(newNode);
            }
        }

        protected void TreeAsistencia_TreeNodePopulate(object sender, TreeNodeEventArgs e)
        {
           
            switch (e.Node.Depth)
            {
                case 0:
                    // Populate the first-level nodes.
                    llenarTreewView(e.Node);
                    break;
                case 1:
                    llenarTreewViewMeses(e.Node);
                    break;
                default:
                    // Do nothing.
                    break;
            }
        }

        public void Listar(int mesEnv)
        {
            List<Tardanza> ar = new TardanzaBL().ListarTardanza(mesEnv);
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

        protected void TreeAsistencia_SelectedNodeChanged(object sender, EventArgs e)
        {
            this.lblMes.Text = this.TreeAsistencia.SelectedValue.ToString();
            this.lbltxtMes.Text = "Se filtra por el mes de : " + meses[Convert.ToInt32(this.lblMes.Text.ToString())]; 
            Listar(Convert.ToInt32(this.lblMes.Text.ToString()) + 1); 
        }
    }
}