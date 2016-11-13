<%@ Page Language="C#" AutoEventWireup="true" CodeFile="findpwd.aspx.cs" Inherits="findpwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="txtupdatepwd" runat ="server" >
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        找回密码
         
        <br />
        &nbsp;&nbsp;&nbsp;
        用户名：<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        手机号：<asp:TextBox ID="txtphone" runat ="server" ></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp; 密保问题：<asp:DropDownList ID="question" runat="server">
            <asp:ListItem>父亲生日</asp:ListItem>
            <asp:ListItem Selected="True">您的学号</asp:ListItem>
            <asp:ListItem>爱豆姓名</asp:ListItem>
              </asp:DropDownList>
        <br />
        <br />
&nbsp;&nbsp; 密保答案：<asp:TextBox ID ="answerpwd" runat ="server" ></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClick" runat ="server"  OnClick ="get" Text ="找回密码" />
       &nbsp;
       <asp:Button ID ="back" runat ="server" PostBackUrl="~/Login.aspx" Text ="返回" />
    </div>
    </form>
</body>
</html>
