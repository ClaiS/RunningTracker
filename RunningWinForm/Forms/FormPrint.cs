using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using RunningWinForm.Services.DTOs;
using System.IO;

namespace RunningWinForm.Forms
{
    public partial class FormPrint : Form
    {
        private readonly ReportPrintDTO _info;
        private readonly List<ChartDataDTO> _volData;
        private readonly List<ChartDataDTO> _perfData;
        private readonly List<ChartDataDTO> _distData;

        // Constructor nhận 4 tham số
        public FormPrint(ReportPrintDTO info,
                         List<ChartDataDTO> volData,
                         List<ChartDataDTO> perfData,
                         List<ChartDataDTO> distData)
        {
            InitializeComponent();

            _info = info;
            _volData = volData ?? new List<ChartDataDTO>();
            _perfData = perfData ?? new List<ChartDataDTO>();
            _distData = distData ?? new List<ChartDataDTO>();
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Clear data sources cũ
                this.reportViewer1.LocalReport.DataSources.Clear();

                // 2. Tìm file RDLC
                string rdlcPath = FindRdlcFile();

                if (string.IsNullOrEmpty(rdlcPath))
                {
                    MessageBox.Show("Không tìm thấy file RunningReport.rdlc!\n\n" +
                                    "Vui lòng kiểm tra:\n" +
                                    "1. File RunningReport.rdlc có trong project\n" +
                                    "2. Build Action = Embedded Resource",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Load RDLC file
                this.reportViewer1.LocalReport.ReportEmbeddedResource = rdlcPath;

                // 4. Gán dữ liệu vào các DataSet
                // Tên DataSet phải khớp với tên trong file RDLC
                this.reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("RunningReport", new List<ReportPrintDTO> { _info }));

                this.reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSetVolume", _volData));

                this.reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSetPerformance", _perfData));

                this.reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSetDistribution", _distData));

                // 5. Refresh report
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải báo cáo:\n\n{ex.Message}\n\n{ex.StackTrace}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FindRdlcFile()
        {
            try
            {
                // Cách 1: Tìm trong Embedded Resources
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                string[] resources = assembly.GetManifestResourceNames();

                // Tìm file có tên chứa "RunningReport.rdlc"
                string rdlcResource = resources.FirstOrDefault(r => r.EndsWith("RunningReport.rdlc", StringComparison.OrdinalIgnoreCase));

                if (!string.IsNullOrEmpty(rdlcResource))
                {
                    return rdlcResource;
                }

                // Nếu không tìm thấy, log ra tất cả resources để debug
                string allResources = string.Join("\n", resources);
                System.Diagnostics.Debug.WriteLine("=== TẤT CẢ EMBEDDED RESOURCES ===");
                System.Diagnostics.Debug.WriteLine(allResources);
                System.Diagnostics.Debug.WriteLine("=================================");

                // Cách 2: Thử tìm file trực tiếp trong thư mục
                string exePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                string rdlcPath = System.IO.Path.Combine(exePath, "RunningReport.rdlc");

                if (File.Exists(rdlcPath))
                {
                    // Load từ file path thay vì embedded resource
                    this.reportViewer1.LocalReport.ReportPath = rdlcPath;
                    return null; // Trả null vì đã set ReportPath rồi
                }

                return null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error finding RDLC: {ex.Message}");
                return null;
            }
        }
    }
}