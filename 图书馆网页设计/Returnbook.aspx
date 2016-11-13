<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Returnbook.aspx.cs" Inherits="Returnbook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>欢迎您，
    <asp:Label ID="lbname" runat="server"></asp:Label><br />
        您的借阅情况为：
         <asp:Repeater id="rptreturn" runat ="server"  OnItemCommand="rptreturn_ItemCommand" >
          <HeaderTemplate> 
                <table>
                    <tr>
                        <th>书名</th>
                        <th>作者</th>
                        <th>出版社</th>
                        <th>编号</th>
                        <th>数量</th>
                        <th>分类</th>
                         <th>借书日期</th>
                         <th>还书日期</th>
                    </tr>
            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                    <td><%# Eval("bookname")%></td>
                    <td><%# Eval("writer")%></td>
                    <td><%# Eval("press")%></td>
                     <td><%# Eval("number")%></td>
                     <td><%# Eval("count")%></td>
                     <td><%# Eval("class1")%></td>
                    <td><%# Eval("datetime1")%></td>
                    <td><%# Eval("datetime2")%></td>
                     <td><asp:LinkButton ID="lbtEditor" runat="server" Text="归还" PostBackUrl='<%#"Return1.aspx?id="+Eval("id") %>'></asp:LinkButton></td>
                    <td><asp:LinkButton ID="lbtBorrow" runat="server" Text="续借" CommandName="borrow" CommandArgument='<%#Eval("id") %>'></asp:LinkButton></td>
                     <asp:Button ID ="back" runat ="server" PostBackUrl="~/Welcome.aspx" Text ="返回" />
               </tr>
             </ItemTemplate>

             <FooterTemplate>
               </table>

            </FooterTemplate>
     
    </asp:Repeater>
         (续借从申请续借当天开始计算)<br />
        <br />
&nbsp;&nbsp;&nbsp;
         <asp:Button ID ="back" runat ="server" PostBackUrl="~/Welcome.aspx" Text ="返回" />
    </div>
    </form>
</body>
</html>
