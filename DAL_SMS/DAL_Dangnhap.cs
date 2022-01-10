using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL_SMS
{
    public class DAL_Dangnhap : DBConnection
    {
        public int Dangnhap(string tk, string mk)
        {
            SqlDataAdapter data = new SqlDataAdapter($"select * from Taikhoan where Taikhoan='{tk}' and Matkhau='{mk}'", con);
            DataTable daDN = new DataTable();
            data.Fill(daDN);
            if (daDN.Rows.Count > 0)
            {
                return 1;
            }
            else return 0;

        } 
    }
}
