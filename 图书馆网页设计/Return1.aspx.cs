using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Return1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"] != null)
        {
            return1.Visible = true;
            string username = Session["name"].ToString();
            lbname.Text = username;
            int id = Convert.ToInt32(Request.QueryString["id"]);

            string sql = "select * from tabBorrow where id='" + id + "'";

            DataTable dt = new DataTable();

            dt = Class1.Put1(sql);

            string bookname = dt.Rows[0][1].ToString();

            txtbookname.Text = bookname;
            string writer = dt.Rows[0][2].ToString();

            txtwriter.Text = writer;
            string press = dt.Rows[0][3].ToString();

            txtpress.Text = press;
            string number = dt.Rows[0][4].ToString();

            txtnumber.Text = number;
            string class1 = dt.Rows[0][6].ToString();


            txtclass1.Text = class1;

        }
        else
        {
            Response.Write("<script>alert('请先登录！')</script>");
            Response.Redirect("Login.aspx");
        }
    }
    protected void update(object sender, EventArgs e)
    {
        int num = 0;

        if (int.TryParse(Request.Form[txtcount.UniqueID], out num))
        {
            string username = Session["name"].ToString();
            lbname.Text = username;
            string sql2 = "select * from tabUsers where name='" + username + "'";
            DataTable dt = new DataTable();
            dt = Class1.Put1(sql2);
            string nameID = dt.Rows[0][5].ToString();
            string bookcount=dt.Rows [0][8].ToString();
            string bookname = txtbookname.Text;
            string writer = txtwriter.Text;
            string press = txtpress.Text;
            string number = txtnumber.Text;
            long count1 = Convert.ToInt64(Request.Form[txtcount.UniqueID]);
            string class1 = txtclass1.Text;
            string sql3 = "select * from tabBooks where bookname='" + bookname + "'";
            DataTable dt1 = new DataTable();
            dt1 = Class1.Put1(sql3);
            long count2 = Convert.ToInt64(dt1.Rows[0][5].ToString());
            string sql4 = "select * from tabBorrow where bookname='" + bookname + "'";
            DataTable dt2 = new DataTable();
            dt2 = Class1.Put1(sql4);
            long count3 = Convert.ToInt64(dt2.Rows[0][5].ToString());
            if (count1 > count3 || count1 == 0)
            {
                Response.Write("<script>alert('所还数目大于所借数目！或者归还数目不为0！')</script>");
            }
            else
            {
                count2 += count1;
                count3 -= count1;
                long count4 = count2 - count1;
                long count5 =Convert .ToInt64 (bookcount) - count1;
                string sql = "update tabBorrow set count='" + count3 + "' where bookname='" + bookname + "'";
                string sql5 = "delete from tabBorrow  where bookname='" + bookname + "'";
                string sql1 = "update tabBooks set count='" + count2 + "' where bookname='" + bookname + "'";
                string sql7 = "update tabUsers set bookcount='" + count5 + "' where name='"+username +"'";
                string sql8= "update tabBorrow1 set count='" + count3 + "' where bookname='" + bookname + "'";
                string sql9 = "delete from tabBorrow1  where bookname='" + bookname + "'";
                long result = Class1.Put(sql1);
                if (result == 1)
                {
                    if (count3 == 0)
                    {
                        Class1.Put(sql5);
                        Class1.Put(sql9);
                    }
                    else { Class1.Put(sql); Class1.Put(sql8); }
                    Class1.Put(sql7);
                    Response.Write("<script>alert('归还成功！'),location='Returnbook.aspx'</script>");
                }
                else
                {
                    string sql6 = "update tabBooks set count='" + count4 + "' where bookname='" + bookname + "'";
                    Class1.Put(sql1);
                    Response.Write("<script>alert('归还失败！'),location='Returnbook.aspx'</script>");
                }
            }
        }
        else Response.Write("<script>alert('数量为数字！'),location='Returnbook.aspx'</script>");
    }
}