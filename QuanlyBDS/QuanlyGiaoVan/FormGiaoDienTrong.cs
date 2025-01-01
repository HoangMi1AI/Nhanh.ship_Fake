namespace QuanlyGiaoVan
{
    public partial class FormGiaoDienTrong : Form
    {
        public FormGiaoDienTrong()
        {
            InitializeComponent();

            NoBorderButton myButton = new NoBorderButton
            {
                Location = new Point(20, 20),
                Size = new Size(100, 50),
                BackColor = Color.LightBlue,
                Text = "Click Me"
            };

            Controls.Add(myButton);

            RoundPanel roundPanel = new RoundPanel
            {
                CornerRadiusTopLeft = 10,
                CornerRadiusTopRight = 30,
                CornerRadiusBottomLeft = 0,
                CornerRadiusBottomRight = 20,
                BorderColor = Color.Blue,
                BorderThickness = 2f,
                BackColor = Color.LightGray,
                Size = new Size(200, 150),
                Location = new Point(50, 50)
            };
            Controls.Add(roundPanel);
            CirclePanel circlePanel = new CirclePanel
            {
                Size = new Size(200, 200), // Kích thước hình tròn
                Location = new Point(20, 20), // Vị trí trên Form
                CircleColor = Color.Gray // Đổi màu bên trong hình tròn
            };

            //circlePanel.CircleImage = Image.FromFile("Image/user.png");

            Controls.Add(circlePanel);

        }




        private void FormGiaoDienNgoai_Load(object sender, EventArgs e)
        {

        }

        private void circlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circlePanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void roundPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tra_Cuoc_Click(object sender, EventArgs e)
        {

            // Tạo một instance của FormTraCuoc
            FormTraCuoc formTra_cuoc = new FormTraCuoc();

            // Đăng ký sự kiện FormClosed cho FormTraCuoc
            formTra_cuoc.FormClosed += (s, args) =>
            {
                // Hiển thị lại FormGiaoHang2
                this.Show();
            };

            // Hiển thị FormTraCuoc
            formTra_cuoc.Show();

            // Ẩn FormGiaoHang2
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            // Tạo một instance của formtaodon
            FormTaoDonHang formTaoDonHang = new FormTaoDonHang();

            // Đăng ký sự kiện FormClosed cho FormTraCuoc
            formTaoDonHang.FormClosed += (s, args) =>
            {

                this.Show();

            };

            // Hiển thị FormTraCuoc
            formTaoDonHang.Show();

            // Ẩn FormGiaoHang2
            this.Hide();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
              
                FormGiaoDienNgoai formGiaoDienNgoai = new FormGiaoDienNgoai();
                formGiaoDienNgoai.Show();
                this.Close(); // Đóng form chính sau khi thoát
            }
        }
    }
}
