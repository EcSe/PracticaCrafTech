﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Nombres<br />
        Apellidos<br />
        Sexo<br />
        <br />
        <asp:GridView ID="gvdatos" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
