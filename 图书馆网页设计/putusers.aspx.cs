using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class putusers : System.Web.UI.Page
{
    protected void btnRegister_Click1(object sender, EventArgs e)
    {  string phone = txtPhone.Text;
        bool result = Class1.bolNon(phone);
        if (result == false)
            Response.Write("<script>alert('手机号应是数字！'),location='Register.aspx'</script>");
        else
        {
            string name = txtName.Text;
            string pwd = txtPwd.Text;
            string repwd = txtPwd1.Text;
            string sex = radlSex.SelectedValue;
            question.Text = question.SelectedValue;
            string question1 = question.Text;
            string answerpwd1 = answerpwd.Text;
            long nameID = Convert.ToInt64(txtPhone.Text);
            string sql = "insert into tabUsers values('" + name + "','" + pwd + "','" + sex + "','" + phone + "','" + nameID + "','" + question1 + "','" + answerpwd1 + "','" + 0 + "')";
            if (name.Length == 0 || pwd.Length == 0 || phone.Length == 0)//判断注册用户名和密码和手机号都不为空
            {
                Response.Write("<script>alert('输入不为空！'),location=='Register.aspx'</script>");
            }
            else if (pwd.Length < 6 || pwd.Length > 20)//密码长度大于六且小于二十
            {
                Response.Write("<script>alert('密码长度有误！'),location='Register.aspx'</script>");
            }
            else if (pwd != repwd)
            {
                Response.Write("<script>alert('确认密码不正确！'),location='Register.aspx'</script>");
            }
            else if (phone.Length != 11)
            {
                Response.Write("<script>alert('手机号长度有误！'),location='Register.aspx'</script>");
            }
            else
            {
                int result1 = Class1.Put(sql);
                if (result1 == 1)
                    Response.Write("<script>alert('注册成功！'),location='putusers.aspx'</script>");
                else Response.Write("<script>alert('注册失败！'),location='putusers.aspx'</script>");
            }
        }
        
    }
}