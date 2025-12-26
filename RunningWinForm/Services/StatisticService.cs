using RunningWinForm.Data.Repositories;
using RunningWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunningWinForm.Services.DTOs;
using RunningWinForm.Services.Helpers;

namespace RunningWinForm.Services
{
    public class StatisticService
    {
        private readonly RunRepository _runRepo;

        public StatisticService(RunRepository runRepo)
        {
            _runRepo = runRepo;
        }

        public List<int> GetYears(int userId)
        {
            return _runRepo.GetAvailableYears(userId);
        }

        public StatisticResultDTO GetStatistics(int userId, int year, int? month, int? week)
        {
            // Bước 1: Lấy dữ liệu thô từ Repo
            var rawRuns = _runRepo.GetRunsByFilter(userId, year, month, week);

            // Bước 2: Khởi tạo kết quả
            var result = new StatisticResultDTO();

            // Bước 3: Tính toán Tổng quan (4 Label to)
            result.Overview = CalculateOverview(rawRuns);

            // Bước 4: Chuẩn bị dữ liệu cho 3 biểu đồ
            // Logic: 
            // - Nếu xem Cả năm (Month = null) -> Trục X là Tháng (1-12)
            // - Nếu xem Tháng (Month != null) -> Trục X là Tuần (hoặc Ngày)
            // - Nếu xem Tuần (Week != null) -> Trục X là Ngày (Thứ 2 - CN)

            if (week.HasValue)
            {
                // View theo Ngày (trong tuần)
                result.VolumeData = CalendarHelper.GroupByDay(rawRuns);
                result.PerformanceData = CalendarHelper.GroupByDay(rawRuns);
            }
            else if (month.HasValue)
            {
                // View theo Tuần (trong tháng)
                result.VolumeData = CalendarHelper.GroupByWeek(rawRuns);
                result.PerformanceData = CalendarHelper.GroupByWeek(rawRuns);
            }
            else
            {
                // View theo Tháng (trong năm)
                result.VolumeData = CalendarHelper.GroupByMonth(rawRuns);
                result.PerformanceData =CalendarHelper.GroupByMonth(rawRuns);
            }

            // Biểu đồ tròn (Luôn group theo RunType)
            result.DistributionData = CalendarHelper.GroupByRunType(rawRuns);

            return result;
        }

        private OverviewStatDTO CalculateOverview(List<RunSession> runs)
        {
            if (runs == null || runs.Count == 0)
                return new OverviewStatDTO { AvgPaceFormatted = "00:00" };

            double totalDistance = (double)runs.Sum(r => r.Distance);
            double totalDuration = (double)runs.Sum(r => r.Duration); // Giây

            // Công thức Foster: (Giây / 60) * RPE
            double totalLoad = runs.Sum(r => ((double)r.Duration / 60) * r.RPE);

            // Pace trung bình = Tổng giây / Tổng Km
            int avgPaceSeconds = totalDistance > 0 ? (int)(totalDuration / totalDistance) : 0;

            return new OverviewStatDTO
            {
                TotalRuns = runs.Count,
                TotalDistance = Math.Round(totalDistance, 2),
                TotalTrainingLoad = Math.Round(totalLoad, 1),
                AvgPaceFormatted = TimeSpan.FromSeconds(avgPaceSeconds).ToString(@"mm\:ss")
            };
        }
    }
}
