namespace QuanlyGiaoVan
{
    partial class FormQuanLyDonHang
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
            textBox1 = new TextBox();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(35, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1074, 609);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý Đơn hàng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(639, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 44);
            textBox1.TabIndex = 0;
            textBox1.Text = "Tìm kiếm";
            // 
            // button1
            // 
            button1.Location = new Point(842, 45);
            button1.Name = "button1";
            button1.Size = new Size(179, 44);
            button1.TabIndex = 1;
            button1.Text = "Tạo đơn hàng";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(28, 116);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1030, 454);
            tabControl1.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new Point(4, 37);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1022, 413);
            tabPage4.TabIndex = 2;
            tabPage4.Text = "Chờ bàn giao";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.AutoScroll = true;
            tabPage5.Location = new Point(4, 37);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1022, 339);
            tabPage5.TabIndex = 3;
            tabPage5.Text = "Đã bàn giao - đang giao";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 37);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1022, 339);
            tabPage6.TabIndex = 4;
            tabPage6.Text = "Đã bàn giao - đang hoàn hàng";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 37);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1022, 339);
            tabPage7.TabIndex = 5;
            tabPage7.Text = "Chờ xác nhận giao lại";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1022, 339);
            tabPage3.TabIndex = 6;
            tabPage3.Text = "Hoàn tất";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(952, 225);
            dataGridView1.TabIndex = 0;
            // 
            // FormQuanLyDonHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 668);
            Controls.Add(groupBox1);
            Name = "FormQuanLyDonHang";
            Text = "FormQuanLyDonHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
    }
}