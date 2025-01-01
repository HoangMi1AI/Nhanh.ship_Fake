using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanlyGiaoVan.FormTraCuoc;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanlyGiaoVan
{
    public partial class FormTaoDonHang2 : Form
    {
        private OrdersData _ordersData;
        private OrdersDetailData _ordersDetailData;

        public FormTaoDonHang2(OrdersData ordersData, OrdersDetailData ordersDetailData)
        {
            InitializeComponent();
            _ordersData = ordersData;
            _ordersDetailData = ordersDetailData;

        }

        private void btnTraCuoc_Click(object sender, EventArgs e)
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


        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            List<System.Windows.Forms.ComboBox> comboBoxes = new List<System.Windows.Forms.ComboBox> { cbDonViVanChuyen };

            // Validate ComboBox
            foreach (var comboBox in comboBoxes)
            {
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn giá trị trong ComboBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Validate RadioButton
            bool isRadioButtonChecked = gbTienThuHo.Controls.OfType<RadioButton>().Any(r => r.Checked);
            if (!isRadioButtonChecked)
            {
                MessageBox.Show("Vui lòng chọn một tùy chọn trong RadioButton!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }





            // Get the selected payer option (RadioButton)
            bool payer = radioButton3.Checked;

            // Add new fields to FormData
            _ordersData.ShippingCompany = cbDonViVanChuyen.SelectedItem.ToString();
            _ordersData.Payer = payer;

            //_ordersDetailData.Note = txtBox_Note.Text;



            DateTime changeTime = DateTime.UtcNow.AddHours(7);

            var _orderStatus = new OrderStatusData
            {
                OrdersId = _ordersData.OrderId,
                FromStatus = "init",
                ToStatus = "pending",
                ChangeTime = changeTime
            };


            // Save data to database
            ConnectDB connectDB = new ConnectDB();
            connectDB.SaveOrderDataToDatabase(_ordersData);
            connectDB.SaveOrderDetailDataToDatabase(_ordersDetailData);
            connectDB.SaveOrderStatusDataToDatabase(_orderStatus);

            MessageBox.Show("Đã thêm đơn hàng vào Database!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



            GHNService ghnService = new GHNService();

            await ghnService.CreateShippingOrder(
                _ordersData.ToName,
                _ordersData.ToPhone,
                _ordersData.ToAddress,
                _ordersData.ToWardCode,
                _ordersData.ToDistrictId,
                _ordersDetailData.Weight,
                _ordersDetailData.Length,
                _ordersDetailData.Width,
                _ordersDetailData.Height,
                _ordersData.RequiredNote
                );
        }



    }
}
