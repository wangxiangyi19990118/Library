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

        if (e.CommandName == "borrow")
        {
            int id = Convert.ToInt32(e.CommandArgument.ToString());
            string sql1 = "select * from tabBorrow where id='" + id + "'";
            DataTable dt = new DataTable();
            dt = Class1.Put1(sql1);
            rptreturn.DataSource = dt;
            rptreturn.DataBind();
            string bookname=dt .Rows [0][1].ToString ();
            string datetime2=dt.Rows[0][9].ToString();
            DateTime.Parse(datetime2);
            DateTime datetime3 = DateTime.Now.AddDays(30);
            string sql10 = "update tabBorrow set datetime2='" + datetime3 + "' where bookname='"+bookname+"'";
                    string sql11= "update tabBorrow1 set datetime2='" + datetime3 + "' where bookname='"+bookname+"'";
                    Class1.Put(sql10);
                  int result= Class1.Put(sql11);
                  if (result == 1)
                  {
                      Response.Write("<script>alert('借阅成功！')</script>");
                  }
                  else Response.Write("<script>alert('借阅失败！')</script>");

        }

    }
}