using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json.Linq;

namespace QuanlyGiaoVan
{
    internal class GHTKService
    {
        private static readonly string ApiBaseUrl = "https://services.giaohangtietkiem.vn"; // URL API gốc
        private static readonly string Token = "OSokxrt8T2JQUVPucrnktV9aFHBHh0is0JUqsc"; // Thay bằng token của bạn

        /// <summary>
        /// Gửi yêu cầu POST tới API GHTK.
        /// </summary>
        /// <param name="endpoint">Đường dẫn API.</param>
        /// <param name="payload">Dữ liệu gửi đi.</param>
        /// <returns>Kết quả trả về từ API dưới dạng chuỗi JSON.</returns>
        private static async Task<string> PostApiAsync(string endpoint, object payload)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiBaseUrl);
                client.DefaultRequestHeaders.Add("Token", Token);

                var jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(payload);
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(endpoint, content);

                // Nếu yêu cầu thất bại, trả về chi tiết lỗi
                if (!response.IsSuccessStatusCode)
                {
                    return $"Lỗi: {response.StatusCode} - {await response.Content.ReadAsStringAsync()}";
                }

                return await response.Content.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// Tạo đơn hàng và xử lý kết quả trả về.
        /// </summary>
        /// <param name="pickProvince">Tỉnh/Thành phố nơi gửi.</param>
        /// <param name="pickDistrict">Quận/Huyện nơi gửi.</param>
        /// <param name="pickWard">Phường/Xã nơi gửi.</param>
        /// <param name="Province">Tỉnh/Thành phố nơi nhận.</param>
        /// <param name="District">Quận/Huyện nơi nhận.</param>
        /// <param name="Ward">Phường/Xã nơi nhận.</param>
        /// <param name="Weight">Trọng lượng (gram).</param>
        /// <returns>Kết quả trả về từ API dưới dạng chuỗi đã định dạng.</returns>
        public async Task<string> CalculateShippingFeeAsync(
    string pickProvince, string pickDistrict, string pickWard,
    string Province, string District, string Ward,
    int Weight)
        {
            string endpoint = "/services/shipment/fee"; // Đường dẫn API tính phí

            
            var payload = new
            {
                pick_province = pickProvince,
                pick_district = pickDistrict,
                pick_ward = pickWard,
                province = Province,
                district = District,
                ward = Ward,
                deliver_option = "none",
                weight = Weight     // Trọng lượng
            };

            string response = await PostApiAsync(endpoint, payload);

            // Xử lý kết quả JSON và in ra đẹp hơn
            try
            {
                JObject json = JObject.Parse(response);

                if (json["success"] != null && !(bool)json["success"])
                {
                    return $"Lỗi: {json["message"]?.ToString() ?? "Không rõ lý do"}\n" +
                           $"Mã lỗi: {json["error_code"]?.ToString() ?? "N/A"}";
                }

                // Lấy thông tin phí từ kết quả trả về
                var fee = json["fee"];
                if (fee == null)
                {
                    return $"Tính phí thất bại: Không tìm thấy thông tin phí trong kết quả.";
                }

                var formattedFee = new StringBuilder();
                formattedFee.AppendLine($"Phí giao hàng: {fee["fee"] ?? "N/A"} VNĐ");

                return formattedFee.ToString();
            }
            catch (Exception ex)
            {
                return $"Không thể phân tích kết quả trả về: {ex.Message}\nChi tiết: {response}";
            }
        }


    }
}
