<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MantEmpleado.aspx.cs" Inherits="SARH_ASISTENCIA.UI.MantEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
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
                <form id="frm_Empleadoindex" class="form-horizontal" action="#" method="post" runat="server">
                <fieldset>
                <legend>Lista - Empleado</legend> 
                  <asp:GridView ID="GridView1" runat="server" Width="1040px" CellPadding="4" 
                        ForeColor="#333333" GridLines="None" 
                    onrowdeleting="GridView1_RowDeleting" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" AllowPaging="True" 
                    onpageindexchanging="GridView1_PageIndexChanging" 
                    AutoGenerateColumns="False" Height="16px" PageSize="5">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:CommandField HeaderText="Editar" SelectText="Editar" 
                                ShowSelectButton="True" ControlStyle-CssClass="btn btn-success" />
                            <asp:CommandField ButtonType="Button" HeaderText="Eliminar" 
                                SelectText="Eliminar  <i class='icon-trash icon-white'></i>"  ShowDeleteButton="True" ControlStyle-CssClass="btn btn-danger" />
                            <asp:BoundField DataField="Cod_empl" HeaderText="CÓDIGO" />
                            <asp:BoundField DataField="Nom_emp" HeaderText="NOMBRE" />
                            <asp:BoundField DataField="Ape_pat" HeaderText="APELL. PATERNO" />
                            <asp:BoundField DataField="Ape_mat" HeaderText="APELL. MATERNO" />
                            <asp:BoundField DataField="Dni" HeaderText="DNI" />
                            <asp:BoundField DataField="Fec_nac" HeaderText="FEC. NACIM." />
                            <asp:BoundField DataField="Tel_cel" HeaderText="TELEFONO" />
                            <asp:BoundField DataField="Sex_emp" HeaderText="SEXO" />
                            <asp:BoundField DataField="Est_emp" HeaderText="ESTADO" />
                            <asp:BoundField DataField="Hora_id" HeaderText="HORARIO" />
                            <asp:BoundField DataField="Area_id" HeaderText="ÁREA" />
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
                    <div class="form-actions">
                        <asp:Button ID="BtnRegistrar" runat="server" Text="Nuevo" 
                        cssclass="btn btn-primary" onclick="BtnRegistrar_Click"/>
                    </div>
                    </fieldset>
                </form>
     </div>
 </div>
 </div>
 </div>
</asp:Content>
