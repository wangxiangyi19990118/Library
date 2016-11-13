using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Borrow1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"] != null)
        {
            borrow.Visible = true;
            string username = Session["name"].ToString();
            lbname.Text = username;
            int id = Convert.ToInt32(Request.QueryString["id"]);

            string sql = "select * from tabBooks where id='" + id + "'";

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
            string bookcount =dt.Rows[0][8].ToString();
            string bookname = txtbookname.Text;
            string writer = txtwriter.Text;
            string press = txtpress.Text;
            string number = txtnumber.Text;
            long  count1 = Convert.ToInt64(Request.Form[txtcount.UniqueID]);
            string class1 = txtclass1.Text;
            string sql3 = "select * from tabBooks where bookname='" + bookname + "'";
            DataTable dt1 = new DataTable();
            dt1 = Class1.Put1(sql3);
            long count2 = Convert.ToInt64(dt1.Rows[0][5].ToString());
            int count3,count4;
            if (bookcount != "0")
            {
                count3 = Convert.ToInt32(count1) + Convert.ToInt32(bookcount);
                count4 = count3;
            }
            else
            {
                count3 = 0;
                count4 = Convert.ToInt32(count1);
            }
            if (count1 >= count2 || count2 == 1 || count1 == 0||count3>10)
            {
                Response.Write("<script>alert('所借数目大于馆藏数目！或者您借阅了保存本！或者借阅数目不为0！或者已经超过借阅上限！'),location='Borrowbook.aspx'</script>");
            }
            else
            {
                count2 -= count1;
                string sql = "insert into tabBorrow(bookname,writer,press,number,count,class1,name,nameID) values('" + bookname + "','" + writer + "','" + press + "','" + number + "','" + count1 + "','" + class1 + "','" + username + "','" + nameID + "')";
                string sql5 = "insert into tabBorrow1(bookname,writer,press,number,count,class1,name,nameID) values('" + bookname + "','" + writer + "','" + press + "','" + number + "','" + count1 + "','" + class1 + "','" + username + "','" + nameID + "')";
                string sql1 = "update tabBooks set count='" + count2 + "' where bookname='" + bookname + "'";
                string sql4 = "update tabUsers set bookcount= '" + count4 + "' where name='"+username +"'";
                string sql9 = "select * from tabBorrow1 where bookname='" + bookname + "'";
                long result = 0;
                result = Class1.Put(sql1);
                if (result == 1)
                {
                    Class1.Put(sql);
                    Class1.Put(sql5);
                    Class1.Put(sql4);
                    string datetime2 = Class1.Find2(sql9);
                    DateTime.Parse(datetime2);
                    DateTime datetime3 = DateTime.Now.AddDays(30);
                    string sql10 = "update tabBorrow set datetime2='" + datetime3 + "' where bookname='"+bookname+"'";
                    string sql11= "update tabBorrow1 set datetime2='" + datetime3 + "' where bookname='"+bookname+"'";
                    Class1.Put(sql10);
                    Class1.Put(sql11);
                    Response.Write("<script>alert('借阅成功！'),location='Borrowbook.aspx'</script>");
                }
                else Response.Write("<script>alert('借阅失败！'),location='Borrowbook.aspx'</script>");
            }
        }
        else Response.Write("<script>alert('数量为数字！'),location='Borrowbook.aspx'</script>");
    }
}