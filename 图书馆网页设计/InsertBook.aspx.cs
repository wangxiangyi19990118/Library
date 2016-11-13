using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data.Sql;
public partial class InsertBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void insert(object sender, EventArgs e)//查询图书在馆情况
    {
        rptinsert.Visible = true;
        book.Visible = true;
        string massage = txtinput.Text;
        string class1 = dropProv.SelectedValue;
        if (massage.Length == 0)
        {
            string sql6 = "select*from tabBooks ";
            DataBindToRepeater(1, sql6);

        }

        else
        {
            if (dropProv.SelectedValue == "书名")
            {
                string sql1 = "select * from tabBooks where bookname like'%" + massage + "%'";
                DataBindToRepeater(1, sql1);

            }
            if (dropProv.SelectedValue == "作者")
            {
                string sql2 = "select * from tabBooks where writer like'%" + massage + "%'";
                DataBindToRepeater(1, sql2);
            }
            if (dropProv.SelectedValue == "出版社")
            {
                string sql3 = "select * from tabBooks where press like'%" + massage + "%'";
                DataBindToRepeater(1, sql3);
            }
            if (dropProv.SelectedValue == "编号")
            {
                string sql4 = "select * from tabBooks where number like'%" + massage + "%'";
                DataBindToRepeater(1, sql4);
            }
            if (dropProv.SelectedValue == "分类")
            {
                string sql5 = "select * from tabBooks where class1 like'%" + massage + "%'";
                DataBindToRepeater(1, sql5);

            }
        }
    }
    protected void rptinsert_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

        if (e.CommandName == "Delete")
        {
            string str = @"server=DESKTOP-VQ4TNA2;Integrated Security=SSPI;database=Library;";
            int id = Convert.ToInt32(e.CommandArgument.ToString());

            string sql = "delete from tabBooks where id='" + id + "'";
            string sql2 = "select * from tabBooks where id='" + id + " '";
            DataTable dt = new DataTable();
            dt=Class1.Put1(sql2);
            string bookname=dt.Rows[0][1].ToString();
            string sql1 = "delete from tabBorrow where bookname='" + bookname + "'";
            int result = Class1.Put(sql);
            Class1.Put1(sql1);
            if (result == 1)
                Response.Write("<script>alert('删除成功！');location='Insertbook.aspx'</script>");
            else
                Response.Write("<script>alert('删除失败！');location='Insertbook.aspx'</script>");
        }

    }
    protected void select_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Delete")
        {
            int id = Convert.ToInt32(e.CommandArgument.ToString());

            string sql = "delete from tabBorrow where id='" + id + "'";

            int result = Class1.Put(sql);
            if (result == 1)
                Response.Write("<script>alert('删除成功！');location='Insertbook.aspx'</script>");
            else
                Response.Write("<script>alert('删除失败！');location='Insertbook.aspx'</script>");

        }
    }
    protected void Button1_Click(object sender, EventArgs e)//查询图书借阅情况
    {
        select.Visible = true;
        borrow.Visible = true;
        string massage = txtinput.Text;
        string class1 = dropProv.SelectedValue;
        if (massage.Length == 0)
        {
            string sql6 = "select * from tabBorrow ";
            DataBindToRepeater1(1, sql6);
        }
        else
        {
            if (dropProv.SelectedValue == "书名")
            {
                string sql1 = "select * from tabBorrow where bookname like'%" + massage + "%'";
                DataBindToRepeater1(1, sql1);
            }
            if (dropProv.SelectedValue == "作者")
            {
                string sql2 = "select * from tabBorrow where writer like'%" + massage + "%'";
                DataBindToRepeater1(1, sql2);
            }
            if (dropProv.SelectedValue == "出版社")
            {
                string sql3 = "select * from tabBorrow where press like'%" + massage + "%'";
                DataBindToRepeater1(1, sql3);
            }
            if (dropProv.SelectedValue == "编号")
            {
                string sql4 = "select * from tabBorrow where number like'%" + massage + "%'";
                DataBindToRepeater1(1, sql4);
            }
            if (dropProv.SelectedValue == "分类")
            {
                string sql5 = "select * from tabBorrow where class1 like'%" + massage + "%'";
                DataBindToRepeater1(1, sql5);
            }
            if (dropProv.SelectedValue == "借阅者")
            {
                string sql7 = "select * from tabBorrow where name like'%" + massage + "%'";
                DataBindToRepeater1(1, sql7);
            }
        }
    }
    protected void btnBefore_Click(object sender, EventArgs e)//上一页
    {
        string massage = txtinput.Text;
        string class1 = dropProv.SelectedValue;
        if (massage.Length == 0)
        {
            string sql6 = "select*from tabBooks ";
            lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) - 1);
            DataBindToRepeater(Convert.ToInt32(lblCurrentPage.Text), sql6);

        }
        else
        {
            if (dropProv.SelectedValue == "书名")
            {
                string sql1 = "select * from tabBooks where bookname like'%" + massage + "%'";
                lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) - 1);
                DataBindToRepeater(Convert.ToInt32(lblCurrentPage.Text), sql1);


            }
            if (dropProv.SelectedValue == "作者")
            {
                string sql2 = "select * from tabBooks where writer like'%" + massage + "%'";
                lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) - 1);
                DataBindToRepeater(Convert.ToInt32(lblCurrentPage.Text), sql2);

            }
            if (dropProv.SelectedValue == "出版社")
            {
                string sql3 = "select * from tabBooks where press like'%" + massage + "%'";
                lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) - 1);
                DataBindToRepeater(Convert.ToInt32(lblCurrentPage.Text), sql3);

            }
            if (dropProv.SelectedValue == "编号")
            {
                string sql4 = "select * from tabBooks where number like'%" + massage + "%'";
                lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) - 1);
                DataBindToRepeater(Convert.ToInt32(lblCurrentPage.Text), sql4);

            }
            if (dropProv.SelectedValue == "分类")
            {
                string sql5 = "select * from tabBooks where class1 like'%" + massage + "%'";
                lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) - 1);
                DataBindToRepeater(Convert.ToInt32(lblCurrentPage.Text), sql5);


            }
        }
    }
    protected void btnNext_Click(object sender, EventArgs e)//下一页
    {
        string massage = txtinput.Text;
        string class1 = dropProv.SelectedValue;
        if (massage.Length == 0)
        {
            string sql6 = "select*from tabBooks ";
            lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) + 1);
            DataBindToRepeater(Convert.ToInt32(lblCurrentPage.Text), sql6);

        }
        else
        {
            if (dropProv.SelectedValue == "书名")
            {
                string sql1 = "select * from tabBooks where bookname like'%" + massage + "%'";
                lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) + 1);
                DataBindToRepeater(Convert.ToInt32(lblCurrentPage.Text), sql1);


            }
            if (dropProv.SelectedValue == "作者")
            {
                string sql2 = "select * from tabBooks where writer like'%" + massage + "%'";
                lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) + 1);
                DataBindToRepeater(Convert.ToInt32(lblCurrentPage.Text), sql2);

            }
            if (dropProv.SelectedValue == "出版社")
            {
                string sql3 = "select * from tabBooks where press like'%" + massage + "%'";
                lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) + 1);
                DataBindToRepeater(Convert.ToInt32(lblCurrentPage.Text), sql3);

            }
            if (dropProv.SelectedValue == "编号")
            {
                string sql4 = "select * from tabBooks where number like'%" + massage + "%'";
                lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) + 1);
                DataBindToRepeater(Convert.ToInt32(lblCurrentPage.Text), sql4);

            }
            if (dropProv.SelectedValue == "分类")
            {
                string sql5 = "select * from tabBooks where class1 like'%" + massage + "%'";
                lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) + 1);
                DataBindToRepeater(Convert.ToInt32(lblCurrentPage.Text), sql5);


            }
        }
    }
    protected void butTop_Click(object sender, EventArgs e)//首页
    {
        string massage = txtinput.Text;
        string class1 = dropProv.SelectedValue;
        if (massage.Length == 0)
        {
            string sql6 = "select*from tabBooks ";
            lblCurrentPage.Text = "1";
            DataBindToRepeater(1, sql6);

        }
        else
        {
            if (dropProv.SelectedValue == "书名")
            {
                string sql1 = "select * from tabBooks where bookname like'%" + massage + "%'";
                lblCurrentPage.Text = "1";
                DataBindToRepeater(1, sql1);


            }
            if (dropProv.SelectedValue == "作者")
            {
                string sql2 = "select * from tabBooks where writer like'%" + massage + "%'";
                lblCurrentPage.Text = "1";
                DataBindToRepeater(1, sql2);

            }
            if (dropProv.SelectedValue == "出版社")
            {
                string sql3 = "select * from tabBooks where press like'%" + massage + "%'";
                lblCurrentPage.Text = "1";
                DataBindToRepeater(1, sql3);

            }
            if (dropProv.SelectedValue == "编号")
            {
                string sql4 = "select * from tabBooks where number like'%" + massage + "%'";
                lblCurrentPage.Text = "1";
                DataBindToRepeater(1, sql4);

            }
            if (dropProv.SelectedValue == "分类")
            {
                string sql5 = "select * from tabBooks where class1 like'%" + massage + "%'";
                lblCurrentPage.Text = "1";
                DataBindToRepeater(1, sql5);


            }
        }
    }
    protected void btnFinal_Click(object sender, EventArgs e)//尾页
    {
        string massage = txtinput.Text;
        string class1 = dropProv.SelectedValue;
        if (massage.Length == 0)
        {
            string sql6 = "select * from tabBooks ";
            DataTable dt = new DataTable();

            dt = Class1.Put1(sql6);

            PagedDataSource pds = new PagedDataSource();

            pds.AllowPaging = true;

            pds.PageSize = 5;

            pds.DataSource = dt.DefaultView;
            int Count = pds.PageCount;
            labPage.Text = Count.ToString();
            lblCurrentPage.Text = Count.ToString();
            DataBindToRepeater(Count, sql6);

        }
        else
        {
            if (dropProv.SelectedValue == "书名")
            {
                string sql1 = "select * from tabBooks where bookname like'%" + massage + "%'";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql1);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage.Text = Count.ToString();
                lblCurrentPage.Text = Count.ToString();
                DataBindToRepeater(Count, sql1);


            }
            if (dropProv.SelectedValue == "作者")
            {
                string sql2 = "select * from tabBooks where writer like'%" + massage + "%'";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql2);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage.Text = Count.ToString();
                lblCurrentPage.Text = Count.ToString();
                DataBindToRepeater(Count, sql2);

            }
            if (dropProv.SelectedValue == "出版社")
            {
                string sql3 = "select * from tabBooks where press like'%" + massage + "%'";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql3);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage.Text = Count.ToString();
                lblCurrentPage.Text = Count.ToString();
                DataBindToRepeater(Count, sql3);

            }
            if (dropProv.SelectedValue == "编号")
            {
                string sql4 = "select * from tabBooks where number like'%" + massage + "%'";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql4);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage.Text = Count.ToString();
                lblCurrentPage.Text = Count.ToString();
                DataBindToRepeater(Count, sql4);

            }
            if (dropProv.SelectedValue == "分类")
            {
                string sql5 = "select * from tabBooks where class1 like'%" + massage + "%'";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql5);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage.Text = Count.ToString();
                lblCurrentPage.Text = Count.ToString();
                DataBindToRepeater(Count, sql5);

            }
        }
    }

    void DataBindToRepeater(int currentPage, string sql)
    {

        DataTable dt = new DataTable();

        dt = Class1.Put1(sql);

        PagedDataSource pds = new PagedDataSource();

        pds.AllowPaging = true;

        pds.PageSize = 5;

        pds.DataSource = dt.DefaultView;
        int Count = pds.PageCount;
        if (Count == 1)
        {
            currentPage = 1;
            btnBefore.Enabled = false;
            btnNext.Enabled = false;
        }
        else if (currentPage == Count)
        {
            btnBefore.Enabled = true;
            btnNext.Enabled = false;

        }
        else if (currentPage == 1)
        {
            btnBefore.Enabled = false;
            btnNext.Enabled = true;

        }
        else
        {
            btnBefore.Enabled = true;
            btnNext.Enabled = true;
        }
        lblCurrentPage.Text = currentPage.ToString();
        labPage.Text = Count.ToString();
        pds.CurrentPageIndex = currentPage - 1;

        rptinsert.DataSource = pds;

        rptinsert.DataBind();

    }
    void DataBindToRepeater1(int currentPage, string sql)
    {

        DataTable dt = new DataTable();

        dt = Class1.Put1(sql);

        PagedDataSource pds = new PagedDataSource();

        pds.AllowPaging = true;

        pds.PageSize = 5;

        pds.DataSource = dt.DefaultView;
        int Count = pds.PageCount;
        if (Count == 1)
        {
            currentPage = 1;
            btnBefore1.Enabled = false;
            btnNext1.Enabled = false;
        }
        else if (currentPage == Count)
        {
            btnBefore1.Enabled = true;
            btnNext1.Enabled = false;

        }
        else if (currentPage == 1)
        {
            btnBefore1.Enabled = false;
            btnNext1.Enabled = true;

        }
        else
        {
            btnBefore1.Enabled = true;
            btnNext1.Enabled = true;
        }
        lblCurrentPage1.Text = currentPage.ToString();
        labPage1.Text = Count.ToString();
        pds.CurrentPageIndex = currentPage - 1;

        select.DataSource = pds;

        select.DataBind();

    }

    protected void btnBefore1_Click(object sender, EventArgs e)//上一页
    {
        string massage = txtinput.Text;
        string class1 = dropProv.SelectedValue;
        if (massage.Length == 0)
        {
            string sql6 = "select*from tabBorrow ";
            lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) - 1);
            DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql6);

        }
        else
        {
            if (dropProv.SelectedValue == "书名")
            {
                string sql1 = "select * from tabBorrow where bookname like'%" + massage + "%'";
                lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) - 1);
                DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql1);


            }
            if (dropProv.SelectedValue == "作者")
            {
                string sql2 = "select * from tabBorrow where writer like'%" + massage + "%'";
                lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) - 1);
                DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql2);

            }
            if (dropProv.SelectedValue == "出版社")
            {
                string sql3 = "select * from tabBorrow where press like'%" + massage + "%'";
                lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) - 1);
                DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql3);

            }
            if (dropProv.SelectedValue == "编号")
            {
                string sql4 = "select * from tabBorrow where number like'%" + massage + "%'";
                lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) - 1);
                DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql4);

            }
            if (dropProv.SelectedValue == "分类")
            {
                string sql5 = "select * from tabBorrow where class1 like'%" + massage + "%'";
                lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) - 1);
                DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql5);
            }
            if (dropProv.SelectedValue == "借阅者")
            {
                string sql7 = "select * from tabBorrow where name like'%" + massage + "%'";
                lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) - 1);
                DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql7);
            }
        }
    }

    protected void btnNext1_Click(object sender, EventArgs e)//下一页
    {
        string massage = txtinput.Text;
        string class1 = dropProv.SelectedValue;
        if (massage.Length == 0)
        {
            string sql6 = "select*from tabBorrow ";
            lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) + 1);
            DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql6);

        }
        else
        {
            if (dropProv.SelectedValue == "书名")
            {
                string sql1 = "select * from tabBorrow where bookname like'%" + massage + "%'";
                lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) + 1);
                DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql1);


            }
            if (dropProv.SelectedValue == "作者")
            {
                string sql2 = "select * from tabBorrow where writer like'%" + massage + "%'";
                lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) + 1);
                DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql2);

            }
            if (dropProv.SelectedValue == "出版社")
            {
                string sql3 = "select * from tabBorrow where press like'%" + massage + "%'";
                lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) + 1);
                DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql3);

            }
            if (dropProv.SelectedValue == "编号")
            {
                string sql4 = "select * from tabBorrow where number like'%" + massage + "%'";
                lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) + 1);
                DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql4);

            }
            if (dropProv.SelectedValue == "分类")
            {
                string sql5 = "select * from tabBorrow where class1 like'%" + massage + "%'";
                lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) + 1);
                DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql5);
            }
            if (dropProv.SelectedValue == "借阅者")
            {
                string sql7 = "select * from tabBorrow where name like'%" + massage + "%'";
                lblCurrentPage1.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage1.Text) + 1);
                DataBindToRepeater1(Convert.ToInt32(lblCurrentPage1.Text), sql7);
            }
        }
    }
    protected void btnTop1_Click(object sender, EventArgs e)
    {
        string massage = txtinput.Text;
        string class1 = dropProv.SelectedValue;
        if (massage.Length == 0)
        {
            string sql6 = "select*from tabBorrow ";
            lblCurrentPage1.Text = "1";
            DataBindToRepeater1(1, sql6);

        }
        else
        {
            if (dropProv.SelectedValue == "书名")
            {
                string sql1 = "select * from tabBorrow where bookname like'%" + massage + "%'";
                lblCurrentPage1.Text = "1";
                DataBindToRepeater1(1, sql1);


            }
            if (dropProv.SelectedValue == "作者")
            {
                string sql2 = "select * from tabBorrow where writer like'%" + massage + "%'";
                lblCurrentPage1.Text = "1";
                DataBindToRepeater1(1, sql2);

            }
            if (dropProv.SelectedValue == "出版社")
            {
                string sql3 = "select * from tabBorrow where press like'%" + massage + "%'";
                lblCurrentPage1.Text = "1";
                DataBindToRepeater1(1, sql3);

            }
            if (dropProv.SelectedValue == "编号")
            {
                string sql4 = "select * from tabBorrow where number like'%" + massage + "%'";
                lblCurrentPage1.Text = "1";
                DataBindToRepeater1(1, sql4);

            }
            if (dropProv.SelectedValue == "分类")
            {
                string sql5 = "select * from tabBorrow where class1 like'%" + massage + "%'";
                lblCurrentPage1.Text = "1";
                DataBindToRepeater1(1, sql5);
            }
            if (dropProv.SelectedValue == "借阅者")
            {
                string sql7 = "select * from tabBorrow where name like'%" + massage + "%'";
                lblCurrentPage1.Text = "1";
                DataBindToRepeater1(1, sql7);
            }
        }
    }
    protected void btnFinal1_Click(object sender, EventArgs e)
    {
        string massage = txtinput.Text;
        string class1 = dropProv.SelectedValue;
        if (massage.Length == 0)
        {
            string sql6 = "select * from tabBorrow ";
            DataTable dt = new DataTable();

            dt = Class1.Put1(sql6);

            PagedDataSource pds = new PagedDataSource();

            pds.AllowPaging = true;

            pds.PageSize = 5;

            pds.DataSource = dt.DefaultView;
            int Count = pds.PageCount;
            labPage1.Text = Count.ToString();
            lblCurrentPage1.Text = Count.ToString();
            DataBindToRepeater1(Count, sql6);

        }
        else
        {
            if (dropProv.SelectedValue == "书名")
            {
                string sql1 = "select * from tabBorrow where bookname like'%" + massage + "%'";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql1);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage1.Text = Count.ToString();
                lblCurrentPage1.Text = Count.ToString();
                DataBindToRepeater1(Count, sql1);


            }
            if (dropProv.SelectedValue == "作者")
            {
                string sql2 = "select * from tabBorrow where writer like'%" + massage + "%'";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql2);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage1.Text = Count.ToString();
                lblCurrentPage1.Text = Count.ToString();
                DataBindToRepeater1(Count, sql2);

            }
            if (dropProv.SelectedValue == "出版社")
            {
                string sql3 = "select * from tabBorrow where press like'%" + massage + "%'";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql3);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage1.Text = Count.ToString();
                lblCurrentPage1.Text = Count.ToString();
                DataBindToRepeater1(Count, sql3);

            }
            if (dropProv.SelectedValue == "编号")
            {
                string sql4 = "select * from tabBorrow where number like'%" + massage + "%'";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql4);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage1.Text = Count.ToString();
                lblCurrentPage1.Text = Count.ToString();
                DataBindToRepeater1(Count, sql4);

            }
            if (dropProv.SelectedValue == "分类")
            {
                string sql5 = "select * from tabBorrow where class1 like'%" + massage + "%'";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql5);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage1.Text = Count.ToString();
                lblCurrentPage1.Text = Count.ToString();
                DataBindToRepeater1(Count, sql5);

            }
            if (dropProv.SelectedValue == "借阅者")
            {
                string sql5 = "select * from tabBorrow where name like'%" + massage + "%'";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql5);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage1.Text = Count.ToString();
                lblCurrentPage1.Text = Count.ToString();
                DataBindToRepeater1(Count, sql5);

            }
        }
    }
    protected void paperturn_Click(object sender, EventArgs e)
    {
        int num = 0;

        if (int.TryParse(Request.Form[paper.UniqueID], out num))
        {
            string massage = txtinput.Text;
            string class1 = dropProv.SelectedValue;
            int papercount = Convert.ToInt32( paper.Text);
            if (massage.Length == 0)
            {
                string sql6 = "select * from tabBooks ";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql6);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage.Text = Count.ToString();
                if (papercount == 0 || papercount > Count)
                {
                    Response.Write("<script>alert('操作无效')</script>");
                }
                else
                {
                    lblCurrentPage.Text = papercount.ToString();
                    DataBindToRepeater(papercount, sql6);
                }

            }
            else
            {
                if (dropProv.SelectedValue == "书名")
                {
                    string sql1 = "select * from tabBooks where bookname like'%" + massage + "%'";
                    DataTable dt = new DataTable();

                    dt = Class1.Put1(sql1);

                    PagedDataSource pds = new PagedDataSource();

                    pds.AllowPaging = true;

                    pds.PageSize = 5;

                    pds.DataSource = dt.DefaultView;
                    int Count = pds.PageCount;
                    labPage.Text = Count.ToString();
                    if (papercount == 0 || papercount > Count)
                    {
                        Response.Write("<script>alert('操作无效')</script>");
                    }
                    else
                    {
                        lblCurrentPage.Text = papercount.ToString();
                        DataBindToRepeater(papercount, sql1);
                    }

                }
                if (dropProv.SelectedValue == "作者")
                {
                    string sql2 = "select * from tabBooks where writer like'%" + massage + "%'";
                    DataTable dt = new DataTable();

                    dt = Class1.Put1(sql2);

                    PagedDataSource pds = new PagedDataSource();

                    pds.AllowPaging = true;

                    pds.PageSize = 5;

                    pds.DataSource = dt.DefaultView;
                    int Count = pds.PageCount;
                    labPage.Text = Count.ToString();
                    if (papercount == 0 || papercount > Count)
                    {
                        Response.Write("<script>alert('操作无效')</script>");
                    }
                    else
                    {
                        lblCurrentPage.Text = papercount.ToString();
                        DataBindToRepeater(papercount, sql2);
                    }

                }
                if (dropProv.SelectedValue == "出版社")
                {
                    string sql3 = "select * from tabBooks where press like'%" + massage + "%'";
                    DataTable dt = new DataTable();

                    dt = Class1.Put1(sql3);

                    PagedDataSource pds = new PagedDataSource();

                    pds.AllowPaging = true;

                    pds.PageSize = 5;

                    pds.DataSource = dt.DefaultView;
                    int Count = pds.PageCount;
                    labPage.Text = Count.ToString();
                    if (papercount == 0 || papercount > Count)
                    {
                        Response.Write("<script>alert('操作无效')</script>");
                    }
                    else
                    {
                        lblCurrentPage.Text = papercount.ToString();
                        DataBindToRepeater(papercount, sql3);
                    }

                }
                if (dropProv.SelectedValue == "编号")
                {
                    string sql4 = "select * from tabBooks where number like'%" + massage + "%'";
                    DataTable dt = new DataTable();

                    dt = Class1.Put1(sql4);

                    PagedDataSource pds = new PagedDataSource();

                    pds.AllowPaging = true;

                    pds.PageSize = 5;

                    pds.DataSource = dt.DefaultView;
                    int Count = pds.PageCount;
                    labPage.Text = Count.ToString();
                    if (papercount == 0 || papercount > Count)
                    {
                        Response.Write("<script>alert('操作无效')</script>");
                    }
                    else
                    {
                        lblCurrentPage.Text = papercount.ToString();
                        DataBindToRepeater(papercount, sql4);
                    }

                }
                if (dropProv.SelectedValue == "分类")
                {
                    string sql5 = "select * from tabBooks where class1 like'%" + massage + "%'";
                    DataTable dt = new DataTable();

                    dt = Class1.Put1(sql5);

                    PagedDataSource pds = new PagedDataSource();

                    pds.AllowPaging = true;

                    pds.PageSize = 5;

                    pds.DataSource = dt.DefaultView;
                    int Count = pds.PageCount;
                    labPage.Text = Count.ToString();
                    if (papercount == 0 || papercount > Count)
                    {
                        Response.Write("<script>alert('操作无效')</script>");
                    }
                    else
                    {
                        lblCurrentPage.Text = papercount.ToString();
                        DataBindToRepeater(papercount, sql5);
                    }

                }
            }
        }
        else Response.Write("<script>alert('数量为数字！')</script>");
    }
    protected void paperturn1_Click(object sender, EventArgs e)
    {
        int num = 0;

        if (int.TryParse(Request.Form[paper1.UniqueID], out num))
        {
            string massage = txtinput.Text;
            string class1 = dropProv.SelectedValue;
            int papercount = Convert.ToInt32(paper1.Text);
            if (massage.Length == 0)
            {
                string sql6 = "select * from tabBorrow ";
                DataTable dt = new DataTable();

                dt = Class1.Put1(sql6);

                PagedDataSource pds = new PagedDataSource();

                pds.AllowPaging = true;

                pds.PageSize = 5;

                pds.DataSource = dt.DefaultView;
                int Count = pds.PageCount;
                labPage1.Text = Count.ToString();
                if (papercount == 0 || papercount > Count)
                {
                    Response.Write("<script>alert('操作无效')</script>");
                }
                else
                {
                    lblCurrentPage.Text = papercount.ToString();
                    DataBindToRepeater1(papercount, sql6);
                }

            }
            else
            {
                if (dropProv.SelectedValue == "书名")
                {
                    string sql1 = "select * from tabBorrow where bookname like'%" + massage + "%'";
                    DataTable dt = new DataTable();

                    dt = Class1.Put1(sql1);

                    PagedDataSource pds = new PagedDataSource();

                    pds.AllowPaging = true;

                    pds.PageSize = 5;

                    pds.DataSource = dt.DefaultView;
                    int Count = pds.PageCount;
                    labPage1.Text = Count.ToString();
                    if (papercount <=1 || papercount > Count)
                    {
                        Response.Write("<script>alert('操作无效')</script>");
                    }
                    else
                    {
                        lblCurrentPage1.Text = papercount.ToString();
                        DataBindToRepeater1(papercount, sql1);
                    }

                }
                if (dropProv.SelectedValue == "作者")
                {
                    string sql2 = "select * from tabBorrow where writer like'%" + massage + "%'";
                    DataTable dt = new DataTable();

                    dt = Class1.Put1(sql2);

                    PagedDataSource pds = new PagedDataSource();

                    pds.AllowPaging = true;

                    pds.PageSize = 5;

                    pds.DataSource = dt.DefaultView;
                    int Count = pds.PageCount;
                    labPage1.Text = Count.ToString();
                    if (papercount == 0 || papercount > Count)
                    {
                        Response.Write("<script>alert('操作无效')</script>");
                    }
                    else
                    {
                        lblCurrentPage1.Text = papercount.ToString();
                        DataBindToRepeater1(papercount, sql2);
                    }

                }
                if (dropProv.SelectedValue == "出版社")
                {
                    string sql3 = "select * from tabBorrow where press like'%" + massage + "%'";
                    DataTable dt = new DataTable();

                    dt = Class1.Put1(sql3);

                    PagedDataSource pds = new PagedDataSource();

                    pds.AllowPaging = true;

                    pds.PageSize = 5;

                    pds.DataSource = dt.DefaultView;
                    int Count = pds.PageCount;
                    labPage1.Text = Count.ToString();
                    if (papercount == 0 || papercount > Count)
                    {
                        Response.Write("<script>alert('操作无效')</script>");
                    }
                    else
                    {
                        lblCurrentPage1.Text = papercount.ToString();
                        DataBindToRepeater1(papercount, sql3);
                    }

                }
                if (dropProv.SelectedValue == "编号")
                {
                    string sql4 = "select * from tabBorrow where number like'%" + massage + "%'";
                    DataTable dt = new DataTable();

                    dt = Class1.Put1(sql4);

                    PagedDataSource pds = new PagedDataSource();

                    pds.AllowPaging = true;

                    pds.PageSize = 5;

                    pds.DataSource = dt.DefaultView;
                    int Count = pds.PageCount;
                    labPage1.Text = Count.ToString();
                    if (papercount == 0 || papercount > Count)
                    {
                        Response.Write("<script>alert('操作无效')</script>");
                    }
                    else
                    {
                        lblCurrentPage1.Text = papercount.ToString();
                        DataBindToRepeater1(papercount, sql4);
                    }

                }
                if (dropProv.SelectedValue == "分类")
                {
                    string sql5 = "select * from tabBorrow where class1 like'%" + massage + "%'";
                    DataTable dt = new DataTable();

                    dt = Class1.Put1(sql5);

                    PagedDataSource pds = new PagedDataSource();

                    pds.AllowPaging = true;

                    pds.PageSize = 5;

                    pds.DataSource = dt.DefaultView;
                    int Count = pds.PageCount;
                    labPage1.Text = Count.ToString();
                    if (papercount == 0 || papercount > Count)
                    {
                        Response.Write("<script>alert('操作无效')</script>");
                    }
                    else
                    {
                        lblCurrentPage1.Text = papercount.ToString();
                        DataBindToRepeater1(papercount, sql5);
                    }

                }
                if (dropProv.SelectedValue == "借阅者")
                {
                    string sql5 = "select * from tabBorrow where name like'%" + massage + "%'";
                    DataTable dt = new DataTable();

                    dt = Class1.Put1(sql5);

                    PagedDataSource pds = new PagedDataSource();

                    pds.AllowPaging = true;

                    pds.PageSize = 5;

                    pds.DataSource = dt.DefaultView;
                    int Count = pds.PageCount;
                    labPage1.Text = Count.ToString();
                    if (papercount <=1 || papercount > Count)
                    {
                        Response.Write("<script>alert('操作无效')</script>");
                    }
                    else
                    {
                        lblCurrentPage1.Text = papercount.ToString();
                        DataBindToRepeater1(papercount, sql5);
                    }

                }
            }
        }
        else Response.Write("<script>alert('数量为数字！')</script>");
    }
}


