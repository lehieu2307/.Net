using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_SMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Lock_Unlock(mySave.KT);
        }
        void Lock_Unlock(Boolean kt)
        {
            mnuDangxuat.Enabled = mnuKhohang.Enabled = mnuBanhang.Enabled = mnuThongke.Enabled = !kt;
            mnuDangnhap.Enabled = mnuThoat.Enabled = kt;

        }

        private void GUI_Menu_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
        } 

        private void mnuDangnhap_Click(object sender, EventArgs e)
        {
            GUI_Dangnhap f = new GUI_Dangnhap();
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
            Lock_Unlock(mySave.KT);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuBanhang_Click(object sender, EventArgs e)
        {
            GUI_Banhang f = new GUI_Banhang();
            f.Show();
        }

        private void mnuThongke_Click(object sender, EventArgs e)
        {
            GUI_Thongke f = new GUI_Thongke();
            f.Show();
        }

        private void mnuKhohang_Click(object sender, EventArgs e)
        {
            GUI_Khohang f = new GUI_Khohang();
            f.Show();
        }
    }
}
