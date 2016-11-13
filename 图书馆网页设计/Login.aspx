<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="divLogin" runat="server" visible="true">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 登录页面
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 用户名：<asp:TextBox ID="txtname" runat="server" ></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 密码：<asp:TextBox ID="txtpwd" runat="server" TextMode="Password" ></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="登录" Width="66px" style="margin-left: 56px" />
            <asp:Button ID ="btnRegister" runat ="server" PostBackUrl="~/Register.aspx" Text="注册" Width="66px" style="margin-left: 56px" />
         <asp:Button ID ="Button3" runat ="server" PostBackUrl="~/Visiter.aspx" Text="游客" Width="66px" style="margin-left: 56px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat ="server"  PostBackUrl="~/findpwd.aspx" Text ="找回密码" Width="107px" style="margin-left: 56px" />
        <asp:Button ID="Button1" runat ="server"  PostBackUrl="~/LibrarianLogin.aspx" Text ="管理员登录" Width="107px" style="margin-left: 56px" />
    </div>
    </form>
</body>
</html>
