using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string name = txtname.Text;
        string pwd = txtpwd.Text;
        string sql = "select * from tabUsers where name='" + name + "'and pwd='" + pwd + "'";
        if (name.Length == 0 || pwd.Length == 0)
            Response.Write("<script>alert('登录失败！用户名或密码不为空'),location=='Login.aspx'</script>");
        else
        {
            long result = 0;
            result = Class1.Find(sql);
            if (result == 1)
            {
                Session["name"] = name;
                Response.Redirect("~/Welcome.aspx");
            }
            else Response.Write("<script>alert('登录失败！用户名或密码错误'),location=='Login.aspx'</script>");
        }

    }
}