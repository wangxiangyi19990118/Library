<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WelcomeLibrarian.aspx.cs" Inherits="WelcomeLibrarian" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="welcome" runat ="server"  visible="false">
        欢迎您：
        <asp:Label ID="lbname" runat="server"></asp:Label>
        <br />
        欢迎使用管理员系统
         
        <br />
        您的操作是：
        1：管理图书信息<asp:Button ID="Button1" runat ="server"  PostBackUrl="~/AddBook.aspx" Text ="增加图书" Width="107px" style="margin-left: 56px" />
         <asp:Button ID="Button6" runat ="server"  PostBackUrl="~/InsertBook.aspx" Text ="管理图书信息" Width="137px" style="margin-left: 56px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        2：管理用户信息<asp:Button ID="Button2" runat ="server" PostBackUrl="~/putusers.aspx"   Text ="增加用户" Width="107px" style="margin-left: 56px" />
        <asp:Button ID="Button3" runat ="server"  PostBackUrl="~/Updateuserinf.aspx" Text ="修改用户信息" Width="133px" style="margin-left: 56px" />
        <asp:Button ID="Button4" runat ="server"  PostBackUrl="~/Deleteusers.aspx" Text ="删除用户" Width="107px" style="margin-left: 56px" />
        <br />
        <br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3：修改个人信息（密码）
        新密码：<asp:TextBox ID ="updatepwd" runat ="server" ></asp:TextBox>
        确认新密码：<asp:TextBox  ID ="updatepwd1" runat ="server" ></asp:TextBox>
        <asp:Button ID ="update" runat ="server" Text ="修改" OnClick ="update_Click" />
         <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID ="back" runat ="server" onclick="back_Click" Text ="退出" />
    </div>
    </form>
</body>
</html>
