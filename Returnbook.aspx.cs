using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Returnbook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"] != null)
        {
            string username = Session["name"].ToString();
            lbname.Text = username;
            Session["name"] = username;
            string sql1 = "select * from tabBorrow where name='" + username + "'";
            DataTable dt = new DataTable();
            dt = Class1.Put1(sql1);
            rptreturn.DataSource = dt;
            rptreturn.DataBind();
        }
        else
        {
            Response.Write("<script>alert('请先登录！')</script>");
            Response.Redirect("Login.aspx");
        }
    }
    protected void rptreturn_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

        if (e.CommandName == "Return")
        {
            int id = Convert.ToInt32(e.CommandArgument.ToString());
            string sql1 = "select * from tabBorrow where id='" + id + "'";
            DataTable dt = new DataTable();
            dt = Class1.Put1(sql1);
            rptreturn.DataSource = dt;
            rptreturn.DataBind();
            string bookname=dt .Rows [0][1].ToString ();
            string sql = "delete from tabBorrow where id='" + id + "'";
            string sql2 = "update tabBooks set count=count+1 where bookname='" + bookname + "'";
            long result = 0;
            result = Class1.Put(sql);
            if (result == 1)
            {
                Class1.Put(sql2);
                Response.Write("<script>alert('还书成功'),location='Returnbook.aspx'</script>");
            }
            else

                Response.Write("<script>alert('还书失败！');location='Returnbook.aspx'</script>");


        }

    }
}