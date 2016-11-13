using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WelcomeLibrarian : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"] != null)
        {
            string username = Session["name"].ToString();
            lbname.Text = username;
            Session["name"] = username;
            welcome.Visible = true;
        }
        else
        {
            Response.Write("<script>alert('请先登录！')</script>");
            Response.Redirect("Login.aspx");
        }
    }
    
    protected void back_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        
        
            Response.Write("<script>alert('请先登录！')</script>");
            Response.Redirect("Login.aspx");
       
    }
    protected void update_Click(object sender, EventArgs e)
    {
        string username = Session["name"].ToString();
        Session["name"] = username;
        string pwd=updatepwd .Text ;
        string pwd1=updatepwd1 .Text;
        if(pwd.Length <6||pwd.Length >20)
             Response.Write("<script>alert('密码长度不合适！')</script>");
        else {if(pwd!=pwd1)
             Response.Write("<script>alert('两次输入的密码不一致！')</script>");
        else
        {
            string sql = "update tabLibrarian set pwd='" + pwd + "' where name='" + username + "'";
              int result1 = Class1.Put(sql);
            if (result1 == 1)
                Response.Write("<script>alert('修改成功！'),location='LibrarianLogin.aspx'</script>");
            else
                Response.Write("<script>alert('修改失败！')</script>");   
        
        }}
    }
}