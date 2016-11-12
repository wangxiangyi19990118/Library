using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Delateusers : System.Web.UI.Page
{
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        string name = txtname.Text;
        string sql1 = "select * from tabUsers where name='" + name + "'";
        string sql = "delete from tabUsers where name='" + name + "'";
        string sql2 = "delete from tabBorrow where name='" + name + "'";
        string sql3 = "select * from tabBorrow where name='" + name + "'";
        string sql4 = "delete from tabBorrow1 where name='" + name + "'";
        string sql5 = "select * from tabBorrow1 where name='" + name + "'";

       long  result = Class1.Find(sql1);
        if (result == 1)
        {
          int result1 = Class1.Put(sql3);
          Class1.Put(sql5);
           if (result1 == 1)
           {
               string sql6 = "select * from tabBorrow where name='" + name + "'";
               DataTable dt = new DataTable();

               dt = Class1.Put1(sql6);
               Class1.Put(sql2);
               Class1.Put(sql4);
            }
            Class1.Put(sql);
            Response.Write("<script>alert('删除成功！此用户已消失！'),location='Deleteusers.aspx'</script>");
        }
        else Response.Write("<script>alert('此用户不存在！'),location='Deleteusers.aspx'</script>");
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}