namespace QuanlyGiaoVan
{
    partial class FormBaocao
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaocao));
            lblBaocao = new Label();
            Timer_Capnhat = new System.Windows.Forms.Timer(components);
            panel_2 = new Panel();
            checkBoxTungloai = new CheckBox();
            checkBoxTatca = new CheckBox();
            dataGridView1 = new DataGridView();
            btnBaocaothoigiaogiaohangtrungbinh = new Button();
            lblBaocaodonhang = new Label();
            btnBaocaotinhhinhthitruong = new Button();
            btnBaocaohieusuatdoitac = new Button();
            btnBaocaotilekhieunai = new Button();
            btnBaocaosoluongdonhang = new Button();
            lblLoaibaocao = new Label();
            panel_1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBaocao
            // 
            lblBaocao.AutoSize = true;
            lblBaocao.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaocao.Location = new Point(69, 7);
            lblBaocao.Name = "lblBaocao";
            lblBaocao.Size = new Size(127, 40);
            lblBaocao.TabIndex = 3;
            lblBaocao.Text = "Báo cáo";
            lblBaocao.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel_2
            // 
            panel_2.BackColor = Color.White;
            panel_2.BorderStyle = BorderStyle.FixedSingle;
            panel_2.Controls.Add(checkBoxTungloai);
            panel_2.Controls.Add(checkBoxTatca);
            panel_2.Controls.Add(dataGridView1);
            panel_2.Controls.Add(btnBaocaothoigiaogiaohangtrungbinh);
            panel_2.Controls.Add(lblBaocaodonhang);
            panel_2.Controls.Add(btnBaocaotinhhinhthitruong);
            panel_2.Controls.Add(btnBaocaohieusuatdoitac);
            panel_2.Controls.Add(btnBaocaotilekhieunai);
            panel_2.Controls.Add(btnBaocaosoluongdonhang);
            panel_2.Controls.Add(lblLoaibaocao);
            panel_2.Location = new Point(12, 76);
            panel_2.Name = "panel_2";
            panel_2.Size = new Size(968, 380);
            panel_2.TabIndex = 4;
            // 
            // checkBoxTungloai
            // 
            checkBoxTungloai.AutoSize = true;
            checkBoxTungloai.Location = new Point(268, 29);
            checkBoxTungloai.Name = "checkBoxTungloai";
            checkBoxTungloai.Size = new Size(147, 19);
            checkBoxTungloai.TabIndex = 13;
            checkBoxTungloai.Text = "Theo từng loại báo cáo";
            checkBoxTungloai.UseVisualStyleBackColor = true;
            checkBoxTungloai.CheckedChanged += checkBoxTungloai_CheckedChanged;
            // 
            // checkBoxTatca
            // 
            checkBoxTatca.AutoSize = true;
            checkBoxTatca.Location = new Point(192, 30);
            checkBoxTatca.Name = "checkBoxTatca";
            checkBoxTatca.Size = new Size(57, 19);
            checkBoxTatca.TabIndex = 12;
            checkBoxTatca.Text = "Tất cả";
            checkBoxTatca.UseVisualStyleBackColor = true;
            checkBoxTatca.CheckedChanged += checkBoxTatca_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(931, 247);
            dataGridView1.TabIndex = 11;
            // 
            // btnBaocaothoigiaogiaohangtrungbinh
            // 
            btnBaocaothoigiaogiaohangtrungbinh.FlatStyle = FlatStyle.System;
            btnBaocaothoigiaogiaohangtrungbinh.Location = new Point(789, 64);
            btnBaocaothoigiaogiaohangtrungbinh.Name = "btnBaocaothoigiaogiaohangtrungbinh";
            btnBaocaothoigiaogiaohangtrungbinh.Size = new Size(172, 21);
            btnBaocaothoigiaogiaohangtrungbinh.TabIndex = 2;
            btnBaocaothoigiaogiaohangtrungbinh.Text = "Thời gian giao hàng trung bình";
            btnBaocaothoigiaogiaohangtrungbinh.UseVisualStyleBackColor = true;
            btnBaocaothoigiaogiaohangtrungbinh.Click += btnBaocaothoigiaogiaohangtrungbinh_Click;
            // 
            // lblBaocaodonhang
            // 
            lblBaocaodonhang.AutoSize = true;
            lblBaocaodonhang.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaocaodonhang.Location = new Point(3, 24);
            lblBaocaodonhang.Name = "lblBaocaodonhang";
            lblBaocaodonhang.Size = new Size(167, 25);
            lblBaocaodonhang.TabIndex = 7;
            lblBaocaodonhang.Text = "Báo cáo đơn hàng";
            // 
            // btnBaocaotinhhinhthitruong
            // 
            btnBaocaotinhhinhthitruong.FlatStyle = FlatStyle.System;
            btnBaocaotinhhinhthitruong.Location = new Point(627, 63);
            btnBaocaotinhhinhthitruong.Name = "btnBaocaotinhhinhthitruong";
            btnBaocaotinhhinhthitruong.Size = new Size(156, 23);
            btnBaocaotinhhinhthitruong.TabIndex = 5;
            btnBaocaotinhhinhthitruong.Text = "Báo cáo tình hình thị trường";
            btnBaocaotinhhinhthitruong.UseVisualStyleBackColor = true;
            btnBaocaotinhhinhthitruong.Click += btnBaocaotinhhinhthitruong_Click;
            // 
            // btnBaocaohieusuatdoitac
            // 
            btnBaocaohieusuatdoitac.FlatStyle = FlatStyle.System;
            btnBaocaohieusuatdoitac.Location = new Point(414, 63);
            btnBaocaohieusuatdoitac.Name = "btnBaocaohieusuatdoitac";
            btnBaocaohieusuatdoitac.Size = new Size(207, 23);
            btnBaocaohieusuatdoitac.TabIndex = 4;
            btnBaocaohieusuatdoitac.Text = "Báo cáo hiệu suất đối tác vận chuyển";
            btnBaocaohieusuatdoitac.UseVisualStyleBackColor = true;
            btnBaocaohieusuatdoitac.Click += btnBaocaohieusuatdoitac_Click;
            // 
            // btnBaocaotilekhieunai
            // 
            btnBaocaotilekhieunai.FlatStyle = FlatStyle.System;
            btnBaocaotilekhieunai.Location = new Point(285, 63);
            btnBaocaotilekhieunai.Name = "btnBaocaotilekhieunai";
            btnBaocaotilekhieunai.Size = new Size(123, 23);
            btnBaocaotilekhieunai.TabIndex = 3;
            btnBaocaotilekhieunai.Text = "Báo cáo tỉ lệ khiếu nại";
            btnBaocaotilekhieunai.UseVisualStyleBackColor = true;
            btnBaocaotilekhieunai.Click += btnBaocaotilekhieunai_Click;
            // 
            // btnBaocaosoluongdonhang
            // 
            btnBaocaosoluongdonhang.BackColor = Color.Transparent;
            btnBaocaosoluongdonhang.FlatStyle = FlatStyle.System;
            btnBaocaosoluongdonhang.ForeColor = Color.White;
            btnBaocaosoluongdonhang.Location = new Point(118, 63);
            btnBaocaosoluongdonhang.Name = "btnBaocaosoluongdonhang";
            btnBaocaosoluongdonhang.Size = new Size(161, 23);
            btnBaocaosoluongdonhang.TabIndex = 1;
            btnBaocaosoluongdonhang.Text = "Báo cáo số lượng đơn hàng";
            btnBaocaosoluongdonhang.UseVisualStyleBackColor = false;
            btnBaocaosoluongdonhang.Click += btnBaocaosoluongdonhang_Click;
            // 
            // lblLoaibaocao
            // 
            lblLoaibaocao.AutoSize = true;
            lblLoaibaocao.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoaibaocao.Location = new Point(3, 61);
            lblLoaibaocao.Name = "lblLoaibaocao";
            lblLoaibaocao.Size = new Size(119, 25);
            lblLoaibaocao.TabIndex = 0;
            lblLoaibaocao.Text = "Loại báo cáo";
            // 
            // panel_1
            // 
            panel_1.BackColor = Color.White;
            panel_1.Controls.Add(label1);
            panel_1.Controls.Add(lblBaocao);
            panel_1.Location = new Point(-6, -1);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(1012, 58);
            panel_1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(14, 7);
            label1.Name = "label1";
            label1.Size = new Size(49, 45);
            label1.TabIndex = 6;
            label1.Text = "       \r\n\r\n              ";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = Color.White;
            button1.Location = new Point(832, 462);
            button1.Name = "button1";
            button1.Size = new Size(132, 35);
            button1.TabIndex = 5;
            button1.Text = "Xuất báo cáo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormBaocao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(992, 512);
            Controls.Add(button1);
            Controls.Add(panel_1);
            Controls.Add(panel_2);
            Name = "FormBaocao";
            Text = "FormBaocao";
            Load += FormBaocao_Load;
            panel_2.ResumeLayout(false);
            panel_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_1.ResumeLayout(false);
            panel_1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblBaocao;
        private System.Windows.Forms.Timer Timer_Capnhat;
        private Panel panel_2;
        private Panel panel_1;
        private Label lblLoaibaocao;
        private Button btnBaocaosoluongdonhang;
        private Button btnBaocaotinhhinhthitruong;
        private Button btnBaocaohieusuatdoitac;
        private Button btnBaocaotilekhieunai;
        private DataGridView dataGridView1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label lblBaocaodonhang;
        private Button button1;
        private Label label1;
        private Button btnBaocaothoigiaogiaohangtrungbinh;
        private CheckBox checkBoxTungloai;
        private CheckBox checkBoxTatca;
    }
}