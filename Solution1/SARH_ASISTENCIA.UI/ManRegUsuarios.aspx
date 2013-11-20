<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ManRegUsuarios.aspx.cs" Inherits="SARH_ASISTENCIA.UI.ManRegUsuarios" %>
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
						<a href="#">usuario</a>
					</li>
				</ul>
	</div>
<div class="row-fluid sortable ui-sortable">
		    <div class="box span12">
                    <div class="box-header well" data-original-title="">
						    <h2><i class="icon-edit"></i> Matenimiento de usuario</h2>
				    </div>
            <div class="box-content">
                <form id="frm_UsuarioindexReg" class="form-inline" action="#" method="post" runat="server">
                    <fieldset>
                        <legend>Mantenimiento - Usuarios</legend>                        
                        <div class="control-group">
                            <label class="control-label" for="Txt_Empleado">Cod. Empleado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:TextBox ID="Txt_Empleado" runat="server"></asp:TextBox>
                            <label class="control-label" for="Txt_Alias">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Alias&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:TextBox ID="Txt_Alias" runat="server"></asp:TextBox>
                        </div>       
                        <br/>
                        <div class="control-group">
                            <label class="control-label" for="CboTipUsuario">Tipo de Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:DropDownList ID="CboTipUsuario" runat="server" Height="30px" Width="172px"></asp:DropDownList>
                            <label class="control-label" for="CboArea" id="est" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Estado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <label class="checkbox inline"><asp:CheckBox ID="CheckBox1" runat="server" 
                                    ValidationGroup="A" />Activo</label>
                            
                                <label class="checkbox inline"><asp:CheckBox ID="CheckBox2" runat="server" 
                                    ValidationGroup="A" />Inactivo</label>
                        </div>   
                        <br/>   
                        <div class="controls"> 
                                    <asp:Button ID="Retornar" runat="server" Text="Retornar" 
                                    cssclass="btn btn-inverse" onclick="Retornar_Click" Width="85px"></asp:Button>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Registrar" runat="server" Text="Registrar" 
                                    cssclass="btn btn-primary" onclick="Registrar_Click"></asp:Button>
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
