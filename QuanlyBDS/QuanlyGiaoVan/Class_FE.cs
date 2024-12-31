using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class NoBorderButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        pevent.Graphics.Clear(this.BackColor); // Xóa viền
        base.OnPaint(pevent);
    }
}
public class CirclePanel : Panel
{
    public Image CircleImage { get; set; } // Thuộc tính để lưu ảnh
    public Color CircleColor { get; set; } = Color.Gray; // Màu nền mặc định

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        // Vẽ hình tròn với màu sắc đã chỉ định
        g.FillEllipse(new SolidBrush(CircleColor), 0, 0, Width, Height);

        // Nếu có ảnh, vẽ ảnh bên trong hình tròn
        if (CircleImage != null)
        {
            // Tính toán vị trí và kích thước để ảnh vừa với hình tròn
            int size = Math.Min(Width, Height);
            g.SetClip(new Rectangle(0, 0, size, size)); // Thiết lập clip để chỉ vẽ trong hình tròn
            g.DrawImage(CircleImage, 0, 0, size, size); // Vẽ ảnh
        }

        base.OnPaint(e);
    }
}
    public class RoundPanel : Panel
{
    // Bán kính bo tròn cho từng góc
    public int CornerRadiusTopLeft { get; set; } = 0;
    public int CornerRadiusTopRight { get; set; } = 20;
    public int CornerRadiusBottomLeft { get; set; } = 0;
    public int CornerRadiusBottomRight { get; set; } = 20;

    public Color BorderColor { get; set; } = Color.Black;
    public float BorderThickness { get; set; } = 2f;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Tạo GraphicsPath với góc bo tùy chỉnh
        GraphicsPath path = new GraphicsPath();

        // Góc trên bên trái
        if (CornerRadiusTopLeft > 0)
        {
            path.AddArc(0, 0, CornerRadiusTopLeft * 2, CornerRadiusTopLeft * 2, 180, 90);
        }
        else
        {
            path.AddLine(0, 0, 0, 0);
        }

        // Cạnh trên
        path.AddLine(CornerRadiusTopLeft, 0, Width - CornerRadiusTopRight, 0);

        // Góc trên bên phải
        if (CornerRadiusTopRight > 0)
        {
            path.AddArc(Width - CornerRadiusTopRight * 2, 0, CornerRadiusTopRight * 2, CornerRadiusTopRight * 2, 270, 90);
        }
        else
        {
            path.AddLine(Width, 0, Width, 0);
        }

        // Cạnh phải
        path.AddLine(Width, CornerRadiusTopRight, Width, Height - CornerRadiusBottomRight);

        // Góc dưới bên phải
        if (CornerRadiusBottomRight > 0)
        {
            path.AddArc(Width - CornerRadiusBottomRight * 2, Height - CornerRadiusBottomRight * 2, CornerRadiusBottomRight * 2, CornerRadiusBottomRight * 2, 0, 90);
        }
        else
        {
            path.AddLine(Width, Height, Width, Height);
        }

        // Cạnh dưới
        path.AddLine(Width - CornerRadiusBottomRight, Height, CornerRadiusBottomLeft, Height);

        // Góc dưới bên trái
        if (CornerRadiusBottomLeft > 0)
        {
            path.AddArc(0, Height - CornerRadiusBottomLeft * 2, CornerRadiusBottomLeft * 2, CornerRadiusBottomLeft * 2, 90, 90);
        }
        else
        {
            path.AddLine(0, Height, 0, Height);
        }

        // Cạnh trái
        path.AddLine(0, Height - CornerRadiusBottomLeft, 0, CornerRadiusTopLeft);

        path.CloseFigure();

        // Fill background
        using (SolidBrush brush = new SolidBrush(BackColor))
        {
            e.Graphics.FillPath(brush, path);
        }

        // Vẽ viền nếu cần
        using (Pen pen = new Pen(BorderColor, BorderThickness))
        {
            e.Graphics.DrawPath(pen, path);
        }

        // Thiết lập vùng hiển thị (Region) của Panel
        this.Region = new Region(path);
    }
}
