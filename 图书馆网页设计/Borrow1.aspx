<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Borrow1.aspx.cs" Inherits="Borrow1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="borrow" runat ="server" visible="false">
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        请确认借阅信息<br />
        <br />
        &nbsp; 用户名： <asp:Label ID="lbname" runat="server"></asp:Label><br />
        <br />
&nbsp;&nbsp;
        书名：<asp:Label ID="txtbookname" runat="server"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;
        作者：<asp:Label ID="txtwriter" runat="server"></asp:Label>
        <br />
        <br />
        &nbsp;
        出版社：<asp:Label ID="txtpress" runat="server"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;
        编号：<asp:Label ID="txtnumber" runat="server"></asp:Label>
         <br />
        <br />
         &nbsp;&nbsp;
         数量：<asp:TextBox ID="txtcount" runat="server"></asp:TextBox>
         <br />
        <br />
         &nbsp;&nbsp;
         分类：<asp:Label ID="txtclass1" runat="server"></asp:Label>
        <br />
        <br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Button ID="update1" Onclick="update"  runat ="server"  Text="借阅"/>
        &nbsp;
        <asp:Button ID ="back" runat ="server" PostBackUrl="~/Borrowbook.aspx" Text ="返回" />
    </div>
    </form>
</body>
</html>
