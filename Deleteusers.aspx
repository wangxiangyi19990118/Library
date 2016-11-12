<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Deleteusers.aspx.cs" Inherits="Delateusers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="delateusers" runat="server" visible="true">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        删除用户
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        用户名：<asp:TextBox ID="txtname" runat="server" ></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID ="btnRegister" runat ="server" OnClick="btnRegister_Click"  Text ="确认删除" Width="98px" style="margin-left: 56px"  />
    &nbsp;<asp:Button ID ="Button1" runat ="server" PostBackUrl="~/WelcomeLibrarian.aspx" Text="返回" Width="66px" style="margin-left: 56px" />
    </div>
    </form>
</body>
</html>
