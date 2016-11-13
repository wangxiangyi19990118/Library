using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/// <summary>
/// Class1 的摘要说明
/// </summary>
public class Class1
{
   static string str = @"server=DESKTOP-VQ4TNA2;Integrated Security=SSPI;database=Library;";
	public Class1()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static int Put(string sql)
    {
        try
        {
            SqlConnection conn = new SqlConnection(str);
            DataTable ds = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();
            return 1;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return 0;
        }

}
    public static int Find(string sql)
    {
        try
        {
            SqlConnection conn = new SqlConnection(str);
            DataTable dt = new DataTable();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            da.Fill(dt);
            int count = dt.Rows.Count;
            conn.Close();
            if (count> 0)
            {
                return 1;
            }
            else return 0;
           
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return 0;
        }
        
    }
     public static string Find1(string sql)
    {
        try
        {
            SqlConnection conn = new SqlConnection(str);
            DataTable dt = new DataTable();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            da.Fill(dt);
            int count = dt.Rows.Count;
            string name = dt.Rows.Count.ToString();
            conn.Close();
            string id=dt.Rows[0][0].ToString ();
            return dt.Rows[0][2].ToString();
           
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return "";
        }
        
    }
     public static DataTable Put1(string sql)
     {
        
             SqlConnection conn = new SqlConnection(str);
             DataTable ds = new DataTable();
             conn.Open();
             SqlDataAdapter da = new SqlDataAdapter(sql, conn);
             da.Fill(ds);
             conn.Close();
             return ds;
     }
     public static bool bolNon(string temp)
     {
         bool flag = true;
         if (temp != "")
         {
             for (int i = 0; i < temp.Length; i++)
             {
                 if (!Char.IsNumber(temp, i))
                 { flag = false; break; }
             }
         }
         else flag = false;
         return flag;
     }
     public static string Find2(string sql)
     {
         try
         {
             SqlConnection conn = new SqlConnection(str);
             DataTable dt = new DataTable();
             conn.Open();

             SqlDataAdapter da = new SqlDataAdapter(sql, conn);
             da.Fill(dt);
             int count = dt.Rows.Count;
             string name = dt.Rows.Count.ToString();
             conn.Close();
             string id = dt.Rows[0][0].ToString();
             return dt.Rows[0][9].ToString();

         }
         catch (Exception ex)
         {
             Console.WriteLine(ex.Message);
             return "";
         }

     }
    }
