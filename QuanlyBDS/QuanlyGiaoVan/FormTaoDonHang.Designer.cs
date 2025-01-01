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
            cbBox_estimate_pickup_time = new ComboBox();
            label3 = new Label();
            datePicker_estimate_pickup_date = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            txtBox_username = new TextBox();
            groupBox2 = new GroupBox();
            datePicker_estimate_delivery_date = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbBox_to_ward = new ComboBox();
            cbBox_to_district = new ComboBox();
            txtBox_to_name = new TextBox();
            txtBox_to_address = new TextBox();
            cbBox_to_province = new ComboBox();
            txtBox_to_number = new TextBox();
            gbTThangHoa = new GroupBox();
            txtBox_length = new TextBox();
            txtBox_width = new TextBox();
            txtBox_height = new TextBox();
            tick_Giayto_Hoadon = new CheckBox();
            tick_Nguyen_khoi = new CheckBox();
            tick_Gia_tri_cao = new CheckBox();
            tick_Tu_kinh_pin = new CheckBox();
            tick_De_vo = new CheckBox();
            tick_chat_long = new CheckBox();
            label15 = new Label();
            label14 = new Label();
            txtBox_weight = new TextBox();
            txtBox_value = new TextBox();
            txtBox_name_order = new TextBox();
            label2 = new Label();
            radioBtn_Tailieu = new RadioButton();
            radioBtn_Buukien = new RadioButton();
            label1 = new Label();
            radioBtn_khong_xem = new RadioButton();
            radioBtn_cho_xem_khong_thu = new RadioButton();
            radioBtn_cho_thu_hang = new RadioButton();
            label11 = new Label();
            btnNextpageTaoDon = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            gbTThangHoa.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbBox_estimate_pickup_time);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(datePicker_estimate_pickup_date);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBox_username);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(10, 19);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(428, 191);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Người gửi";
            // 
            // cbBox_estimate_pickup_time
            // 
            cbBox_estimate_pickup_time.FormattingEnabled = true;
            cbBox_estimate_pickup_time.Items.AddRange(new object[] { "Sáng (8h-11h30)", "Chiều (13h30-17h30)", "Tối (17h30-22h30)" });
            cbBox_estimate_pickup_time.Location = new Point(127, 139);
            cbBox_estimate_pickup_time.Name = "cbBox_estimate_pickup_time";
            cbBox_estimate_pickup_time.Size = new Size(151, 33);
            cbBox_estimate_pickup_time.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 143);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 22;
            label3.Text = "Giờ hẹn lấy";
            // 
            // datePicker_estimate_pickup_date
            // 
            datePicker_estimate_pickup_date.Format = DateTimePickerFormat.Short;
            datePicker_estimate_pickup_date.Location = new Point(127, 93);
            datePicker_estimate_pickup_date.Name = "datePicker_estimate_pickup_date";
            datePicker_estimate_pickup_date.Size = new Size(146, 32);
            datePicker_estimate_pickup_date.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 93);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 24);
            label5.TabIndex = 20;
            label5.Text = "Ngày hẹn lấy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 34);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 24);
            label4.TabIndex = 19;
            label4.Text = "Tên người gửi";
            // 
            // txtBox_username
            // 
            txtBox_username.Font = new Font("Segoe UI", 10F);
            txtBox_username.Location = new Point(127, 32);
            txtBox_username.Margin = new Padding(2);
            txtBox_username.Multiline = true;
            txtBox_username.Name = "txtBox_username";
            txtBox_username.PlaceholderText = "Nhập tên";
            txtBox_username.Size = new Size(174, 26);
            txtBox_username.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(datePicker_estimate_delivery_date);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbBox_to_ward);
            groupBox2.Controls.Add(cbBox_to_district);
            groupBox2.Controls.Add(txtBox_to_name);
            groupBox2.Controls.Add(txtBox_to_address);
            groupBox2.Controls.Add(cbBox_to_province);
            groupBox2.Controls.Add(txtBox_to_number);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.Location = new Point(10, 215);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(428, 341);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Người nhận";
            // 
            // datePicker_estimate_delivery_date
            // 
            datePicker_estimate_delivery_date.Format = DateTimePickerFormat.Short;
            datePicker_estimate_delivery_date.Location = new Point(127, 282);
            datePicker_estimate_delivery_date.Name = "datePicker_estimate_delivery_date";
            datePicker_estimate_delivery_date.Size = new Size(146, 30);
            datePicker_estimate_delivery_date.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 273);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(80, 48);
            label9.TabIndex = 21;
            label9.Text = "Thời gian\r\nhẹn giao";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 145);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 24);
            label8.TabIndex = 23;
            label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 96);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 24);
            label7.TabIndex = 22;
            label7.Text = "Họ tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 43);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 24);
            label6.TabIndex = 21;
            label6.Text = "Điện thoại";
            // 
            // cbBox_to_ward
            // 
            cbBox_to_ward.Font = new Font("Segoe UI", 9F);
            cbBox_to_ward.FormattingEnabled = true;
            cbBox_to_ward.Location = new Point(127, 238);
            cbBox_to_ward.Margin = new Padding(2);
            cbBox_to_ward.Name = "cbBox_to_ward";
            cbBox_to_ward.Size = new Size(110, 28);
            cbBox_to_ward.TabIndex = 9;
            cbBox_to_ward.Text = "Xã / Phường";
            // 
            // cbBox_to_district
            // 
            cbBox_to_district.Font = new Font("Segoe UI", 9F);
            cbBox_to_district.FormattingEnabled = true;
            cbBox_to_district.Location = new Point(260, 193);
            cbBox_to_district.Margin = new Padding(2);
            cbBox_to_district.Name = "cbBox_to_district";
            cbBox_to_district.Size = new Size(118, 28);
            cbBox_to_district.TabIndex = 8;
            cbBox_to_district.Text = "Quận/ Huyện";
            cbBox_to_district.SelectedIndexChanged += cboDistricts_SelectedIndexChanged;
            // 
            // txtBox_to_name
            // 
            txtBox_to_name.Location = new Point(127, 93);
            txtBox_to_name.Margin = new Padding(2);
            txtBox_to_name.Multiline = true;
            txtBox_to_name.Name = "txtBox_to_name";
            txtBox_to_name.PlaceholderText = "Họ tên người nhận";
            txtBox_to_name.Size = new Size(250, 27);
            txtBox_to_name.TabIndex = 7;
            // 
            // txtBox_to_address
            // 
            txtBox_to_address.Location = new Point(127, 140);
            txtBox_to_address.Margin = new Padding(2);
            txtBox_to_address.Multiline = true;
            txtBox_to_address.Name = "txtBox_to_address";
            txtBox_to_address.PlaceholderText = "Nhập địa chỉ";
            txtBox_to_address.Size = new Size(250, 28);
            txtBox_to_address.TabIndex = 6;
            // 
            // cbBox_to_province
            // 
            cbBox_to_province.Font = new Font("Segoe UI", 9F);
            cbBox_to_province.FormattingEnabled = true;
            cbBox_to_province.Location = new Point(127, 193);
            cbBox_to_province.Margin = new Padding(2);
            cbBox_to_province.Name = "cbBox_to_province";
            cbBox_to_province.Size = new Size(110, 28);
            cbBox_to_province.TabIndex = 5;
            cbBox_to_province.Text = "Tỉnh / Thành phố";
            cbBox_to_province.SelectedIndexChanged += cboProvinces_SelectedIndexChanged;
            // 
            // txtBox_to_number
            // 
            txtBox_to_number.Location = new Point(127, 42);
            txtBox_to_number.Margin = new Padding(2);
            txtBox_to_number.Multiline = true;
            txtBox_to_number.Name = "txtBox_to_number";
            txtBox_to_number.PlaceholderText = "Số điện thoại";
            txtBox_to_number.Size = new Size(250, 31);
            txtBox_to_number.TabIndex = 1;
            // 
            // gbTThangHoa
            // 
            gbTThangHoa.Controls.Add(txtBox_length);
            gbTThangHoa.Controls.Add(txtBox_width);
            gbTThangHoa.Controls.Add(txtBox_height);
            gbTThangHoa.Controls.Add(tick_Giayto_Hoadon);
            gbTThangHoa.Controls.Add(tick_Nguyen_khoi);
            gbTThangHoa.Controls.Add(tick_Gia_tri_cao);
            gbTThangHoa.Controls.Add(tick_Tu_kinh_pin);
            gbTThangHoa.Controls.Add(tick_De_vo);
            gbTThangHoa.Controls.Add(tick_chat_long);
            gbTThangHoa.Controls.Add(label15);
            gbTThangHoa.Controls.Add(label14);
            gbTThangHoa.Controls.Add(txtBox_weight);
            gbTThangHoa.Controls.Add(txtBox_value);
            gbTThangHoa.Controls.Add(txtBox_name_order);
            gbTThangHoa.Controls.Add(label2);
            gbTThangHoa.Controls.Add(radioBtn_Tailieu);
            gbTThangHoa.Controls.Add(radioBtn_Buukien);
            gbTThangHoa.Controls.Add(label1);
            gbTThangHoa.Font = new Font("Sitka Subheading", 10F);
            gbTThangHoa.Location = new Point(451, 19);
            gbTThangHoa.Margin = new Padding(2);
            gbTThangHoa.Name = "gbTThangHoa";
            gbTThangHoa.Padding = new Padding(2);
            gbTThangHoa.Size = new Size(417, 417);
            gbTThangHoa.TabIndex = 14;
            gbTThangHoa.TabStop = false;
            gbTThangHoa.Text = "Thông tin hàng hóa";
            // 
            // txtBox_length
            // 
            txtBox_length.Location = new Point(242, 155);
            txtBox_length.Margin = new Padding(2);
            txtBox_length.Multiline = true;
            txtBox_length.Name = "txtBox_length";
            txtBox_length.PlaceholderText = "Chiều dài ";
            txtBox_length.Size = new Size(97, 28);
            txtBox_length.TabIndex = 39;
            // 
            // txtBox_width
            // 
            txtBox_width.Location = new Point(242, 197);
            txtBox_width.Margin = new Padding(2);
            txtBox_width.Multiline = true;
            txtBox_width.Name = "txtBox_width";
            txtBox_width.PlaceholderText = "Chiều rộng";
            txtBox_width.Size = new Size(97, 28);
            txtBox_width.TabIndex = 38;
            // 
            // txtBox_height
            // 
            txtBox_height.Location = new Point(82, 197);
            txtBox_height.Margin = new Padding(2);
            txtBox_height.Multiline = true;
            txtBox_height.Name = "txtBox_height";
            txtBox_height.PlaceholderText = "Chiều cao";
            txtBox_height.Size = new Size(97, 28);
            txtBox_height.TabIndex = 37;
            // 
            // tick_Giayto_Hoadon
            // 
            tick_Giayto_Hoadon.AutoSize = true;
            tick_Giayto_Hoadon.Location = new Point(279, 354);
            tick_Giayto_Hoadon.Margin = new Padding(2);
            tick_Giayto_Hoadon.Name = "tick_Giayto_Hoadon";
            tick_Giayto_Hoadon.Size = new Size(97, 52);
            tick_Giayto_Hoadon.TabIndex = 36;
            tick_Giayto_Hoadon.Text = "Giấy tờ/\r\nHóa đơn\r\n";
            tick_Giayto_Hoadon.UseVisualStyleBackColor = true;
            // 
            // tick_Nguyen_khoi
            // 
            tick_Nguyen_khoi.AutoSize = true;
            tick_Nguyen_khoi.Location = new Point(153, 364);
            tick_Nguyen_khoi.Margin = new Padding(2);
            tick_Nguyen_khoi.Name = "tick_Nguyen_khoi";
            tick_Nguyen_khoi.Size = new Size(128, 28);
            tick_Nguyen_khoi.TabIndex = 35;
            tick_Nguyen_khoi.Text = "Nguyên khối";
            tick_Nguyen_khoi.UseVisualStyleBackColor = true;
            // 
            // tick_Gia_tri_cao
            // 
            tick_Gia_tri_cao.AutoSize = true;
            tick_Gia_tri_cao.Location = new Point(21, 364);
            tick_Gia_tri_cao.Margin = new Padding(2);
            tick_Gia_tri_cao.Name = "tick_Gia_tri_cao";
            tick_Gia_tri_cao.Size = new Size(111, 28);
            tick_Gia_tri_cao.TabIndex = 34;
            tick_Gia_tri_cao.Text = "Giá trị cao";
            tick_Gia_tri_cao.UseVisualStyleBackColor = true;
            // 
            // tick_Tu_kinh_pin
            // 
            tick_Tu_kinh_pin.AutoSize = true;
            tick_Tu_kinh_pin.Location = new Point(279, 317);
            tick_Tu_kinh_pin.Margin = new Padding(2);
            tick_Tu_kinh_pin.Name = "tick_Tu_kinh_pin";
            tick_Tu_kinh_pin.Size = new Size(121, 28);
            tick_Tu_kinh_pin.TabIndex = 33;
            tick_Tu_kinh_pin.Text = "Từ kính,pin";
            tick_Tu_kinh_pin.UseVisualStyleBackColor = true;
            // 
            // tick_De_vo
            // 
            tick_De_vo.AutoSize = true;
            tick_De_vo.Location = new Point(153, 317);
            tick_De_vo.Margin = new Padding(2);
            tick_De_vo.Name = "tick_De_vo";
            tick_De_vo.Size = new Size(76, 28);
            tick_De_vo.TabIndex = 31;
            tick_De_vo.Text = "Dễ vỡ";
            tick_De_vo.UseVisualStyleBackColor = true;
            // 
            // tick_chat_long
            // 
            tick_chat_long.AutoSize = true;
            tick_chat_long.Location = new Point(21, 317);
            tick_chat_long.Margin = new Padding(2);
            tick_chat_long.Name = "tick_chat_long";
            tick_chat_long.Size = new Size(105, 28);
            tick_chat_long.TabIndex = 30;
            tick_chat_long.Text = "Chất lỏng";
            tick_chat_long.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(23, 290);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(241, 23);
            label15.TabIndex = 29;
            label15.Text = "Tính chất hàng hóa đặc biệt";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(2, 265);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(411, 20);
            label14.TabIndex = 28;
            label14.Text = "___________________________________________________________________";
            // 
            // txtBox_weight
            // 
            txtBox_weight.Location = new Point(82, 155);
            txtBox_weight.Margin = new Padding(2);
            txtBox_weight.Multiline = true;
            txtBox_weight.Name = "txtBox_weight";
            txtBox_weight.PlaceholderText = "Trọng lượng";
            txtBox_weight.Size = new Size(97, 28);
            txtBox_weight.TabIndex = 21;
            // 
            // txtBox_value
            // 
            txtBox_value.Location = new Point(82, 234);
            txtBox_value.Margin = new Padding(2);
            txtBox_value.Multiline = true;
            txtBox_value.Name = "txtBox_value";
            txtBox_value.PlaceholderText = "Giá trị";
            txtBox_value.Size = new Size(97, 28);
            txtBox_value.TabIndex = 20;
            // 
            // txtBox_name_order
            // 
            txtBox_name_order.Location = new Point(82, 115);
            txtBox_name_order.Margin = new Padding(2);
            txtBox_name_order.Multiline = true;
            txtBox_name_order.Name = "txtBox_name_order";
            txtBox_name_order.PlaceholderText = "Nhập tên hàng hóa";
            txtBox_name_order.Size = new Size(226, 28);
            txtBox_name_order.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 93);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(411, 20);
            label2.TabIndex = 17;
            label2.Text = "___________________________________________________________________";
            // 
            // radioBtn_Tailieu
            // 
            radioBtn_Tailieu.AutoSize = true;
            radioBtn_Tailieu.Location = new Point(255, 70);
            radioBtn_Tailieu.Margin = new Padding(2);
            radioBtn_Tailieu.Name = "radioBtn_Tailieu";
            radioBtn_Tailieu.Size = new Size(87, 28);
            radioBtn_Tailieu.TabIndex = 16;
            radioBtn_Tailieu.TabStop = true;
            radioBtn_Tailieu.Text = "Tài liệu";
            radioBtn_Tailieu.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Buukien
            // 
            radioBtn_Buukien.AutoSize = true;
            radioBtn_Buukien.Location = new Point(109, 70);
            radioBtn_Buukien.Margin = new Padding(2);
            radioBtn_Buukien.Name = "radioBtn_Buukien";
            radioBtn_Buukien.Size = new Size(99, 28);
            radioBtn_Buukien.TabIndex = 15;
            radioBtn_Buukien.TabStop = true;
            radioBtn_Buukien.Text = "Bưu kiện";
            radioBtn_Buukien.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 14;
            label1.Text = "Loại hàng hóa";
            // 
            // radioBtn_khong_xem
            // 
            radioBtn_khong_xem.AutoSize = true;
            radioBtn_khong_xem.Location = new Point(706, 488);
            radioBtn_khong_xem.Margin = new Padding(2);
            radioBtn_khong_xem.Name = "radioBtn_khong_xem";
            radioBtn_khong_xem.Size = new Size(105, 24);
            radioBtn_khong_xem.TabIndex = 44;
            radioBtn_khong_xem.TabStop = true;
            radioBtn_khong_xem.Text = "Không xem";
            radioBtn_khong_xem.UseVisualStyleBackColor = true;
            // 
            // radioBtn_cho_xem_khong_thu
            // 
            radioBtn_cho_xem_khong_thu.AutoSize = true;
            radioBtn_cho_xem_khong_thu.Location = new Point(502, 531);
            radioBtn_cho_xem_khong_thu.Margin = new Padding(2);
            radioBtn_cho_xem_khong_thu.Name = "radioBtn_cho_xem_khong_thu";
            radioBtn_cho_xem_khong_thu.Size = new Size(162, 24);
            radioBtn_cho_xem_khong_thu.TabIndex = 42;
            radioBtn_cho_xem_khong_thu.TabStop = true;
            radioBtn_cho_xem_khong_thu.Text = "Cho xem, không thử";
            radioBtn_cho_xem_khong_thu.UseVisualStyleBackColor = true;
            // 
            // radioBtn_cho_thu_hang
            // 
            radioBtn_cho_thu_hang.AutoSize = true;
            radioBtn_cho_thu_hang.Location = new Point(502, 488);
            radioBtn_cho_thu_hang.Margin = new Padding(2);
            radioBtn_cho_thu_hang.Name = "radioBtn_cho_thu_hang";
            radioBtn_cho_thu_hang.Size = new Size(119, 24);
            radioBtn_cho_thu_hang.TabIndex = 41;
            radioBtn_cho_thu_hang.TabStop = true;
            radioBtn_cho_thu_hang.Text = "Cho thử hàng";
            radioBtn_cho_thu_hang.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(475, 452);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(113, 23);
            label11.TabIndex = 40;
            label11.Text = "Loại ghi chú";
            // 
            // btnNextpageTaoDon
            // 
            btnNextpageTaoDon.Location = new Point(399, 570);
            btnNextpageTaoDon.Margin = new Padding(2);
            btnNextpageTaoDon.Name = "btnNextpageTaoDon";
            btnNextpageTaoDon.Size = new Size(90, 27);
            btnNextpageTaoDon.TabIndex = 15;
            btnNextpageTaoDon.Text = "Tiếp tục";
            btnNextpageTaoDon.UseVisualStyleBackColor = true;
            btnNextpageTaoDon.Click += btnNextpageTaoDon_Click;
            // 
            // FormTaoDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(900, 614);
            Controls.Add(radioBtn_khong_xem);
            Controls.Add(radioBtn_cho_xem_khong_thu);
            Controls.Add(btnNextpageTaoDon);
            Controls.Add(radioBtn_cho_thu_hang);
            Controls.Add(groupBox1);
            Controls.Add(gbTThangHoa);
            Controls.Add(label11);
            Controls.Add(groupBox2);
            Margin = new Padding(2);
            Name = "FormTaoDonHang";
            Text = "FormTaoDonHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbTThangHoa.ResumeLayout(false);
            gbTThangHoa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBox_username;
        private GroupBox groupBox2;
        private ComboBox cbBox_to_province;
        private TextBox txtBox_to_number;
        private TextBox txtBox_to_address;
        private TextBox txtBox_to_name;
        private ComboBox cbBox_to_ward;
        private ComboBox cbBox_to_district;
        private GroupBox gbTThangHoa;
        private RadioButton radioButton1;
        private Label label1;
        private RadioButton radioBtn_Tailieu;
        private RadioButton radioBtn_Buukien;

        private TextBox txtBox_name_order;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtBox_weight;
        private TextBox txtBox_value;
        private Label label15;
        private Label label14;
        private CheckBox tick_Nguyen_khoi;
        private CheckBox tick_Gia_tri_cao;
        private CheckBox tick_Tu_kinh_pin;
        private CheckBox tick_chat_long;
        private CheckBox tick_De_vo;
        private CheckBox tick_Giayto_Hoadon;

        private Button btnNextpageTaoDon;
        private TextBox txtBox_length;
        private TextBox txtBox_width;
        private TextBox txtBox_height;
        private DateTimePicker datePicker_estimate_pickup_date;
        private ComboBox cbBox_estimate_pickup_time;
        private Label label3;
        private DateTimePicker datePicker_estimate_delivery_date;
        private RadioButton radioBtn_khong_xem;
        private RadioButton radioBtn_cho_xem_khong_thu;
        private RadioButton radioBtn_cho_thu_hang;
        private Label label11;
    }
}