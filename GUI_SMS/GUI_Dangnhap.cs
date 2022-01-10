using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_SMS;

namespace GUI_SMS
{
    public partial class GUI_Dangnhap : Form
    {
        BUS_Danghap bn = new BUS_Danghap();
        public GUI_Dangnhap()
        {
            InitializeComponent();
            
        }



        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string tk = txtTaikhoan.Text;
            string mk = txtMatkhau.Text;


            int i = bn.Dangnhap(tk, mk);
            if (txtMatkhau.Text != "" && txtTaikhoan.Text != "")
            {
                if (i == 1)
                {
                    mySave.KT = !mySave.KT;
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai thông tin", "Thông báo");
                    txtTaikhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Thông tin thiếu", "Thông báo");
            }
        }
    }
}
