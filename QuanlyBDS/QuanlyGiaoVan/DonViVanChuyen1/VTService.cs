using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Collections.Generic;

namespace QuanlyGiaoVan
{
    public class ViettelPostService
    {
        private static readonly HttpClient client = new HttpClient();
        private string _token;

        // Đăng nhập để lấy token
        private async Task<bool> LoginAsync()
        {
            try
            {
                string loginUrl = "https://partner.viettelpost.vn/v2/user/Login";
                var loginData = new
                {
                    USERNAME = "tgddhaibon@gmail.com", // Tài khoản cố định
                    PASSWORD = "Lecanhhai24" // Mật khẩu cố định
                };

                string jsonData = JsonConvert.SerializeObject(loginData);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(loginUrl, content);
                string result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    dynamic jsonResponse = JsonConvert.DeserializeObject(result);
                    _token = jsonResponse.data.token; // Lưu token
                    return true;
                }
                else
                {
                    MessageBox.Show($"Đăng nhập thất bại: {result}", "Lỗi");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}", "Lỗi");
                return false;
            }
        }

        // Gửi yêu cầu tính cước vận chuyển với API getPriceAllNlp và chỉ lấy giá
        public async Task<string> GetPriceAllNlpAsync(string ADDgui, string ADDnhan, int cannang)
        {
            try
            {
                // Đảm bảo token đã được lấy
                if (string.IsNullOrEmpty(_token))
                {
                    bool loginSuccess = await LoginAsync();
                    if (!loginSuccess) return "Lỗi: Không thể đăng nhập!";
                }

                string priceUrl = "https://partner.viettelpost.vn/v2/order/getPriceAllNlp";
                var priceData = new
                {
                    SENDER_ADDRESS = ADDgui,
                    RECEIVER_ADDRESS = ADDnhan,
                    PRODUCT_TYPE = "HH",
                    PRODUCT_WEIGHT = cannang,
                    PRODUCT_PRICE = 0,
                    MONEY_COLLECTION = "",
                    PRODUCT_LENGTH = 0,
                    PRODUCT_WIDTH = 0,
                    PRODUCT_HEIGHT = 0,
                    TYPE = 1
                };

                string jsonData = JsonConvert.SerializeObject(priceData);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Thêm Authorization Header với token
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");

                // Gửi yêu cầu
                HttpResponseMessage response = await client.PostAsync(priceUrl, content);
                string result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // Phân tích kết quả JSON và lấy giá cước
                    dynamic jsonResponse = JsonConvert.DeserializeObject(result);
                    var results = jsonResponse.RESULT;

                    StringBuilder prices = new StringBuilder();
                    foreach (var service in results)
                    {
                        // Lấy giá cước của từng dịch vụ
                        int price = service.GIA_CUOC;
                        prices.AppendLine($"Dịch vụ: {service.TEN_DICHVU} - Giá cước: {price} VND");
                    }

                    return prices.ToString();
                }
                else
                {
                    return $"Lỗi: {response.StatusCode} - Chi tiết: {result}";
                }
            }
            catch (Exception ex)
            {
                return $"Exception: {ex.Message}";
            }
        }
    }
}
