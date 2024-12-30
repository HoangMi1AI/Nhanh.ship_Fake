using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace QuanlyGiaoVan
{
    internal class GHNService
    {
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://online-gateway.ghn.vn/shiip/public-api/v2/")
        };

        private const string Token = "333326a6-c674-11ef-8400-fe4ff714b6c1";
        private const int ShopId = 5559346;

        public async Task CalculateShippingFee()
        {
            // Dữ liệu yêu cầu
            var requestPayload = new
            {
                service_type_id = 2,
                from_district_id = 1442,
                to_district_id = 1820,
                to_ward_code = "030712",
                height = 20,
                length = 30,
                weight = 3000,
                width = 40,
                insurance_value = 0,
                coupon = (string)null
            };

            // Chuyển đổi dữ liệu thành JSON
            string jsonRequest = JsonConvert.SerializeObject(requestPayload);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            // Thêm header bắt buộc
            content.Headers.Add("Token", Token);
            content.Headers.Add("ShopId", ShopId.ToString());

            try
            {
                // Gửi yêu cầu đến API
                var response = await client.PostAsync("shipping-order/fee", content);

                // Kiểm tra phản hồi
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();

                    // Phân tích dữ liệu JSON
                    var jsonData = JObject.Parse(responseBody);
                    var totalFee = jsonData["data"]?["total"]?.ToString();

                    if (!string.IsNullOrEmpty(totalFee))
                    {
                        MessageBox.Show($"Tổng phí vận chuyển: {totalFee} VNĐ");
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy thông tin phí vận chuyển từ phản hồi API.");
                    }
                }
                else
                {
                    var errorDetails = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Lỗi: {response.StatusCode}\nChi tiết: {errorDetails}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
    }
}
