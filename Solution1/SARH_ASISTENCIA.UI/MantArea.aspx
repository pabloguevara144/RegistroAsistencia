<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MantArea.aspx.cs" Inherits="SARH_ASISTENCIA.UI.MantArea" %>
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
                    <form id="frm_Areaindex" class="form-horizontal" action="#" method="post" runat="server">
                        <fieldset>
				            <legend>Lista de áreas </legend>
                            <asp:Button ID="BtnRegistrar" runat="server" Text="Nuevo" class="btn btn-primary" onclick="BtnRegistrar_Click"/>
                            <br/>
                               <asp:GridView ID="GridView1" runat="server" Width="100%" CellPadding="4" 
                                    ForeColor="#333333" GridLines="None" 
                                onrowdeleting="GridView1_RowDeleting" 
                                onselectedindexchanged="GridView1_SelectedIndexChanged" AllowPaging="True" 
                                onpageindexchanging="GridView1_PageIndexChanging" 
                                AutoGenerateColumns="False" Height="16px" PageSize="5">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    <Columns>
                                        <asp:CommandField HeaderText="Editar" SelectText="Editar" 
                                            ShowSelectButton="True" />
                                        <asp:CommandField ButtonType="Button" HeaderText="Eliminar" 
                                            SelectText="Eliminar" ShowDeleteButton="True" />
                                        <asp:BoundField DataField="Nom_area" HeaderText="Area" />
                                        <asp:BoundField DataField="Sigla_area" HeaderText="Sigla" />
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
