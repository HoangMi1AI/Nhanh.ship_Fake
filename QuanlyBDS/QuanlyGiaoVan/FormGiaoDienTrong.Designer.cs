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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoDienTrong));
            roundPanel = new RoundPanel();
            btnDangXuat = new NoBorderButton();
            noBorderButton2 = new NoBorderButton();
            noBorderButton1 = new NoBorderButton();
            btnHoiDap = new NoBorderButton();
            btnTaoDon = new NoBorderButton();
            btnTraCuoc1 = new NoBorderButton();
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
            roundPanel.Controls.Add(btnDangXuat);
            roundPanel.Controls.Add(noBorderButton2);
            roundPanel.Controls.Add(noBorderButton1);
            roundPanel.Controls.Add(btnHoiDap);
            roundPanel.Controls.Add(btnTaoDon);
            roundPanel.Controls.Add(btnTraCuoc1);
            roundPanel.CornerRadiusBottomLeft = 20;
            roundPanel.CornerRadiusBottomRight = 0;
            roundPanel.CornerRadiusTopLeft = 20;
            roundPanel.CornerRadiusTopRight = 30;
            roundPanel.Location = new Point(15, 15);
            roundPanel.Margin = new Padding(4);
            roundPanel.Name = "roundPanel";
            roundPanel.Size = new Size(215, 559);
            roundPanel.TabIndex = 0;
            roundPanel.Paint += roundPanel_Paint;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(43, 57, 82);
            btnDangXuat.FlatStyle = FlatStyle.Popup;
            btnDangXuat.ForeColor = SystemColors.ControlLightLight;
            btnDangXuat.Location = new Point(0, 484);
            btnDangXuat.Margin = new Padding(4);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(219, 60);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // noBorderButton2
            // 
            noBorderButton2.BackColor = Color.FromArgb(43, 57, 82);
            noBorderButton2.FlatStyle = FlatStyle.Popup;
            noBorderButton2.ForeColor = SystemColors.ControlLightLight;
            noBorderButton2.Location = new Point(0, 334);
            noBorderButton2.Margin = new Padding(4);
            noBorderButton2.Name = "noBorderButton2";
            noBorderButton2.Size = new Size(219, 60);
            noBorderButton2.TabIndex = 4;
            noBorderButton2.Text = "Tài khoản";
            noBorderButton2.UseVisualStyleBackColor = false;
            // 
            // noBorderButton1
            // 
            noBorderButton1.BackColor = Color.FromArgb(43, 57, 82);
            noBorderButton1.FlatStyle = FlatStyle.Popup;
            noBorderButton1.ForeColor = SystemColors.ControlLightLight;
            noBorderButton1.Location = new Point(0, 259);
            noBorderButton1.Margin = new Padding(4);
            noBorderButton1.Name = "noBorderButton1";
            noBorderButton1.Size = new Size(219, 60);
            noBorderButton1.TabIndex = 3;
            noBorderButton1.Text = "Báo cáo";
            noBorderButton1.UseVisualStyleBackColor = false;
            // 
            // btnHoiDap
            // 
            btnHoiDap.BackColor = Color.FromArgb(43, 57, 82);
            btnHoiDap.FlatStyle = FlatStyle.Popup;
            btnHoiDap.ForeColor = SystemColors.ControlLightLight;
            btnHoiDap.Location = new Point(0, 409);
            btnHoiDap.Margin = new Padding(4);
            btnHoiDap.Name = "btnHoiDap";
            btnHoiDap.Size = new Size(219, 60);
            btnHoiDap.TabIndex = 2;
            btnHoiDap.Text = "Hỏi đáp";
            btnHoiDap.UseVisualStyleBackColor = false;
            // 
            // btnTaoDon
            // 
            btnTaoDon.BackColor = Color.FromArgb(43, 57, 82);
            btnTaoDon.FlatStyle = FlatStyle.Popup;
            btnTaoDon.ForeColor = SystemColors.ControlLightLight;
            btnTaoDon.Location = new Point(0, 109);
            btnTaoDon.Margin = new Padding(4);
            btnTaoDon.Name = "btnTaoDon";
            btnTaoDon.Size = new Size(219, 60);
            btnTaoDon.TabIndex = 1;
            btnTaoDon.Text = "Tạo đơn";
            btnTaoDon.UseVisualStyleBackColor = false;
            btnTaoDon.Click += btnTaoDon_Click;
            // 
            // btnTraCuoc1
            // 
            btnTraCuoc1.BackColor = Color.FromArgb(43, 57, 82);
            btnTraCuoc1.FlatStyle = FlatStyle.Popup;
            btnTraCuoc1.ForeColor = SystemColors.ControlLightLight;
            btnTraCuoc1.Location = new Point(0, 184);
            btnTraCuoc1.Margin = new Padding(4);
            btnTraCuoc1.Name = "btnTraCuoc1";
            btnTraCuoc1.Size = new Size(219, 60);
            btnTraCuoc1.TabIndex = 0;
            btnTraCuoc1.Text = "Tra cước";
            btnTraCuoc1.UseVisualStyleBackColor = false;
            btnTraCuoc1.Click += Tra_Cuoc_Click;
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
            roundPanel1.Location = new Point(15, 15);
            roundPanel1.Margin = new Padding(4);
            roundPanel1.Name = "roundPanel1";
            roundPanel1.Size = new Size(1154, 559);
            roundPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(341, 189);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(680, 366);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Zoom;
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(672, 328);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tin mới 1";
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Zoom;
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(672, 328);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quy trình";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.BackgroundImageLayout = ImageLayout.Zoom;
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4);
            tabPage3.Size = new Size(672, 328);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tin mới 2";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(844, 56);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(231, 125);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(562, 56);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(231, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(281, 56);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1044, 16);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // circlePanel
            // 
            circlePanel.CircleColor = Color.Gray;
            circlePanel.CircleImage = (Image)resources.GetObject("circlePanel.CircleImage");
            circlePanel.Location = new Point(1000, 10);
            circlePanel.Margin = new Padding(4);
            circlePanel.Name = "circlePanel";
            circlePanel.Size = new Size(38, 38);
            circlePanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
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
            roundPanel2.Location = new Point(15, 15);
            roundPanel2.Margin = new Padding(4);
            roundPanel2.Name = "roundPanel2";
            roundPanel2.Size = new Size(215, 80);
            roundPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14F);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(30, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 35);
            label1.TabIndex = 0;
            label1.Text = "DCMM.ship";
            // 
            // FormGiaoDienTrong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 589);
            Controls.Add(roundPanel2);
            Controls.Add(roundPanel);
            Controls.Add(roundPanel1);
            Margin = new Padding(4);
            Name = "FormGiaoDienTrong";
            Text = "FormGiaoDienTrong";
            Load += FormGiaoDienNgoai_Load;
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
        private NoBorderButton btnTraCuoc1;

        private Label label3;
        private Label label2;
        private NoBorderButton btnTaoDon;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private NoBorderButton btnHoiDap;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private NoBorderButton btnDangXuat;
        private NoBorderButton noBorderButton2;
        private NoBorderButton noBorderButton1;
    }
}
