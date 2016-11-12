<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="welcome" runat ="server" Visible="false" >
        欢迎您：
        <asp:Label ID="lbname" runat="server"></asp:Label>
        欢迎使用本系统
         
        <br />
        您的需求是： 1: 修改个人信息：&nbsp; <asp:Button ID="Button1" runat ="server"  PostBackUrl="~/Updateinf.aspx" Text ="修改个人信息" Width="107px" style="margin-left: 56px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        2：借阅图书：&nbsp;&nbsp;&nbsp; <asp:Button ID="Button3" runat ="server"  PostBackUrl="~/Borrowbook.aspx" Text ="借阅图书" Width="107px" style="margin-left: 56px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3：归还图书：&nbsp;&nbsp;&nbsp; <asp:Button ID="Button4" runat ="server"  PostBackUrl="~/Returnbook.aspx" Text ="归还图书" Width="107px" style="margin-left: 56px" />
        <br />
        <br />
        <asp:Button ID ="back" runat ="server" Onclick="back_Click" Text ="退出" />
    </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
    </form>
</body>
</html>
