namespace WinFormsApp1
{
    partial class DoiKieuChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_NhapHoVaTen = new Label();
            textBox_NhapTen = new TextBox();
            label_ChonKieuChu = new Label();
            radioButton_ChuThuong = new RadioButton();
            radioButton_ChuInHoa = new RadioButton();
            button_KetQua = new Button();
            textBox_Ketqua = new TextBox();
            button_Xoa = new Button();
            SuspendLayout();
            // 
            // label_NhapHoVaTen
            // 
            label_NhapHoVaTen.AutoSize = true;
            label_NhapHoVaTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label_NhapHoVaTen.Location = new Point(74, 64);
            label_NhapHoVaTen.Name = "label_NhapHoVaTen";
            label_NhapHoVaTen.Size = new Size(143, 25);
            label_NhapHoVaTen.TabIndex = 0;
            label_NhapHoVaTen.Text = "Nhap ho va ten";
            // 
            // textBox_NhapTen
            // 
            textBox_NhapTen.Location = new Point(279, 58);
            textBox_NhapTen.Name = "textBox_NhapTen";
            textBox_NhapTen.Size = new Size(410, 31);
            textBox_NhapTen.TabIndex = 1;
            // 
            // label_ChonKieuChu
            // 
            label_ChonKieuChu.AutoSize = true;
            label_ChonKieuChu.Location = new Point(77, 143);
            label_ChonKieuChu.Name = "label_ChonKieuChu";
            label_ChonKieuChu.Size = new Size(124, 25);
            label_ChonKieuChu.TabIndex = 2;
            label_ChonKieuChu.Text = "Chon kieu chu";
            // 
            // radioButton_ChuThuong
            // 
            radioButton_ChuThuong.AutoSize = true;
            radioButton_ChuThuong.Location = new Point(130, 189);
            radioButton_ChuThuong.Name = "radioButton_ChuThuong";
            radioButton_ChuThuong.Size = new Size(131, 29);
            radioButton_ChuThuong.TabIndex = 3;
            radioButton_ChuThuong.TabStop = true;
            radioButton_ChuThuong.Text = "Chu thuong";
            radioButton_ChuThuong.UseVisualStyleBackColor = true;
            // 
            // radioButton_ChuInHoa
            // 
            radioButton_ChuInHoa.AutoSize = true;
            radioButton_ChuInHoa.Location = new Point(128, 241);
            radioButton_ChuInHoa.Name = "radioButton_ChuInHoa";
            radioButton_ChuInHoa.Size = new Size(140, 29);
            radioButton_ChuInHoa.TabIndex = 4;
            radioButton_ChuInHoa.TabStop = true;
            radioButton_ChuInHoa.Text = "CHU IN HOA";
            radioButton_ChuInHoa.UseVisualStyleBackColor = true;
            // 
            // button_KetQua
            // 
            button_KetQua.Location = new Point(125, 320);
            button_KetQua.Name = "button_KetQua";
            button_KetQua.Size = new Size(112, 34);
            button_KetQua.TabIndex = 5;
            button_KetQua.Text = "Ket qua";
            button_KetQua.UseVisualStyleBackColor = true;
            button_KetQua.Click += button_KetQua_Click;
            // 
            // textBox_Ketqua
            // 
            textBox_Ketqua.Location = new Point(289, 326);
            textBox_Ketqua.Name = "textBox_Ketqua";
            textBox_Ketqua.Size = new Size(400, 31);
            textBox_Ketqua.TabIndex = 6;
            // 
            // button_Xoa
            // 
            button_Xoa.Location = new Point(591, 150);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(98, 120);
            button_Xoa.TabIndex = 7;
            button_Xoa.Text = "Xoa";
            button_Xoa.UseVisualStyleBackColor = true;
            button_Xoa.Click += button_Xoa_Click;
            // 
            // DoiKieuChu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Xoa);
            Controls.Add(textBox_Ketqua);
            Controls.Add(button_KetQua);
            Controls.Add(radioButton_ChuInHoa);
            Controls.Add(radioButton_ChuThuong);
            Controls.Add(label_ChonKieuChu);
            Controls.Add(textBox_NhapTen);
            Controls.Add(label_NhapHoVaTen);
            Name = "DoiKieuChu";
            Text = "DoiKieuChu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_NhapHoVaTen;
        private TextBox textBox_NhapTen;
        private Label label_ChonKieuChu;
        private RadioButton radioButton_ChuThuong;
        private RadioButton radioButton_ChuInHoa;
        private Button button_KetQua;
        private TextBox textBox_Ketqua;
        private Button button_Xoa;
    }
}