using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Services.DTOs
{
    // 2. DTO cho phần tổng quan
    public class OverviewStatDTO
    {
        public int TotalRuns { get; set; }
        public double TotalDistance { get; set; }
        public double TotalTrainingLoad { get; set; }
        public string AvgPaceFormatted { get; set; }
    }

    // 3. DTO kết quả trả về (Cái bạn đang bị báo lỗi đỏ)
    public class StatisticResultDTO
    {
        public OverviewStatDTO Overview { get; set; }
        public List<ChartDataDTO> VolumeData { get; set; }
        public List<ChartDataDTO> PerformanceData { get; set; }
        public List<ChartDataDTO> DistributionData { get; set; }
    }
}
