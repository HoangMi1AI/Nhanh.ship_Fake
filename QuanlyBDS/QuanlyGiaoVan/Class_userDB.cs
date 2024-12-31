using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;

namespace QuanlyGiaoVan
{
    internal class Class_userDB
    {
        private readonly string connectionString = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};",
            "mysql-7c6ac32-destroyer159357258-59be.d.aivencloud.com", "24221", "user_db", "avnadmin", "AVNS_Epz3iT1LragWAov7pqh");

        // Hàm mở kết nối
        private MySqlConnection GetMySqlConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Hàm băm mật khẩu bằng SHA256
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Hàm thêm người dùng vào cơ sở dữ liệu
        public bool AddUser(string username, string password, string fullName, string email, string phone, string address, string province, string district, string ward)
        {
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();

                    // Kiểm tra xem tài khoản hoặc email đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE username = @username OR email = @mail";
                    using (var checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@username", username);
                        checkCommand.Parameters.AddWithValue("@mail", email);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (count > 0)
                        {
                            return false; // Tài khoản hoặc email đã tồn tại
                        }
                    }

                    // Thêm người dùng mới
                    string insertQuery = "INSERT INTO Users (username, password, full_name, email, phone, address, user_province, user_district, user_ward) " +
                     "VALUES (@username, @password, @fullName, @mail, @phone, @address, @province, @district, @ward)";
                    using (var command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", HashPassword(password)); // Mã hóa mật khẩu
                        command.Parameters.AddWithValue("@fullName", fullName);
                        command.Parameters.AddWithValue("@mail", email);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@province", province);
                        command.Parameters.AddWithValue("@district", district);
                        command.Parameters.AddWithValue("@ward", ward);

                        command.ExecuteNonQuery();
                        return true; // Đăng ký thành công
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false; // Có lỗi xảy ra
                }
            }
        }

        // Hàm kiểm tra đăng nhập
        public bool CheckLogin(string username, string password)
        {
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", HashPassword(password)); // Mã hóa mật khẩu để kiểm tra

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // Trả về true nếu đăng nhập thành công
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
