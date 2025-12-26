using RunningWinForm.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunningWinForm.Services.DTOs;

namespace RunningWinForm.Services.Helpers
{
    public static class CalendarHelper
    {
        private static string GetDayNameVN(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday: return "T2";
                case DayOfWeek.Tuesday: return "T3";
                case DayOfWeek.Wednesday: return "T4";
                case DayOfWeek.Thursday: return "T5";
                case DayOfWeek.Friday: return "T6";
                case DayOfWeek.Saturday: return "T7";
                case DayOfWeek.Sunday: return "CN";
                default: return "";
            }
        }
        public static List<ChartDataDTO> GroupByMonth(List<RunSession> runs)
        {
            return runs.GroupBy(r => r.RunDate.Month)
                       .OrderBy(g => g.Key)
                       .Select(g => new ChartDataDTO
                       {
                           Label = "T" + g.Key,
                           // FIX: Ép kiểu (double) cho Distance
                           Value = (double)g.Sum(r => r.Distance),
                           // FIX: Ép kiểu (double) cho tham số thứ 2
                           SecondValue = CalculateAvgPace((double)g.Sum(r => r.Duration), (double)g.Sum(r => r.Distance))
                       }).ToList();
        }

        public static List<ChartDataDTO> GroupByWeek(List<RunSession> runs)
        {
            var cal = CultureInfo.CurrentCulture.Calendar;
            return runs.GroupBy(r => cal.GetWeekOfYear(r.RunDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday))
                       .OrderBy(g => g.Key)
                       .Select(g => new ChartDataDTO
                       {
                           Label = "W" + g.Key,
                           // FIX: Ép kiểu (double)
                           Value = (double)g.Sum(r => r.Distance),
                           // FIX: Ép kiểu (double)
                           SecondValue = CalculateAvgPace((double)g.Sum(r => r.Duration), (double)g.Sum(r => r.Distance))
                       }).ToList();
        }

        public static List<ChartDataDTO> GroupByDay(List<RunSession> runs)
        {
            return runs.GroupBy(r => r.RunDate.DayOfWeek)
                       .OrderBy(g => ((int)g.Key == 0) ? 7 : (int)g.Key)
                       .Select(g => new ChartDataDTO
                       {
                           Label = GetDayNameVN(g.Key),
                           // FIX: Ép kiểu (double)
                           Value = (double)g.Sum(r => r.Distance),
                           // FIX: Ép kiểu (double)
                           SecondValue = CalculateAvgPace((double)g.Sum(r => r.Duration), (double)g.Sum(r => r.Distance))
                       }).ToList();
        }

        public static List<ChartDataDTO> GroupByRunType(List<RunSession> runs)
        {
            return runs.GroupBy(r => r.RunType)
                       .Select(g => new ChartDataDTO
                       {
                           Label = g.Key,
                           Value = g.Count()
                       }).ToList();
        }

        public static   double CalculateAvgPace(double duration, double distance)
        {
            if (distance == 0) return 0;
            return Math.Round((duration / distance) / 60.0, 2);
        }
    }
}
