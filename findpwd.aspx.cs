using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class findpwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void get(object sender, EventArgs e)
    {
        string phone = txtphone.Text;
        string name = txtname.Text;
        if (phone.Length != 0)
        {
            bool result = Class1.bolNon(phone);
            if (result == false)
            {
                question.Text = question.SelectedValue;
                string question1 = question.Text;
                string answerpwd1 = answerpwd.Text;
                string sql1 = "select * from tabUsers where name='" + name + "' and question='" + question1 + "' and answer='" + answerpwd1 + "'";
                {
                    string result1;
                    result1 = Class1.Find1(sql1);
                    if (result1 != "")
                    {
                        string str1 = Class1.Find1(sql1);
                        Response.Write(" <script>alert('成功！您的密码是'+'" + str1 + "'),location='Login.aspx'</script>");
                    }
                    else Response.Write("<script>alert('手机号应是数字！'),location='findpwd.aspx'</script>");
                }

            }
            else
            {
                string sql = "select * from tabUsers where name='" + name + "'and phone='" + phone + "'";
                if (phone.Length == 11)
                {
                    string result1;
                    result1 = Class1.Find1(sql);
                    if (result1 != "")
                    {
                        string str1 = Class1.Find1(sql);
                        Response.Write(" <script>alert('成功！您的密码是'+'" + str1 + "'),location='Login.aspx'</script>");
                    }
                    else
                    {
                        question.Text = question.SelectedValue;
                        string question1 = question.Text;
                        string answerpwd1 = answerpwd.Text;
                        string sql1 = "select * from tabUsers where name='" + name + "' and question='" + question1 + "' and answer='" + answerpwd1 + "'";
                        {
                            string result2;
                            result2 = Class1.Find1(sql1);
                            if (result2 != "")
                            {
                                string str1 = Class1.Find1(sql1);
                                Response.Write(" <script>alert('成功！您的密码是'+'" + str1 + "'),location='Login.aspx'</script>");
                            }
                            else Response.Write(" <script>alert('手机号不正确！'),location='findpwd.aspx'</script>");
                        }
                    }
                }
                else
                {
                    question.Text = question.SelectedValue;
                    string question1 = question.Text;
                    string answerpwd1 = answerpwd.Text;
                    string sql1 = "select * from tabUsers where name='" + name + "' and question='" + question1 + "' and answer='" + answerpwd1 + "'";
                    {
                        string result2;
                        result2 = Class1.Find1(sql1);
                        if (result2 != "")
                        {
                            string str1 = Class1.Find1(sql1);
                            Response.Write(" <script>alert('成功！您的密码是'+'" + str1 + "'),location='Login.aspx'</script>");
                        }

                        else Response.Write(" <script>alert('手机号长度不正确！'),location='findpwd.aspx'</script>");
                    }
                }
            }
        }
        else
        {
            question.Text = question.SelectedValue;
            string question1 = question.Text;
            string answerpwd1 = answerpwd.Text;
            string sql1 = "select * from tabUsers where name='" + name + "' and question='" + question1 + "' and answer='" + answerpwd1 + "'";
            {
                string result1;
                result1 = Class1.Find1(sql1);
                if (result1 != "")
                {
                    string str1 = Class1.Find1(sql1);
                    Response.Write(" <script>alert('成功！您的密码是'+'" + str1 + "'),location='Login.aspx'</script>");
                }
                else Response.Write(" <script>alert('密保问题不正确！'),location='findpwd.aspx'</script>");
            }
        }
    }
}