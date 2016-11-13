<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Updateinf.aspx.cs" Inherits="Updateinf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          修改个人信息<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 用户名： <asp:Label ID="lbname" runat="server"></asp:Label>(不可更改)
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        密码：<asp:TextBox ID="txtPwd" runat="server" ></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        确认密码：<asp:TextBox ID="txtPwd1" runat="server" ></asp:TextBox>
        &nbsp;&nbsp;<br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        手机号码：<asp:TextBox ID="txtPhone" runat="server" ></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 性别：<asp:RadioButtonList ID="radlSex" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
            <asp:ListItem Selected="True">男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem></asp:RadioButtonList> 
          <br />
          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 密保问题：<asp:DropDownList ID="question" runat="server">
            <asp:ListItem>父亲生日</asp:ListItem>
            <asp:ListItem >您的学号</asp:ListItem>
            <asp:ListItem>爱豆姓名</asp:ListItem>
              </asp:DropDownList>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 密保答案：<asp:TextBox ID ="answerpwd" runat ="server" ></asp:TextBox>
          <br />
          <br />
          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Button ID="update1" Onclick="update"  runat ="server"  Text="修改"/>
         &nbsp;<asp:Button ID ="back" runat ="server" PostBackUrl="~/Welcome.aspx" Text ="返回" />
    </div>
    
    
    </form>
</body>
</html>
