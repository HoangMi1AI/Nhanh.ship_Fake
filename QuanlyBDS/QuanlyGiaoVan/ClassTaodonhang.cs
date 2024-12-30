using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanlyGiaoVan
{
    internal class ClassTaodonhang
    {

        private string connectionString = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};",
    "mysql-7c6ac32-destroyer159357258-59be.d.aivencloud.com", "24221", "`qlgv_taodon`", "avnadmin", "AVNS_Epz3iT1LragWAov7pqh");

        // Hàm mở kết nối
        private MySqlConnection GetMySqlConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }









}

