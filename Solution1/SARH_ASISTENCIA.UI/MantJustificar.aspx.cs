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
    public partial class MantJustificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.lblCodAsis.Text = Request.QueryString["coAsis"].ToString();
                this.LblMotivo.Text = Request.QueryString["tipo"].ToString();
                List<Justificacion> ar = new JustificacionBL().getJustificar(Convert.ToInt32(this.lblCodAsis.Text));
                if (Request.QueryString["accion"].ToString().Equals("atender"))
                {
                    this.txJustificar.Enabled = false;
                    this.dlTipo.Enabled = false;
                    this.lblestado.Visible = true;
                    this.lblRespuesta.Visible = true;
                    this.txRespuesta.Visible = true;
                    this.dlEstado.Visible = true;
                  //  List<Justificacion> ar = new JustificacionBL(). getJustificar (Convert.ToInt32 ( this.lblCodAsis.Text) );
                    /*this.txJustificar.Text = ar[0].Motivo.ToString();
                    this.dlTipo.SelectedValue = ar[0].Codigo_tipo_justificacion.ToString();
                    this.dlEstado.SelectedValue = ar[0].Codigo_estado.ToString();
                    this.txRespuesta.Text = ar[0].Respuesta.ToString();*/
                    llenarEstadoJustificacion();
                }
                llenarTipoJustificacion();
                if (ar.Count > 0)
                {
                    this.txJustificar.Text = ar[0].Motivo.ToString();
                    this.dlTipo.SelectedValue = ar[0].Codigo_tipo_justificacion.ToString();
                    this.dlEstado.SelectedValue = ar[0].Codigo_estado.ToString();
                    this.txRespuesta.Text = ar[0].Respuesta.ToString();
                    if (Request.QueryString["accion"].ToString().Equals("nada"))
                         this.btnGuardar.Enabled = false;  

                }
                
            }
        }

        public void llenarTipoJustificacion()
        {
            List<TipoJustificacion> ar = new TipoJustificacionBL().List();
            if (ar.ToList().Count() > 0)
            {
                this.dlTipo.DataSource= ar.ToList();
                dlTipo.DataTextField = "Descripcion";
                dlTipo.DataValueField = "Codigo_Estado"; 
                this.dlTipo.DataBind();
                //Formato();
            }
            else
            {
                dlTipo.DataSource = null;
                dlTipo.DataBind();
            }
        }

        public void llenarEstadoJustificacion()
        {
            List<TipoJustificacion> ar = new TipoJustificacionBL().ListEstado();
            if (ar.ToList().Count() > 0)
            {
                this.dlEstado.DataSource = ar.ToList();
                dlEstado.DataTextField = "Descripcion";
                dlEstado.DataValueField = "Codigo_Estado";
                this.dlEstado.DataBind();
                //Formato();
            }
            else
            {
                dlEstado.DataSource = null;
                dlEstado.DataBind();
            }
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //REGISTRAMNIOS EN LA BD
            Justificacion objJust = new Justificacion();
            objJust.Codigo_asistencia = Convert.ToInt32(this.lblCodAsis.Text.ToString())  ;
            objJust.Codigo_estado = 1;
            objJust.Codigo_tipo_justificacion = Convert.ToInt32(this.dlTipo.SelectedItem.Value.ToString());
            objJust.Motivo = this.txJustificar.Text.ToString().Trim();
            objJust.Archivo = "";
            objJust.Respuesta = "";
            if (Request.QueryString["accion"].ToString().Equals("atender"))
            {
                objJust.Respuesta = this.txRespuesta.Text.ToString();
                objJust.Codigo_estado = Convert.ToInt32(this.dlEstado.SelectedItem.Value.ToString()); ;
            }
            JustificacionBL justificacionBL = new JustificacionBL();
            int intGrabar = justificacionBL.Registrar(objJust);
            if (intGrabar == 0)
            {
                this.lblMensaje.Text = "Ocurrio un error al Grabar consulte la Base de Datos";
            }
            else if (intGrabar == 1)
            {
                this.lblMensaje.Text = "La justificación se realizó con exito";
                Response.Redirect("~/ListarJustificaciones.aspx"); 
            }

        }
    }
}