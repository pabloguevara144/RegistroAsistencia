<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MantTipo.aspx.cs" Inherits="SARH_ASISTENCIA.UI.MantTipo" %>
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
						<a href="#">tipo de usuario</a>
					</li>
				</ul>
	</div>

        <div class="row-fluid sortable ui-sortable">
		<div class="box span12">
                <div class="box-header well" data-original-title="">
						<h2><i class="icon-edit"></i> Matenimiento de tipo de usuario</h2>
				</div>
                <div class="box-content">
                <form id="frm_tipoindex" class="form-horizontal" action="#" method="post" runat="server">
                <fieldset>
                        <legend>Lista - Tipo de Usuarios</legend>
                <asp:Button ID="BtnRegistrar" runat="server" Text="Nuevo" 
                    class="btn btn-primary" onclick="BtnRegistrar_Click"/>
                <br/>
                       <asp:GridView ID="GridView1" runat="server" Width="933px" CellPadding="4" 
                            ForeColor="#333333" GridLines="None" 
                        onrowdeleting="GridView1_RowDeleting" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged" AllowPaging="True" 
                        onpageindexchanging="GridView1_PageIndexChanging" 
                        AutoGenerateColumns="False" PageSize="5" Height="16px">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:CommandField HeaderText="Editar" SelectText="Editar"  ControlStyle-CssClass="btn btn-success" 
                                    ShowSelectButton="True" />
                                <asp:CommandField ButtonType="Button" HeaderText="Eliminar" ControlStyle-CssClass="btn btn-danger"
                                    SelectText="Eliminar" ShowDeleteButton="True" />
                                <asp:BoundField DataField="Tipo_id" HeaderText="Código">
                                <ControlStyle Width="20px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Nom_tipo" HeaderText="Tipo"></asp:BoundField>
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
                    </fieldset>
                </form>
</div>
        </div>
     </div>
 </div>

</asp:Content>
