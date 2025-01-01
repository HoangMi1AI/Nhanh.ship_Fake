using QuanlyBDS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanlyGiaoVan.FormTraCuoc;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace QuanlyGiaoVan
{
    public partial class FormTaoDonHang : Form
    {
        private Class_Diachi classDiachi;
        private OrdersData _ordersData;
        private OrdersDetailData _ordersDetailData;

        public FormTaoDonHang()
        {
            InitializeComponent();
            LoadProvinces();
        }


        private async void LoadProvinces()
        {
            try
            {
                var ghnDistrict = new GHNdistrict();
                var provinces = await ghnDistrict.GetProvinces();

                if (provinces != null)
                {
                    cbBox_to_province.DataSource = null;
                    cbBox_to_province.Items.Clear();
                    foreach (var province in provinces)
                    {
                        cbBox_to_province.Items.Add(new ComboBoxItem
                        {
                            Text = province.Name,
                            Value = province.Id
                        });
                    }
                }
                else
                {
                    ShowError("Unable to load province list.");
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error loading provinces: {ex.Message}");
            }
        }

        private async void LoadDistricts(int provinceId)
        {
            try
            {
                var ghnDistrict = new GHNdistrict();
                var districts = await ghnDistrict.GetDistricts(provinceId);

                if (districts != null)
                {
                    cbBox_to_district.Items.Clear();
                    foreach (var district in districts)
                    {
                        cbBox_to_district.Items.Add(new ComboBoxItem
                        {
                            Text = district.Name,
                            Value = district.Id
                        });
                    }
                }
                else
                {
                    ShowError("Unable to load district list.");
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error loading districts: {ex.Message}");
            }
        }

        private async void LoadWards(int districtId)
        {
            try
            {
                var ghnDistrict = new GHNdistrict();
                var wards = await ghnDistrict.GetWards(districtId);

                if (wards != null)
                {
                    cbBox_to_ward.Items.Clear();
                    foreach (var ward in wards)
                    {
                        cbBox_to_ward.Items.Add(new ComboBoxItem
                        {
                            Text = ward.Name,
                            Value = ward.Id
                        });
                    }
                }
                else
                {
                    ShowError("Unable to load ward list.");
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error loading wards: {ex.Message}");
            }
        }

        private void cboProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_to_province.SelectedItem is ComboBoxItem selectedItem)
            {
                LoadDistricts((int)selectedItem.Value);
            }
        }

        private void cboDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_to_district.SelectedItem is ComboBoxItem selectedDistrict)
            {
                LoadWards((int)selectedDistrict.Value);
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public class ComboBoxItem
        {
            public string Text { get; set; } // Display name
            public object Value { get; set; } // ID value

            public override string ToString() => Text;
        }

        // Event handler for the district selection change for receiver's district

        //private void cboProvinces_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbBox_to_province.SelectedValue != null)
        //    {
        //        string provinceCode = cbBox_to_province.SelectedValue.ToString();
        //        classDiachi.LoadDistricts(cbBox_to_district, provinceCode); // Tải huyện theo tỉnh đã chọn

        //    }
        //}
        //private void cboDistricts_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbBox_to_district.SelectedValue != null)
        //    {
        //        string district_code = cbBox_to_district.SelectedValue.ToString();
        //        classDiachi.LoadXa(cbBox_to_ward, district_code); // Tải xa theo tỉnh đã chọn
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
            string typeOrder;
            if (radioBtn_Tailieu.Checked)
            {
                typeOrder = "Tài liệu";
            }
            else if (radioBtn_Buukien.Checked)
            {
                typeOrder = "Bưu kiện";
            }
            else
            {
                // Xử lý nếu không có RadioButton nào được chọn
                MessageBox.Show("Vui lòng chọn loại đơn hàng.");
                return; // Dừng thực hiện nếu không có lựa chọn
            }




            DateTime changeTime = DateTime.UtcNow.AddHours(7);
            ConnectDB db = new ConnectDB();
            int maxOrderId = db.GetMaxOrderId() + 1;

            int district_id = (int)((ComboBoxItem)cbBox_to_district.SelectedItem).Value;
            string ToWardCode = ((ComboBoxItem)cbBox_to_ward.SelectedItem).Value.ToString();


            _ordersData = new OrdersData
            {
                OrderId = maxOrderId,
                UserId = 1,
                OrderCode = 12345,
                Created_At = changeTime,
                ToName = txtBox_to_name.Text,
                ToPhone = txtBox_to_number.Text,
                ToAddress = txtBox_to_address.Text + ", " + cbBox_to_ward.Text + ", " + cbBox_to_district.Text + ", " + cbBox_to_province.Text + ", Vietnam",
                ToWardName = cbBox_to_ward.Text,
                ToWardCode = ToWardCode,
                ToDistrictName = cbBox_to_district.Text,
                ToDistrictId = district_id,  
                FromDistrictId = 1,  
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

            DateTime pickupDate = datePicker_estimate_pickup_date.Value;
            DateTime utcPickupDate = pickupDate.ToUniversalTime();
            utcPickupDate = utcPickupDate.AddHours(7);

            DateTime deliveryDate = datePicker_estimate_pickup_date.Value;
            DateTime utcDelivery = deliveryDate.ToUniversalTime();
            utcDelivery = utcDelivery.AddHours(7);

            List<string> characteristics = new List<string>();

            // Kiểm tra từng CheckBox và thêm vào danh sách nếu được chọn
            if (tick_Nguyen_khoi.Checked) characteristics.Add("Nguyên khối");
            if (tick_Gia_tri_cao.Checked) characteristics.Add("Giá trị cao");
            if (tick_Tu_kinh_pin.Checked) characteristics.Add("Từ kính pin");
            if (tick_chat_long.Checked) characteristics.Add("Chất lỏng");
            if (tick_De_vo.Checked) characteristics.Add("Dễ vỡ");
            if (tick_Giayto_Hoadon.Checked) characteristics.Add("Giấy tờ hóa đơn");
            characteristics = characteristics.Where(c => c != null).ToList();

            string characteristicString = string.Join(",", characteristics);

            _ordersDetailData = new OrdersDetailData
            {
                OrdersId = maxOrderId,
                NameOrder = txtBox_name_order.Text,
                TypeOrder = typeOrder,
                Weight = Convert.ToInt32(txtBox_weight.Text),
                Length = Convert.ToInt32(txtBox_length.Text),
                Width = Convert.ToInt32(txtBox_width.Text),
                Height = Convert.ToInt32(txtBox_height.Text),
                Value = Convert.ToDecimal(txtBox_value.Text),
                EstimatePickUpDate = utcPickupDate.Date,
                EstimatePickUpTime = cbBox_estimate_pickup_time.Text,
                EstimateDeliveryDate = utcDelivery.Date,
                Characteristic = characteristicString,
            };

            FormTaoDonHang2 formtaodonhang2 = new FormTaoDonHang2(_ordersData, _ordersDetailData);

            // Hiển thị form tiếp theo
            formtaodonhang2.Show();

            // Đóng form hiện tại nếu cần
            this.Hide();
        }
    }
}
