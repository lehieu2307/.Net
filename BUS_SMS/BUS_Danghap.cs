using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_SMS;

namespace BUS_SMS
{
   public class BUS_Danghap
    {
        DAL_Dangnhap daDN = new DAL_Dangnhap();
        public int Dangnhap(string tk, string mk)
        {
            return daDN.Dangnhap(tk, mk);
        }
    }
}
