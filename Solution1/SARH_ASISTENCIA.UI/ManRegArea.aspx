<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ManRegArea.aspx.cs" Inherits="SARH_ASISTENCIA.UI.ManRegArea" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
<div id="content" class="span10">

    <div>
				<ul class="breadcrumb">
					<li>
						<a href="#">Inicio</a> <span class="divider">/</span>
					</li>
					<li>
						<a href="#">áreas</a>
					</li>
				</ul>
	</div>

    <div class="row-fluid sortable ui-sortable">
		    <div class="box span12">
                    <div class="box-header well" data-original-title="">
						    <h2><i class="icon-edit"></i> Matenimiento de áreas</h2>
				    </div>
                    <div class="box-content">
                    <form id="frm_periodoindexReg" class="form-horizontal" action="#" method="post" runat="server">
                        <fieldset>
                            <legend>Mantenimiento - Áreas</legend>                        
                            <div class="control-group">
                                <label class="control-label" for="S_AÃ±o">Descripción</label>
                                <div class="controls">
                                    <asp:TextBox ID="Txt_Area" runat="server">  </asp:TextBox> 
                                </div>
                            </div>
                            <div class="control-group">
                                <label class="control-label" for="Txt_Periodo">Sigla</label>
                                <div class="controls">
                                    <asp:TextBox ID="Txt_Sigla" runat="server">   </asp:TextBox>
                                </div>
                            </div>                    
                            <div class="controls"> 
                                        <asp:Button ID="Retornar" runat="server" Text="Retornar" 
                                        class="btn btn-inverse" onclick="Retornar_Click" Width="85px"></asp:Button>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Registrar" runat="server" Text="Registrar" 
                                        class="btn btn-primary" onclick="Registrar_Click"></asp:Button>
                            </div>
                            <br />
                            <br />
                            <div class="control-group">
                                <div class="controls">
                                    <asp:Label ID="LblResult" runat="server" Text="" CssClass="text-success"></asp:Label>
                                </div>
                            </div>
                        </fieldset>
                    </form>
                </div>
            </div>
    </div>
</div>

</asp:Content>
