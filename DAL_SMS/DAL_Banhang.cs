using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL_SMS
{
    public class  DAL_Banhang : DBConnection
    {    
        public DataTable TimAll(string loaitb, string tentb)
        {
            string str = string.Format("select * from ThietBi where LoaiTB like N'%{0}%' and TenTB like N'%{1}%'", loaitb, tentb);
            SqlDataAdapter da = new SqlDataAdapter(str, con);//thuc hien sql
            DataTable Thuenha = new DataTable();
            da.Fill(Thuenha);
            return Thuenha;
        }
        public DataTable TimLoai(string loaitb){

            string str = string.Format("select * from ThietBi where LoaiTB like N'%{0}%' ",loaitb );
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable Thuenha = new DataTable();
            da.Fill(Thuenha);        
            return Thuenha; 
         }
        public DataTable TimTen(string tentb)
        {

            string str = string.Format("select * from ThietBi where TenTB like N'%{0}%'", tentb);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable Thuenha = new DataTable();
            da.Fill(Thuenha);
            return Thuenha;
        }
        public bool Datmua(int soluong, string matb)
        {

            string str = string.Format("update ThietBi set Soluong='{0}' where MaTB ='{1}'", soluong, matb);
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
        public bool Thongke(string matb, string loaitb, string tentb, string sl, string dvt, string gia, string ngaynhap, string ngaymua)
        {
            string str = string.Format("insert  into Thongke (MaTB,LoaiTB,TenTB,Soluong,Donvitinh,Giatien,Ngaynhap,Ngaymua) values('{0}',N'{1}',N'{2}','{3}',N'{4}','{5}','{6}','{7}')", matb, loaitb, tentb, sl, dvt, gia, ngaynhap, ngaymua);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
           
        }
    }
}
