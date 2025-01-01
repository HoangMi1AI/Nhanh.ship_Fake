using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyGiaoVan
{
    internal class GHNdistrict
    {
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://online-gateway.ghn.vn/shiip/public-api/")
        };

        private const string Token = "b58324d1-c834-11ef-82e4-ca3fa9530337";
        private const int ShopId = 5564116;

        // Hàm lấy danh sách tỉnh/thành phố
        public async Task<List<(int Id, string Name)>> GetProvinces()
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Token", Token);

                var response = await client.GetAsync("master-data/province");

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var jsonData = JsonConvert.DeserializeObject<dynamic>(responseBody);

                    var provinces = new List<(int Id, string Name)>();
                    foreach (var province in jsonData.data)
                    {
                        provinces.Add(((int)province.ProvinceID, (string)province.ProvinceName));
                    }

                    return provinces;
                }
                else
                {
                    MessageBox.Show($"Lỗi: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lấy tỉnh/thành phố: {ex.Message}");
            }

            return null; // Trả về null trong trường hợp lỗi
        }


        // Hàm lấy danh sách quận/huyện
        public async Task<List<(int Id, string Name)>> GetDistricts(int provinceId)
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Token", Token);

                var payload = new { province_id = provinceId };
                var jsonPayload = JsonConvert.SerializeObject(payload);

                var response = await client.PostAsync("master-data/district",
                    new StringContent(jsonPayload, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var jsonData = JsonConvert.DeserializeObject<dynamic>(responseBody);

                    var districts = new List<(int Id, string Name)>();
                    foreach (var district in jsonData.data)
                    {
                        districts.Add(((int)district.DistrictID, (string)district.DistrictName));
                    }

                    return districts;
                }
                else
                {
                    var errorDetails = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Lỗi: {response.StatusCode}\nChi tiết: {errorDetails}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lấy quận/huyện: {ex.Message}");
            }

            return null; // Trả về null trong trường hợp lỗi
        }



        // Hàm lấy danh sách phường/xã
        // Hàm lấy danh sách phường/xã
        public async Task<List<(int Id, string Name)>> GetWards(int districtId)
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Token", Token);

                var response = await client.PostAsync("master-data/ward?district_id",
                    new StringContent($"{{\"district_id\":{districtId}}}", Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var jsonData = JsonConvert.DeserializeObject<dynamic>(responseBody);

                    var wards = new List<(int Id, string Name)>();
                    foreach (var ward in jsonData.data)
                    {
                        wards.Add(((int)ward.WardCode, (string)ward.WardName));
                    }

                    return wards;
                }
                else
                {
                    MessageBox.Show($"Lỗi: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lấy phường/xã: {ex.Message}");
            }

            return null; // Trả về null trong trường hợp lỗi
        }



    }
}

