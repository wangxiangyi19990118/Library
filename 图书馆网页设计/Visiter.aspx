<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Visiter.aspx.cs" Inherits="Visiter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="insertbook" runat ="server" >
      请选择查找类型:<br />
        <br />
&nbsp;查找类型：<asp:DropDownList ID="dropProv" runat="server">
            <asp:ListItem>书名</asp:ListItem>
            <asp:ListItem>分类</asp:ListItem>
            <asp:ListItem>作者</asp:ListItem>
               <asp:ListItem>出版社</asp:ListItem>
               <asp:ListItem>编号</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID ="txtinput" runat ="server" ></asp:TextBox>
        &nbsp;&nbsp;<br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Text="提交" onclick="insert"  />
        <br />
        <br />
        </div> 
         <asp:Repeater id="rptinsert" runat ="server" visible ="false"  >
          <HeaderTemplate> 
                <table>
                    <tr>
                        <th>书名</th>
                        <th>作者</th>
                        <th>出版社</th>
                        <th>编号</th>
                        <th>数量</th>
                        <th>分类</th>
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
                     
             </ItemTemplate>

             <FooterTemplate>
               </table>

            </FooterTemplate>
     
    </asp:Repeater>
    <div id="book" visible ="false" runat ="server">
            &nbsp;<asp:Button ID="btnBefore" runat="server" Text="上一页"  OnClick="btnBefore_Click" Width="68px"/>  
    &nbsp;  
    <asp:Button ID="btnNext" runat="server" Text="下一页" OnClick="btnNext_Click" Width="64px" />  
        &nbsp;  
        <asp:Button ID="butTop" runat="server" Text="首页" OnClick="butTop_Click" />  
         &nbsp;  
         <asp:Button ID="btnFinal" runat="server" Text="尾页" OnClick="btnFinal_Click" />  
        &nbsp;  
        当前页为：<asp:Label ID="lblCurrentPage" runat="server" Text="Label"></asp:Label> 
                共<asp:Label ID="labPage" runat="server" Text="Label"></asp:Label>页 转到 <asp:TextBox ID="paper" runat ="server" Width="37px" ></asp:TextBox>页
            <asp:Button ID ="paperturn" runat ="server" Text ="跳转" OnClick ="paperturn_Click" Width="63px" />

        </div>

        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID ="btnRegister" runat ="server" PostBackUrl="~/Register.aspx" Text="注册" Width="66px" style="margin-left: 56px" />
         &nbsp;&nbsp;&nbsp;
         <asp:Button ID ="back" runat ="server" PostBackUrl="~/Login.aspx" Text ="返回" />
    </form>
</body>
</html>
