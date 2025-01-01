using MySql.Data.MySqlClient;
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
        private OrdersData _ordersData;
        private OrdersDetailData _ordersDetailData;


        public FormTaoDonHang2(OrdersData ordersData)
        {
            InitializeComponent();
            _ordersData = ordersData;

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


        private void btnConfirm_Click(object sender, EventArgs e)
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

            //_ordersDetailData = new OrdersDetailData
            //{
            //    NameOrder = txtBox_name_order.Text,
            //    TypeOrder = cbTypeOrder.SelectedItem.ToString(),
            //    Weight = Convert.ToInt32(txtBox_weight.Text),
            //    Length = Convert.ToInt32(txtBox_length.Text),
            //    Width = Convert.ToInt32(txtBox_width.Text),
            //    Height = Convert.ToInt32(txtBox_height.Text),
            //    Value = Convert.ToDecimal(txtBox_value.Text),
            //    EstimatePickUpDate = datePicker_pick_up.Value,
            //    EstimatePickUpTime = cbPickUpTime.SelectedItem.ToString(),
            //    EstimateDeliveryDate = datePicker_delivery.Value,
            //    Characteristic = txtBox_characteristic.Text,
            //    Note = txtBox_note.Text
            //};



            // Get the selected payer option (RadioButton)
            bool payer = radioButton3.Checked;

            // Add new fields to FormData
            _ordersData.ShippingCompany = cbDonViVanChuyen.SelectedItem.ToString();
            _ordersData.Payer = payer;

            // Save data to database
            ConnectDB connectDB = new ConnectDB();
            connectDB.SaveOrderDataToDatabase(_ordersData);
            //connectDB.SaveOrderDetailDataToDatabase(_ordersDetailData);
            
            MessageBox.Show("Tạo đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            

        }
        


    }
}
