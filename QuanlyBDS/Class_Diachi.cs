using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanlyBDS
{
    internal class Class_Diachi
    {
        private string connectionString = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};",
            "qlgiaovan-tgddhaibon-c92d.g.aivencloud.com", "18438", "DATADIACHI", "avnadmin", "AVNS_QhgqsAhr0kghI9CHr0J");

        // Hàm mở kết nối
        private MySqlConnection GetMySqlConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Hàm tải danh sách tỉnh vào Combobox
        public void LoadProvinces(ComboBox cboProvinces)
        {
            using (MySqlConnection connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT code, name FROM provinces";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Thêm mục mặc định vào đầu danh sách
                    DataRow row = dt.NewRow();
                    row["name"] = "Chọn tỉnh";  // Tên mục mặc định
                    row["code"] = DBNull.Value;  // Giá trị mặc định là null
                    dt.Rows.InsertAt(row, 0);

                    cboProvinces.DisplayMember = "name";
                    cboProvinces.ValueMember = "code";
                    cboProvinces.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading provinces: " + ex.Message);
                }
            }
        }

        // Hàm tải danh sách huyện theo tỉnh
        public void LoadDistricts(ComboBox cboDistricts, string provinceCode)
        {
            using (MySqlConnection connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT name FROM districts WHERE province_code = @provinceCode";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@provinceCode", provinceCode);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Thêm mục mặc định vào đầu danh sách huyện
                    DataRow row = dt.NewRow();
                    row["name"] = "Chọn huyện";  // Tên mục mặc định
                    dt.Rows.InsertAt(row, 0);

                    cboDistricts.DisplayMember = "name";
                    cboDistricts.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading districts: " + ex.Message);
                }
            }
        }
    }
}
