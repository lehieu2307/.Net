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
    public partial class GUI_Khohang : Form
    {
        BUS_Khohang busKhohang = new BUS_Khohang();
        bool tf, tf1;
        string matb;
        
        public GUI_Khohang()
        {
            InitializeComponent();
            tf = tf1 = true;
            lock_unlock(tf);
            lock_unlock1(tf1);
        }

        private void GUI_dsnha_Load(object sender, EventArgs e)
        {
            dgvKhohang.DataSource = busKhohang.getKho();
        }
        void lock_unlock(bool tf)
        {
           
            btnThem.Enabled = txtMaTB.Enabled = txtTenTB.Enabled = txtLoaiTB.Enabled = txtSl.Enabled = txtGiatien.Enabled =txtDVT.Enabled= txtNgaynhap.Enabled = !tf;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhohang_Click(object sender, EventArgs e)
        {
            if (tf)
            {
                int i = dgvKhohang.CurrentRow.Index;

                matb=txtMaTB.Text = dgvKhohang[0, i].Value.ToString();
                txtLoaiTB.Text= dgvKhohang[1, i].Value.ToString();
                txtTenTB.Text= dgvKhohang[2, i].Value.ToString();
                txtSl.Text = dgvKhohang[3, i].Value.ToString();
                txtDVT.Text = dgvKhohang[4, i].Value.ToString();
                txtGiatien.Text = dgvKhohang[5, i].Value.ToString();            
                txtNgaynhap.Text = dgvKhohang[6, i].Value.ToString();
                tf1 = !tf1;
                lock_unlock1(tf1);
            }
            else MessageBox.Show("Lỗi", "Thông báo");
        }

        private void btmLammoi_Click(object sender, EventArgs e)
        {
            tf = tf1 = true;
            lock_unlock(tf);
            lock_unlock1(tf1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (busKhohang.Xoa(matb))
            {
                MessageBox.Show("Đã xóa", "Thông báo");
                tf1 = !tf1;
                lock_unlock1(tf1);
                dgvKhohang.DataSource = busKhohang.getKho();
            }
            else
            {
                MessageBox.Show("Xóa lỗi!", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDVT.Text != "" && txtGiatien.Text != "" && txtLoaiTB.Text != "" && txtMaTB.Text != "" && txtNgaynhap.Text != "" && txtSl.Text != "" && txtTenTB.Text !="")
            {
                if (busKhohang.Them(txtMaTB.Text, txtLoaiTB.Text, txtTenTB.Text, txtSl.Text, txtDVT.Text, txtGiatien.Text,txtNgaynhap.Text))
                {
                    MessageBox.Show("Đã thêm", "Thông báo");
                    tf = !tf;
                    lock_unlock(tf);
                    dgvKhohang.DataSource = busKhohang.getKho();
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Thông tin thiếu!\nYêu cầu nhập lại.", "Thông báo");          
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtDVT.Text != "" && txtGiatien.Text != "" && txtLoaiTB.Text != "" && txtMaTB.Text != "" && txtNgaynhap.Text != "" && txtSl.Text != "" && txtTenTB.Text != "")
            {
                if (busKhohang.capnhat(matb, txtMaTB.Text, txtLoaiTB.Text, txtTenTB.Text, txtSl.Text, txtDVT.Text, txtGiatien.Text, txtNgaynhap.Text))
                {
                    MessageBox.Show("Đã cập nhật!", "Thông báo");
                    tf1 = !tf1;
                    lock_unlock1(tf1);
                    dgvKhohang.DataSource = busKhohang.getKho();
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Lỗi!!!", "Thông báo");
            }
            tf1 = !tf1;
            lock_unlock1(tf1);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (tf1)
            {
                tf = !tf;
                lock_unlock(tf);
                txtMaTB.Text = txtLoaiTB.Text = txtTenTB.Text = txtSl.Text = txtDVT.Text = txtGiatien.Text = txtNgaynhap.Text = "";
                txtMaTB.Focus();
            }
            else MessageBox.Show("Đang thực hiện chức năng khác, yêu cầu làm mới", "Thông báo");
        }

        void lock_unlock1(bool tf1)
        {
            dgvKhohang.Enabled = tf1;
            btnCapnhat.Enabled = btnXoa.Enabled = txtDVT.Enabled = txtGiatien.Enabled=txtLoaiTB.Enabled=txtMaTB.Enabled=txtNgaynhap.Enabled = txtSl.Enabled=txtTenTB.Enabled = !tf1;
        }
    }
}
