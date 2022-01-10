using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_SMS
{
    public class DAL_Thongke : DBConnection
    {
        public DataTable getThongke()
        {
            string str = string.Format("select * from Thongke");
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable Thongke = new DataTable();
            da.Fill(Thongke);
            return Thongke;
        }
        public DataTable Timloai(string loaiTB)
        {
            string str = string.Format("select * from Thongke where LoaiTB like N'%{0}%'",loaiTB);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable Thongke = new DataTable();
            da.Fill(Thongke);
            return Thongke;
        }
        public DataTable Timngaymua(string ngaymua)
        {
            string str = string.Format("select * from Thongke where Ngaymua like '%{0}%'", ngaymua);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable Thongke = new DataTable();
            da.Fill(Thongke);
            return Thongke;
        }
    }
}
