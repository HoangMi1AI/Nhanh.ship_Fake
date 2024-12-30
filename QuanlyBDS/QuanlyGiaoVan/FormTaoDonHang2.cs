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
    public partial class FormTaoDonHang2 : Form
    {
        public FormTaoDonHang2()
        {
            InitializeComponent();
        }

        private void btnTraCuoc_Click(object sender, EventArgs e)
        {
            // Tạo một instance của form kế tiếp
            FormTraCuoc formTra_cuoc = new FormTraCuoc();

            // Hiển thị form tiếp theo
            formTra_cuoc.Show();

            // Đóng form hiện tại nếu cần
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<System.Windows.Forms.ComboBox> comboBoxes = new List<System.Windows.Forms.ComboBox> { cbDonViVanChuyen};

        

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
            bool isRadioButtonChecked = gbTienThuHo.Controls.OfType<RadioButton>().Any(r => r.Checked);
            if (!isRadioButtonChecked)
            {
                MessageBox.Show("Vui lòng chọn một tùy chọn trong RadioButton!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Ngừng thực hiện nếu không có RadioButton nào được chọn
            }
        }
    }
}
