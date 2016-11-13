<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddBook.aspx.cs" Inherits="AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="AddBooks" runat="server" >
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        添加图书<br />
        <br />
&nbsp; 图书全称：<asp:TextBox ID ="txtbookname" runat ="server" ></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp; 作者：<asp:TextBox ID ="txtwriter" runat ="server" ></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp; 出版社：<asp:TextBox ID ="txtpress" runat ="server" ></asp:TextBox>
        <br />
&nbsp;<br />
&nbsp;&nbsp; 图书号：<asp:TextBox ID ="txtnumber" runat ="server" ></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp; 数量：<asp:TextBox ID ="txtcount" runat ="server" ></asp:TextBox>
        &nbsp;&nbsp;&nbsp;<br />
        <br /> &nbsp;&nbsp;&nbsp; 分类：<asp:TextBox ID ="txtclass1" runat ="server" ></asp:TextBox>
&nbsp;&nbsp;&nbsp; 
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Button ID ="putin" runat ="server" Text ="增加" OnClick ="putin_Click" />
        &nbsp;&nbsp;
        <asp:Button ID ="Button1" runat ="server" PostBackUrl="~/WelcomeLibrarian.aspx" Text="返回" />
    </div>
    </form>
</body>
</html>
