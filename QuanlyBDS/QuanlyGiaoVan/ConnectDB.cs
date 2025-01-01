using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

class ConnectDB
{
    private string connString;

    // Constructor to initialize connection string
    public ConnectDB()
    {
        string server = "mysql-33223b05-hoangnv11-f519.g.aivencloud.com";
        string database = "db";
        string user = "avnadmin";
        string password = "AVNS_VXRs-3NrFwP4bv-mjbI";
        int port = 24773;
        connString = $"Server={server};Port={port};Database={database};User Id={user};Password={password};SslMode=Required;";
    }

    // Method to save data to the database
    public void SaveOrderDataToDatabase(OrdersData ordersData)
    {
        string query = "INSERT INTO Orders (user_id, order_code, to_name, to_phone, to_address, to_ward_name, to_district_name, " +
                       "to_district_id, from_district_id, required_note, shipping_company, COD, payer) " +
                       "VALUES (@user_id, @order_code, @to_name, @to_phone, @to_address, @to_ward_name, @to_district_name, " +
                       "@to_district_id, @from_district_id, @required_note, @shipping_company, @COD, @payer)";

        using (var connection = new MySqlConnection(connString))
        {
            connection.Open();
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@user_id", ordersData.UserId);
                command.Parameters.AddWithValue("@order_code", ordersData.OrderCode);
                command.Parameters.AddWithValue("@to_name", ordersData.ToName);
                command.Parameters.AddWithValue("@to_phone", ordersData.ToPhone);
                command.Parameters.AddWithValue("@to_address", ordersData.ToAddress);
                command.Parameters.AddWithValue("@to_ward_name", ordersData.ToWardName);
                command.Parameters.AddWithValue("@to_district_name", ordersData.ToDistrictName);
                command.Parameters.AddWithValue("@to_district_id", ordersData.ToDistrictId);
                command.Parameters.AddWithValue("@from_district_id", ordersData.FromDistrictId);
                command.Parameters.AddWithValue("@required_note", ordersData.RequiredNote);
                command.Parameters.AddWithValue("@shipping_company", ordersData.ShippingCompany);
                command.Parameters.AddWithValue("@COD", ordersData.COD);
                command.Parameters.AddWithValue("@payer", ordersData.Payer);

                command.ExecuteNonQuery();
            }
        }
    }

    public void SaveOrderDetailDataToDatabase(OrdersDetailData ordersDetailData)
    {
        string query = "INSERT INTO OrderDetails (orders_id, name_order, type_order, weight, length, width, height, " +
                       "value, estimate_pick_up_date, estimate_pick_up_time, estimate_delivery_date, characteristic, note) " +
                       "VALUES (@orders_id, @name_order, @type_order, @weight, @length, @width, @height, @value, " +
                       "@estimate_pick_up_date, @estimate_pick_up_time, @estimate_delivery_date, @characteristic, @note)";

        using (var connection = new MySqlConnection(connString))
        {
            connection.Open();
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@orders_id", ordersDetailData.OrdersId);
                command.Parameters.AddWithValue("@name_order", ordersDetailData.NameOrder);
                command.Parameters.AddWithValue("@type_order", ordersDetailData.TypeOrder);
                command.Parameters.AddWithValue("@weight", ordersDetailData.Weight);
                command.Parameters.AddWithValue("@length", ordersDetailData.Length);
                command.Parameters.AddWithValue("@width", ordersDetailData.Width);
                command.Parameters.AddWithValue("@height", ordersDetailData.Height);
                command.Parameters.AddWithValue("@value", ordersDetailData.Value);
                command.Parameters.AddWithValue("@estimate_pick_up_date", ordersDetailData.EstimatePickUpDate);
                command.Parameters.AddWithValue("@estimate_pick_up_time", ordersDetailData.EstimatePickUpTime);
                command.Parameters.AddWithValue("@estimate_delivery_date", ordersDetailData.EstimateDeliveryDate);
                command.Parameters.AddWithValue("@characteristic", ordersDetailData.Characteristic);
                command.Parameters.AddWithValue("@note", ordersDetailData.Note);

                command.ExecuteNonQuery();
            }
        }
    }
}

// FormData class to represent the data structure
public class OrdersData
{
    public int UserId { get; set; }
    public int OrderCode { get; set; }
    public string ToName { get; set; }
    public string ToPhone { get; set; }
    public string ToAddress { get; set; }
    public string ToWardName { get; set; }
    public string ToDistrictName { get; set; }
    public int ToDistrictId { get; set; }
    public int FromDistrictId { get; set; }
    public string RequiredNote { get; set; }  // CHOTHUHANG, CHOXEMHANGKHONGTHU, KHONGCHOXEMHANG
    public string ShippingCompany { get; set; }
    public int COD { get; set; }
    public bool Payer { get; set; }
}
public class OrdersDetailData
{
    public int OrdersId { get; set; }
    public string NameOrder { get; set; }
    public string TypeOrder { get; set; }  // 'Bưu kiện' or 'Tài liệu'
    public int Weight { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public decimal Value { get; set; }
    public DateTime? EstimatePickUpDate { get; set; }
    public string EstimatePickUpTime { get; set; }  // 'Sáng', 'Chiều', 'Tối'
    public DateTime? EstimateDeliveryDate { get; set; }
    public string Characteristic { get; set; }  // 'Chất lỏng', 'Dễ vỡ', etc.
    public string Note { get; set; }
}


