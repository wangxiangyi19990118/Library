using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Updateinf : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"] != null)
        {
            string name = Session["name"].ToString();
            lbname.Text = name;
            string sql = "select * from tabUsers where name='" + name + "'";
            DataTable dt = new DataTable();

            dt = Class1.Put1(sql);
            string pwd = dt.Rows[0][2].ToString();

            txtPwd.Text = pwd;
            txtPwd1.Text = pwd;
            string sex = dt.Rows[0][3].ToString();

            radlSex.SelectedValue = sex;
            string phone = dt.Rows[0][4].ToString();

            txtPhone.Text = phone;
            string question1 = dt.Rows[0][6].ToString();

            question.Text = question1;
            string answer1 = dt.Rows[0][7].ToString();

            answerpwd.Text = answer1;
        }
        else Response.Write("<script>alert('请先登录！'),location=='Login.aspx'</script>");
    }
    protected void update(object sender, EventArgs e)
    {
        string phone = Request.Form[txtPhone.UniqueID];
        bool result = Class1.bolNon(phone);
        if (result == false)
            Response.Write("<script>alert('手机号应是数字！'),location='Updateinf.aspx'</script>");
        else
        {
            string name = Session["name"].ToString();
            lbname.Text = name;
            string pwd = Request.Form[txtPwd.UniqueID];
            string pwd1 = Request.Form[txtPwd1.UniqueID];
            string sex = Request.Form[radlSex.UniqueID];
            string question1 = Request.Form[question.UniqueID];
            string answer1 = Request.Form[answerpwd.UniqueID];
            string nameID = Request.Form[txtPhone.UniqueID];
            string sql = "update tabUsers set pwd='" + pwd + "',sex='" + sex + "',phone='" + phone + "',nameID='" + nameID + "',question='" + question1 + "',answer='" + answer1 + "' where name='" + name + "'";
            if (pwd != pwd1)
                Response.Write("<script>alert('修改失败！两次输入的密码不相同');location='Updateinf.aspx'</script>");
            else
            {
                int result1 = Class1.Put(sql);
                if (result1 == 1)
                    Response.Write("<script>alert('修改成功！');location='Welcome.aspx'</script>");
                else
                    Response.Write("<script>alert('修改失败！');location='Updateinf.aspx'</script>");

            }

        }
    }
}