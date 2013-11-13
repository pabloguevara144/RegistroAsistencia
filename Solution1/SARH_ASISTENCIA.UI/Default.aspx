<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SARH_ASISTENCIA.UI.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>SARH ASISTENCIA</title>
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

// ]]>
</script>
</head>
<body>
<form runat="server" class="form-horizontal" method="post" id="form1">
    <div class="container-fluid">
		<div class="row-fluid">
		
			<div class="row-fluid">
				<div class="span12 center login-header">
					<h2>Bienvenidos SARH ASISTENCIA</h2>
				</div>
			</div>
			
			<div class="row-fluid">
				<div class="well span5 center login-box">
					<div class="alert alert-info" style="display:none">
						Por favor ingresa tu usuario y tu contraseña
					</div>
					
						<fieldset>
							<div class="input-prepend" title="Username" data-rel="tooltip">
								<span class="add-on"><i class="icon-user"></i></span>
                                <input  class="input-large span10" name="txtUsername" id="txtUsername" type="text" 
                                    value="" runat="server" />
							</div>
							<div class="clearfix"></div>

							<div class="input-prepend" title="Password" data-rel="tooltip">
								<span class="add-on"><i class="icon-lock"></i></span>
                                <input class="input-large span10" name="txtPassword" id="txtPassword" 
                                    type="password" value="" runat="server" />
							</div>
							<div class="clearfix"></div>

							<div class="input-prepend" style="display:none" >
							<label class="remember" for="remember"><input type="checkbox" id="remember" onclick="return remember_onclick()" />Remember me</label>
							</div>
							<div class="clearfix"></div>

							<p class="center span5">
							  <asp:Button ID="Button1" CssClass ="btn btn-primary" runat="server" Text="Ingresar" OnClick="Button1_Click" /></p>
                            <asp:Label ID="Label1" runat="server" Width="186px" Visible="False"></asp:Label></fieldset>
					
				</div>
			</div>
				</div>
</div>
</form>
</body>
</html>
