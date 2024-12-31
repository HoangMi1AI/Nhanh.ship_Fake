namespace QuanlyGiaoVan
{
    partial class FormDangNhap
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
            roundPanel = new RoundPanel();
            roundPanel3 = new RoundPanel();
            label3 = new Label();
            roundPanel4 = new RoundPanel();
            label4 = new Label();
            roundPanel1 = new RoundPanel();
            label6 = new Label();
            label5 = new Label();
            txtMK = new TextBox();
            txtTK = new TextBox();
            btnDangNhap1 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            roundPanel2 = new RoundPanel();
            label1 = new Label();
            roundPanel.SuspendLayout();
            roundPanel3.SuspendLayout();
            roundPanel4.SuspendLayout();
            roundPanel1.SuspendLayout();
            roundPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // roundPanel
            // 
            roundPanel.BackColor = Color.FromArgb(32, 43, 61);
            roundPanel.BorderColor = Color.Transparent;
            roundPanel.BorderThickness = 2F;
            roundPanel.Controls.Add(roundPanel3);
            roundPanel.Controls.Add(roundPanel4);
            roundPanel.CornerRadiusBottomLeft = 20;
            roundPanel.CornerRadiusBottomRight = 0;
            roundPanel.CornerRadiusTopLeft = 20;
            roundPanel.CornerRadiusTopRight = 30;
            roundPanel.Location = new Point(15, 15);
            roundPanel.Margin = new Padding(4);
            roundPanel.Name = "roundPanel";
            roundPanel.Size = new Size(774, 80);
            roundPanel.TabIndex = 0;
            roundPanel.Paint += roundPanel_Paint;
            // 
            // roundPanel3
            // 
            roundPanel3.BackColor = Color.FromArgb(197, 205, 229);
            roundPanel3.BorderColor = Color.Transparent;
            roundPanel3.BorderThickness = 2F;
            roundPanel3.Controls.Add(label3);
            roundPanel3.CornerRadiusBottomLeft = 0;
            roundPanel3.CornerRadiusBottomRight = 0;
            roundPanel3.CornerRadiusTopLeft = 30;
            roundPanel3.CornerRadiusTopRight = 30;
            roundPanel3.Location = new Point(198, 0);
            roundPanel3.Margin = new Padding(4);
            roundPanel3.Name = "roundPanel3";
            roundPanel3.Size = new Size(215, 80);
            roundPanel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(39, 22);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 35);
            label3.TabIndex = 0;
            label3.Text = "Đăng nhập";
            label3.Click += label3_Click;
            // 
            // roundPanel4
            // 
            roundPanel4.BackColor = Color.FromArgb(157, 165, 189);
            roundPanel4.BorderColor = Color.Transparent;
            roundPanel4.BorderThickness = 2F;
            roundPanel4.Controls.Add(label4);
            roundPanel4.CornerRadiusBottomLeft = 0;
            roundPanel4.CornerRadiusBottomRight = 0;
            roundPanel4.CornerRadiusTopLeft = 30;
            roundPanel4.CornerRadiusTopRight = 30;
            roundPanel4.Location = new Point(400, 0);
            roundPanel4.Margin = new Padding(4);
            roundPanel4.Name = "roundPanel4";
            roundPanel4.Size = new Size(215, 80);
            roundPanel4.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(59, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 35);
            label4.TabIndex = 0;
            label4.Text = "Đăng ký";
            // 
            // roundPanel1
            // 
            roundPanel1.BackColor = Color.FromArgb(223, 230, 242);
            roundPanel1.BorderColor = Color.FromArgb(224, 224, 224);
            roundPanel1.BorderThickness = 2F;
            roundPanel1.Controls.Add(label6);
            roundPanel1.Controls.Add(label5);
            roundPanel1.Controls.Add(txtMK);
            roundPanel1.Controls.Add(txtTK);
            roundPanel1.Controls.Add(btnDangNhap1);
            roundPanel1.Controls.Add(button2);
            roundPanel1.Controls.Add(button1);
            roundPanel1.Controls.Add(label2);
            roundPanel1.CornerRadiusBottomLeft = 20;
            roundPanel1.CornerRadiusBottomRight = 20;
            roundPanel1.CornerRadiusTopLeft = 20;
            roundPanel1.CornerRadiusTopRight = 20;
            roundPanel1.Location = new Point(15, 15);
            roundPanel1.Margin = new Padding(4);
            roundPanel1.Name = "roundPanel1";
            roundPanel1.Size = new Size(774, 369);
            roundPanel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(149, 221);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 9;
            label6.Text = "Mật khẩu:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 165);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 8;
            label5.Text = "Tên tài khoản:";
            // 
            // txtMK
            // 
            txtMK.Location = new Point(248, 221);
            txtMK.Margin = new Padding(4);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(308, 31);
            txtMK.TabIndex = 7;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(248, 161);
            txtTK.Margin = new Padding(4);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(308, 31);
            txtTK.TabIndex = 6;
            // 
            // btnDangNhap1
            // 
            btnDangNhap1.BackColor = Color.FromArgb(32, 43, 61);
            btnDangNhap1.ForeColor = SystemColors.ControlLightLight;
            btnDangNhap1.Location = new Point(420, 278);
            btnDangNhap1.Margin = new Padding(4);
            btnDangNhap1.Name = "btnDangNhap1";
            btnDangNhap1.Size = new Size(118, 36);
            btnDangNhap1.TabIndex = 5;
            btnDangNhap1.Text = "Đăng nhập";
            btnDangNhap1.UseVisualStyleBackColor = false;
            btnDangNhap1.Click += btnDangNhap1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 43, 61);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(248, 278);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(118, 36);
            button2.TabIndex = 4;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
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
            roundPanel2.CornerRadiusBottomRight = 0;
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
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 391);
            Controls.Add(roundPanel2);
            Controls.Add(roundPanel);
            Controls.Add(roundPanel1);
            Margin = new Padding(4);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            Load += FormGiaoDienNgoai_Load;
            roundPanel.ResumeLayout(false);
            roundPanel3.ResumeLayout(false);
            roundPanel3.PerformLayout();
            roundPanel4.ResumeLayout(false);
            roundPanel4.PerformLayout();
            roundPanel1.ResumeLayout(false);
            roundPanel1.PerformLayout();
            roundPanel2.ResumeLayout(false);
            roundPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundPanel roundPanel;
        private RoundPanel roundPanel1;
        private RoundPanel roundPanel2;
        private Button button1;
        private Label label2;
        private Label label1;
        private RoundPanel roundPanel3;
        private Label label3;
        private TextBox txtTK;
        private Button btnDangNhap1;
        private Button button2;
        private RoundPanel roundPanel4;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox txtMK;
    }
}
