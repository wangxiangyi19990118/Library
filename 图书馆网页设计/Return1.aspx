<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Return1.aspx.cs" Inherits="Return1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id ="return1" runat ="server" visible ="false" >
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        请确认归还信息<br />
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
     <asp:Button ID="update1" Onclick="update"  runat ="server"  Text="归还"/>
        &nbsp;
        <asp:Button ID ="back" runat ="server" PostBackUrl="~/Returnbook.aspx" Text ="返回" />
    
    </div>
    </form>
</body>
</html>
