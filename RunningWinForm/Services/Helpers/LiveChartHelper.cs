using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Wpf = LiveCharts.Wpf;
using WinForms = LiveCharts.WinForms;

namespace RunningWinForm.Services.Helpers
{
    public static class LiveChartHelper
    {
        public static byte[] CaptureCartesianChart(WinForms.CartesianChart sourceChart, int width = 1600, int height = 900)
        {
            try
            {
                var tempChart = new WinForms.CartesianChart
                {
                    DisableAnimations = true,
                    DataTooltip = null,
                    Size = new Size(width, height),
                    // QUAN TRỌNG: Phải set nền trắng cho cả WinForm Control và WPF Host
                    BackColor = System.Drawing.Color.White,
                    LegendLocation = sourceChart.LegendLocation
                };

                // Clone dữ liệu thay vì Add trực tiếp (để tránh lỗi collection)
                foreach (Wpf.Series series in sourceChart.Series)
                {
                    // Tạo một Series mới cùng kiểu, copy Values
                    var newSeries = (Wpf.Series)Activator.CreateInstance(series.GetType());
                    newSeries.Title = series.Title;
                    newSeries.Values = series.Values; // Reference chart values is safe
                    newSeries.Fill = series.Fill;
                    newSeries.Stroke = series.Stroke;
                    newSeries.PointGeometry = series.PointGeometry;

                    // Xử lý riêng cho LineSeries để bỏ điểm tròn nếu cần
                    if (newSeries is Wpf.LineSeries line)
                    {
                        line.LineSmoothness = ((Wpf.LineSeries)series).LineSmoothness;
                    }

                    tempChart.Series.Add(newSeries);
                }

                foreach (var axis in sourceChart.AxisX) tempChart.AxisX.Add(CloneAxis(axis));
                foreach (var axis in sourceChart.AxisY) tempChart.AxisY.Add(CloneAxis(axis));

                return RenderAndCapture(tempChart, width, height);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error Cartesian: {ex.Message}");
                return new byte[0];
            }
        }

        public static byte[] CapturePieChart(WinForms.PieChart sourceChart, int width = 1600, int height = 900)
        {
            try
            {
                var tempChart = new WinForms.PieChart
                {
                    DisableAnimations = true,
                    DataTooltip = null,
                    Size = new Size(width, height),
                    // QUAN TRỌNG: Set nền trắng
                    BackColor = System.Drawing.Color.White,
                    LegendLocation = sourceChart.LegendLocation
                };

                foreach (Wpf.PieSeries series in sourceChart.Series)
                {
                    var newSeries = new Wpf.PieSeries
                    {
                        Title = series.Title,
                        Values = series.Values,
                        Fill = series.Fill,
                        DataLabels = true,
                        LabelPoint = series.LabelPoint
                    };
                    tempChart.Series.Add(newSeries);
                }

                return RenderAndCapture(tempChart, width, height);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error Pie: {ex.Message}");
                return new byte[0];
            }
        }

        private static Wpf.Axis CloneAxis(Wpf.Axis source)
        {
            return new Wpf.Axis
            {
                Title = source.Title,
                Labels = source.Labels,
                Separator = source.Separator,
                MinValue = source.MinValue,
                MaxValue = source.MaxValue
            };
        }

        private static byte[] RenderAndCapture(Control chartControl, int width, int height)
        {
            using (Form tempForm = new Form())
            {
                tempForm.Size = new Size(width, height);
                tempForm.FormBorderStyle = FormBorderStyle.None;
                tempForm.StartPosition = FormStartPosition.Manual;
                // Đừng đẩy quá xa, đẩy vừa đủ khuất thôi
                tempForm.Location = new Point(-width - 100, -height - 100);
                tempForm.BackColor = System.Drawing.Color.White;

                chartControl.Dock = DockStyle.Fill;
                tempForm.Controls.Add(chartControl);

                tempForm.Show();
                // Bắt buộc gọi 2 lệnh này để Chart vẽ lên
                chartControl.Update();
                Application.DoEvents();

                // Tăng thời gian chờ render lên 1 chút để đảm bảo hình vẽ xong
                System.Threading.Thread.Sleep(500);

                Bitmap bmp = new Bitmap(width, height);
                chartControl.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

                tempForm.Close();

                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }
    }
}
