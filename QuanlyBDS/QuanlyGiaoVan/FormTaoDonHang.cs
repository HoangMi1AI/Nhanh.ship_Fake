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

namespace QuanlyGiaoVan
{
    public partial class FormTaoDonHang : Form
    {
        private Class_Diachi classDiachi;
        public FormTaoDonHang()
        {
            InitializeComponent();
            classDiachi = new Class_Diachi();
            classDiachi.LoadProvinces(cboProvinces); // Tải danh sách tỉnh người gửi
        }


        private void cboProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvinces.SelectedValue != null)
            {
                string provinceCode = cboProvinces.SelectedValue.ToString();
                classDiachi.LoadDistricts(cboDistricts, provinceCode); // Tải huyện theo tỉnh đã chọn

            }
        }
        private void cboDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistricts.SelectedValue != null)
            {
                string district_code = cboDistricts.SelectedValue.ToString();
                classDiachi.LoadXa(cboXa, district_code); // Tải xa theo tỉnh đã chọn
            }
        }
        private void thoigian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThoigianhenlay.Text != "")
            {
                LBthoigianhenlay.Visible = true;
            }
        }

        private void btnNextpageTaoDon_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các TextBox và ComboBox cần kiểm tra
            List<System.Windows.Forms.TextBox> textBoxes = new List<System.Windows.Forms.TextBox> {txtDiaChiNguoiNhan, txtHoTenNguoiNhan,txtSDTnguoiNhan,txtTenHang1,txtTrongLuong1,txtGiaTri };
            List<System.Windows.Forms.ComboBox> comboBoxes = new List<System.Windows.Forms.ComboBox> {cboProvinces,cboDistricts,cboXa,cbThoigianhenlay ,cbTgHenGiao};

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
            bool isRadioButtonChecked = gbTThangHoa.Controls.OfType<RadioButton>().Any(r => r.Checked);
            if (!isRadioButtonChecked)
            {
                MessageBox.Show("Vui lòng chọn một tùy chọn trong RadioButton!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Ngừng thực hiện nếu không có RadioButton nào được chọn
            }

            // Kiểm tra ListBox
            if (LBthoigianhenlay.SelectedItems.Count == 0) // Hoặc listBox1.SelectedIndex == -1
            {
                MessageBox.Show("Vui lòng chọn ít nhất một mục trong ListBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Ngừng thực hiện nếu không có mục nào được chọn
            }
            // Tạo một instance của form kế tiếp
            FormTaoDonHang2 formtaodonhang2 = new FormTaoDonHang2();

            // Hiển thị form tiếp theo
            formtaodonhang2.Show();

            // Đóng form hiện tại nếu cần
            this.Hide();
        }
    }
}
