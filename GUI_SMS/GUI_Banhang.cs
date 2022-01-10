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
    public partial class GUI_Banhang : Form
    {
        BUS_Banhang busBan = new BUS_Banhang();
        BUS_Khohang busKho = new BUS_Khohang();
        string matb;
        string time;
        public GUI_Banhang()
        {
            InitializeComponent();
        }

        private void GUI_Banhang_Load(object sender, EventArgs e)
        {
            dgvBanhang.DataSource = busKho.getKho();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtLoaitb.Text != "" && txtTentb.Text == "")
            {
                dgvBanhang.DataSource = busBan.TimLoai(txtLoaitb.Text);
                txtLoaitb.Text = "";

            }
            if (txtTentb.Text != "" && txtLoaitb.Text == "")
            {
                dgvBanhang.DataSource = busBan.TimTen(txtTentb.Text);
                txtTentb.Text = "";
            }
            if (txtLoaitb.Text != "" && txtTentb.Text != "")
            {
                dgvBanhang.DataSource = busBan.TimAll(txtLoaitb.Text, txtTentb.Text);
                  
            }

        }

        private void btnDatmua_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            time = now.ToString();
            int i = dgvBanhang.CurrentRow.Index;
            matb = dgvBanhang[0, i].Value.ToString();
            if (txtSoluong.Text != "")
            {
                MessageBox.Show("Đặt mua thành công","Thông báo");
                dgvBanhang.DataSource= busBan.Datmua((Int32.Parse(dgvBanhang[3, i].Value.ToString()) - Int32.Parse(txtSoluong.Text)), matb);
                dgvBanhang.DataSource = busKho.getKho();
                busBan.Thongke(dgvBanhang[0, i].Value.ToString(),dgvBanhang[1, i].Value.ToString(),dgvBanhang[2, i].Value.ToString(),txtSoluong.Text,dgvBanhang[4, i].Value.ToString(),dgvBanhang[5, i].Value.ToString(),dgvBanhang[6, i].Value.ToString(),time);
                txtSoluong.Text = "";
                time = "";
            }
            else
            {
                MessageBox.Show("Yêu cầu số lượng","Thông báo");
            }
        }
    }
}
