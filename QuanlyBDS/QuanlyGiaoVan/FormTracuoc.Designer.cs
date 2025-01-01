namespace QuanlyGiaoVan
{
    partial class FormTraCuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraCuoc));
            label1 = new Label();
            cboProvincesgui = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            cboDistrictsgui = new ComboBox();
            txtKL = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTTH = new TextBox();
            cboDistrictsnhan = new ComboBox();
            button2 = new Button();
            cboProvincesnhan = new ComboBox();
            btnTra = new Button();
            panel1 = new Panel();
            lbGHTK = new Label();
            pictureBox3 = new PictureBox();
            btnBack = new Button();
            lbVTP = new Label();
            lbGHN = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            cboWardsgui = new ComboBox();
            cboWardsnhan = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(298, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 28);
            label1.TabIndex = 0;
            label1.Text = "TRA CƯỚC VẬN CHUYỂN";
            // 
            // cboProvincesgui
            // 
            cboProvincesgui.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProvincesgui.FormattingEnabled = true;
            cboProvincesgui.Location = new Point(99, 104);
            cboProvincesgui.Margin = new Padding(2);
            cboProvincesgui.Name = "cboProvincesgui";
            cboProvincesgui.Size = new Size(252, 31);
            cboProvincesgui.TabIndex = 1;
            cboProvincesgui.Text = "    - Tỉnh/Thành phố -";
            cboProvincesgui.SelectedIndexChanged += cboProvincesgui_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(248, 269);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(102, 29);
            button1.TabIndex = 2;
            button1.Text = "            gram";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Người gửi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(486, 71);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Người nhận";
            // 
            // cboDistrictsgui
            // 
            cboDistrictsgui.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDistrictsgui.FormattingEnabled = true;
            cboDistrictsgui.Location = new Point(99, 159);
            cboDistrictsgui.Margin = new Padding(2);
            cboDistrictsgui.Name = "cboDistrictsgui";
            cboDistrictsgui.Size = new Size(252, 31);
            cboDistrictsgui.TabIndex = 7;
            cboDistrictsgui.Text = "    - Quận/Huyện -";
            cboDistrictsgui.SelectedIndexChanged += cboDistrictsgui_SelectedIndexChanged;
            // 
            // txtKL
            // 
            txtKL.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKL.Location = new Point(99, 269);
            txtKL.Margin = new Padding(2);
            txtKL.Name = "txtKL";
            txtKL.PlaceholderText = "Khối lượng gói hàng";
            txtKL.Size = new Size(206, 30);
            txtKL.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 299);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(256, 15);
            label4.TabIndex = 11;
            label4.Text = "Tổng khối lượng các sản phẩm trong đơn hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(526, 298);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(213, 15);
            label5.TabIndex = 16;
            label5.Text = "Để trống nếu bạn không có tiền thu hộ";
            // 
            // txtTTH
            // 
            txtTTH.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTTH.Location = new Point(486, 269);
            txtTTH.Margin = new Padding(2);
            txtTTH.Name = "txtTTH";
            txtTTH.PlaceholderText = "Tiền thu hộ";
            txtTTH.Size = new Size(206, 30);
            txtTTH.TabIndex = 15;
            // 
            // cboDistrictsnhan
            // 
            cboDistrictsnhan.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDistrictsnhan.FormattingEnabled = true;
            cboDistrictsnhan.Location = new Point(486, 159);
            cboDistrictsnhan.Margin = new Padding(2);
            cboDistrictsnhan.Name = "cboDistrictsnhan";
            cboDistrictsnhan.Size = new Size(252, 31);
            cboDistrictsnhan.TabIndex = 14;
            cboDistrictsnhan.Text = "    - Quận/Huyện -";
            cboDistrictsnhan.SelectedIndexChanged += cboDistrictsnhan_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(634, 268);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(102, 29);
            button2.TabIndex = 13;
            button2.Text = "            gram";
            button2.UseVisualStyleBackColor = true;
            // 
            // cboProvincesnhan
            // 
            cboProvincesnhan.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProvincesnhan.FormattingEnabled = true;
            cboProvincesnhan.Location = new Point(486, 104);
            cboProvincesnhan.Margin = new Padding(2);
            cboProvincesnhan.Name = "cboProvincesnhan";
            cboProvincesnhan.Size = new Size(252, 31);
            cboProvincesnhan.TabIndex = 12;
            cboProvincesnhan.Text = "    - Tỉnh/Thành phố -";
            cboProvincesnhan.SelectedIndexChanged += cboProvincesnhan_SelectedIndexChanged;
            // 
            // btnTra
            // 
            btnTra.BackColor = Color.PaleGreen;
            btnTra.Location = new Point(369, 317);
            btnTra.Margin = new Padding(2);
            btnTra.Name = "btnTra";
            btnTra.Size = new Size(102, 29);
            btnTra.TabIndex = 17;
            btnTra.Text = "Tra cước";
            btnTra.UseVisualStyleBackColor = false;
            btnTra.Click += btnCalculateFee_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbGHTK);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lbVTP);
            panel1.Controls.Add(lbGHN);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(11, 71);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 346);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // lbGHTK
            // 
            lbGHTK.AutoSize = true;
            lbGHTK.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbGHTK.Location = new Point(113, 94);
            lbGHTK.Margin = new Padding(2, 0, 2, 0);
            lbGHTK.Name = "lbGHTK";
            lbGHTK.Size = new Size(63, 28);
            lbGHTK.TabIndex = 8;
            lbGHTK.Text = "GHTK";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(33, 86);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(439, 288);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 28);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbVTP
            // 
            lbVTP.AutoSize = true;
            lbVTP.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbVTP.Location = new Point(113, 154);
            lbVTP.Margin = new Padding(2, 0, 2, 0);
            lbVTP.Name = "lbVTP";
            lbVTP.Size = new Size(109, 28);
            lbVTP.TabIndex = 5;
            lbVTP.Text = "Viettel post";
            // 
            // lbGHN
            // 
            lbGHN.AutoSize = true;
            lbGHN.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbGHN.Location = new Point(113, 35);
            lbGHN.Margin = new Padding(2, 0, 2, 0);
            lbGHN.Name = "lbGHN";
            lbGHN.Size = new Size(164, 28);
            lbGHN.TabIndex = 4;
            lbGHN.Text = "Giao hàng nhanh";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.vt;
            pictureBox2.Location = new Point(33, 151);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ghn;
            pictureBox1.Location = new Point(33, 31);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(255, 288);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(92, 29);
            button4.TabIndex = 1;
            button4.Text = "OK";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cboWardsgui
            // 
            cboWardsgui.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboWardsgui.FormattingEnabled = true;
            cboWardsgui.Location = new Point(99, 215);
            cboWardsgui.Margin = new Padding(2);
            cboWardsgui.Name = "cboWardsgui";
            cboWardsgui.Size = new Size(252, 31);
            cboWardsgui.TabIndex = 20;
            cboWardsgui.Text = "    - Xã/Phường -";
            // 
            // cboWardsnhan
            // 
            cboWardsnhan.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboWardsnhan.FormattingEnabled = true;
            cboWardsnhan.Location = new Point(486, 215);
            cboWardsnhan.Margin = new Padding(2);
            cboWardsnhan.Name = "cboWardsnhan";
            cboWardsnhan.Size = new Size(252, 31);
            cboWardsnhan.TabIndex = 21;
            cboWardsnhan.Text = "    - Xã/Phường -";
            // 
            // FormTraCuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 559);
            Controls.Add(panel1);
            Controls.Add(cboWardsnhan);
            Controls.Add(cboWardsgui);
            Controls.Add(btnTra);
            Controls.Add(label5);
            Controls.Add(txtTTH);
            Controls.Add(cboDistrictsnhan);
            Controls.Add(button2);
            Controls.Add(cboProvincesnhan);
            Controls.Add(label4);
            Controls.Add(txtKL);
            Controls.Add(cboDistrictsgui);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(cboProvincesgui);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormTraCuoc";
            Text = "Tra_cước";
            Load += Tra_cước_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboProvincesgui;
        private Button button1;
        private Label label2;
        private Label label3;
        private ComboBox cboDistrictsgui;
        private TextBox txtKL;
        private Label label4;
        private Label label5;
        private TextBox txtTTH;
        private ComboBox cboDistrictsnhan;
        private Button button2;
        private ComboBox cboProvincesnhan;
        private Button btnTra;
        private Panel panel1;
        private Button button4;
        private ComboBox cboWardsgui;
        private ComboBox cboWardsnhan;
        private PictureBox pictureBox1;
        private Label lbVTP;
        private Label lbGHN;
        private PictureBox pictureBox2;
        private Button btnBack;
        private Label lbGHTK;
        private PictureBox pictureBox3;
    }
}