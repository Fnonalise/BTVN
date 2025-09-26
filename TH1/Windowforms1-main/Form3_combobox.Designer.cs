namespace WinFormsApp1
{
    partial class Form3_combobox
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
            label_NhapSo = new Label();
            comboBox_NhapSo = new ComboBox();
            DSUocSo = new ListBox();
            text_NhapSo = new TextBox();
            button_CapNhat = new Button();
            button_TongUoc = new Button();
            button_UocChan = new Button();
            button_UocNguyenTo = new Button();
            button_Thoat = new Button();
            SuspendLayout();
            // 
            // label_NhapSo
            // 
            label_NhapSo.AutoSize = true;
            label_NhapSo.Location = new Point(71, 47);
            label_NhapSo.Name = "label_NhapSo";
            label_NhapSo.Size = new Size(79, 25);
            label_NhapSo.TabIndex = 0;
            label_NhapSo.Text = "Nhap so";
            // 
            // comboBox_NhapSo
            // 
            comboBox_NhapSo.FormattingEnabled = true;
            comboBox_NhapSo.Location = new Point(73, 210);
            comboBox_NhapSo.Name = "comboBox_NhapSo";
            comboBox_NhapSo.Size = new Size(346, 33);
            comboBox_NhapSo.TabIndex = 2;
            comboBox_NhapSo.SelectedIndexChanged += comboBox_NhapSo_SelectedIndexChanged;
            // 
            // DSUocSo
            // 
            DSUocSo.FormattingEnabled = true;
            DSUocSo.ItemHeight = 25;
            DSUocSo.Location = new Point(557, 39);
            DSUocSo.Name = "DSUocSo";
            DSUocSo.Size = new Size(180, 129);
            DSUocSo.TabIndex = 3;
            // 
            // text_NhapSo
            // 
            text_NhapSo.Location = new Point(71, 86);
            text_NhapSo.Name = "text_NhapSo";
            text_NhapSo.Size = new Size(160, 31);
            text_NhapSo.TabIndex = 0;
            // 
            // button_CapNhat
            // 
            button_CapNhat.Location = new Point(275, 83);
            button_CapNhat.Name = "button_CapNhat";
            button_CapNhat.Size = new Size(144, 34);
            button_CapNhat.TabIndex = 1;
            button_CapNhat.Text = "Cap nhat";
            button_CapNhat.TextAlign = ContentAlignment.TopCenter;
            button_CapNhat.UseVisualStyleBackColor = true;
            button_CapNhat.Click += button_CapNhat_Click;
            // 
            // button_TongUoc
            // 
            button_TongUoc.Location = new Point(500, 210);
            button_TongUoc.Name = "button_TongUoc";
            button_TongUoc.Size = new Size(266, 34);
            button_TongUoc.TabIndex = 4;
            button_TongUoc.Text = "Tong uoc";
            button_TongUoc.UseVisualStyleBackColor = true;
            button_TongUoc.Click += button_TongUoc_Click;
            // 
            // button_UocChan
            // 
            button_UocChan.Location = new Point(501, 270);
            button_UocChan.Name = "button_UocChan";
            button_UocChan.Size = new Size(265, 34);
            button_UocChan.TabIndex = 5;
            button_UocChan.Text = "So luong uoc so chan";
            button_UocChan.UseVisualStyleBackColor = true;
            button_UocChan.Click += button_UocChan_Click;
            // 
            // button_UocNguyenTo
            // 
            button_UocNguyenTo.Location = new Point(503, 331);
            button_UocNguyenTo.Name = "button_UocNguyenTo";
            button_UocNguyenTo.Size = new Size(263, 34);
            button_UocNguyenTo.TabIndex = 6;
            button_UocNguyenTo.Text = "So luong cac uoc nguyen to";
            button_UocNguyenTo.UseVisualStyleBackColor = true;
            button_UocNguyenTo.Click += button_UocNguyenTo_Click;
            // 
            // button_Thoat
            // 
            button_Thoat.Location = new Point(71, 331);
            button_Thoat.Name = "button_Thoat";
            button_Thoat.Size = new Size(112, 34);
            button_Thoat.TabIndex = 7;
            button_Thoat.Text = "Thoat";
            button_Thoat.UseVisualStyleBackColor = true;
            // 
            // Form3_combobox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Thoat);
            Controls.Add(button_UocNguyenTo);
            Controls.Add(button_UocChan);
            Controls.Add(button_TongUoc);
            Controls.Add(button_CapNhat);
            Controls.Add(text_NhapSo);
            Controls.Add(DSUocSo);
            Controls.Add(comboBox_NhapSo);
            Controls.Add(label_NhapSo);
            Name = "Form3_combobox";
            Text = "Form3_combobox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_NhapSo;
        private ComboBox comboBox_NhapSo;
        private ListBox DSUocSo;
        private TextBox text_NhapSo;
        private Button button_CapNhat;
        private Button button_TongUoc;
        private Button button_UocChan;
        private Button button_UocNguyenTo;
        private Button button_Thoat;
    }
}