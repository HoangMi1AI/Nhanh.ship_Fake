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
            dataGridView1 = new DataGridView();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            lblBaocaonhapkho = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btnBCNhapkho = new Button();
            lblLoaibaocao = new Label();
            panel_1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            btnBCXuatkho = new Button();
            panel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBaocao
            // 
            lblBaocao.AutoSize = true;
            lblBaocao.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaocao.Location = new Point(86, 10);
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
            panel_2.Controls.Add(dataGridView1);
            panel_2.Controls.Add(comboBox3);
            panel_2.Controls.Add(comboBox2);
            panel_2.Controls.Add(comboBox1);
            panel_2.Controls.Add(lblBaocaonhapkho);
            panel_2.Controls.Add(button5);
            panel_2.Controls.Add(button4);
            panel_2.Controls.Add(button3);
            panel_2.Controls.Add(btnBCNhapkho);
            panel_2.Controls.Add(lblLoaibaocao);
            panel_2.Location = new Point(12, 76);
            panel_2.Name = "panel_2";
            panel_2.Size = new Size(910, 347);
            panel_2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(869, 212);
            dataGridView1.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(540, 70);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(141, 23);
            comboBox3.TabIndex = 10;
            comboBox3.Text = "Tùy chỉnh cột:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(369, 70);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(141, 23);
            comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tất cả", "Kho 1", "Kho 2" });
            comboBox1.Location = new Point(201, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 23);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Kho:";
            // 
            // lblBaocaonhapkho
            // 
            lblBaocaonhapkho.AutoSize = true;
            lblBaocaonhapkho.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaocaonhapkho.Location = new Point(12, 70);
            lblBaocaonhapkho.Name = "lblBaocaonhapkho";
            lblBaocaonhapkho.Size = new Size(164, 25);
            lblBaocaonhapkho.TabIndex = 7;
            lblBaocaonhapkho.Text = "Báo cáo nhập kho";
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.System;
            button6.Location = new Point(770, 32);
            button6.Name = "button6";
            button6.Size = new Size(110, 23);
            button6.TabIndex = 6;
            button6.Text = "Cảnh báo hết hàng";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.System;
            button5.Location = new Point(674, 28);
            button5.Name = "button5";
            button5.Size = new Size(156, 23);
            button5.TabIndex = 5;
            button5.Text = "Báo cáo tình hình thị trường";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Location = new Point(446, 28);
            button4.Name = "button4";
            button4.Size = new Size(207, 23);
            button4.TabIndex = 4;
            button4.Text = "Báo cáo hiệu suất đối tác vận chuyển";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(317, 29);
            button3.Name = "button3";
            button3.Size = new Size(123, 23);
            button3.TabIndex = 3;
            button3.Text = "Báo cáo tỉ lệ khiếu nại";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnBCNhapkho
            // 
            btnBCNhapkho.FlatStyle = FlatStyle.System;
            btnBCNhapkho.Location = new Point(150, 28);
            btnBCNhapkho.Name = "btnBCNhapkho";
            btnBCNhapkho.Size = new Size(161, 23);
            btnBCNhapkho.TabIndex = 1;
            btnBCNhapkho.Text = "Báo cáo số lượng đơn hàng";
            btnBCNhapkho.UseVisualStyleBackColor = true;
            // 
            // lblLoaibaocao
            // 
            lblLoaibaocao.AutoSize = true;
            lblLoaibaocao.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoaibaocao.Location = new Point(12, 25);
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
            panel_1.Controls.Add(btnBCXuatkho);
            panel_1.Controls.Add(button6);
            panel_1.Location = new Point(-6, -1);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(946, 58);
            panel_1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(31, 10);
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
            button1.Location = new Point(755, 429);
            button1.Name = "button1";
            button1.Size = new Size(132, 35);
            button1.TabIndex = 5;
            button1.Text = "Xuất báo cáo";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnBCXuatkho
            // 
            btnBCXuatkho.FlatStyle = FlatStyle.System;
            btnBCXuatkho.Location = new Point(480, 26);
            btnBCXuatkho.Name = "btnBCXuatkho";
            btnBCXuatkho.Size = new Size(239, 23);
            btnBCXuatkho.TabIndex = 2;
            btnBCXuatkho.Text = "Báo cáo thời gian giao hàng trung bình";
            btnBCXuatkho.UseVisualStyleBackColor = true;
            // 
            // FormBaocao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(934, 476);
            Controls.Add(button1);
            Controls.Add(panel_1);
            Controls.Add(panel_2);
            Name = "FormBaocao";
            Text = "FormBaocao";
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
        private Button btnBCNhapkho;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label lblBaocaonhapkho;
        private Button button1;
        private Label label1;
        private Button btnBCXuatkho;
    }
}