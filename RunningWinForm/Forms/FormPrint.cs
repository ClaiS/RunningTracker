using Microsoft.Reporting.WinForms;
using RunningWinForm.Services.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RunningWinForm.Forms
{
    public partial class FormPrint : Form
    {
        private ReportPrintDTO _data;
        public FormPrint(ReportPrintDTO data)
        {
            InitializeComponent();
            _data = data;
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {

            this.reportViewer1.LocalReport.DataSources.Clear();
            string exeFolder = Application.StartupPath;
            string reportPath = Path.Combine(exeFolder, "Forms", "RunningReport.rdlc");

            // 2. Trỏ đường dẫn đến file .rdlc (Nhớ copy file rdlc vào thư mục bin hoặc chỉnh property 'Copy to Output' là Copy Always)
            // Cách đơn giản nhất: Đặt đường dẫn tương đối
            this.reportViewer1.LocalReport.ReportPath = reportPath;

            // 3. Nạp dữ liệu vào Dataset
            // "RunningDataSet" phải trùng tên với cái Dataset bạn tạo lúc thiết kế ở Bước 3
            var rds = new ReportDataSource("RunningDataSet", new List<ReportPrintDTO> { _data });
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            // 4. Refresh
            this.reportViewer1.RefreshReport();
        }
    }
}
