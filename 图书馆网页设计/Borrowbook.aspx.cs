using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Borrowbook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"] != null)
        {
            borrow.Visible = true;
            string username = Session["name"].ToString();
            lbname.Text = username;
            Session["name"] = username;
        }
        else
        {
            Response.Write("<script>alert('请先登录！')</script>");
            Response.Redirect("Login.aspx");
        }
    }
    protected void insert(object sender, EventArgs e)
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
    protected void paperturn_Click(object sender, EventArgs e)
    {
        int num = 0;

        if (int.TryParse(Request.Form[paper.UniqueID], out num))
        {
            string massage = txtinput.Text;
            string class1 = dropProv.SelectedValue;
            int papercount = Convert.ToInt32(paper.Text);
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
}