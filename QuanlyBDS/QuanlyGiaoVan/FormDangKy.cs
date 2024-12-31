using QuanlyBDS;

namespace QuanlyGiaoVan
{
    public partial class FormDangKy : Form
    {
        //private Class_userDB userDB = new Class_userDB();
        private Class_Diachi classDiachi;
        public FormDangKy()
        {
            InitializeComponent();

            classDiachi = new Class_Diachi();
            classDiachi.LoadProvinces(cboUserProvinces);

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
        private void cboProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUserProvinces.SelectedValue != null)
            {
                string provinceCode = cboUserProvinces.SelectedValue.ToString();
                classDiachi.LoadDistricts(cbUserDistricts, provinceCode); // Tải huyện theo tỉnh đã chọn

            }
        }
        private void cboDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUserDistricts.SelectedValue != null)
            {
                string district_code = cbUserDistricts.SelectedValue.ToString();
                classDiachi.LoadXa(cboUserXa, district_code); // Tải xa theo tỉnh đã chọn
            }
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

        private void myButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnDangKi_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox> { txtDiaChiNguoiNhan, txtMail, txtMK, txtNhapLaiMK, txtSDT, txtTen, txtTK };
            List<ComboBox> comboBoxes = new List<ComboBox> { cboUserProvinces, cboUserXa, cbUserDistricts };

            // Kiểm tra các TextBox
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin vào các ô TextBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Ngừng thực hiện nếu có TextBox trống
                }
            }

            // Kiểm tra các ComboBox
            foreach (var comboBox in comboBoxes)
            {
                if (comboBox.SelectedIndex == -1) // Hoặc comboBox.SelectedItem == null
                {
                    MessageBox.Show("Vui lòng chọn giá trị trong ComboBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Ngừng thực hiện nếu có ComboBox chưa chọn
                }
            }




            // Kiểm tra mật khẩu nhập lại
            if (txtMK.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ các ô nhập liệu
            string username = txtTK.Text;
            string password = txtMK.Text;
            string confirmPassword = txtNhapLaiMK.Text;
            string fullName = txtTen.Text;
            string email = txtMail.Text;
            string phone = txtSDT.Text;
            string address = txtDiaChiNguoiNhan.Text;
            string province = cboUserProvinces.Text;
            string district = cbUserDistricts.Text;
            string ward = cboUserXa.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và mật khẩu nhập lại không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Class_userDB userDB = new Class_userDB();
            if (userDB.AddUser(username, password, fullName, email, phone, address, province, district, ward))
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc email đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
