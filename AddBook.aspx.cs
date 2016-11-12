using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void putin_Click(object sender, EventArgs e)
    {
        int num = 0;

        if (int.TryParse(Request.Form[txtcount.UniqueID], out num))
        {
            string bookname = txtbookname.Text;
            string writer = txtwriter.Text;
            string press = txtpress.Text;
            string number = txtnumber.Text;
            string count = txtcount.Text;
            long count1 = Convert.ToInt32(count);
            if (count1 <= 0)
                Response.Write("<script>alert('修改失败！数量大于等于零');location='Editor.aspx'</script>");
            string class1 = txtclass1.Text;
            string sql = "insert into tabBooks(bookname,writer,press,number,count,class1) values('" + bookname + "','" + writer + "','" + press + "','" + number + "','" + count + "','" + class1 + "')";
            int result = Class1.Put(sql);
            if (result == 1)
                Response.Write("<script>alert('添加成功！'),location='AddBook.aspx'</script>");
            else Response.Write("<script>alert('添加失败！'),location='AddBook.aspx'</script>");
        }
        else Response.Write("<script>alert('数量为数字！'),location='AddBook.aspx'</script>");
    }
}