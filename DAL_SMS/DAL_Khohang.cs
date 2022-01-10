using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_SMS
{
    public class DAL_Khohang: DBConnection
    {
        public DataTable getKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from ThietBi", con);
            DataTable daKho = new DataTable();
            da.Fill(daKho);
            return daKho;
        }
        public bool Them(string matb, string loaitb,string tentb, string sl, string dvt, string gia, string ngaynhap)
        {
            string str = string.Format("insert  into ThietBi (MaTB,LoaiTB,TenTB,Soluong,Donvitinh,Giatien,Ngaynhap) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", matb,loaitb,tentb,sl,dvt,gia,ngaynhap);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool Xoa(string matb)
        {
            string str = string.Format("delete  from ThietBi where MaTB='{0}'", matb);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool capnhat(string matb, string matb1, string loaitb, string tentb, string sl, string dvt, string gia, string ngaynhap)
        {
            string str = string.Format("update ThietBi set MaTB='{0}',LoaiTB=N'{1}',TenTB=N'{2}',Soluong='{3}',Donvitinh=N'{4}',Giatien='{5}',Ngaynhap='{6}' where MaTB ='{7}'", matb1, loaitb, tentb, sl, dvt, gia, ngaynhap,matb);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
    }
}
