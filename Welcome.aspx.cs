using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
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
        Response.Write("<script>alert('退出成功')</script>");
        Response.Redirect("Login.aspx");
    }
}