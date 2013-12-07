<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MantJustificar.aspx.cs" Inherits="SARH_ASISTENCIA.UI.MantJustificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            height: 21px;
        }
    </style>
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
						<a href="#">Justificar Asistencia</a>
					</li>
				</ul>
			</div>
			
			<div class="row-fluid sortable ui-sortable">		
				<div class="box span12">
					<div data-original-title="" class="box-header well">
						<h2><i class="icon-user"></i> Justificar</h2>
					    
					</div>
					<div class="box-content">
                        <table border="0" style="width: 100%;">
                            <tr>
                                <td class="style1">
                                    <strong>Cósigo Asistencia</strong></td>
                                <td>
                                    <asp:Label ID="lblCodAsis" runat="server" Text="0" Width="250px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style1">
                                    <strong>Motivo </strong>
                                </td>
                                <td>
                                    <asp:Label ID="LblMotivo" runat="server" Text="Tardanza" Width="250px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style1">
                                    <strong>Justificación</strong></td>
                                <td> 
                                    <asp:TextBox ID="txJustificar" runat="server" Height="68px" Rows="50" 
                                        TextMode="MultiLine" Width="287px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="">
                                    <strong>Tipo Justificación</strong></td>
                                <td>
                                    <asp:DropDownList ID="dlTipo" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr style="display:none">
                                <td class="style1">
                                    <strong>Archivo:</strong></td>
                                <td>
                                    <asp:FileUpload ID="FileUpload1" runat="server"   Width="298px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="style1">
                                    <asp:Label ID="lblestado" runat="server" style="font-weight: 700" 
                                        Text="Estado:" Visible="False"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="dlEstado" runat="server" Visible="False">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="style1">
                                    <asp:Label ID="lblRespuesta" runat="server" style="font-weight: 700" 
                                        Text="Respuesta:" Visible="False"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txRespuesta" runat="server" Height="68px" Rows="50" 
                                        TextMode="MultiLine" Width="287px" Visible="False"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style1">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style2" align="center" colspan="2">
                                    <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" ForeColor="#003366" 
                                        Width="100%"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" class="style1" colspan="2" valign="middle">
                                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar"  
                                        CssClass ="btn btn-primary" onclick="btnGuardar_Click"/>&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar"  
                                        CssClass ="btn btn-primary" PostBackUrl="~/ListarTardanza.aspx" />
                                </td>
                            </tr>
                        </table>
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
