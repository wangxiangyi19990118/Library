using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LibrarianLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLLogin_Click(object sender, EventArgs e)
    {
        string name = txtname.Text;
        string pwd = txtpwd.Text;
        if (name.Length == 0 || pwd.Length == 0)
            Response.Write("<script>alert('输入不为空！'),location=='LibrarianLogin.aspx'</script>");
        else
        {
            string sql = "select * from tabLibrarian where name='" + name + "'and pwd='" + pwd + "'";
            long result = 0;
            result = Class1.Find(sql);
            if (result == 1)
            {
                Session["name"] = name;
                Response.Redirect("~/WelcomeLibrarian.aspx");
            }
            else Response.Write("<script>alert('登录失败！用户名或密码错误'),location=='LibrarianLogin.aspx'</script>");
        }
    }
}