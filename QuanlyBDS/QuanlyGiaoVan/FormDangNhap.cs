using MySql.Data.MySqlClient;

namespace QuanlyGiaoVan
{
    public partial class FormDangNhap : Form
    {
        public bool CheckLoginStatus = false;
        private Class_userDB userDB = new Class_userDB();

        public FormDangNhap()
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

        private void btnDangNhap1_Click(object sender, EventArgs e)
        {
            string username = txtTK.Text;
            string password = txtMK.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Class_userDB userDB = new Class_userDB();
            if (userDB.CheckLogin(username, password))
            {
                CheckLoginStatus = true;
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormGiaoDienTrong formGiaoDienTrong = new FormGiaoDienTrong();
                formGiaoDienTrong.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
