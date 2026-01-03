using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Services.DTOs
{
    public class ReportPrintDTO
    {
        // Thông tin User & Ngày in
        public string UserName { get; set; }
        public string PrintedDate { get; set; }
        public string DateRange { get; set; }

        // Số liệu tổng quan
        public string TotalRuns { get; set; }
        public string TotalDistance { get; set; }
        public string TotalLoad { get; set; }
        public string AvgPace { get; set; }
    }

    public class ChartDataDTO
    {
        public string Label { get; set; }
        public double Value { get; set; }
        public double? SecondValue { get; set; }
    }
}
