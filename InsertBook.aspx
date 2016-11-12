<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InsertBook.aspx.cs" Inherits="InsertBook" %>

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
           <asp:ListItem>借阅者</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID ="txtinput" runat ="server" ></asp:TextBox>
        &nbsp;&nbsp;<br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Text="在馆情况" onclick="insert" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button1" runat="server" Text="借阅情况" onclick="Button1_Click" />
        <br />
        <br />
        </div> 
         <asp:Repeater id="rptinsert" runat ="server" OnItemCommand="rptinsert_ItemCommand" >
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
                    
                     <td><asp:LinkButton ID="lbtDelete" runat="server" Text="删除" CommandName="Delete" CommandArgument='<%#Eval("id") %>'></asp:LinkButton></td>
                    <td><asp:LinkButton ID="lbtEditor" runat="server" Text="修改" PostBackUrl='<%#"Editor.aspx?id="+Eval("id") %>'></asp:LinkButton></td>
               </tr>
             </ItemTemplate>

             <FooterTemplate>
               </table>

            </FooterTemplate>
     
    </asp:Repeater>
         &nbsp;<br />
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

                
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Repeater id="select" runat ="server" visible ="false" OnItemCommand="select_ItemCommand" >
          <HeaderTemplate> 
                <table>
                    <tr>
                        <th>书名</th>
                        <th>作者</th>
                        <th>出版社</th>
                        <th>编号</th>
                        <th>数量</th>
                        <th>分类</th>
                        <th>借阅者</th>
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
                     <td><%# Eval("name")%></td>
                     <td><asp:LinkButton ID="lbtDelete" runat="server" Text="删除" CommandName="Delete" CommandArgument='<%#Eval("id") %>'></asp:LinkButton></td>
                    <td><asp:LinkButton ID="lbtEditor" runat="server" Text="修改" PostBackUrl='<%#"EditorBorrow.aspx?id="+Eval("id") %>'></asp:LinkButton></td>

               </tr>
             </ItemTemplate>

             <FooterTemplate>
               </table>

            </FooterTemplate>
     
    </asp:Repeater>
         &nbsp;&nbsp;&nbsp;&nbsp;<br />
        <div id="borrow" visible ="false" runat ="server">
                &nbsp;<asp:Button ID="btnBefore1" runat="server" Text="上一页"  OnClick="btnBefore1_Click" Width="68px"/>  
    &nbsp;  
    <asp:Button ID="btnNext1" runat="server" Text="下一页" OnClick="btnNext1_Click" Width="64px" />  
        &nbsp;  
        <asp:Button ID="btnTop1" runat="server" Text="首页" OnClick="btnTop1_Click" />  
         &nbsp;  
         <asp:Button ID="btnFinal1" runat="server" Text="尾页" OnClick="btnFinal1_Click" />  
        &nbsp;  
        当前页为：<asp:Label ID="lblCurrentPage1" runat="server" Text="Label"></asp:Label> 
                共<asp:Label ID="labPage1" runat="server" Text="Label"></asp:Label>页
            转到 <asp:TextBox ID="paper1" runat ="server" Width="37px" ></asp:TextBox>页
            <asp:Button ID ="paperturn1" runat ="server" Text ="跳转" OnClick="paperturn1_Click" Width="63px" />
        </div>
        
<br />
        <br />
         <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID ="back" runat ="server" PostBackUrl="~/WelcomeLibrarian.aspx" Text ="返回" />
    </form>
</body>
</html>
