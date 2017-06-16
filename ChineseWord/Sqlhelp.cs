using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;

namespace ChineseWord
{
    public class Sqlhelp
    {

        public DataSet QueryAll(string path)
        {
            SQLiteConnection conn = null;

            string dbPath = "Data Source =" + path;
            conn = new SQLiteConnection(dbPath);//创建数据库实例，指定文件位置  
            conn.Open();//打开数据库，若文件不存在会自动创建  

            string sql = "select * from Grade_Type";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public string  QueryWhere(string path,string Name)
        {
            SQLiteConnection conn = null;
            string Url = "0";
            string dbPath = "Data Source =" + path;
            conn = new SQLiteConnection(dbPath);//创建数据库实例，指定文件位置  
            conn.Open();//打开数据库，若文件不存在会自动创建  

            string sql = "select Url from MovieUrl where Name= '"+Name+"'";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Url = ds.Tables[0].Rows[0][0].ToString();
            }
            conn.Close();
            return Url;
        }
      

    }
}
