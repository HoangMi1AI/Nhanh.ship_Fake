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
    public partial class Tra_cước : Form
    {
        private Class_Diachi classDiachi;
        public Tra_cước()
        {
            InitializeComponent();
            classDiachi = new Class_Diachi();
            classDiachi.LoadProvinces(cboProvincesgui); // Tải danh sách tỉnh người gửi
            classDiachi.LoadProvinces(cboProvincesnhan); // Tải danh sách tỉnh người nhận
        }
        private void cboProvincesgui_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincesgui.SelectedValue != null)
            {
                string provinceCode = cboProvincesgui.SelectedValue.ToString();
                classDiachi.LoadDistricts(cboDistrictsgui, provinceCode); // Tải huyện theo tỉnh đã chọn
            }
        }
        private void cboProvincesnhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincesnhan.SelectedValue != null)
            {
                string provinceCode = cboProvincesnhan.SelectedValue.ToString();
                classDiachi.LoadDistricts(cboDistrictsnhan, provinceCode); // Tải huyện theo tỉnh đã chọn
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Tra_cước_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
