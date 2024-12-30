namespace QuanlyGiaoVan
{
    partial class FormTra_cuoc
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
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(372, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(307, 32);
            label1.TabIndex = 0;
            label1.Text = "TRA CƯỚC VẬN CHUYỂN";
            // 
            // cboProvincesgui
            // 
            cboProvincesgui.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProvincesgui.FormattingEnabled = true;
            cboProvincesgui.Location = new Point(124, 130);
            cboProvincesgui.Margin = new Padding(2, 2, 2, 2);
            cboProvincesgui.Name = "cboProvincesgui";
            cboProvincesgui.Size = new Size(314, 36);
            cboProvincesgui.TabIndex = 1;
            cboProvincesgui.Text = "    - Tỉnh/Thành phố -";
            cboProvincesgui.SelectedIndexChanged += cboProvincesgui_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(310, 270);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(127, 36);
            button1.TabIndex = 2;
            button1.Text = "            gram";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 88);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 3;
            label2.Text = "Người gửi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(607, 88);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 4;
            label3.Text = "Người nhận";
            // 
            // cboDistrictsgui
            // 
            cboDistrictsgui.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDistrictsgui.FormattingEnabled = true;
            cboDistrictsgui.Location = new Point(124, 199);
            cboDistrictsgui.Margin = new Padding(2, 2, 2, 2);
            cboDistrictsgui.Name = "cboDistrictsgui";
            cboDistrictsgui.Size = new Size(314, 36);
            cboDistrictsgui.TabIndex = 7;
            cboDistrictsgui.Text = "    - Quận/Huyện -";
            // 
            // txtKL
            // 
            txtKL.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKL.Location = new Point(124, 271);
            txtKL.Margin = new Padding(2, 2, 2, 2);
            txtKL.Name = "txtKL";
            txtKL.PlaceholderText = "Khối lượng gói hàng";
            txtKL.Size = new Size(256, 34);
            txtKL.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 309);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(319, 20);
            label4.TabIndex = 11;
            label4.Text = "Tổng khối lượng các sản phẩm trong đơn hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(658, 309);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(265, 20);
            label5.TabIndex = 16;
            label5.Text = "Để trống nếu bạn không có tiền thu hộ";
            // 
            // txtTTH
            // 
            txtTTH.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTTH.Location = new Point(607, 273);
            txtTTH.Margin = new Padding(2, 2, 2, 2);
            txtTTH.Name = "txtTTH";
            txtTTH.PlaceholderText = "Tiền thu hộ";
            txtTTH.Size = new Size(256, 34);
            txtTTH.TabIndex = 15;
            // 
            // cboDistrictsnhan
            // 
            cboDistrictsnhan.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDistrictsnhan.FormattingEnabled = true;
            cboDistrictsnhan.Location = new Point(607, 199);
            cboDistrictsnhan.Margin = new Padding(2, 2, 2, 2);
            cboDistrictsnhan.Name = "cboDistrictsnhan";
            cboDistrictsnhan.Size = new Size(314, 36);
            cboDistrictsnhan.TabIndex = 14;
            cboDistrictsnhan.Text = "    - Quận/Huyện -";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(793, 270);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(127, 36);
            button2.TabIndex = 13;
            button2.Text = "            gram";
            button2.UseVisualStyleBackColor = true;
            // 
            // cboProvincesnhan
            // 
            cboProvincesnhan.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProvincesnhan.FormattingEnabled = true;
            cboProvincesnhan.Location = new Point(607, 130);
            cboProvincesnhan.Margin = new Padding(2, 2, 2, 2);
            cboProvincesnhan.Name = "cboProvincesnhan";
            cboProvincesnhan.Size = new Size(314, 36);
            cboProvincesnhan.TabIndex = 12;
            cboProvincesnhan.Text = "    - Tỉnh/Thành phố -";
            cboProvincesnhan.SelectedIndexChanged += cboProvincesnhan_SelectedIndexChanged;
            // 
            // btnTra
            // 
            btnTra.BackColor = Color.PaleGreen;
            btnTra.Location = new Point(461, 396);
            btnTra.Margin = new Padding(2, 2, 2, 2);
            btnTra.Name = "btnTra";
            btnTra.Size = new Size(127, 36);
            btnTra.TabIndex = 17;
            btnTra.Text = "Tra cước";
            btnTra.UseVisualStyleBackColor = false;
            btnTra.Click += btnCalculateFee_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGreen;
            button3.Location = new Point(735, 396);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(127, 36);
            button3.TabIndex = 19;
            button3.Text = "Tra cước";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 176);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(766, 339);
            dataGridView1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(337, 377);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(115, 36);
            button4.TabIndex = 1;
            button4.Text = "OK";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(951, 88);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 432);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // FormTra_cuoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 587);
            Controls.Add(button3);
            Controls.Add(panel1);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormTra_cuoc";
            Text = "Tra_cước";
            Load += Tra_cước_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
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
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Panel panel1;
    }
}