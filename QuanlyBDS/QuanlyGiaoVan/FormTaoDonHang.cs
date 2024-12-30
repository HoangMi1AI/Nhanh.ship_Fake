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
            // Tạo một instance của form kế tiếp
            FormTaoDonHang2 formtaodonhang2 = new FormTaoDonHang2();

            // Hiển thị form tiếp theo
            formtaodonhang2.Show();

            // Đóng form hiện tại nếu cần
            this.Hide();
        }
    }
}
