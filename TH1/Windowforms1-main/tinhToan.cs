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
    public partial class tinhToan : Form
    {
        public tinhToan()
        {
            InitializeComponent();
        }

        private bool TryGetInputs(out double a, out double b)
        {
            // Số 1
            if (!double.TryParse(textBox_soMot.Text, out a))
            {
                MessageBox.Show("Số 1 không hợp lệ. Vui lòng nhập số.", "Lỗi nhập liệu");
                textBox_soMot.Focus();
                textBox_soMot.SelectAll();
                b = 0;
                return false;
            }

            // Số 2
            if (!double.TryParse(textBox_soHai.Text, out b))
            {
                MessageBox.Show("Số 2 không hợp lệ. Vui lòng nhập số.", "Lỗi nhập liệu");
                textBox_soHai.Focus();
                textBox_soHai.SelectAll();
                return false;
            }
            return true;
        }

        private void radio_cong_CheckedChanged(object sender, EventArgs e)
        {
            if (!radio_cong.Checked) return;          // only run when it’s selected

            if (TryGetInputs(out double x, out double y))
            {
                textBox_ketQua.Text = (x + y).ToString();
            }

        }

        private void radio_tru_CheckedChanged(object sender, EventArgs e)
        {
            if (!radio_tru.Checked) return;          // only run when it’s selected

            if (TryGetInputs(out double x, out double y))
            {
                textBox_ketQua.Text = (x - y).ToString();
            }
        }

        private void radio_nhan_CheckedChanged(object sender, EventArgs e)
        {
            if (!radio_nhan.Checked) return;          // only run when it’s selected

            if (TryGetInputs(out double x, out double y))
            {
                textBox_ketQua.Text = (x * y).ToString();
            }
        }

        private void radio_chia_CheckedChanged(object sender, EventArgs e)
        {
            if (!radio_chia.Checked) return;          // only run when it’s selected

            if (TryGetInputs(out double x, out double y))
            {
                textBox_ketQua.Text = (x / y).ToString();
            }
        }
    }
}
