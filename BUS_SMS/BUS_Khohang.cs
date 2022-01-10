using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_SMS;
using System.Data;
using System.Data.SqlClient;

namespace BUS_SMS
{
    public class BUS_Khohang
    {
        DAL_Khohang daKho = new DAL_Khohang();
        public DataTable getKho()
        {
            return daKho.getKho();
        }
        public bool Them(string matb, string loaitb, string tentb, string sl, string dvt, string gia, string ngaynhap)
        {
            return daKho.Them(matb, loaitb, tentb, sl, dvt, gia, ngaynhap);
        }
        public bool Xoa(string matb)
        {
            return daKho.Xoa(matb);
        }
        public bool capnhat(string matb, string matb1, string loaitb, string tentb, string sl, string dvt, string gia, string ngaynhap)
        {
            return daKho.capnhat(matb,matb1, loaitb, tentb, sl, dvt, gia, ngaynhap);
        }
    }
}
