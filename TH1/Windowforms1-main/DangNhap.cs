namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Ten dang nhap la: ";
            thongbao += this.textBox_TenDangNhap.Text;
            thongbao += "\n\rMat khau la: ";
            thongbao += this.textBox_MatKhau.Text;
            if (this.checkBox_GhiNho.Checked == true)
            { thongbao += "\n\rBan co ghi nho?"; }
            MessageBox.Show(thongbao, "Thong bao");
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            this.textBox_TenDangNhap.Clear();
            this.textBox_MatKhau.Clear();
            this.textBox_TenDangNhap.Focus();
        }

        private void button_Dung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
