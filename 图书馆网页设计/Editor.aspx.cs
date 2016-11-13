using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Editor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);

        string sql = "select * from tabBooks where id='" + id + "'";

        DataTable dt = new DataTable();

        dt = Class1.Put1(sql);

        string bookname = dt.Rows[0][1].ToString();

        txtbookname.Text = bookname;
        string  writer= dt.Rows[0][2].ToString();

        txtwriter.Text = writer ;
        string press = dt.Rows[0][3].ToString();

        txtpress.Text = press;
        string number = dt.Rows[0][4].ToString();

        txtnumber.Text  = number ;
        string count = dt.Rows[0][5].ToString();

        txtcount.Text = count ;
        string class1 = dt.Rows[0][6].ToString();

        txtclass1.Text = class1;

    }
    protected void update (object sender, EventArgs e)
    {      int num = 0;

    if (int.TryParse(Request.Form[txtcount.UniqueID], out num))
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);
        string bookname = Request.Form[txtbookname.UniqueID];
        string writer = Request.Form[txtwriter.UniqueID];
        string press = Request.Form[txtpress.UniqueID];
        string number = Request.Form[txtnumber.UniqueID];
        string count = Request.Form[txtcount.UniqueID];
        long count1 = Convert.ToInt32(count);
        if (count1<=0)
            Response.Write("<script>alert('修改失败！数量大于等于零');location='Editor.aspx'</script>");
        string class1 = Request.Form[txtclass1.UniqueID];
        string sql = "update tabBooks set bookname='" + bookname + "' ,writer='" + writer + "',press='" + press + "',number='" + number + "',count='" + count + "',class1='" + class1 + "' where id='" + id + "'";
        int result = Class1.Put(sql);
        if (result == 1)
            Response.Write("<script>alert('修改成功！');location='Insertbook.aspx'</script>");
        else
            Response.Write("<script>alert('修改失败！');location='Editor.aspx'</script>");
    }
    else Response.Write("<script>alert('数量为数字！');location='Editor.aspx'</script>");
    }
}