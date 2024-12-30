namespace QuanlyGiaoVan
{
    partial class FormGiaoDienTrong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoDienNgoai));
            roundPanel = new RoundPanel();
            btnHoiDap = new NoBorderButton();
            btnDangNhap = new NoBorderButton();
            btnDangKy = new NoBorderButton();
            roundPanel1 = new RoundPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            circlePanel = new CirclePanel();
            button1 = new Button();
            label2 = new Label();
            roundPanel2 = new RoundPanel();
            label1 = new Label();
            roundPanel.SuspendLayout();
            roundPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // roundPanel
            // 
            roundPanel.BackColor = Color.FromArgb(32, 43, 61);
            roundPanel.BorderColor = Color.Transparent;
            roundPanel.BorderThickness = 2F;
            roundPanel.Controls.Add(btnHoiDap);
            roundPanel.Controls.Add(btnDangNhap);
            roundPanel.Controls.Add(btnDangKy);
            roundPanel.CornerRadiusBottomLeft = 20;
            roundPanel.CornerRadiusBottomRight = 0;
            roundPanel.CornerRadiusTopLeft = 20;
            roundPanel.CornerRadiusTopRight = 30;
            roundPanel.Location = new Point(12, 12);
            roundPanel.Name = "roundPanel";
            roundPanel.Size = new Size(172, 447);
            roundPanel.TabIndex = 0;
            roundPanel.Paint += this.roundPanel_Paint;
            // 
            // btnHoiDap
            // 
            btnHoiDap.BackColor = Color.FromArgb(43, 57, 82);
            btnHoiDap.FlatStyle = FlatStyle.Popup;
            btnHoiDap.ForeColor = SystemColors.ControlLightLight;
            btnHoiDap.Location = new Point(0, 220);
            btnHoiDap.Name = "btnHoiDap";
            btnHoiDap.Size = new Size(175, 48);
            btnHoiDap.TabIndex = 2;
            btnHoiDap.Text = "Hỏi đáp";
            btnHoiDap.UseVisualStyleBackColor = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(43, 57, 82);
            btnDangNhap.FlatStyle = FlatStyle.Popup;
            btnDangNhap.ForeColor = SystemColors.ControlLightLight;
            btnDangNhap.Location = new Point(0, 100);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(175, 48);
            btnDangNhap.TabIndex = 1;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(43, 57, 82);
            btnDangKy.FlatStyle = FlatStyle.Popup;
            btnDangKy.ForeColor = SystemColors.ControlLightLight;
            btnDangKy.Location = new Point(0, 160);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(175, 48);
            btnDangKy.TabIndex = 0;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += this.myButton_Click;
            // 
            // roundPanel1
            // 
            roundPanel1.BackColor = Color.FromArgb(223, 230, 242);
            roundPanel1.BorderColor = Color.FromArgb(224, 224, 224);
            roundPanel1.BorderThickness = 2F;
            roundPanel1.Controls.Add(tabControl1);
            roundPanel1.Controls.Add(pictureBox3);
            roundPanel1.Controls.Add(pictureBox2);
            roundPanel1.Controls.Add(pictureBox1);
            roundPanel1.Controls.Add(label3);
            roundPanel1.Controls.Add(circlePanel);
            roundPanel1.Controls.Add(button1);
            roundPanel1.Controls.Add(label2);
            roundPanel1.CornerRadiusBottomLeft = 20;
            roundPanel1.CornerRadiusBottomRight = 20;
            roundPanel1.CornerRadiusTopLeft = 20;
            roundPanel1.CornerRadiusTopRight = 20;
            roundPanel1.Location = new Point(12, 12);
            roundPanel1.Name = "roundPanel1";
            roundPanel1.Size = new Size(923, 447);
            roundPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(273, 151);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(544, 293);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Zoom;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(536, 260);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tin mới 1";
            tabPage1.Click += this.tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Zoom;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(536, 260);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quy trình";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.BackgroundImageLayout = ImageLayout.Zoom;
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(536, 260);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tin mới 2";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(675, 45);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(185, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(450, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(225, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += this.pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(835, 13);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Khách";
            // 
            // circlePanel
            // 
            circlePanel.CircleColor = Color.Gray;
            circlePanel.CircleImage = (Image)resources.GetObject("circlePanel.CircleImage");
            circlePanel.Location = new Point(800, 8);
            circlePanel.Name = "circlePanel";
            circlePanel.Size = new Size(30, 30);
            circlePanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // roundPanel2
            // 
            roundPanel2.BackColor = Color.FromArgb(51, 126, 255);
            roundPanel2.BorderColor = Color.Transparent;
            roundPanel2.BorderThickness = 2F;
            roundPanel2.Controls.Add(label1);
            roundPanel2.CornerRadiusBottomLeft = 0;
            roundPanel2.CornerRadiusBottomRight = 30;
            roundPanel2.CornerRadiusTopLeft = 20;
            roundPanel2.CornerRadiusTopRight = 30;
            roundPanel2.Location = new Point(12, 12);
            roundPanel2.Name = "roundPanel2";
            roundPanel2.Size = new Size(172, 64);
            roundPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14F);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(119, 29);
            label1.TabIndex = 0;
            label1.Text = "DCMM.ship";
            // 
            // FormGiaoDienNgoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 471);
            Controls.Add(roundPanel2);
            Controls.Add(roundPanel);
            Controls.Add(roundPanel1);
            Name = "FormGiaoDienNgoai";
            Text = "FormGiaoDienTrong";
            Load += this.FormGiaoDienNgoai_Load;
            roundPanel.ResumeLayout(false);
            roundPanel1.ResumeLayout(false);
            roundPanel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundPanel2.ResumeLayout(false);
            roundPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundPanel roundPanel;
        private RoundPanel roundPanel1;
        private RoundPanel roundPanel2;

        private Label label1;
        private CirclePanel circlePanel;
        private Button button1;
        private NoBorderButton btnDangKy;

        private Label label3;
        private Label label2;
        private NoBorderButton btnDangNhap;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private NoBorderButton btnHoiDap;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}
