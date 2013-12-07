<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListarJustificaciones.aspx.cs" Inherits="SARH_ASISTENCIA.UI.ListarJustificaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <form id="form1" runat="server">
    <div class="span10" id="content">
			<!-- content starts -->
			

			<div>
				<ul class="breadcrumb">
					<li>
						<a href="#">Inicio</a> <span class="divider">/</span>
					</li>
					<li>
						<a href="#">Justificaciones</a>
					</li>
				</ul>
			</div>
			
			<div class="row-fluid sortable ui-sortable">		
				<div class="box span12">
					<div data-original-title="" class="box-header well">
						<h2><i class="icon-user"></i> Lista de Justificaciones </h2>
					</div>
					<div class="box-content"  style="height:350px">
                    <div>
                                    
                                        


                                        <asp:GridView ID="gdAsistencia" runat="server" Width="807px" CellPadding="4" 
                                        ForeColor="#333333" GridLines="None" Height="16px" 
                                        AutoGenerateColumns="False">
                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                        <Columns>
                                            <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                                            <asp:BoundField DataField="D_fecha" HeaderText="Fecha" />
                                            <asp:BoundField DataField="Dni" HeaderText="DNI" />
                                            <asp:BoundField DataField="Estado_text" HeaderText="Estado" />
                                            <asp:HyperLinkField 
                                                DataNavigateUrlFields="Codigo_asistencia" 
                                                DataNavigateUrlFormatString="~/MantJustificar.aspx?coAsis={0}&amp;tipo=Tardanza&amp;accion=atender" 
                                                ShowHeader="False" Text="Atender <i class='icon-edit icon-white'" ControlStyle-CssClass="btn btn-info" />
                                        </Columns>
                                        <EditRowStyle BackColor="#999999" />
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                                    </asp:GridView>


                                    
                                  
                                    </div>
                                   </div>
				</div><!--/span-->
			
			</div><!--/row-->

			<!--/row-->
			
			<div class="row-fluid sortable ui-sortable">	
				<!--/span-->
				
				<!--/span-->
			
			</div><!--/row-->
			
			<div class="row-fluid sortable ui-sortable">	
				<!--/span-->
			</div><!--/row-->
    
					<!-- content ends -->
			</div>



    </form>
</asp:Content>
