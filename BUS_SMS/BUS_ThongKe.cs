using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_SMS;
using System.Data;

namespace BUS_SMS
{
    public class BUS_ThongKe
    {
        DAL_Thongke daThongke = new DAL_Thongke();
        public DataTable getThongke()
        {
            return daThongke.getThongke();
        }
        public DataTable Timloai(string loaiTB)
        {
            return daThongke.Timloai(loaiTB);
        }
        public DataTable Timngaymua(string ngaymua)
        {
            return daThongke.Timngaymua(ngaymua);
        }
    }
}

