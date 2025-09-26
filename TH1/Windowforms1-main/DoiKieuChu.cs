using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DoiKieuChu : Form
    {
        public DoiKieuChu()
        {
            InitializeComponent();
        }

        private void button_KetQua_Click(object sender, EventArgs e)
        {
            string hoten = this.textBox_NhapTen.Text.Trim();
            if (this.radioButton_ChuThuong.Checked == true)
                this.textBox_Ketqua.Text = hoten.ToLower();
            if (this.radioButton_ChuInHoa.Checked == true)
                this.textBox_Ketqua.Text = hoten.ToUpper();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            this.textBox_NhapTen.Clear();
            this.textBox_Ketqua.Clear();
            this.radioButton_ChuInHoa.Checked = false;
            this.radioButton_ChuThuong.Checked = false;
            this.textBox_NhapTen.Focus();
        }
    }
}
