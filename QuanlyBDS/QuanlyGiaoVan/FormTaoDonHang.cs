using QuanlyBDS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanlyGiaoVan
{
    public partial class FormTaoDonHang : Form
    {
        private Class_Diachi classDiachi;
        private OrdersData _ordersData;
        public FormTaoDonHang()
        {
            InitializeComponent();
            classDiachi = new Class_Diachi();
            classDiachi.LoadProvinces(cbBox_to_province); // Tải danh sách tỉnh người gửi
        }


        private void cboProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_to_province.SelectedValue != null)
            {
                string provinceCode = cbBox_to_province.SelectedValue.ToString();
                classDiachi.LoadDistricts(cbBox_to_district, provinceCode); // Tải huyện theo tỉnh đã chọn

            }
        }
        private void cboDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_to_district.SelectedValue != null)
            {
                string district_code = cbBox_to_district.SelectedValue.ToString();
                classDiachi.LoadXa(cbBox_to_ward, district_code); // Tải xa theo tỉnh đã chọn
            }
        }
        //private void thoigian_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbThoigianhenlay.Text != "")
        //    {
        //        LBthoigianhenlay.Visible = true;
        //    }
        //}

        private void btnNextpageTaoDon_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các TextBox và ComboBox cần kiểm tra
            List<System.Windows.Forms.TextBox> textBoxes = new List<System.Windows.Forms.TextBox> {
                txtBox_to_address, txtBox_to_name, txtBox_to_number, txtBox_name_order, txtBox_weight, txtBox_value };
            List<System.Windows.Forms.ComboBox> comboBoxes = new List<System.Windows.Forms.ComboBox> { cbBox_to_province, cbBox_to_district, cbBox_to_ward };

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

            // Kiểm tra nhóm RadioButton trong GroupBox
            bool isRadioButtonChecked = gbTThangHoa.Controls.OfType<System.Windows.Forms.RadioButton>().Any(r => r.Checked);
            if (!isRadioButtonChecked)
            {
                MessageBox.Show("Vui lòng chọn một tùy chọn trong RadioButton!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Ngừng thực hiện nếu không có RadioButton nào được chọn
            }
            _ordersData = new OrdersData
            {
                UserId = 1,  // Example, this could come from the logged-in user
                OrderCode = 12345,
                ToName = txtBox_to_name.Text,
                ToPhone = txtBox_to_number.Text,
                ToAddress = txtBox_to_address.Text,
                ToWardName = cbBox_to_ward.SelectedItem.ToString(),
                ToDistrictName = cbBox_to_district.SelectedItem.ToString(),
                ToDistrictId = 1,  // Example district ID
                FromDistrictId = 202,  // Example district ID
            };

            if (radioBtn_khong_xem.Checked)
            {
                _ordersData.RequiredNote = "KHONGCHOXEMHANG";
            }
            else if (radioBtn_cho_xem_khong_thu.Checked)
            {
                _ordersData.RequiredNote = "CHOXEMHANGKHONGTHU";
            }
            else if (radioBtn_cho_thu_hang.Checked)
            {
                _ordersData.RequiredNote = "CHOTHUHANG";
            }


            FormTaoDonHang2 formtaodonhang2 = new FormTaoDonHang2(_ordersData);

            // Hiển thị form tiếp theo
            formtaodonhang2.Show();

            // Đóng form hiện tại nếu cần
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormTaoDonHang_Load(object sender, EventArgs e)
        {

        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtn_Tailieu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
