namespace WinFormsApp1
{
    partial class tinhToan
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
            label_soMot = new Label();
            label_soHai = new Label();
            textBox_soMot = new TextBox();
            textBox_soHai = new TextBox();
            label_phepTinh = new Label();
            radio_cong = new RadioButton();
            radio_tru = new RadioButton();
            radio_nhan = new RadioButton();
            radio_chia = new RadioButton();
            label_ketQua = new Label();
            textBox_ketQua = new TextBox();
            SuspendLayout();
            // 
            // label_soMot
            // 
            label_soMot.AutoSize = true;
            label_soMot.Location = new Point(92, 69);
            label_soMot.Name = "label_soMot";
            label_soMot.Size = new Size(57, 25);
            label_soMot.TabIndex = 0;
            label_soMot.Text = "So 1: ";
            // 
            // label_soHai
            // 
            label_soHai.AutoSize = true;
            label_soHai.Location = new Point(92, 119);
            label_soHai.Name = "label_soHai";
            label_soHai.Size = new Size(52, 25);
            label_soHai.TabIndex = 1;
            label_soHai.Text = "So 2:";
            // 
            // textBox_soMot
            // 
            textBox_soMot.Location = new Point(155, 63);
            textBox_soMot.Name = "textBox_soMot";
            textBox_soMot.Size = new Size(501, 31);
            textBox_soMot.TabIndex = 2;
            // 
            // textBox_soHai
            // 
            textBox_soHai.Location = new Point(156, 116);
            textBox_soHai.Name = "textBox_soHai";
            textBox_soHai.Size = new Size(500, 31);
            textBox_soHai.TabIndex = 3;
            // 
            // label_phepTinh
            // 
            label_phepTinh.AutoSize = true;
            label_phepTinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_phepTinh.Location = new Point(93, 202);
            label_phepTinh.Name = "label_phepTinh";
            label_phepTinh.Size = new Size(94, 25);
            label_phepTinh.TabIndex = 4;
            label_phepTinh.Text = "Phep tinh";
            // 
            // radio_cong
            // 
            radio_cong.AutoSize = true;
            radio_cong.Location = new Point(97, 255);
            radio_cong.Name = "radio_cong";
            radio_cong.Size = new Size(80, 29);
            radio_cong.TabIndex = 5;
            radio_cong.TabStop = true;
            radio_cong.Text = "Cong";
            radio_cong.UseVisualStyleBackColor = true;
            radio_cong.CheckedChanged += radio_cong_CheckedChanged;
            // 
            // radio_tru
            // 
            radio_tru.AutoSize = true;
            radio_tru.Location = new Point(267, 255);
            radio_tru.Name = "radio_tru";
            radio_tru.Size = new Size(60, 29);
            radio_tru.TabIndex = 6;
            radio_tru.TabStop = true;
            radio_tru.Text = "Tru";
            radio_tru.UseVisualStyleBackColor = true;
            radio_tru.CheckedChanged += radio_tru_CheckedChanged;
            // 
            // radio_nhan
            // 
            radio_nhan.AutoSize = true;
            radio_nhan.Location = new Point(418, 255);
            radio_nhan.Name = "radio_nhan";
            radio_nhan.Size = new Size(79, 29);
            radio_nhan.TabIndex = 7;
            radio_nhan.TabStop = true;
            radio_nhan.Text = "Nhan";
            radio_nhan.UseVisualStyleBackColor = true;
            radio_nhan.CheckedChanged += radio_nhan_CheckedChanged;
            // 
            // radio_chia
            // 
            radio_chia.AutoSize = true;
            radio_chia.Location = new Point(585, 255);
            radio_chia.Name = "radio_chia";
            radio_chia.Size = new Size(71, 29);
            radio_chia.TabIndex = 8;
            radio_chia.TabStop = true;
            radio_chia.Text = "Chia";
            radio_chia.UseVisualStyleBackColor = true;
            radio_chia.CheckedChanged += radio_chia_CheckedChanged;
            // 
            // label_ketQua
            // 
            label_ketQua.AutoSize = true;
            label_ketQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_ketQua.Location = new Point(92, 327);
            label_ketQua.Name = "label_ketQua";
            label_ketQua.Size = new Size(83, 25);
            label_ketQua.TabIndex = 9;
            label_ketQua.Text = "Ket qua:";
            // 
            // textBox_ketQua
            // 
            textBox_ketQua.Location = new Point(198, 324);
            textBox_ketQua.Name = "textBox_ketQua";
            textBox_ketQua.Size = new Size(458, 31);
            textBox_ketQua.TabIndex = 10;
            // 
            // tinhToan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_ketQua);
            Controls.Add(label_ketQua);
            Controls.Add(radio_chia);
            Controls.Add(radio_nhan);
            Controls.Add(radio_tru);
            Controls.Add(radio_cong);
            Controls.Add(label_phepTinh);
            Controls.Add(textBox_soHai);
            Controls.Add(textBox_soMot);
            Controls.Add(label_soHai);
            Controls.Add(label_soMot);
            Name = "tinhToan";
            Text = "tinhToan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_soMot;
        private Label label_soHai;
        private TextBox textBox_soMot;
        private TextBox textBox_soHai;
        private Label label_phepTinh;
        private RadioButton radio_cong;
        private RadioButton radio_tru;
        private RadioButton radio_nhan;
        private RadioButton radio_chia;
        private Label label_ketQua;
        private TextBox textBox_ketQua;
    }
}