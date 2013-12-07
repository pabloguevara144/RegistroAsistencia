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
                            <asp:TextBox ID="Txt_DNI" runat="server" MaxLength="8"></asp:TextBox> 
                            <label class="control-label" for="CboArea">&nbsp;&nbsp;&nbsp;&nbsp;Área&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:DropDownList ID="CboArea" runat="server" Height="30px" Width="172px"></asp:DropDownList>                            
                        </div>    
                        <div class="control-group">
                            <label class="control-label" for="Txt_ApPaterno">Apell. Paterno&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:TextBox ID="Txt_ApPaterno" runat="server"></asp:TextBox>
                            <label class="control-label" for="Txt_Fecha">&nbsp;&nbsp;&nbsp;&nbsp;Fec. Naci.&nbsp;&nbsp;&nbsp;&nbsp;</label>
                                <asp:DropDownList ID="CboDia" class="checkbox inline" runat="server" Height="31px" Width="60px">
                                </asp:DropDownList>
                                <asp:Label ID="Label1" runat="server" Text="/"></asp:Label> 
                                <asp:DropDownList ID="CboMes" class="checkbox inline" runat="server" Height="31px" Width="60px">
                                </asp:DropDownList>
                                <asp:Label ID="Label2" runat="server" Text="/"></asp:Label> 
                                <asp:DropDownList ID="CboAnio" class="checkbox inline" runat="server" Height="31px" Width="80px">
                                </asp:DropDownList> 
                            <label class="control-label" for="Txt_Horario">&nbsp;&nbsp;&nbsp;Horario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <asp:TextBox ID="Txt_Horario" runat="server"></asp:TextBox>
                            <a class="btn" href="#pricingShared" role="button" data-toggle="modal">Ver</a>
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
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Registrar" 
                                        runat="server" Text="Registrar" 
                                    cssclass="btn btn-primary" onclick="Registrar_Click" ></asp:Button>
                        </div>
                        <br />
                        <br />
                        <div class="control-group">
                            <div class="controls">
                                <asp:Label ID="LblResult" runat="server" Text="" CssClass="text-success"></asp:Label>
                            </div>
                        </div>
                    </fieldset>
                
                <div id ="pricingShared" class="modal hide fade">                 
                    <div class="modal-header"><h4>Horarios</h4></div>
                    <div class="modal-body">
                       <asp:GridView ID="GridView1" runat="server" Width="100%" CellPadding="4" 
                        ForeColor="#333333" GridLines="None" onselectedindexchanged="GridView1_SelectedIndexChanged" AllowPaging="True" 
                        onpageindexchanging="GridView1_PageIndexChanging"  
                        AutoGenerateColumns="False" Height="16px" PageSize="5">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:CommandField HeaderText="Seleccionar" SelectText="Seleccionar" 
                                ShowSelectButton="True" />
                            <asp:BoundField DataField="Nom_hor" HeaderText="HORARIO" />
                            <asp:BoundField DataField="Hor_ing" HeaderText="INGRESO" />
                            <asp:BoundField DataField="Hor_sal" HeaderText="SALIDA" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#F7F6F3" 
                            ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                    </div>
                    <div class="modal-footer">
                        <button class="btn" data-dismiss="modal">Salir</button>
                    </div>
                </div>
                </form>
        </div>
    </div>
</div>
</asp:Content>

