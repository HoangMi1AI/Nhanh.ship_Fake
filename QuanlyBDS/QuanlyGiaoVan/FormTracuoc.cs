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
    public partial class FormTraCuoc : Form
    {
        private FormTaoDonHang2 _formTaoDonHang2;
        public FormTraCuoc()
        {
            InitializeComponent();
            LoadProvinces();
        }
        public FormTraCuoc(FormTaoDonHang2 formTaoDonHang2)
        {
            InitializeComponent();
            LoadProvinces();
            _formTaoDonHang2 = formTaoDonHang2;
        }

        private async void LoadProvinces()
        {
            var gHNdistrict = new GHNdistrict();

            // Lấy danh sách tỉnh/thành phố từ API
            var provinces = await gHNdistrict.GetProvinces();

            if (provinces != null)
            {
                cboProvincesgui.Items.Clear();
                cboProvincesnhan.Items.Clear();  // Clear the receiving province ComboBox
                foreach (var province in provinces)
                {
                    // Lưu cả tên và ID của tỉnh vào ComboBoxItem
                    cboProvincesgui.Items.Add(new ComboBoxItem
                    {
                        Text = province.Name,
                        Value = province.Id
                    });

                    cboProvincesnhan.Items.Add(new ComboBoxItem
                    {
                        Text = province.Name,
                        Value = province.Id
                    });
                }
            }
            else
            {
                MessageBox.Show("Không thể tải danh sách tỉnh/thành phố.");
            }
        }

        private async void LoadDistricts(int provinceId, ComboBox cboDistricts)
        {
            var gHNdistrict = new GHNdistrict();

            // Lấy danh sách quận/huyện từ API
            var districts = await gHNdistrict.GetDistricts(provinceId);

            if (districts != null)
            {
                cboDistricts.Items.Clear();
                foreach (var district in districts)
                {
                    // Thêm tên và ID của quận/huyện vào ComboBox
                    cboDistricts.Items.Add(new ComboBoxItem
                    {
                        Text = district.Name,  // Tên quận/huyện
                        Value = district.Id     // ID quận/huyện
                    });
                }
            }
            else
            {
                MessageBox.Show("Không thể tải danh sách quận/huyện.");
            }
        }

        private async void LoadWards(int districtId, ComboBox cboWards)
        {
            var gHNdistrict = new GHNdistrict();

            // Lấy danh sách xã/phường từ API
            var wards = await gHNdistrict.GetWards(districtId);

            if (wards != null)
            {
                cboWards.Items.Clear();
                foreach (var ward in wards)
                {
                    // Thêm item vào ComboBox với tên và ID
                    cboWards.Items.Add(new ComboBoxItem
                    {
                        Text = ward.Name,   // Tên xã/phường
                        Value = ward.Id     // ID xã/phường
                    });
                }
            }
            else
            {
                MessageBox.Show("Không thể tải danh sách xã/phường.");
            }
        }

        // Event handler for the province selection change for sender's province
        private async void cboProvincesgui_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincesgui.SelectedIndex >= 0)
            {
                // Lấy tỉnh được chọn
                var selectedItem = (ComboBoxItem)cboProvincesgui.SelectedItem;

                // Lấy ID của tỉnh
                int provinceId = (int)selectedItem.Value;

                // Gọi hàm để tải danh sách quận/huyện
                LoadDistricts(provinceId, cboDistrictsgui);  // Sender's district ComboBox
            }
        }

        // Event handler for the province selection change for receiver's province
        private async void cboProvincesnhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincesnhan.SelectedIndex >= 0)
            {
                // Lấy tỉnh được chọn
                var selectedItem = (ComboBoxItem)cboProvincesnhan.SelectedItem;

                // Lấy ID của tỉnh
                int provinceId = (int)selectedItem.Value;

                // Gọi hàm để tải danh sách quận/huyện cho bên nhận
                LoadDistricts(provinceId, cboDistrictsnhan);  // Receiver's district ComboBox
            }
        }

        // Event handler for the district selection change for sender's district
        private async void cboDistrictsgui_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistrictsgui.SelectedIndex >= 0)
            {
                // Lấy đối tượng ComboBoxItem đã được chọn
                var selectedDistrict = cboDistrictsgui.SelectedItem as ComboBoxItem;

                if (selectedDistrict != null)
                {
                    // Lấy ID của quận/huyện đã chọn
                    int districtId = (int)selectedDistrict.Value;

                    // Gọi hàm LoadWards với districtId lấy được
                    LoadWards(districtId, cboWardsgui);  // Sender's ward ComboBox
                }
            }
        }

        // Event handler for the district selection change for receiver's district
        private async void cboDistrictsnhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistrictsnhan.SelectedIndex >= 0)
            {
                // Lấy đối tượng ComboBoxItem đã được chọn
                var selectedDistrict = cboDistrictsnhan.SelectedItem as ComboBoxItem;

                if (selectedDistrict != null)
                {
                    // Lấy ID của quận/huyện đã chọn
                    int districtId = (int)selectedDistrict.Value;

                    // Gọi hàm LoadWards với districtId lấy được cho bên nhận
                    LoadWards(districtId, cboWardsnhan);  // Receiver's ward ComboBox
                }
            }
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
        private async void btnCalculateFee_Click(object sender, EventArgs e)
        {
            int district_idgui = (int)((ComboBoxItem)cboDistrictsgui.SelectedItem).Value;
            string ward_codegui = ((ComboBoxItem)cboWardsgui.SelectedItem).Value.ToString();
            int district_idnhan = (int)((ComboBoxItem)cboDistrictsnhan.SelectedItem).Value;
            string ward_codenhan = ((ComboBoxItem)cboWardsnhan.SelectedItem).Value.ToString();
            string ADDgui = cboWardsgui.Text + ", " + cboDistrictsgui.Text + ", " + cboProvincesgui.Text;
            string ADDnhan = cboWardsnhan.Text + ", " + cboDistrictsnhan.Text + ", " + cboProvincesnhan.Text;
            string pickProvince = cboProvincesgui.Text;
            string pickDistrict = cboDistrictsgui.Text;
            string pickWard = cboWardsgui.Text;
            string Province = cboProvincesnhan.Text;
            string District = cboDistrictsnhan.Text;
            string Ward = cboWardsnhan.Text;


            if (string.IsNullOrEmpty(ward_codegui) || string.IsNullOrEmpty(ward_codenhan) || string.IsNullOrEmpty(txtKL.Text))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin để tính phí vận chuyển.");
                return;
            }
            else
            {
                int cannang = int.Parse(txtKL.Text);
                var ghnService = new GHNService();
                await ghnService.CalculateShippingFee(district_idgui, ward_codegui, district_idnhan, ward_codenhan, cannang);
                var _viettelPostService = new ViettelPostService();
                string priceInfo = await _viettelPostService.GetPriceAllNlpAsync(ADDgui, ADDnhan, cannang);
                GHTKService ghtkService = new GHTKService();
                string result = await ghtkService.CalculateShippingFeeAsync(pickProvince, pickDistrict, pickWard, Province, District, Ward, cannang);
                lbGHN.Text = "Phí vận chuyển: " + ghnService.phi + " VNĐ";
                lbVTP.Text = priceInfo;
                lbGHTK.Text = result;
                panel1.Visible = true;
            }

        }

        public class ComboBoxItem
        {
            public string Text { get; set; } // Tên hiển thị
            public object Value { get; set; } // Giá trị ID

            public override string ToString()
            {
                return Text; // Hiển thị Text trong ComboBox
            }
        }
        private async void btnGetShippingPrice_Click(object sender, EventArgs e)
        {
            string ADDgui = cboWardsgui.Text + ", " + cboDistrictsgui.Text + ", " + cboProvincesgui.Text;
            string ADDnhan = cboWardsnhan.Text + ", " + cboDistrictsnhan.Text + ", " + cboProvincesnhan.Text;

            if (string.IsNullOrEmpty(txtKL.Text))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin để tính phí vận chuyển.");
                return;
            }
            else
            {
                int cannang = int.Parse(txtKL.Text);

                // Tính cước vận chuyển mà không cần đăng nhập
                var _viettelPostService = new ViettelPostService();
                string priceInfo = await _viettelPostService.GetPriceAllNlpAsync(ADDgui, ADDnhan, cannang);
                MessageBox.Show(priceInfo, "Cước vận chuyển");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        //private async void test_Click(object sender, EventArgs e)
        //{
        //    var ghnService = new GHNService();
        //    await ghnService.CreateShippingOrder();
        //}
    }
}
