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
    public partial class Form3_combobox : Form
    {
        public Form3_combobox()
        {
            InitializeComponent();
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            comboBox_NhapSo.Items.Add(text_NhapSo.Text);
            text_NhapSo.Clear();
            DSUocSo.Items.Clear();
        }

        private void comboBox_NhapSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int so = int.Parse(comboBox_NhapSo.SelectedItem.ToString());
            for (int i = 1; i <=so; i++)
            {
                if ((so % i) == 0)
                {
                    DSUocSo.Items.Add(i);
                }
            }
        }

        private void button_TongUoc_Click(object sender, EventArgs e)
        {
            int sum = 0;

            // Loop through each item in the ListBox
            foreach (var item in DSUocSo.Items)
            {
                // Convert item (object) to integer and add to sum
                sum += int.Parse(item.ToString());
            }

            // Show result in a MessageBox
            MessageBox.Show("Tong cac uoc bang = " + sum.ToString());
        }

        private void button_UocChan_Click(object sender, EventArgs e)
        {
            int countEven = 0;

            foreach (var item in DSUocSo.Items)
            {
                // Convert each item to integer
                int number = int.Parse(item.ToString());

                // Check if even
                if (number % 2 == 0)
                {
                    countEven++;
                }
            }

            MessageBox.Show("So luong cac uoc chan = " + countEven.ToString(), "Ket qua");

        }

        private bool IsPrime(int n)
        {
            if (n < 2) return false; // 0 and 1 are not prime
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        private void button_UocNguyenTo_Click(object sender, EventArgs e)
        {
            int countPrime = 0;

            foreach (var item in DSUocSo.Items)
            {
                if (int.TryParse(item.ToString(), out int number))
                {
                    if (IsPrime(number))
                    {
                        countPrime++;
                    }
                }
            }

            MessageBox.Show("So luong cac uoc nguyen to la = " + countPrime, "Ket qua");
        }
    }
}
