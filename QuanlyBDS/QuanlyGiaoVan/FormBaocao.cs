using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanlyGiaoVan
{
    public partial class FormBaocao : Form
    {
        public FormBaocao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveToPdf();
        }
        private void SaveToPdf()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (.pdf)|.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument document = new PdfDocument();
                    document.Info.Title = "Báo cáo đơn hàng";

                    // Set page orientation to Landscape
                    PdfPage page = document.AddPage();
                    page.Orientation = PdfSharp.PageOrientation.Landscape;

                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont headerFont = new XFont("Arial", 12, XFontStyleEx.Bold);
                    XFont titleFont = new XFont("Arial", 14, XFontStyleEx.Bold);
                    XFont normalFont = new XFont("Arial", 10, XFontStyleEx.Italic);

                    // Header (adjusted X positions for landscape)
                    gfx.DrawString("Vận chuyển Bách Khoa", headerFont, XBrushes.Black, new XPoint(50, 40));
                    gfx.DrawString("CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM", headerFont, XBrushes.Black, new XPoint(450, 40));
                    gfx.DrawString("Độc lập - Tự do - Hạnh phúc", normalFont, XBrushes.Black, new XPoint(500, 60));
                    gfx.DrawString("..........., ngày ... tháng ... năm 20...", normalFont, XBrushes.Black, new XPoint(450, 80));

                    // Title
                    gfx.DrawString("BÁO CÁO ĐƠN HÀNG", titleFont, XBrushes.Black,
                        new XRect(0, 120, page.Width, 30), XStringFormats.Center);

                    // Table headers
                    int y = 160;
                    int startX = 50;
                    int columnWidth = 100; // Set the column width
                    int totalWidth = columnWidth * dataGridView1.Columns.Count;

                    // Draw headers
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        gfx.DrawRectangle(XPens.Black, startX + (i * columnWidth), y, columnWidth, 25);
                        gfx.DrawString(dataGridView1.Columns[i].HeaderText, headerFont, XBrushes.Black,
                            new XRect(startX + (i * columnWidth), y, columnWidth, 25), XStringFormats.Center);
                    }

                    // Draw data from DataGridView1
                    y += 25;
                    for (int row = 0; row < dataGridView1.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridView1.Columns.Count; col++)
                        {
                            gfx.DrawRectangle(XPens.Black, startX + (col * columnWidth), y, columnWidth, 25);
                            if (dataGridView1.Rows[row].Cells[col].Value != null)
                            {
                                gfx.DrawString(dataGridView1.Rows[row].Cells[col].Value.ToString(), normalFont, XBrushes.Black,
                                    new XRect(startX + (col * columnWidth), y, columnWidth, 25), XStringFormats.Center);
                            }
                        }

                        y += 25;

                        // New page if needed
                        if (y >= page.Height - 50)
                        {
                            page = document.AddPage();
                            page.Orientation = PdfSharp.PageOrientation.Landscape;
                            gfx = XGraphics.FromPdfPage(page);
                            y = 50;
                        }
                    }

                    document.Save(sfd.FileName);
                    MessageBox.Show("PDF đã được lưu thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void FormBaocao_Load(object sender, EventArgs e)
        {
            // Ẩn các control khi form được tải lần đầu tiên
            lblLoaibaocao.Visible = false;
            btnBaocaosoluongdonhang.Visible = false;
            btnBaocaotinhhinhthitruong.Visible = false;
            btnBaocaohieusuatdoitac.Visible = false;
            btnBaocaotilekhieunai.Visible = false;
            btnBaocaothoigiaogiaohangtrungbinh.Visible = false;
        }
        private void checkBoxTatca_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem checkBox1 có được tích không
            if (checkBoxTatca.Checked)
            {
                // Nếu checkBox1 được tích, gọi hàm LoadData
                LoadDonHangData();

                // Tắt checkBox2 nếu nó đang được tích
                checkBoxTungloai.Checked = false;  // Tắt checkBox2
            }
            else
            {
                // Nếu checkBox1 bị bỏ tích, làm sạch dữ liệu trong DataGridView1
                dataGridView1.DataSource = null; // Xóa nguồn dữ liệu
                dataGridView1.Rows.Clear(); // Xóa tất cả các dòng
            }
        }
        private void LoadDonHangData()
        {
            // Tạo DataTable với các cột cần thiết cho tất cả báo cáo
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tháng", typeof(string));
            dataTable.Columns.Add("SL đơn", typeof(int));
            dataTable.Columns.Add("TL khiếu nại", typeof(double));
            dataTable.Columns.Add("HSDT vận chuyển", typeof(double));
            dataTable.Columns.Add("TLGH đúng hạn", typeof(double));
            dataTable.Columns.Add("TLTT thị trường", typeof(double));
            dataTable.Columns.Add("TGGHTB", typeof(double));

            // Dữ liệu mẫu cho tất cả báo cáo (Tháng 1 đến Tháng 12)
            dataTable.Rows.Add("Tháng 1", 150, 2.5, 95.5, 92.3, 5.5, 3.2);
            dataTable.Rows.Add("Tháng 2", 200, 3.2, 98.2, 94.1, 4.2, 2.8);
            dataTable.Rows.Add("Tháng 3", 180, 2.0, 92.3, 89.7, 6.1, 3.0);
            dataTable.Rows.Add("Tháng 4", 160, 2.3, 96.0, 91.5, 5.0, 3.1);
            dataTable.Rows.Add("Tháng 5", 170, 3.1, 97.0, 93.0, 4.8, 3.0);
            dataTable.Rows.Add("Tháng 6", 220, 2.8, 97.5, 94.8, 5.3, 3.3);
            dataTable.Rows.Add("Tháng 7", 190, 3.5, 96.3, 92.5, 5.9, 3.2);
            dataTable.Rows.Add("Tháng 8", 210, 3.0, 98.0, 95.0, 4.5, 2.9);
            dataTable.Rows.Add("Tháng 9", 200, 2.7, 96.8, 94.0, 5.2, 3.0);
            dataTable.Rows.Add("Tháng 10", 230, 3.0, 97.2, 94.5, 4.7, 3.1);
            dataTable.Rows.Add("Tháng 11", 240, 2.9, 97.6, 95.2, 4.9, 2.8);
            dataTable.Rows.Add("Tháng 12", 250, 3.1, 98.1, 94.9, 5.0, 3.4);

            // Hiển thị vào dataGridView
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void checkBoxTungloai_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTungloai.Checked)
            {
                // Tắt checkBoxTatca nếu nó đang được tích
                if (checkBoxTatca.Checked)
                {
                    checkBoxTatca.Checked = false;  // Tắt checkBox2
                }
                // Nếu checkBox2 được tích, hiển thị các control
                lblLoaibaocao.Visible = true;
                btnBaocaosoluongdonhang.Visible = true;
                btnBaocaotinhhinhthitruong.Visible = true;
                btnBaocaohieusuatdoitac.Visible = true;
                btnBaocaotilekhieunai.Visible = true;
                btnBaocaothoigiaogiaohangtrungbinh.Visible = true;
            }
            else
            {
                // Nếu checkBox1 bị bỏ tích, làm sạch dữ liệu trong DataGridView1
                dataGridView1.DataSource = null; // Xóa nguồn dữ liệu
                dataGridView1.Rows.Clear(); // Xóa tất cả các dòng
                // Nếu checkBox2 không được tích, ẩn các control
                lblLoaibaocao.Visible = false;
                btnBaocaosoluongdonhang.Visible = false;
                btnBaocaotinhhinhthitruong.Visible = false;
                btnBaocaohieusuatdoitac.Visible = false;
                btnBaocaotilekhieunai.Visible = false;
                btnBaocaothoigiaogiaohangtrungbinh.Visible = false;
            }
        }
        // Phương thức dùng để hiển thị báo cáo số lượng đơn hàng
        private void LoadSoLuongDonHangData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tháng", typeof(string));
            dataTable.Columns.Add("Mã đơn hàng", typeof(string));
            dataTable.Columns.Add("Ngày tạo đơn", typeof(DateTime));
            dataTable.Columns.Add("Trạng thái đơn hàng", typeof(string));
            dataTable.Columns.Add("Số lượng sản phẩm", typeof(int));
            dataTable.Columns.Add("Số lượng đơn hàng", typeof(int));

            // Dữ liệu mẫu cho 12 tháng
            dataTable.Rows.Add("Tháng 1", "DH001", new DateTime(2025, 1, 5), "Đang xử lý", 10, 150);
            dataTable.Rows.Add("Tháng 2", "DH002", new DateTime(2025, 2, 7), "Đã giao", 8, 200);
            dataTable.Rows.Add("Tháng 3", "DH003", new DateTime(2025, 3, 10), "Đã hủy", 15, 180);
            dataTable.Rows.Add("Tháng 4", "DH004", new DateTime(2025, 4, 12), "Đang xử lý", 12, 220);
            dataTable.Rows.Add("Tháng 5", "DH005", new DateTime(2025, 5, 15), "Đã giao", 14, 190);
            dataTable.Rows.Add("Tháng 6", "DH006", new DateTime(2025, 6, 18), "Đang xử lý", 9, 210);
            dataTable.Rows.Add("Tháng 7", "DH007", new DateTime(2025, 7, 20), "Đã giao", 11, 240);
            dataTable.Rows.Add("Tháng 8", "DH008", new DateTime(2025, 8, 25), "Đã hủy", 13, 200);
            dataTable.Rows.Add("Tháng 9", "DH009", new DateTime(2025, 9, 10), "Đang xử lý", 7, 180);
            dataTable.Rows.Add("Tháng 10", "DH010", new DateTime(2025, 10, 5), "Đã giao", 10, 220);
            dataTable.Rows.Add("Tháng 11", "DH011", new DateTime(2025, 11, 11), "Đang xử lý", 12, 250);
            dataTable.Rows.Add("Tháng 12", "DH012", new DateTime(2025, 12, 8), "Đã giao", 15, 230);

            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        // Phương thức dùng để hiển thị báo cáo tỉ lệ khiếu nại
        private void LoadTiLeKhieuNaiData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tháng", typeof(string));
            dataTable.Columns.Add("Mã đơn hàng", typeof(string));
            dataTable.Columns.Add("Ngày khiếu nại", typeof(DateTime));
            dataTable.Columns.Add("Loại khiếu nại", typeof(string));
            dataTable.Columns.Add("Trạng thái khiếu nại", typeof(string));
            dataTable.Columns.Add("Mức độ nghiêm trọng", typeof(string));
            dataTable.Columns.Add("Tỉ lệ khiếu nại (%)", typeof(double));

            // Dữ liệu mẫu cho 12 tháng
            dataTable.Rows.Add("Tháng 1", "DH001", new DateTime(2025, 1, 6), "Giao hàng bị hư hỏng", "Đang giải quyết", "Cao", 2.5);
            dataTable.Rows.Add("Tháng 2", "DH002", new DateTime(2025, 2, 8), "Giao hàng sai địa chỉ", "Đã giải quyết", "Trung bình", 3.2);
            dataTable.Rows.Add("Tháng 3", "DH003", new DateTime(2025, 3, 12), "Hủy đơn hàng", "Chưa giải quyết", "Thấp", 2.0);
            dataTable.Rows.Add("Tháng 4", "DH004", new DateTime(2025, 4, 15), "Giao hàng bị trễ", "Đang giải quyết", "Trung bình", 1.8);
            dataTable.Rows.Add("Tháng 5", "DH005", new DateTime(2025, 5, 10), "Giao hàng sai mẫu", "Đã giải quyết", "Thấp", 2.3);
            dataTable.Rows.Add("Tháng 6", "DH006", new DateTime(2025, 6, 20), "Không đúng thời gian", "Đang giải quyết", "Trung bình", 2.1);
            dataTable.Rows.Add("Tháng 7", "DH007", new DateTime(2025, 7, 25), "Giao hàng bị hư hỏng", "Chưa giải quyết", "Cao", 3.0);
            dataTable.Rows.Add("Tháng 8", "DH008", new DateTime(2025, 8, 10), "Hủy đơn hàng", "Đang giải quyết", "Thấp", 1.5);
            dataTable.Rows.Add("Tháng 9", "DH009", new DateTime(2025, 9, 15), "Giao hàng sai địa chỉ", "Đã giải quyết", "Trung bình", 2.0);
            dataTable.Rows.Add("Tháng 10", "DH010", new DateTime(2025, 10, 5), "Giao hàng bị hư hỏng", "Đang giải quyết", "Cao", 3.2);
            dataTable.Rows.Add("Tháng 11", "DH011", new DateTime(2025, 11, 20), "Không đúng sản phẩm", "Chưa giải quyết", "Thấp", 1.9);
            dataTable.Rows.Add("Tháng 12", "DH012", new DateTime(2025, 12, 10), "Giao hàng sai địa chỉ", "Đã giải quyết", "Trung bình", 2.4);


            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        // Phương thức dùng để hiển thị báo cáo hiệu suất đối tác vận chuyển
        private void LoadHieuSuatDoiTacData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tháng", typeof(string));
            dataTable.Columns.Add("Mã đối tác vận chuyển", typeof(string));
            dataTable.Columns.Add("Đối tác vận chuyển", typeof(string));
            dataTable.Columns.Add("Số lượng đơn hàng", typeof(int));
            dataTable.Columns.Add("Số đơn hàng bị trễ", typeof(int));
            dataTable.Columns.Add("Thời gian giao hàng trung bình (ngày)", typeof(double));
            dataTable.Columns.Add("Tỉ lệ giao hàng đúng hạn (%)", typeof(double));

            // Dữ liệu mẫu cho 12 tháng
            dataTable.Rows.Add("Tháng 1", "VT001", "Vận chuyển A", 150, 5, 3.2, 95.5);
            dataTable.Rows.Add("Tháng 2", "VT002", "Vận chuyển B", 180, 7, 2.8, 98.2);
            dataTable.Rows.Add("Tháng 3", "VT003", "Vận chuyển C", 120, 10, 3.5, 92.3);
            dataTable.Rows.Add("Tháng 4", "VT004", "Vận chuyển D", 200, 8, 3.0, 96.0);
            dataTable.Rows.Add("Tháng 5", "VT005", "Vận chuyển E", 220, 6, 2.9, 97.5);
            dataTable.Rows.Add("Tháng 6", "VT006", "Vận chuyển F", 160, 9, 3.1, 94.8);
            dataTable.Rows.Add("Tháng 7", "VT007", "Vận chuyển G", 180, 4, 3.3, 95.0);
            dataTable.Rows.Add("Tháng 8", "VT008", "Vận chuyển H", 140, 12, 3.4, 91.0);
            dataTable.Rows.Add("Tháng 9", "VT009", "Vận chuyển I", 130, 10, 3.2, 92.5);
            dataTable.Rows.Add("Tháng 10", "VT010", "Vận chuyển J", 190, 7, 2.7, 98.0);
            dataTable.Rows.Add("Tháng 11", "VT011", "Vận chuyển K", 170, 8, 3.0, 94.0);
            dataTable.Rows.Add("Tháng 12", "VT012", "Vận chuyển L", 200, 6, 3.3, 96.0);

            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        // Phương thức dùng để hiển thị báo cáo tình hình thị trường
        private void LoadTinhHinhThiTruongData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tháng", typeof(string));
            dataTable.Columns.Add("Thị trường", typeof(string));
            dataTable.Columns.Add("Số lượng đơn hàng bán ra", typeof(int));
            dataTable.Columns.Add("Tổng doanh thu", typeof(double));
            dataTable.Columns.Add("Loại sản phẩm bán chạy", typeof(string));
            dataTable.Columns.Add("Tỷ lệ tăng trưởng doanh thu (%)", typeof(double));

            // Dữ liệu mẫu cho 12 tháng
            // Dữ liệu mẫu cho 12 tháng
            dataTable.Rows.Add("Tháng 1", "Thị trường A", 300, 1500000, "Sản phẩm điện tử", 5.3);
            dataTable.Rows.Add("Tháng 2", "Thị trường B", 350, 1700000, "Sản phẩm gia dụng", 6.1);
            dataTable.Rows.Add("Tháng 3", "Thị trường C", 280, 1400000, "Sản phẩm thời trang", 4.7);
            dataTable.Rows.Add("Tháng 4", "Thị trường D", 320, 1600000, "Sản phẩm điện thoại", 7.5);
            dataTable.Rows.Add("Tháng 5", "Thị trường E", 380, 1800000, "Sản phẩm máy tính", 8.2);
            dataTable.Rows.Add("Tháng 6", "Thị trường F", 310, 1550000, "Sản phẩm thiết bị gia đình", 5.8);
            dataTable.Rows.Add("Tháng 7", "Thị trường G", 340, 1700000, "Sản phẩm điện tử", 6.4);
            dataTable.Rows.Add("Tháng 8", "Thị trường H", 360, 1750000, "Sản phẩm thời trang", 7.0);
            dataTable.Rows.Add("Tháng 9", "Thị trường I", 330, 1650000, "Sản phẩm gia dụng", 6.5);
            dataTable.Rows.Add("Tháng 10", "Thị trường J", 290, 1450000, "Sản phẩm máy tính", 5.1);
            dataTable.Rows.Add("Tháng 11", "Thị trường K", 310, 1550000, "Sản phẩm điện thoại", 6.3);
            dataTable.Rows.Add("Tháng 12", "Thị trường L", 350, 1700000, "Sản phẩm điện tử", 7.7);

            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        // Phương thức dùng để hiển thị báo cáo thời gian giao hàng trung bình
        private void LoadThoiGianGiaoHangTrungBinhData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tháng", typeof(string));
            dataTable.Columns.Add("Thời gian giao hàng trung bình (ngày)", typeof(double));
            dataTable.Columns.Add("Số lượng đơn hàng", typeof(int));
            dataTable.Columns.Add("Đối tác vận chuyển", typeof(string));
            dataTable.Columns.Add("Tỉ lệ giao hàng đúng hạn (%)", typeof(double));

            // Dữ liệu mẫu cho 12 tháng
            dataTable.Rows.Add("Tháng 1", 3.2, 150, "Vận chuyển A", 95.5);
            dataTable.Rows.Add("Tháng 2", 2.8, 180, "Vận chuyển B", 98.2);
            dataTable.Rows.Add("Tháng 3", 3.0, 160, "Vận chuyển C", 92.3);
            dataTable.Rows.Add("Tháng 4", 2.9, 170, "Vận chuyển A", 96.1);
            dataTable.Rows.Add("Tháng 5", 3.1, 190, "Vận chuyển B", 97.4);
            dataTable.Rows.Add("Tháng 6", 2.7, 200, "Vận chuyển C", 95.8);
            dataTable.Rows.Add("Tháng 7", 3.0, 210, "Vận chuyển A", 94.5);
            dataTable.Rows.Add("Tháng 8", 3.3, 220, "Vận chuyển B", 98.0);
            dataTable.Rows.Add("Tháng 9", 3.2, 230, "Vận chuyển C", 92.0);
            dataTable.Rows.Add("Tháng 10", 2.6, 240, "Vận chuyển A", 96.7);
            dataTable.Rows.Add("Tháng 11", 3.4, 250, "Vận chuyển B", 97.9);
            dataTable.Rows.Add("Tháng 12", 3.1, 260, "Vận chuyển C", 94.0);

            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void btnBaocaosoluongdonhang_Click(object sender, EventArgs e)
        {
            LoadSoLuongDonHangData();
        }

        private void btnBaocaotilekhieunai_Click(object sender, EventArgs e)
        {
            LoadTiLeKhieuNaiData();
        }

        private void btnBaocaohieusuatdoitac_Click(object sender, EventArgs e)
        {
            LoadHieuSuatDoiTacData();
        }

        private void btnBaocaotinhhinhthitruong_Click(object sender, EventArgs e)
        {
            LoadTinhHinhThiTruongData();
        }

        private void btnBaocaothoigiaogiaohangtrungbinh_Click(object sender, EventArgs e)
        {
            LoadThoiGianGiaoHangTrungBinhData();
        }


    }
}
