using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QuanlyGiaoVan
{
    internal class GHNService
    {
        public string phi = "";
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://online-gateway.ghn.vn/shiip/public-api/v2/")
        };

        private const string Token = "333326a6-c674-11ef-8400-fe4ff714b6c1";

        // Hàm tính phí vận chuyển
        public async Task CalculateShippingFee( int district_idgui, string ward_codegui, int district_idguinhan, string ward_codenhan, int cannang)
        {
            var requestPayload = new
            {
                service_type_id = 2,
                from_district_id = district_idgui,
                from_ward_code = ward_codegui,
                to_district_id = district_idguinhan,
                to_ward_code = ward_codenhan,
                height = 20,
                length = 30,
                weight = cannang,
                width = 40,
                insurance_value = 0,
                coupon = (string)null
            };

            string jsonRequest = JsonConvert.SerializeObject(requestPayload);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            content.Headers.Add("Token", Token);

            try
            {
                var response = await client.PostAsync("shipping-order/fee", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var jsonData = JsonConvert.DeserializeObject<dynamic>(responseBody);
                    string totalFee = jsonData?.data?.total.ToString();

                    if (!string.IsNullOrEmpty(totalFee))
                    {
                        phi = totalFee;
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy thông tin phí vận chuyển từ phản hồi API.");
                        phi = "";
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
