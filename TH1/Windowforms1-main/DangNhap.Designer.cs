namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label_TenDangNhap = new Label();
            Label_NhapMatKhau = new Label();
            textBox_TenDangNhap = new TextBox();
            textBox_MatKhau = new TextBox();
            checkBox_GhiNho = new CheckBox();
            button_DangNhap = new Button();
            button_Xoa = new Button();
            button_Dung = new Button();
            SuspendLayout();
            // 
            // Label_TenDangNhap
            // 
            Label_TenDangNhap.AllowDrop = true;
            Label_TenDangNhap.AutoSize = true;
            Label_TenDangNhap.Location = new Point(100, 120);
            Label_TenDangNhap.Name = "Label_TenDangNhap";
            Label_TenDangNhap.Size = new Size(129, 25);
            Label_TenDangNhap.TabIndex = 0;
            Label_TenDangNhap.Text = "Ten dang nhap";
            Label_TenDangNhap.Click += label1_Click;
            // 
            // Label_NhapMatKhau
            // 
            Label_NhapMatKhau.AutoSize = true;
            Label_NhapMatKhau.Location = new Point(100, 174);
            Label_NhapMatKhau.Name = "Label_NhapMatKhau";
            Label_NhapMatKhau.Size = new Size(86, 25);
            Label_NhapMatKhau.TabIndex = 1;
            Label_NhapMatKhau.Text = "Mat khau";
            Label_NhapMatKhau.Click += label1_Click_1;
            // 
            // textBox_TenDangNhap
            // 
            textBox_TenDangNhap.Location = new Point(263, 117);
            textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            textBox_TenDangNhap.Size = new Size(355, 31);
            textBox_TenDangNhap.TabIndex = 2;
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Location = new Point(263, 168);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.Size = new Size(355, 31);
            textBox_MatKhau.TabIndex = 3;
            // 
            // checkBox_GhiNho
            // 
            checkBox_GhiNho.AutoSize = true;
            checkBox_GhiNho.Location = new Point(100, 234);
            checkBox_GhiNho.Name = "checkBox_GhiNho";
            checkBox_GhiNho.Size = new Size(100, 29);
            checkBox_GhiNho.TabIndex = 4;
            checkBox_GhiNho.Text = "Ghi nho";
            checkBox_GhiNho.UseVisualStyleBackColor = true;
            // 
            // button_DangNhap
            // 
            button_DangNhap.Location = new Point(96, 302);
            button_DangNhap.Name = "button_DangNhap";
            button_DangNhap.Size = new Size(112, 34);
            button_DangNhap.TabIndex = 5;
            button_DangNhap.Text = "DangNhap";
            button_DangNhap.UseVisualStyleBackColor = true;
            button_DangNhap.Click += button_DangNhap_Click;
            // 
            // button_Xoa
            // 
            button_Xoa.Location = new Point(341, 302);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(112, 34);
            button_Xoa.TabIndex = 6;
            button_Xoa.Text = "Xoa";
            button_Xoa.UseVisualStyleBackColor = true;
            button_Xoa.Click += button_Xoa_Click;
            // 
            // button_Dung
            // 
            button_Dung.Location = new Point(597, 302);
            button_Dung.Name = "button_Dung";
            button_Dung.Size = new Size(112, 34);
            button_Dung.TabIndex = 7;
            button_Dung.Text = "Dung";
            button_Dung.UseVisualStyleBackColor = true;
            button_Dung.Click += button_Dung_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Dung);
            Controls.Add(button_Xoa);
            Controls.Add(button_DangNhap);
            Controls.Add(checkBox_GhiNho);
            Controls.Add(textBox_MatKhau);
            Controls.Add(textBox_TenDangNhap);
            Controls.Add(Label_NhapMatKhau);
            Controls.Add(Label_TenDangNhap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_TenDangNhap;
        private Label Label_NhapMatKhau;
        private TextBox textBox_TenDangNhap;
        private TextBox textBox_MatKhau;
        private CheckBox checkBox_GhiNho;
        private Button button_DangNhap;
        private Button button_Xoa;
        private Button button_Dung;
    }
}
