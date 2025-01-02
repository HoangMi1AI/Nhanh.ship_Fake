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

namespace QuanlyGiaoVan
{
    public partial class FormQuanLyDonHang : Form
    {
        private string connectionString = "Server=mysql-33223b05-hoangnv11-f519.g.aivencloud.com;Port=24773;Database=db;User Id=avnadmin;Password=AVNS_VXRs-3NrFwP4bv-mjbI;SslMode=Required;";

        public FormQuanLyDonHang()
        {
            InitializeComponent();
            txtNhapMaDonHang.Enter += new EventHandler(txtNhapMaDonHang_Enter);
            txtNhapMaDonHang.Leave += new EventHandler(txtNhapMaDonHang_Leave);
            txtNhapMaDonHang.Enter += new EventHandler(txtNhapMaDonHang_Enter);
            txtNhapMaDonHang.Leave += new EventHandler(txtNhapMaDonHang_Leave);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maDonHang = txtNhapMaDonHang.Text.Trim();
            if (string.IsNullOrEmpty(maDonHang) || maDonHang == "Nhập mã đơn hàng")
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng.");
                return;
            }

            SearchOrder(maDonHang);
        }

        // Sự kiện khi người dùng nhấn vào trường txtMaLHP
        private void txtNhapMaDonHang_Enter(object sender, EventArgs e)
        {
            if (txtNhapMaDonHang.Text == "Nhập mã đơn hàng")
            {
                txtNhapMaDonHang.Text = "";
                txtNhapMaDonHang.ForeColor = System.Drawing.Color.Black; // Đặt màu chữ thành đen
            }
        }

        // Sự kiện khi người dùng rời khỏi trường txtMaLHP
        private void txtNhapMaDonHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhapMaDonHang.Text))
            {
                txtNhapMaDonHang.Text = "Nhập mã đơn hàng";
                txtNhapMaDonHang.ForeColor = System.Drawing.Color.Gray; // Đặt màu chữ thành xám
            }
        }

        private void SearchOrder(string maDonHang)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Chuyển đổi maDonHang sang int
                    if (int.TryParse(maDonHang, out int orderId))
                    {
                        string query = @"SELECT o.orders_id, o.user_id, o.order_code, o.created_at, o.to_name, o.to_phone, o.to_address,
                                os.to_status, os.change_time 
                                FROM Orders o 
                                JOIN OrderStatus os ON o.orders_id = os.orders_id 
                                WHERE o.orders_id = @orders_id";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@orders_id", orderId);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvDonHangTimKiem.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy đơn hàng.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã đơn hàng không hợp lệ. Vui lòng nhập lại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
        }
    }
}