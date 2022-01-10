using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_SMS
{
     public class DAL_Login1 : DBConnection
    {
        public int getLogin(string username, string password)
        {

            SqlDataAdapter da = new SqlDataAdapter($"select * from User where username='{username}' and password='{password}'", con);//thuc hien cau lenh sql
            DataTable daLG = new DataTable();
            da.Fill(daLG);
            if (daLG.Rows.Count > 0)
            {
                return 1;
            }
            else return 0;

        }
    }
}
