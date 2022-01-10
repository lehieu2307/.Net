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
    public partial class GUI_Thongke : Form
    {
        BUS_ThongKe busThongKe = new BUS_ThongKe();
        public GUI_Thongke()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radNgaymua.Checked || radLoaitb.Checked && txtTimkiem.Text == "")
            {
                dgvThongke.DataSource = busThongKe.getThongke();
            }
            if (radLoaitb.Checked)
            {
                dgvThongke.DataSource = busThongKe.Timloai(txtTimkiem.Text);
            }
            if (radNgaymua.Checked)
            {
                dgvThongke.DataSource = busThongKe.Timngaymua(txtTimkiem.Text);
            }
        }
    }
}
