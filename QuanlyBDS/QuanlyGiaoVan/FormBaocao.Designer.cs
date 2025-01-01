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
            btnBCXuatkho = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            lblBaocaonhapkho = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btnBCNhapkho = new Button();
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
            lblBaocao.Location = new Point(99, 12);
            lblBaocao.Margin = new Padding(4, 0, 4, 0);
            lblBaocao.Name = "lblBaocao";
            lblBaocao.Size = new Size(195, 60);
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
            panel_2.Controls.Add(btnBCXuatkho);
            panel_2.Controls.Add(comboBox2);
            panel_2.Controls.Add(comboBox1);
            panel_2.Controls.Add(lblBaocaonhapkho);
            panel_2.Controls.Add(button5);
            panel_2.Controls.Add(button4);
            panel_2.Controls.Add(button3);
            panel_2.Controls.Add(btnBCNhapkho);
            panel_2.Controls.Add(lblLoaibaocao);
            panel_2.Location = new Point(17, 127);
            panel_2.Margin = new Padding(4, 5, 4, 5);
            panel_2.Name = "panel_2";
            panel_2.Size = new Size(1382, 632);
            panel_2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 190);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1330, 412);
            dataGridView1.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(700, 117);
            comboBox3.Margin = new Padding(4, 5, 4, 5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(200, 33);
            comboBox3.TabIndex = 10;
            comboBox3.Text = "Tùy chỉnh cột:";
            // 
            // btnBCXuatkho
            // 
            btnBCXuatkho.FlatStyle = FlatStyle.System;
            btnBCXuatkho.Location = new Point(1127, 47);
            btnBCXuatkho.Margin = new Padding(4, 5, 4, 5);
            btnBCXuatkho.Name = "btnBCXuatkho";
            btnBCXuatkho.Size = new Size(246, 35);
            btnBCXuatkho.TabIndex = 2;
            btnBCXuatkho.Text = "Thời gian giao hàng trung bình";
            btnBCXuatkho.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(459, 117);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 33);
            comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tất cả", "Kho 1", "Kho 2" });
            comboBox1.Location = new Point(211, 117);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 33);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Kho:";
            // 
            // lblBaocaonhapkho
            // 
            lblBaocaonhapkho.AutoSize = true;
            lblBaocaonhapkho.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaocaonhapkho.Location = new Point(4, 113);
            lblBaocaonhapkho.Margin = new Padding(4, 0, 4, 0);
            lblBaocaonhapkho.Name = "lblBaocaonhapkho";
            lblBaocaonhapkho.Size = new Size(202, 40);
            lblBaocaonhapkho.TabIndex = 7;
            lblBaocaonhapkho.Text = "Báo đơn hàng";
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.System;
            button5.Location = new Point(896, 45);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(223, 38);
            button5.TabIndex = 5;
            button5.Text = "Báo cáo tình hình thị trường";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Location = new Point(591, 45);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(296, 38);
            button4.TabIndex = 4;
            button4.Text = "Báo cáo hiệu suất đối tác vận chuyển";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(407, 47);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(176, 38);
            button3.TabIndex = 3;
            button3.Text = "Báo cáo tỉ lệ khiếu nại";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnBCNhapkho
            // 
            btnBCNhapkho.FlatStyle = FlatStyle.System;
            btnBCNhapkho.Location = new Point(194, 47);
            btnBCNhapkho.Margin = new Padding(4, 5, 4, 5);
            btnBCNhapkho.Name = "btnBCNhapkho";
            btnBCNhapkho.Size = new Size(230, 38);
            btnBCNhapkho.TabIndex = 1;
            btnBCNhapkho.Text = "Báo cáo số lượng đơn hàng";
            btnBCNhapkho.UseVisualStyleBackColor = true;
            btnBCNhapkho.Click += btnBCNhapkho_Click;
            // 
            // lblLoaibaocao
            // 
            lblLoaibaocao.AutoSize = true;
            lblLoaibaocao.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoaibaocao.Location = new Point(4, 42);
            lblLoaibaocao.Margin = new Padding(4, 0, 4, 0);
            lblLoaibaocao.Name = "lblLoaibaocao";
            lblLoaibaocao.Size = new Size(182, 40);
            lblLoaibaocao.TabIndex = 0;
            lblLoaibaocao.Text = "Loại báo cáo";
            // 
            // panel_1
            // 
            panel_1.BackColor = Color.White;
            panel_1.Controls.Add(label1);
            panel_1.Controls.Add(lblBaocao);
            panel_1.Location = new Point(-9, -2);
            panel_1.Margin = new Padding(4, 5, 4, 5);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(1446, 97);
            panel_1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(20, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 75);
            label1.TabIndex = 6;
            label1.Text = "       \r\n\r\n              ";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1189, 770);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(189, 58);
            button1.TabIndex = 5;
            button1.Text = "Xuất báo cáo";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormBaocao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1417, 853);
            Controls.Add(button1);
            Controls.Add(panel_1);
            Controls.Add(panel_2);
            Margin = new Padding(4, 5, 4, 5);
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