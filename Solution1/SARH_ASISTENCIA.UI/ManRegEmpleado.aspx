<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ManRegEmpleado.aspx.cs" Inherits="SARH_ASISTENCIA.UI.ManRegEmpleado" %>
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
						<a href="#">empleado</a>
					</li>
				</ul>
	</div>
<div class="row-fluid sortable ui-sortable">
		    <div class="box span12">
                    <div class="box-header well" data-original-title="">
						    <h2><i class="icon-edit"></i> Matenimiento de empleado</h2>
				    </div>
            <div class="box-content">
                <form id="frm_UsuarioindexReg" class="form-inline" action="#" method="post" runat="server">
                    <fieldset>
                        <legend>Mantenimiento - empleado</legend>                        
                        <div class="control-group">
                            <label class="control-label" for="Txt_Empleado">Cod. Empleado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:TextBox ID="Txt_Empleado" runat="server"></asp:TextBox>
                            <label class="control-label" for="Txt_DNI">&nbsp;&nbsp;&nbsp;&nbsp;DNI&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:TextBox ID="Txt_DNI" runat="server"></asp:TextBox> 
                            <label class="control-label" for="CboArea">&nbsp;&nbsp;&nbsp;&nbsp;Área&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:DropDownList ID="CboArea" runat="server" Height="30px" Width="172px"></asp:DropDownList>                            
                        </div>    
                        <div class="control-group">
                            <label class="control-label" for="Txt_ApPaterno">Apell. Paterno&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:TextBox ID="Txt_ApPaterno" runat="server"></asp:TextBox>
                            <label class="control-label" for="Txt_DNI">&nbsp;&nbsp;&nbsp;&nbsp;Fec. Naci.&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:TextBox ID="Txt_Fecha" runat="server"></asp:TextBox>
                            <label class="control-label" for="Txt_Horario">&nbsp;&nbsp;&nbsp;&nbsp;Horario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:TextBox ID="Txt_Horario" runat="server"></asp:TextBox>
                        </div> 

                        <div class="control-group">
                            <label class="control-label" for="Txt_ApMaterno">Apell. Materno&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:TextBox ID="Txt_ApMaterno" runat="server"></asp:TextBox>
                            <label class="control-label" for="Txt_Tel">&nbsp;&nbsp;&nbsp;&nbsp;Telefono&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:TextBox ID="Txt_Tel" runat="server"></asp:TextBox>
                            <label class="control-label" for="CboArea" id="est" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;Estado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <label class="checkbox inline"><asp:CheckBox ID="CheckBox1" runat="server" 
                                    ValidationGroup="A" />Activo</label>
                            
                                <label class="checkbox inline"><asp:CheckBox ID="CheckBox2" runat="server" 
                                    ValidationGroup="A" />Inactivo</label>
                        </div>                        
                        <div class="control-group">
                            <label class="control-label" for="Txt_Nombre">Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;</label>
                            <asp:TextBox ID="Txt_Nombre" runat="server"></asp:TextBox>
                            <label class="control-label" for="Txt_Sexo">&nbsp;&nbsp;&nbsp;&nbsp;Sexo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;</label>
                            <asp:DropDownList ID="CboSexo" runat="server" Height="30px" Width="172px"></asp:DropDownList>                            
                        </div> 
                        <br/>   
                        <div class="form-actions"> 
                                    <asp:Button ID="Retornar" runat="server" Text="Retornar" 
                                    cssclass="btn btn-inverse"  Width="85px" onclick="Retornar_Click"></asp:Button>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Registrar" runat="server" Text="Registrar" 
                                    cssclass="btn btn-primary" ></asp:Button>
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
