using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_SMS;
using System.Data;

namespace BUS_SMS
{
    public class BUS_Banhang
    {
        DAL_Banhang daBan = new DAL_Banhang();   
        public DataTable TimAll(string loaitb, string tentb)
        {
            return daBan.TimAll(loaitb,tentb);
        }
            public DataTable TimLoai(string loaitb)
        {
            return daBan.TimLoai(loaitb);
        }
        public DataTable TimTen(string tentb)
        {
            return daBan.TimTen(tentb);
        }
        public bool Datmua(int soluong, string matb)
        {
            return daBan.Datmua(soluong, matb);
        }
        public bool Thongke(string matb, string loaitb, string tentb, string sl, string dvt, string gia, string ngaynhap, string ngaymua)
        {
            return daBan.Thongke(matb, loaitb, tentb, sl, dvt, gia, ngaynhap, ngaymua);
        }
    }
}
