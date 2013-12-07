<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarcarAsistencia.aspx.cs" Inherits="SARH_ASISTENCIA.UI.MarcarAsistencia" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro de Asistencia</title>
    <!-- The styles -->
	<link  href="css/bootstrap-cerulean.css" rel="stylesheet" />
	<style type="text/css">
	  body {
		padding-bottom: 40px;
	  }
	  .sidebar-nav {
		padding: 9px 0;
	  }
	</style>
	<link href="css/bootstrap-responsive.css" rel="stylesheet"/>
	<link href="css/charisma-app.css" rel="stylesheet"/>
	<link href="css/jquery-ui-1.8.21.custom.css" rel="stylesheet"/>
	<link href='css/fullcalendar.css' rel='stylesheet'/>
	<link href='css/fullcalendar.print.css' rel='stylesheet'  media='print'/>
	<link href='css/chosen.css' rel='stylesheet'/>
	<link href='css/uniform.default.css' rel='stylesheet'/>
	<link href='css/colorbox.css' rel='stylesheet'/>
	<link href='css/jquery.cleditor.css' rel='stylesheet'/>
	<link href='css/jquery.noty.css' rel='stylesheet'/>
	<link href='css/noty_theme_default.css' rel='stylesheet'/>
	<link href='css/elfinder.min.css' rel='stylesheet'/>
	<link href='css/elfinder.theme.css' rel='stylesheet'/>
	<link href='css/jquery.iphone.toggle.css' rel='stylesheet'/>
	<link href='css/opa-icons.css' rel='stylesheet'/>
	<link href='css/uploadify.css' rel='stylesheet'/>

	<!-- The HTML5 shim, for IE6-8 support of HTML5 elements -->
	<!--[if lt IE 9]>
	  <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
	<![endif]-->

	<!-- The fav icon -->
	<link rel="shortcut icon" href="img/favicon.ico"/>
<script language="javascript" type="text/javascript">
    // <!CDATA[

    function remember_onclick() {

    }
    function Validar() {
        var codigo = document.getElementById("id").value;
        alert(codigo);
    }

    // ]]>
</script>
</head>
<body onload="window.document.form1.txtCodigoEmpleado." >
    <form id="form1" runat="server">
    <div class="span12 center login-header">
        <P><strong><h2>Registro de Asistencia</h2></strong></P>
        <P><strong>Ingrese su Código de Empleado</strong></P>
        <P>
            <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" Font-Size="Medium" 
                ForeColor="Maroon" Text="Mensaje de error" Visible="False"></asp:Label>
        </P>
        <P>
            <i class="icon-user"></i></span><asp:TextBox ID="txtCodigoEmpleado" 
                name="txtCodigoEmpleado" runat="server" Font-Bold="True" 
                Font-Size="14pt" Height="30px" Width="267px" 
                ontextchanged="txtCodigoEmpleado_TextChanged" MaxLength="8"></asp:TextBox>
        </P>
        <P>
           <asp:Button ID="btnRegistrar" CssClass ="btn btn-primary" runat="server" 
                Text="Registrar" onclick="btnRegistrar_Click"  /></P>
    </div>
    </form>
</body>
</html>
