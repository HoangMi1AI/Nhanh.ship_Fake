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
            groupBoxQuanLyDonHang = new GroupBox();
            btnTimKiem = new Button();
            txtNhapMaDonHang = new TextBox();
            tabControlQuanLyDonHang = new TabControl();
            tabPageDonHangTimKiem = new TabPage();
            btnHuyDonHang = new Button();
            btnKhieuNai = new Button();
            dgvDonHangTimKiem = new DataGridView();
            tabPageDaTaoDon = new TabPage();
            btnTabDXL = new Button();
            txtTabDXL = new TextBox();
            dgvTabDXL = new DataGridView();
            tabPageDangXuLy = new TabPage();
            tabPageDangVanChuyen = new TabPage();
            btnTabDVC = new Button();
            txtTabDVC = new TextBox();
            dgvTabDVC = new DataGridView();
            tabPageDangGiaoHang = new TabPage();
            btnTabDGH = new Button();
            txtTabDGH = new TextBox();
            dgvTabDGH = new DataGridView();
            tabPageDaGiaoHang = new TabPage();
            btnTabDaGH = new Button();
            txtTabDaGH = new TextBox();
            dgvTabDaGH = new DataGridView();
            tabPageTraHang = new TabPage();
            btnTabTH = new Button();
            txtTabTH = new TextBox();
            dgvTabTH = new DataGridView();
            tabPageKhieuNai = new TabPage();
            btnTabKN = new Button();
            txtTabKN = new TextBox();
            dgvTabKN = new DataGridView();
            tabPageHoanTat = new TabPage();
            btnTabHT = new Button();
            txtTabHT = new TextBox();
            dgvTabHT = new DataGridView();
            btnDTD = new Button();
            txtDTD = new TextBox();
            dgvDTD = new DataGridView();
            groupBoxQuanLyDonHang.SuspendLayout();
            tabControlQuanLyDonHang.SuspendLayout();
            tabPageDonHangTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonHangTimKiem).BeginInit();
            tabPageDaTaoDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabDXL).BeginInit();
            tabPageDangXuLy.SuspendLayout();
            tabPageDangVanChuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabDVC).BeginInit();
            tabPageDangGiaoHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabDGH).BeginInit();
            tabPageDaGiaoHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabDaGH).BeginInit();
            tabPageTraHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabTH).BeginInit();
            tabPageKhieuNai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabKN).BeginInit();
            tabPageHoanTat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabHT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDTD).BeginInit();
            SuspendLayout();
            // 
            // groupBoxQuanLyDonHang
            // 
            groupBoxQuanLyDonHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxQuanLyDonHang.Controls.Add(btnTimKiem);
            groupBoxQuanLyDonHang.Controls.Add(txtNhapMaDonHang);
            groupBoxQuanLyDonHang.Controls.Add(tabControlQuanLyDonHang);
            groupBoxQuanLyDonHang.Font = new Font("Segoe UI", 12F);
            groupBoxQuanLyDonHang.Location = new Point(38, 12);
            groupBoxQuanLyDonHang.Name = "groupBoxQuanLyDonHang";
            groupBoxQuanLyDonHang.Size = new Size(1074, 644);
            groupBoxQuanLyDonHang.TabIndex = 0;
            groupBoxQuanLyDonHang.TabStop = false;
            groupBoxQuanLyDonHang.Text = "Quản lý Đơn hàng";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(128, 128, 255);
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(499, 50);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(136, 43);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtNhapMaDonHang
            // 
            txtNhapMaDonHang.ForeColor = Color.Gray;
            txtNhapMaDonHang.Location = new Point(35, 50);
            txtNhapMaDonHang.Name = "txtNhapMaDonHang";
            txtNhapMaDonHang.Size = new Size(385, 39);
            txtNhapMaDonHang.TabIndex = 4;
            txtNhapMaDonHang.Text = "Nhập mã đơn hàng";
            // 
            // tabControlQuanLyDonHang
            // 
            tabControlQuanLyDonHang.Controls.Add(tabPageDonHangTimKiem);
            tabControlQuanLyDonHang.Controls.Add(tabPageDaTaoDon);
            tabControlQuanLyDonHang.Controls.Add(tabPageDangXuLy);
            tabControlQuanLyDonHang.Controls.Add(tabPageDangVanChuyen);
            tabControlQuanLyDonHang.Controls.Add(tabPageDangGiaoHang);
            tabControlQuanLyDonHang.Controls.Add(tabPageDaGiaoHang);
            tabControlQuanLyDonHang.Controls.Add(tabPageTraHang);
            tabControlQuanLyDonHang.Controls.Add(tabPageKhieuNai);
            tabControlQuanLyDonHang.Controls.Add(tabPageHoanTat);
            tabControlQuanLyDonHang.Font = new Font("Segoe UI", 10F);
            tabControlQuanLyDonHang.Location = new Point(28, 116);
            tabControlQuanLyDonHang.Multiline = true;
            tabControlQuanLyDonHang.Name = "tabControlQuanLyDonHang";
            tabControlQuanLyDonHang.SelectedIndex = 0;
            tabControlQuanLyDonHang.Size = new Size(1030, 522);
            tabControlQuanLyDonHang.TabIndex = 2;
            // 
            // tabPageDonHangTimKiem
            // 
            tabPageDonHangTimKiem.Controls.Add(btnHuyDonHang);
            tabPageDonHangTimKiem.Controls.Add(btnKhieuNai);
            tabPageDonHangTimKiem.Controls.Add(dgvDonHangTimKiem);
            tabPageDonHangTimKiem.Location = new Point(4, 70);
            tabPageDonHangTimKiem.Name = "tabPageDonHangTimKiem";
            tabPageDonHangTimKiem.Size = new Size(1022, 448);
            tabPageDonHangTimKiem.TabIndex = 2;
            tabPageDonHangTimKiem.Text = "Đơn hàng tìm kiếm";
            tabPageDonHangTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnHuyDonHang
            // 
            btnHuyDonHang.BackColor = Color.FromArgb(128, 128, 255);
            btnHuyDonHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyDonHang.ForeColor = Color.White;
            btnHuyDonHang.Location = new Point(244, 390);
            btnHuyDonHang.Name = "btnHuyDonHang";
            btnHuyDonHang.Size = new Size(187, 43);
            btnHuyDonHang.TabIndex = 7;
            btnHuyDonHang.Text = "Hủy đơn hàng";
            btnHuyDonHang.UseVisualStyleBackColor = false;
            // 
            // btnKhieuNai
            // 
            btnKhieuNai.BackColor = Color.FromArgb(128, 128, 255);
            btnKhieuNai.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhieuNai.ForeColor = Color.White;
            btnKhieuNai.Location = new Point(28, 390);
            btnKhieuNai.Name = "btnKhieuNai";
            btnKhieuNai.Size = new Size(136, 43);
            btnKhieuNai.TabIndex = 6;
            btnKhieuNai.Text = "Khiếu nại";
            btnKhieuNai.UseVisualStyleBackColor = false;
            // 
            // dgvDonHangTimKiem
            // 
            dgvDonHangTimKiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHangTimKiem.Location = new Point(3, 3);
            dgvDonHangTimKiem.Name = "dgvDonHangTimKiem";
            dgvDonHangTimKiem.RowHeadersWidth = 62;
            dgvDonHangTimKiem.Size = new Size(1016, 376);
            dgvDonHangTimKiem.TabIndex = 0;
            // 
            // tabPageDaTaoDon
            // 
            tabPageDaTaoDon.AutoScroll = true;
            tabPageDaTaoDon.Controls.Add(btnDTD);
            tabPageDaTaoDon.Controls.Add(txtDTD);
            tabPageDaTaoDon.Controls.Add(dgvDTD);
            tabPageDaTaoDon.Location = new Point(4, 70);
            tabPageDaTaoDon.Name = "tabPageDaTaoDon";
            tabPageDaTaoDon.Size = new Size(1022, 448);
            tabPageDaTaoDon.TabIndex = 4;
            tabPageDaTaoDon.Text = "Đã tạo đơn";
            tabPageDaTaoDon.UseVisualStyleBackColor = true;
            // 
            // btnTabDXL
            // 
            btnTabDXL.BackColor = Color.FromArgb(128, 128, 255);
            btnTabDXL.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabDXL.ForeColor = Color.White;
            btnTabDXL.Location = new Point(467, 13);
            btnTabDXL.Name = "btnTabDXL";
            btnTabDXL.Size = new Size(136, 43);
            btnTabDXL.TabIndex = 3;
            btnTabDXL.Text = "Tìm kiếm";
            btnTabDXL.UseVisualStyleBackColor = false;
            // 
            // txtTabDXL
            // 
            txtTabDXL.ForeColor = Color.Gray;
            txtTabDXL.Location = new Point(32, 17);
            txtTabDXL.Name = "txtTabDXL";
            txtTabDXL.Size = new Size(385, 34);
            txtTabDXL.TabIndex = 2;
            txtTabDXL.Text = "Nhập mã đơn hàng";
            // 
            // dgvTabDXL
            // 
            dgvTabDXL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabDXL.Location = new Point(3, 82);
            dgvTabDXL.Name = "dgvTabDXL";
            dgvTabDXL.RowHeadersWidth = 62;
            dgvTabDXL.Size = new Size(1016, 363);
            dgvTabDXL.TabIndex = 1;
            // 
            // tabPageDangXuLy
            // 
            tabPageDangXuLy.AutoScroll = true;
            tabPageDangXuLy.Controls.Add(btnTabDXL);
            tabPageDangXuLy.Controls.Add(txtTabDXL);
            tabPageDangXuLy.Controls.Add(dgvTabDXL);
            tabPageDangXuLy.Location = new Point(4, 70);
            tabPageDangXuLy.Name = "tabPageDangXuLy";
            tabPageDangXuLy.Size = new Size(1022, 448);
            tabPageDangXuLy.TabIndex = 3;
            tabPageDangXuLy.Text = "Đang xử lý";
            tabPageDangXuLy.UseVisualStyleBackColor = true;
            // 
            // tabPageDangVanChuyen
            // 
            tabPageDangVanChuyen.Controls.Add(btnTabDVC);
            tabPageDangVanChuyen.Controls.Add(txtTabDVC);
            tabPageDangVanChuyen.Controls.Add(dgvTabDVC);
            tabPageDangVanChuyen.Location = new Point(4, 70);
            tabPageDangVanChuyen.Name = "tabPageDangVanChuyen";
            tabPageDangVanChuyen.Size = new Size(1022, 448);
            tabPageDangVanChuyen.TabIndex = 5;
            tabPageDangVanChuyen.Text = "Đang vận chuyển";
            tabPageDangVanChuyen.UseVisualStyleBackColor = true;
            // 
            // btnTabDVC
            // 
            btnTabDVC.BackColor = Color.FromArgb(128, 128, 255);
            btnTabDVC.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabDVC.ForeColor = Color.White;
            btnTabDVC.Location = new Point(467, 13);
            btnTabDVC.Name = "btnTabDVC";
            btnTabDVC.Size = new Size(136, 43);
            btnTabDVC.TabIndex = 6;
            btnTabDVC.Text = "Tìm kiếm";
            btnTabDVC.UseVisualStyleBackColor = false;
            // 
            // txtTabDVC
            // 
            txtTabDVC.ForeColor = Color.Gray;
            txtTabDVC.Location = new Point(32, 17);
            txtTabDVC.Name = "txtTabDVC";
            txtTabDVC.Size = new Size(385, 34);
            txtTabDVC.TabIndex = 5;
            txtTabDVC.Text = "Nhập mã đơn hàng";
            // 
            // dgvTabDVC
            // 
            dgvTabDVC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabDVC.Location = new Point(3, 82);
            dgvTabDVC.Name = "dgvTabDVC";
            dgvTabDVC.RowHeadersWidth = 62;
            dgvTabDVC.Size = new Size(1016, 381);
            dgvTabDVC.TabIndex = 4;
            // 
            // tabPageDangGiaoHang
            // 
            tabPageDangGiaoHang.Controls.Add(btnTabDGH);
            tabPageDangGiaoHang.Controls.Add(txtTabDGH);
            tabPageDangGiaoHang.Controls.Add(dgvTabDGH);
            tabPageDangGiaoHang.Location = new Point(4, 70);
            tabPageDangGiaoHang.Name = "tabPageDangGiaoHang";
            tabPageDangGiaoHang.Size = new Size(1022, 448);
            tabPageDangGiaoHang.TabIndex = 6;
            tabPageDangGiaoHang.Text = "Đang giao hàng";
            tabPageDangGiaoHang.UseVisualStyleBackColor = true;
            // 
            // btnTabDGH
            // 
            btnTabDGH.BackColor = Color.FromArgb(128, 128, 255);
            btnTabDGH.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabDGH.ForeColor = Color.White;
            btnTabDGH.Location = new Point(467, 13);
            btnTabDGH.Name = "btnTabDGH";
            btnTabDGH.Size = new Size(136, 43);
            btnTabDGH.TabIndex = 6;
            btnTabDGH.Text = "Tìm kiếm";
            btnTabDGH.UseVisualStyleBackColor = false;
            // 
            // txtTabDGH
            // 
            txtTabDGH.ForeColor = Color.Gray;
            txtTabDGH.Location = new Point(32, 17);
            txtTabDGH.Name = "txtTabDGH";
            txtTabDGH.Size = new Size(385, 34);
            txtTabDGH.TabIndex = 5;
            txtTabDGH.Text = "Nhập mã đơn hàng";
            // 
            // dgvTabDGH
            // 
            dgvTabDGH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabDGH.Location = new Point(3, 82);
            dgvTabDGH.Name = "dgvTabDGH";
            dgvTabDGH.RowHeadersWidth = 62;
            dgvTabDGH.Size = new Size(1016, 381);
            dgvTabDGH.TabIndex = 4;
            // 
            // tabPageDaGiaoHang
            // 
            tabPageDaGiaoHang.Controls.Add(btnTabDaGH);
            tabPageDaGiaoHang.Controls.Add(txtTabDaGH);
            tabPageDaGiaoHang.Controls.Add(dgvTabDaGH);
            tabPageDaGiaoHang.Location = new Point(4, 70);
            tabPageDaGiaoHang.Name = "tabPageDaGiaoHang";
            tabPageDaGiaoHang.Size = new Size(1022, 448);
            tabPageDaGiaoHang.TabIndex = 7;
            tabPageDaGiaoHang.Text = "Đã giao hàng";
            tabPageDaGiaoHang.UseVisualStyleBackColor = true;
            // 
            // btnTabDaGH
            // 
            btnTabDaGH.BackColor = Color.FromArgb(128, 128, 255);
            btnTabDaGH.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabDaGH.ForeColor = Color.White;
            btnTabDaGH.Location = new Point(467, 13);
            btnTabDaGH.Name = "btnTabDaGH";
            btnTabDaGH.Size = new Size(136, 43);
            btnTabDaGH.TabIndex = 6;
            btnTabDaGH.Text = "Tìm kiếm";
            btnTabDaGH.UseVisualStyleBackColor = false;
            // 
            // txtTabDaGH
            // 
            txtTabDaGH.ForeColor = Color.Gray;
            txtTabDaGH.Location = new Point(32, 17);
            txtTabDaGH.Name = "txtTabDaGH";
            txtTabDaGH.Size = new Size(385, 34);
            txtTabDaGH.TabIndex = 5;
            txtTabDaGH.Text = "Nhập mã đơn hàng";
            // 
            // dgvTabDaGH
            // 
            dgvTabDaGH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabDaGH.Location = new Point(3, 82);
            dgvTabDaGH.Name = "dgvTabDaGH";
            dgvTabDaGH.RowHeadersWidth = 62;
            dgvTabDaGH.Size = new Size(1016, 381);
            dgvTabDaGH.TabIndex = 4;
            // 
            // tabPageTraHang
            // 
            tabPageTraHang.Controls.Add(btnTabTH);
            tabPageTraHang.Controls.Add(txtTabTH);
            tabPageTraHang.Controls.Add(dgvTabTH);
            tabPageTraHang.Location = new Point(4, 70);
            tabPageTraHang.Name = "tabPageTraHang";
            tabPageTraHang.Size = new Size(1022, 448);
            tabPageTraHang.TabIndex = 8;
            tabPageTraHang.Text = "Trả hàng";
            tabPageTraHang.UseVisualStyleBackColor = true;
            // 
            // btnTabTH
            // 
            btnTabTH.BackColor = Color.FromArgb(128, 128, 255);
            btnTabTH.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabTH.ForeColor = Color.White;
            btnTabTH.Location = new Point(467, 13);
            btnTabTH.Name = "btnTabTH";
            btnTabTH.Size = new Size(136, 43);
            btnTabTH.TabIndex = 6;
            btnTabTH.Text = "Tìm kiếm";
            btnTabTH.UseVisualStyleBackColor = false;
            // 
            // txtTabTH
            // 
            txtTabTH.ForeColor = Color.Gray;
            txtTabTH.Location = new Point(32, 17);
            txtTabTH.Name = "txtTabTH";
            txtTabTH.Size = new Size(385, 34);
            txtTabTH.TabIndex = 5;
            txtTabTH.Text = "Nhập mã đơn hàng";
            // 
            // dgvTabTH
            // 
            dgvTabTH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabTH.Location = new Point(3, 82);
            dgvTabTH.Name = "dgvTabTH";
            dgvTabTH.RowHeadersWidth = 62;
            dgvTabTH.Size = new Size(1016, 381);
            dgvTabTH.TabIndex = 4;
            // 
            // tabPageKhieuNai
            // 
            tabPageKhieuNai.Controls.Add(btnTabKN);
            tabPageKhieuNai.Controls.Add(txtTabKN);
            tabPageKhieuNai.Controls.Add(dgvTabKN);
            tabPageKhieuNai.Location = new Point(4, 70);
            tabPageKhieuNai.Name = "tabPageKhieuNai";
            tabPageKhieuNai.Size = new Size(1022, 448);
            tabPageKhieuNai.TabIndex = 9;
            tabPageKhieuNai.Text = "Khiếu nại";
            tabPageKhieuNai.UseVisualStyleBackColor = true;
            // 
            // btnTabKN
            // 
            btnTabKN.BackColor = Color.FromArgb(128, 128, 255);
            btnTabKN.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabKN.ForeColor = Color.White;
            btnTabKN.Location = new Point(467, 13);
            btnTabKN.Name = "btnTabKN";
            btnTabKN.Size = new Size(136, 43);
            btnTabKN.TabIndex = 6;
            btnTabKN.Text = "Tìm kiếm";
            btnTabKN.UseVisualStyleBackColor = false;
            // 
            // txtTabKN
            // 
            txtTabKN.ForeColor = Color.Gray;
            txtTabKN.Location = new Point(32, 17);
            txtTabKN.Name = "txtTabKN";
            txtTabKN.Size = new Size(385, 34);
            txtTabKN.TabIndex = 5;
            txtTabKN.Text = "Nhập mã đơn hàng";
            // 
            // dgvTabKN
            // 
            dgvTabKN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabKN.Location = new Point(3, 82);
            dgvTabKN.Name = "dgvTabKN";
            dgvTabKN.RowHeadersWidth = 62;
            dgvTabKN.Size = new Size(1016, 381);
            dgvTabKN.TabIndex = 4;
            // 
            // tabPageHoanTat
            // 
            tabPageHoanTat.Controls.Add(btnTabHT);
            tabPageHoanTat.Controls.Add(txtTabHT);
            tabPageHoanTat.Controls.Add(dgvTabHT);
            tabPageHoanTat.Location = new Point(4, 70);
            tabPageHoanTat.Name = "tabPageHoanTat";
            tabPageHoanTat.Size = new Size(1022, 448);
            tabPageHoanTat.TabIndex = 10;
            tabPageHoanTat.Text = "Hoàn tất";
            tabPageHoanTat.UseVisualStyleBackColor = true;
            // 
            // btnTabHT
            // 
            btnTabHT.BackColor = Color.FromArgb(128, 128, 255);
            btnTabHT.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabHT.ForeColor = Color.White;
            btnTabHT.Location = new Point(467, 13);
            btnTabHT.Name = "btnTabHT";
            btnTabHT.Size = new Size(136, 43);
            btnTabHT.TabIndex = 6;
            btnTabHT.Text = "Tìm kiếm";
            btnTabHT.UseVisualStyleBackColor = false;
            // 
            // txtTabHT
            // 
            txtTabHT.ForeColor = Color.Gray;
            txtTabHT.Location = new Point(32, 17);
            txtTabHT.Name = "txtTabHT";
            txtTabHT.Size = new Size(385, 34);
            txtTabHT.TabIndex = 5;
            txtTabHT.Text = "Nhập mã đơn hàng";
            // 
            // dgvTabHT
            // 
            dgvTabHT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabHT.Location = new Point(3, 82);
            dgvTabHT.Name = "dgvTabHT";
            dgvTabHT.RowHeadersWidth = 62;
            dgvTabHT.Size = new Size(1016, 381);
            dgvTabHT.TabIndex = 4;
            // 
            // btnDTD
            // 
            btnDTD.BackColor = Color.FromArgb(128, 128, 255);
            btnDTD.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDTD.ForeColor = Color.White;
            btnDTD.Location = new Point(467, 13);
            btnDTD.Name = "btnDTD";
            btnDTD.Size = new Size(136, 43);
            btnDTD.TabIndex = 6;
            btnDTD.Text = "Tìm kiếm";
            btnDTD.UseVisualStyleBackColor = false;
            // 
            // txtDTD
            // 
            txtDTD.ForeColor = Color.Gray;
            txtDTD.Location = new Point(32, 17);
            txtDTD.Name = "txtDTD";
            txtDTD.Size = new Size(385, 34);
            txtDTD.TabIndex = 5;
            txtDTD.Text = "Nhập mã đơn hàng";
            // 
            // dgvDTD
            // 
            dgvDTD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDTD.Location = new Point(3, 82);
            dgvDTD.Name = "dgvDTD";
            dgvDTD.RowHeadersWidth = 62;
            dgvDTD.Size = new Size(1016, 363);
            dgvDTD.TabIndex = 4;
            // 
            // FormQuanLyDonHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 668);
            Controls.Add(groupBoxQuanLyDonHang);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormQuanLyDonHang";
            Text = "FormQuanLyDonHang";
            groupBoxQuanLyDonHang.ResumeLayout(false);
            groupBoxQuanLyDonHang.PerformLayout();
            tabControlQuanLyDonHang.ResumeLayout(false);
            tabPageDonHangTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDonHangTimKiem).EndInit();
            tabPageDaTaoDon.ResumeLayout(false);
            tabPageDaTaoDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabDXL).EndInit();
            tabPageDangXuLy.ResumeLayout(false);
            tabPageDangXuLy.PerformLayout();
            tabPageDangVanChuyen.ResumeLayout(false);
            tabPageDangVanChuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabDVC).EndInit();
            tabPageDangGiaoHang.ResumeLayout(false);
            tabPageDangGiaoHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabDGH).EndInit();
            tabPageDaGiaoHang.ResumeLayout(false);
            tabPageDaGiaoHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabDaGH).EndInit();
            tabPageTraHang.ResumeLayout(false);
            tabPageTraHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabTH).EndInit();
            tabPageKhieuNai.ResumeLayout(false);
            tabPageKhieuNai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabKN).EndInit();
            tabPageHoanTat.ResumeLayout(false);
            tabPageHoanTat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabHT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDTD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxQuanLyDonHang;
        private TabControl tabControlQuanLyDonHang;
        private TabPage tabPageDonHangTimKiem;
        private TabPage tabPageDangXuLy;
        private TabPage tabPageDaTaoDon;
        private TabPage tabPageDangVanChuyen;
        private TabPage tabPageDangGiaoHang;
        private TabPage tabPageDaGiaoHang;
        private TabPage tabPageTraHang;
        private TabPage tabPageKhieuNai;
        private TabPage tabPageDaHoanHang;
        private TabPage tabPageHoanTat; 
        private DataGridView dgvTabDVC;
        private DataGridView dgvTabKN;
        private DataGridView dgvDonHangTimKiem;
        private DataGridView dgvTabDXL;
        private DataGridView dgvTabHT;
        private DataGridView dgvTabDGH;
        private DataGridView dgvTabTH;
        private DataGridView dgvTabDaGH;
        private Button btnTabDXL;
        private Button btnTimKiem;
        private Button btnTabDVC;
        private Button btnTabDGH;
        private Button btnTabDaGH;
        private Button btnTabTH;
        private Button btnTabKN;
        private Button btnTabHT;
        private Button btnKhieuNai;
        private Button btnHuyDonHang;
        private TextBox txtTabDXL;
        private TextBox txtTabKN;
        private TextBox txtTabHT;
        private TextBox txtTabDVC;
        private TextBox textBoxTabDXL;
        private TextBox txtNhapMaDonHang;
        private TextBox txtTabDGH;
        private TextBox txtTabDaGH;
        private TextBox txtTabTH;
        private Button btnDTD;
        private TextBox txtDTD;
        private DataGridView dgvDTD;
    }
}