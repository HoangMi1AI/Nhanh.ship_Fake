namespace QuanlyGiaoVan
{
    partial class FormTaoDonHang
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
            groupBox1 = new GroupBox();
            LBthoigianhenlay = new ListBox();
            label5 = new Label();
            label4 = new Label();
            cbThoigianhenlay = new ComboBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbTgHenGiao = new ComboBox();
            cboXa = new ComboBox();
            cboDistricts = new ComboBox();
            txtHoTenNguoiNhan = new TextBox();
            txtDiaChiNguoiNhan = new TextBox();
            cboProvinces = new ComboBox();
            txtSDTnguoiNhan = new TextBox();
            gbTThangHoa = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label15 = new Label();
            label14 = new Label();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            label13 = new Label();
            label11 = new Label();
            btnThemHangHoa = new Button();
            txtTrongLuong1 = new TextBox();
            txtGiaTri = new TextBox();
            label10 = new Label();
            txtTenHang1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            btnNextpageTaoDon = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            gbTThangHoa.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LBthoigianhenlay);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbThoigianhenlay);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(535, 239);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Người gửi";
            // 
            // LBthoigianhenlay
            // 
            LBthoigianhenlay.Font = new Font("Segoe UI", 9F);
            LBthoigianhenlay.FormattingEnabled = true;
            LBthoigianhenlay.ItemHeight = 25;
            LBthoigianhenlay.Items.AddRange(new object[] { "Cả ngày", "Sáng (7h30 - 12h00)", "Chiều (13h30 - 18h00)", "Tối (18h30 - 21h00)" });
            LBthoigianhenlay.Location = new Point(339, 122);
            LBthoigianhenlay.Name = "LBthoigianhenlay";
            LBthoigianhenlay.Size = new Size(182, 104);
            LBthoigianhenlay.TabIndex = 0;
            LBthoigianhenlay.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 119);
            label5.Name = "label5";
            label5.Size = new Size(98, 56);
            label5.TabIndex = 20;
            label5.Text = "Thời gian\r\nhẹn lấy\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 40);
            label4.Name = "label4";
            label4.Size = new Size(106, 56);
            label4.TabIndex = 19;
            label4.Text = "Thông tin \r\nngười gửi";
            // 
            // cbThoigianhenlay
            // 
            cbThoigianhenlay.FormattingEnabled = true;
            cbThoigianhenlay.Items.AddRange(new object[] { "Hôm nay", "Ngày mai" });
            cbThoigianhenlay.Location = new Point(159, 142);
            cbThoigianhenlay.Name = "cbThoigianhenlay";
            cbThoigianhenlay.Size = new Size(174, 38);
            cbThoigianhenlay.TabIndex = 3;
            cbThoigianhenlay.SelectedIndexChanged += thoigian_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(159, 40);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Thông tin người gửi";
            textBox2.Size = new Size(258, 59);
            textBox2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbTgHenGiao);
            groupBox2.Controls.Add(cboXa);
            groupBox2.Controls.Add(cboDistricts);
            groupBox2.Controls.Add(txtHoTenNguoiNhan);
            groupBox2.Controls.Add(txtDiaChiNguoiNhan);
            groupBox2.Controls.Add(cboProvinces);
            groupBox2.Controls.Add(txtSDTnguoiNhan);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.Location = new Point(12, 269);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(535, 426);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Người nhận";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 341);
            label9.Name = "label9";
            label9.Size = new Size(98, 56);
            label9.TabIndex = 21;
            label9.Text = "Thời gian\r\nhẹn giao";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(31, 181);
            label8.Name = "label8";
            label8.Size = new Size(72, 28);
            label8.TabIndex = 23;
            label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 108);
            label7.Name = "label7";
            label7.Size = new Size(73, 28);
            label7.TabIndex = 22;
            label7.Text = "Họ tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 54);
            label6.Name = "label6";
            label6.Size = new Size(107, 28);
            label6.TabIndex = 21;
            label6.Text = "Điện thoại";
            // 
            // cbTgHenGiao
            // 
            cbTgHenGiao.FormattingEnabled = true;
            cbTgHenGiao.Items.AddRange(new object[] { "Cả ngày", "Sáng (7h30 - 12h00)", "Chiều (13h30 - 18h00)", "Tối (18h30 - 21h00)", "Giờ hành chính", "Chủ nhật", "Ngày nghỉ lễ" });
            cbTgHenGiao.Location = new Point(159, 357);
            cbTgHenGiao.Name = "cbTgHenGiao";
            cbTgHenGiao.Size = new Size(312, 36);
            cbTgHenGiao.TabIndex = 11;
            cbTgHenGiao.Text = "Cả ngày";
            // 
            // cboXa
            // 
            cboXa.Font = new Font("Segoe UI", 9F);
            cboXa.FormattingEnabled = true;
            cboXa.Location = new Point(159, 297);
            cboXa.Name = "cboXa";
            cboXa.Size = new Size(136, 33);
            cboXa.TabIndex = 9;
            cboXa.Text = "Xã / Phường";
            // 
            // cboDistricts
            // 
            cboDistricts.Font = new Font("Segoe UI", 9F);
            cboDistricts.FormattingEnabled = true;
            cboDistricts.Location = new Point(325, 241);
            cboDistricts.Name = "cboDistricts";
            cboDistricts.Size = new Size(146, 33);
            cboDistricts.TabIndex = 8;
            cboDistricts.Text = "Quận/ Huyện";
            cboDistricts.SelectedIndexChanged += cboDistricts_SelectedIndexChanged;
            // 
            // txtHoTenNguoiNhan
            // 
            txtHoTenNguoiNhan.Location = new Point(159, 104);
            txtHoTenNguoiNhan.Multiline = true;
            txtHoTenNguoiNhan.Name = "txtHoTenNguoiNhan";
            txtHoTenNguoiNhan.PlaceholderText = "Họ tên người nhận";
            txtHoTenNguoiNhan.Size = new Size(312, 33);
            txtHoTenNguoiNhan.TabIndex = 7;
            // 
            // txtDiaChiNguoiNhan
            // 
            txtDiaChiNguoiNhan.Location = new Point(159, 175);
            txtDiaChiNguoiNhan.Multiline = true;
            txtDiaChiNguoiNhan.Name = "txtDiaChiNguoiNhan";
            txtDiaChiNguoiNhan.PlaceholderText = "Nhập địa chỉ";
            txtDiaChiNguoiNhan.Size = new Size(312, 34);
            txtDiaChiNguoiNhan.TabIndex = 6;
            // 
            // cboProvinces
            // 
            cboProvinces.Font = new Font("Segoe UI", 9F);
            cboProvinces.FormattingEnabled = true;
            cboProvinces.Location = new Point(159, 241);
            cboProvinces.Name = "cboProvinces";
            cboProvinces.Size = new Size(136, 33);
            cboProvinces.TabIndex = 5;
            cboProvinces.Text = "Tỉnh / Thành phố";
            cboProvinces.SelectedIndexChanged += cboProvinces_SelectedIndexChanged;
            // 
            // txtSDTnguoiNhan
            // 
            txtSDTnguoiNhan.Location = new Point(159, 40);
            txtSDTnguoiNhan.Multiline = true;
            txtSDTnguoiNhan.Name = "txtSDTnguoiNhan";
            txtSDTnguoiNhan.PlaceholderText = "Số điện thoại";
            txtSDTnguoiNhan.Size = new Size(312, 38);
            txtSDTnguoiNhan.TabIndex = 1;
            // 
            // gbTThangHoa
            // 
            gbTThangHoa.Controls.Add(checkBox6);
            gbTThangHoa.Controls.Add(checkBox5);
            gbTThangHoa.Controls.Add(checkBox4);
            gbTThangHoa.Controls.Add(checkBox3);
            gbTThangHoa.Controls.Add(checkBox2);
            gbTThangHoa.Controls.Add(checkBox1);
            gbTThangHoa.Controls.Add(label15);
            gbTThangHoa.Controls.Add(label14);
            gbTThangHoa.Controls.Add(textBox6);
            gbTThangHoa.Controls.Add(textBox4);
            gbTThangHoa.Controls.Add(label13);
            gbTThangHoa.Controls.Add(label11);
            gbTThangHoa.Controls.Add(btnThemHangHoa);
            gbTThangHoa.Controls.Add(txtTrongLuong1);
            gbTThangHoa.Controls.Add(txtGiaTri);
            gbTThangHoa.Controls.Add(label10);
            gbTThangHoa.Controls.Add(txtTenHang1);
            gbTThangHoa.Controls.Add(label3);
            gbTThangHoa.Controls.Add(label2);
            gbTThangHoa.Controls.Add(radioButton2);
            gbTThangHoa.Controls.Add(radioButton1);
            gbTThangHoa.Controls.Add(label1);
            gbTThangHoa.Font = new Font("Sitka Subheading", 10F);
            gbTThangHoa.Location = new Point(564, 24);
            gbTThangHoa.Name = "gbTThangHoa";
            gbTThangHoa.Size = new Size(521, 671);
            gbTThangHoa.TabIndex = 14;
            gbTThangHoa.TabStop = false;
            gbTThangHoa.Text = "Thông tin hàng hóa";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(366, 573);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(113, 62);
            checkBox6.TabIndex = 36;
            checkBox6.Text = "Giấy tờ/\r\nHóa đơn\r\n";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(209, 586);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(148, 33);
            checkBox5.TabIndex = 35;
            checkBox5.Text = "Nguyên khối";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(43, 586);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(129, 33);
            checkBox4.TabIndex = 34;
            checkBox4.Text = "Giá trị cao";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(366, 527);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(141, 33);
            checkBox3.TabIndex = 33;
            checkBox3.Text = "Từ kính,pin";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(209, 527);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 33);
            checkBox2.TabIndex = 31;
            checkBox2.Text = "dễ vỡ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(43, 527);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 33);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "chất lỏng";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(29, 488);
            label15.Name = "label15";
            label15.Size = new Size(296, 26);
            label15.TabIndex = 29;
            label15.Text = "Tính chất hàng hóa đặc biệt";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(29, 446);
            label14.Name = "label14";
            label14.Size = new Size(481, 25);
            label14.TabIndex = 28;
            label14.Text = "___________________________________________________________________";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Yu Gothic UI", 10F);
            textBox6.Location = new Point(275, 409);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "0 vnd";
            textBox6.Size = new Size(235, 34);
            textBox6.TabIndex = 27;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(275, 362);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "0 kg";
            textBox4.Size = new Size(235, 34);
            textBox4.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(29, 408);
            label13.Name = "label13";
            label13.Size = new Size(135, 30);
            label13.TabIndex = 25;
            label13.Text = "Tổng Giá trị";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(29, 362);
            label11.Name = "label11";
            label11.Size = new Size(175, 30);
            label11.TabIndex = 23;
            label11.Text = "Tổng khối lượng";
            // 
            // btnThemHangHoa
            // 
            btnThemHangHoa.Font = new Font("Segoe UI", 10F);
            btnThemHangHoa.ForeColor = Color.Red;
            btnThemHangHoa.Location = new Point(209, 282);
            btnThemHangHoa.Name = "btnThemHangHoa";
            btnThemHangHoa.Size = new Size(160, 39);
            btnThemHangHoa.TabIndex = 22;
            btnThemHangHoa.Text = "Thêm hàng hóa";
            btnThemHangHoa.UseVisualStyleBackColor = true;
            // 
            // txtTrongLuong1
            // 
            txtTrongLuong1.Location = new Point(209, 217);
            txtTrongLuong1.Multiline = true;
            txtTrongLuong1.Name = "txtTrongLuong1";
            txtTrongLuong1.PlaceholderText = "Trọng lượng";
            txtTrongLuong1.Size = new Size(120, 34);
            txtTrongLuong1.TabIndex = 21;
            // 
            // txtGiaTri
            // 
            txtGiaTri.Location = new Point(376, 217);
            txtGiaTri.Multiline = true;
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.PlaceholderText = "Giá trị";
            txtGiaTri.Size = new Size(115, 34);
            txtGiaTri.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(29, 320);
            label10.Name = "label10";
            label10.Size = new Size(481, 25);
            label10.TabIndex = 19;
            label10.Text = "___________________________________________________________________";
            // 
            // txtTenHang1
            // 
            txtTenHang1.Location = new Point(209, 159);
            txtTenHang1.Multiline = true;
            txtTenHang1.Name = "txtTenHang1";
            txtTenHang1.PlaceholderText = "Nhập tên hàng hóa";
            txtTenHang1.Size = new Size(282, 34);
            txtTenHang1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 159);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 18;
            label3.Text = "Tên hàng 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 116);
            label2.Name = "label2";
            label2.Size = new Size(481, 25);
            label2.TabIndex = 17;
            label2.Text = "___________________________________________________________________";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(319, 87);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 33);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tài liệu";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(136, 87);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 33);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Bưu kiện";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 42);
            label1.Name = "label1";
            label1.Size = new Size(158, 26);
            label1.TabIndex = 14;
            label1.Text = "Loại hàng hóa";
            // 
            // btnNextpageTaoDon
            // 
            btnNextpageTaoDon.Location = new Point(499, 712);
            btnNextpageTaoDon.Name = "btnNextpageTaoDon";
            btnNextpageTaoDon.Size = new Size(112, 34);
            btnNextpageTaoDon.TabIndex = 15;
            btnNextpageTaoDon.Text = "Tiếp tục";
            btnNextpageTaoDon.UseVisualStyleBackColor = true;
            btnNextpageTaoDon.Click += btnNextpageTaoDon_Click;
            // 
            // FormTaoDonHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1125, 768);
            Controls.Add(btnNextpageTaoDon);
            Controls.Add(gbTThangHoa);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormTaoDonHang";
            Text = "FormTaoDonHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbTThangHoa.ResumeLayout(false);
            gbTThangHoa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private ComboBox cbThoigianhenlay;
        private ListBox LBthoigianhenlay;
        private GroupBox groupBox2;
        private ComboBox cboProvinces;
        private TextBox txtSDTnguoiNhan;
        private TextBox txtDiaChiNguoiNhan;
        private TextBox txtHoTenNguoiNhan;
        private ComboBox cboXa;
        private ComboBox cboDistricts;
        private ComboBox cbTgHenGiao;
        private GroupBox gbTThangHoa;
        private RadioButton radioButton1;
        private Label label1;
        private RadioButton radioButton2;
        private TextBox txtTenHang1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label11;
        private Button btnThemHangHoa;
        private TextBox txtTrongLuong1;
        private TextBox txtGiaTri;
        private Label label10;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label15;
        private Label label14;
        private TextBox textBox6;
        private TextBox textBox4;
        private Label label13;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox6;
        private Button btnNextpageTaoDon;
    }
}