<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditorBorrow.aspx.cs" Inherits="EditorBorrow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        修改借阅信息<br />
        <br />
&nbsp;&nbsp;
        书名：<asp:TextBox ID="txtbookname" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
        作者：<asp:TextBox ID="txtwriter" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;
        出版社：<asp:TextBox ID="txtpress" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
        编号：<asp:TextBox ID="txtnumber" runat="server"></asp:TextBox>
         <br />
        <br />
         &nbsp;&nbsp;
         数量：<asp:TextBox ID="txtcount" runat="server"></asp:TextBox>
         <br />
        <br />
         &nbsp;&nbsp;
         分类：<asp:TextBox ID="txtclass1" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;
       借阅者：<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Button ID="update1" Onclick="update1_Click" runat ="server"  Text="修改"/>
         &nbsp;<asp:Button ID ="back" runat ="server" PostBackUrl="~/InsertBook.aspx" Text ="返回" />
    
    </div>
    </form>
</body>
</html>
