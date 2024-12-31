using System;
using MySql.Data.MySqlClient;

class ConnectDB
{
    internal void connectDB()
    {
        // Thông tin kết nối
        string server = "mysql-33223b05-hoangnv11-f519.g.aivencloud.com"; // Thay bằng tên server trên Aiven
        string database = "db"; // Tên database đã tạo
        string user = "avnadmin"; // Tên user của bạn
        string password = "AVNS_VXRs-3NrFwP4bv-mjbI"; // Mật khẩu user
        int port = 24773; // Cổng MySQL (thường Aiven cung cấp, ví dụ: 25060)

        // Connection string
        string connString = $"Server={server};Port={port};Database={database};User Id={user};Password={password};SslMode=Required;";

        try
        {
            using (var connection = new MySqlConnection(connString))
            {
                // Mở kết nối
                connection.Open();
                Console.WriteLine("Kết nối thành công đến MySQL trên Aiven!");

                // Ví dụ thực hiện truy vấn
                string query = "SELECT NOW() as CurrentTime;";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Thời gian hiện tại: {reader["CurrentTime"]}");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi kết nối: {ex.Message}");
        }
    }
}
