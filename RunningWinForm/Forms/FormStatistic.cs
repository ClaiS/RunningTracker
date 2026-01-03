using LiveCharts;
using LiveCharts.Wpf;
using RunningWinForm.Data;
using RunningWinForm.Data.Repositories;
using RunningWinForm.Forms;
using RunningWinForm.Models;
using RunningWinForm.Services;
using RunningWinForm.Services.DTOs;
using RunningWinForm.Services.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace RunningWinForm
{
    public partial class FrmStatistic : Form
    {
        private readonly User _currentUser;
        private bool _isLoading = false;
        private readonly StatisticService _statisticService;
        private readonly UserServices _userServices;

        public FrmStatistic(User currentUser)
        {
            _currentUser = currentUser;
            var context = new RunningContext();
            var runRepo = new Data.Repositories.RunRepository(context);
            var userRepo = new Data.Repositories.UserRepository(context);
            _statisticService = new StatisticService(runRepo);
            _userServices = new UserServices(userRepo);
            InitializeComponent();
        }

        private string GetDateRangeLabel()
        {
            // 1. Lấy các giá trị hiện tại từ ComboBox
            // Lưu ý: cmbYear load List<int> nên SelectedItem là int
            string selectedYear = cmbYear.SelectedItem != null ? cmbYear.SelectedItem.ToString() : DateTime.Now.Year.ToString();

            // Lấy giá trị Tháng (ValueMember là int, key 0 là "Cả năm")
            int selectedMonth = 0;
            if (cmbMonth.SelectedValue != null)
            {
                int.TryParse(cmbMonth.SelectedValue.ToString(), out selectedMonth);
            }

            // Lấy giá trị Tuần (ValueMember là int, key 0 là "Cả tháng")
            int selectedWeek = 0;
            if (cmbWeek.Enabled && cmbWeek.SelectedValue != null)
            {
                int.TryParse(cmbWeek.SelectedValue.ToString(), out selectedWeek);
            }

            // 2. Xử lý Logic hiển thị theo cấp độ

            // TRƯỜNG HỢP 1: XEM CẢ NĂM (Tháng = 0)
            if (selectedMonth == 0)
            {
                return $"BÁO CÁO TỔNG HỢP NĂM {selectedYear}";
            }

            // TRƯỜNG HỢP 2: XEM CẢ THÁNG (Tháng > 0 và Tuần = 0)
            else if (selectedWeek == 0)
            {
                return $"BÁO CÁO THÁNG {selectedMonth} / {selectedYear}";
            }

            // TRƯỜNG HỢP 3: XEM CHI TIẾT TUẦN (Tuần > 0)
            else
            {
                return $"BÁO CÁO CHI TIẾT TUẦN {selectedWeek}\n(Tháng {selectedMonth} Năm {selectedYear})";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            LoadYears();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return; // Nếu đang nạp code thì không làm gì cả
            LoadMonths(); // Chọn năm khác -> Reset lại tháng
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;
            LoadWeeks(); // Chọn tháng khác -> Tính lại danh sách tuần
        }

        private void cmbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;
            LoadChartData(); // Chọn tuần khác -> Vẽ lại biểu đồ
        }

        private void LoadYears()
        {
            _isLoading = true; // Bắt đầu nạp, tạm dừng xử lý sự kiện

            // Gọi Service lấy các năm user đã chạy
            var years = _statisticService.GetYears(_currentUser.UserID);

            // Nếu user mới tinh chưa chạy lần nào -> Thêm năm nay vào để không bị lỗi
            if (years.Count == 0) years.Add(DateTime.Now.Year);

            cmbYear.DataSource = years;
            cmbYear.SelectedIndex = 0; // Mặc định chọn năm mới nhất

            _isLoading = false; // Nạp xong

            // Sau khi có Năm -> Tự động nạp Tháng
            LoadMonths();
        }

        private void LoadMonths()
        {
            _isLoading = true;

            // Tạo danh sách tháng: 0 là "Cả năm", 1-12 là tháng
            var months = new Dictionary<int, string>();
            months.Add(0, "Cả năm");
            for (int i = 1; i <= 12; i++)
            {
                months.Add(i, "Tháng " + i);
            }

            cmbMonth.DataSource = new BindingSource(months, null);
            cmbMonth.DisplayMember = "Value"; // Hiển thị chữ "Tháng 1"
            cmbMonth.ValueMember = "Key";     // Giá trị ngầm là số 1

            cmbMonth.SelectedIndex = 0; // Mặc định chọn "Cả năm"

            _isLoading = false;

            // Sau khi có Tháng -> Tự động nạp Tuần
            LoadWeeks();
        }

        private void LoadWeeks()
        {
            _isLoading = true;

            // Lấy giá trị đang chọn
            int selectedYear = (int)cmbYear.SelectedItem;
            int selectedMonth = (int)cmbMonth.SelectedValue;

            var weeks = new Dictionary<int, string>();
            weeks.Add(0, "Cả tháng");

            // Chỉ nạp danh sách tuần nếu người dùng ĐÃ chọn một tháng cụ thể
            if (selectedMonth > 0)
            {
                // Logic tính toán: Lấy tất cả các tuần trong tháng đó
                var culture = CultureInfo.CurrentCulture;
                var calendar = culture.Calendar;

                // Ngày đầu tháng và ngày cuối tháng
                DateTime firstDayOfMonth = new DateTime(selectedYear, selectedMonth, 1);
                DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                // Lấy số tuần của ngày đầu và ngày cuối
                int startWeek = calendar.GetWeekOfYear(firstDayOfMonth, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                int endWeek = calendar.GetWeekOfYear(lastDayOfMonth, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

                // Xử lý trường hợp đặc biệt cuối năm (tuần 52/53)
                if (endWeek < startWeek) endWeek = 53;

                for (int w = startWeek; w <= endWeek; w++)
                {
                    // Nếu tuần > 52 thì có thể là tuần 1 của năm sau, nhưng ở đây ta cứ hiện số tuần thực tế
                    weeks.Add(w, "Tuần " + w);
                }
                cmbWeek.Enabled = true;
            }
            else
            {
                // Nếu chọn "Cả năm" thì khóa ô chọn Tuần lại
                cmbWeek.Enabled = false;
            }

            cmbWeek.DataSource = new BindingSource(weeks, null);
            cmbWeek.DisplayMember = "Value";
            cmbWeek.ValueMember = "Key";
            cmbWeek.SelectedIndex = 0;

            _isLoading = false;

            // Cuối cùng: Nạp dữ liệu lên biểu đồ (Hàm này mình sẽ viết ở bước sau)
            LoadChartData();
        }

        private void LoadChartData()
        {
            if (cmbYear.SelectedItem == null) return; // Kiểm tra an toàn

            int year = (int)cmbYear.SelectedItem;
            int? month = null;
            int? week = null;

            // Lấy tháng (Nếu chọn "Cả năm" có value = 0 -> thì month = null)
            if (cmbMonth.SelectedValue != null)
            {
                int m = 0;
                int.TryParse(cmbMonth.SelectedValue.ToString(), out m);
                if (m > 0) month = m;
            }

            // Lấy tuần (Tương tự, nếu chọn "Cả tháng" -> week = null)
            if (cmbWeek.Enabled && cmbWeek.SelectedValue != null)
            {
                int w = 0;
                int.TryParse(cmbWeek.SelectedValue.ToString(), out w);
                if (w > 0) week = w;
            }

            var result = _statisticService.GetStatistics(_currentUser.UserID, year, month, week);

            // 3. Đổ dữ liệu Tổng quan (Overview) ra các ô text
            if (result != null && result.Overview != null)
            {
                txtTotalRuns.Text = result.Overview.TotalRuns.ToString();

                // Format quãng đường: Ví dụ 10.5 km
                txtTotalDistance.Text = result.Overview.TotalDistance.ToString() + " km";

                txtTrainingLoad.Text = result.Overview.TotalTrainingLoad.ToString();

                // Pace đã được format sẵn dạng "mm:ss" bên Service
                txtAvgPace.Text = result.Overview.AvgPaceFormatted;
            }

            if (result == null) return;

            // TAB 1: BIỂU ĐỒ KHỐI LƯỢNG (Distance - Cột)
            DrawVolumeChart(result.VolumeData);

            // TAB 2: BIỂU ĐỒ HIỆU SUẤT (Pace - Đường)
            DrawPerformanceChart(result.PerformanceData);

            // TAB 3: BIỂU ĐỒ PHÂN BỐ (Pie Chart - Run Type)
            DrawDistributionChart(result.DistributionData);
        }

        private void DrawVolumeChart(List<RunningWinForm.Services.DTOs.ChartDataDTO> data)
        {
            chartVolume.Series.Clear();
            chartVolume.AxisX.Clear();
            chartVolume.AxisY.Clear();

            var colSeries = new ColumnSeries
            {
                Title = "Quãng đường",
                Values = new ChartValues<double>(data.Select(x => x.Value)),
                DataLabels = true
            };
            chartVolume.Series.Add(colSeries);

            // Trục X: Là các nhãn (Tháng 1, Tháng 2... hoặc T2, T3...)
            chartVolume.AxisX.Add(new Axis
            {
                Title = "Thời gian",
                Labels = data.Select(x => x.Label).ToList(),
                Separator = new LiveCharts.Wpf.Separator { Step = 1 } // Đảm bảo hiện đủ nhãn
            });

            // Trục Y
            chartVolume.AxisY.Add(new Axis
            {
                Title = "Km",
                LabelFormatter = value => value.ToString("N1")
            });
        }

        private void DrawPerformanceChart(List<RunningWinForm.Services.DTOs.ChartDataDTO> data)
        {
            chartIntensityAndPerformance.Series.Clear();
            chartIntensityAndPerformance.AxisX.Clear();
            chartIntensityAndPerformance.AxisY.Clear();

            if (data == null || data.Count == 0) return;

            var lineSeries = new LineSeries
            {
                Title = "Pace trung bình",
                // Lấy SecondValue, nếu null thì coi là 0
                Values = new ChartValues<double>(data.Select(x => x.SecondValue ?? 0)),
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 10,
                LineSmoothness = 0 // Đường thẳng gấp khúc (0) hay cong (1)
            };
            chartIntensityAndPerformance.Series.Add(lineSeries);

            chartIntensityAndPerformance.AxisX.Add(new Axis
            {
                Title = "Thời gian",
                Labels = data.Select(x => x.Label).ToList(),
                Separator = new LiveCharts.Wpf.Separator { Step = 1 }
            });

            chartIntensityAndPerformance.AxisY.Add(new Axis
            {
                Title = "Pace (phút/km)",
                LabelFormatter = value => value.ToString("N2")
            });
        }

        private void DrawDistributionChart(List<RunningWinForm.Services.DTOs.ChartDataDTO> data)
        {
            chartDistribution.Series.Clear();

            if (data == null || data.Count == 0) return;

            // Định dạng chữ hiển thị trên miếng bánh: VD "Interval (25%)"
            Func<ChartPoint, string> labelPoint = chartPoint =>
        string.Format("{0} ({1:P0})", chartPoint.SeriesView.Title, chartPoint.Participation);

            var pieSeriesCollection = new SeriesCollection();

            foreach (var item in data)
            {
                pieSeriesCollection.Add(new PieSeries
                {
                    Title = item.Label,
                    Values = new ChartValues<double> { item.Value },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            }

            chartDistribution.Series = pieSeriesCollection;
            chartDistribution.LegendLocation = LegendLocation.Right;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotalRuns.Text))
            {
                MessageBox.Show("Vui lòng xem thống kê trước khi in!");
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            try
            {
                // Lấy dữ liệu từ Service
                int year = (int)cmbYear.SelectedItem;
                int? month = null;
                int? week = null;

                if (cmbMonth.SelectedValue != null)
                {
                    int m = 0;
                    int.TryParse(cmbMonth.SelectedValue.ToString(), out m);
                    if (m > 0) month = m;
                }

                if (cmbWeek.Enabled && cmbWeek.SelectedValue != null)
                {
                    int w = 0;
                    int.TryParse(cmbWeek.SelectedValue.ToString(), out w);
                    if (w > 0) week = w;
                }

                string timeLabel = GetDateRangeLabel();

                var result = _statisticService.GetStatistics(_currentUser.UserID, year, month, week);

                // Tạo DTO cho thông tin tổng quan
                var printData = new RunningWinForm.Services.DTOs.ReportPrintDTO
                {
                    UserName = _userServices.GetUserById(_currentUser.UserID).FullName,
                    PrintedDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    DateRange = timeLabel,
                    TotalRuns = txtTotalRuns.Text,
                    TotalDistance = txtTotalDistance.Text,
                    TotalLoad = txtTrainingLoad.Text,
                    AvgPace = txtAvgPace.Text
                };

                // Mở Form in với 4 tham số
                FormPrint frm = new FormPrint(
                    printData,
                    result.VolumeData,
                    result.PerformanceData,
                    result.DistributionData
                );

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo báo cáo:\n\n{ex.Message}\n\n{ex.StackTrace}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
