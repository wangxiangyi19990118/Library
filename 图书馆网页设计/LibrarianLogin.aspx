<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LibrarianLogin.aspx.cs" Inherits="LibrarianLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="LLogin" runat ="server" >
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        管理员登录
         
        <br />
        <br />
&nbsp;&nbsp; 用户名：<asp:TextBox ID="txtname" runat="server" ></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        密码：<asp:TextBox ID="txtpwd" runat="server" TextMode="Password" ></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnLogin" runat="server" OnClick="btnLLogin_Click" Text="登录" Width="66px" style="margin-left: 56px" />
     &nbsp;&nbsp;&nbsp;
     <asp:Button ID ="back" runat ="server" PostBackUrl="~/Login.aspx" Text ="返回" />
    </div>
    </form>
</body>
</html>
