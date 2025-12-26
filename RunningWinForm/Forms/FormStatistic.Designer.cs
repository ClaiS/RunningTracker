namespace RunningWinForm
{
    partial class FrmStatistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tabStatictis = new System.Windows.Forms.TabControl();
            this.tabVolume = new System.Windows.Forms.TabPage();
            this.chartVolume = new LiveCharts.WinForms.CartesianChart();
            this.tabIntensityAndPerformance = new System.Windows.Forms.TabPage();
            this.chartIntensityAndPerformance = new LiveCharts.WinForms.CartesianChart();
            this.tabDistribution = new System.Windows.Forms.TabPage();
            this.chartDistribution = new LiveCharts.WinForms.PieChart();
            this.grpChooseTime = new System.Windows.Forms.GroupBox();
            this.cmbWeek = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvgPace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrainingLoad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalRuns = new System.Windows.Forms.TextBox();
            this.lblBuoiChay = new System.Windows.Forms.Label();
            this.txtTotalDistance = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabStatictis.SuspendLayout();
            this.tabVolume.SuspendLayout();
            this.tabIntensityAndPerformance.SuspendLayout();
            this.tabDistribution.SuspendLayout();
            this.grpChooseTime.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(710, 25);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(244, 63);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tổng kết";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1489, 1108);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(156, 67);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tabStatictis
            // 
            this.tabStatictis.Controls.Add(this.tabVolume);
            this.tabStatictis.Controls.Add(this.tabIntensityAndPerformance);
            this.tabStatictis.Controls.Add(this.tabDistribution);
            this.tabStatictis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStatictis.Location = new System.Drawing.Point(39, 523);
            this.tabStatictis.Name = "tabStatictis";
            this.tabStatictis.SelectedIndex = 0;
            this.tabStatictis.Size = new System.Drawing.Size(1606, 552);
            this.tabStatictis.TabIndex = 27;
            // 
            // tabVolume
            // 
            this.tabVolume.Controls.Add(this.chartVolume);
            this.tabVolume.Location = new System.Drawing.Point(8, 51);
            this.tabVolume.Name = "tabVolume";
            this.tabVolume.Padding = new System.Windows.Forms.Padding(3);
            this.tabVolume.Size = new System.Drawing.Size(1590, 493);
            this.tabVolume.TabIndex = 0;
            this.tabVolume.Text = "Khối lượng luyện tập";
            this.tabVolume.UseVisualStyleBackColor = true;
            // 
            // chartVolume
            // 
            this.chartVolume.Location = new System.Drawing.Point(0, 3);
            this.chartVolume.Name = "chartVolume";
            this.chartVolume.Size = new System.Drawing.Size(1590, 487);
            this.chartVolume.TabIndex = 0;
            this.chartVolume.Text = "Biểu đồ khối lượng luyện tập";
            // 
            // tabIntensityAndPerformance
            // 
            this.tabIntensityAndPerformance.Controls.Add(this.chartIntensityAndPerformance);
            this.tabIntensityAndPerformance.Location = new System.Drawing.Point(8, 51);
            this.tabIntensityAndPerformance.Name = "tabIntensityAndPerformance";
            this.tabIntensityAndPerformance.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntensityAndPerformance.Size = new System.Drawing.Size(1590, 493);
            this.tabIntensityAndPerformance.TabIndex = 1;
            this.tabIntensityAndPerformance.Text = "Hiệu suất và cường độ";
            this.tabIntensityAndPerformance.UseVisualStyleBackColor = true;
            // 
            // chartIntensityAndPerformance
            // 
            this.chartIntensityAndPerformance.Location = new System.Drawing.Point(0, 3);
            this.chartIntensityAndPerformance.Name = "chartIntensityAndPerformance";
            this.chartIntensityAndPerformance.Size = new System.Drawing.Size(1590, 490);
            this.chartIntensityAndPerformance.TabIndex = 0;
            this.chartIntensityAndPerformance.Text = "Biểu đồ hiệu suất và cường độ";
            // 
            // tabDistribution
            // 
            this.tabDistribution.Controls.Add(this.chartDistribution);
            this.tabDistribution.Location = new System.Drawing.Point(8, 51);
            this.tabDistribution.Name = "tabDistribution";
            this.tabDistribution.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistribution.Size = new System.Drawing.Size(1590, 493);
            this.tabDistribution.TabIndex = 2;
            this.tabDistribution.Text = "Phân bố luyện tập";
            this.tabDistribution.UseVisualStyleBackColor = true;
            // 
            // chartDistribution
            // 
            this.chartDistribution.Location = new System.Drawing.Point(0, 3);
            this.chartDistribution.Name = "chartDistribution";
            this.chartDistribution.Size = new System.Drawing.Size(1590, 487);
            this.chartDistribution.TabIndex = 0;
            this.chartDistribution.Text = "Biểu đồ phân bố luyện tập";
            // 
            // grpChooseTime
            // 
            this.grpChooseTime.Controls.Add(this.cmbWeek);
            this.grpChooseTime.Controls.Add(this.cmbMonth);
            this.grpChooseTime.Controls.Add(this.cmbYear);
            this.grpChooseTime.Controls.Add(this.lblWeek);
            this.grpChooseTime.Controls.Add(this.lblMonth);
            this.grpChooseTime.Controls.Add(this.lblYear);
            this.grpChooseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChooseTime.Location = new System.Drawing.Point(235, 121);
            this.grpChooseTime.Name = "grpChooseTime";
            this.grpChooseTime.Size = new System.Drawing.Size(1250, 142);
            this.grpChooseTime.TabIndex = 28;
            this.grpChooseTime.TabStop = false;
            this.grpChooseTime.Text = "Chọn thời gian bạn muốn xem:";
            // 
            // cmbWeek
            // 
            this.cmbWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWeek.FormattingEnabled = true;
            this.cmbWeek.Location = new System.Drawing.Point(1062, 65);
            this.cmbWeek.Name = "cmbWeek";
            this.cmbWeek.Size = new System.Drawing.Size(121, 41);
            this.cmbWeek.TabIndex = 42;
            this.cmbWeek.SelectedIndexChanged += new System.EventHandler(this.cmbWeek_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(648, 65);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 41);
            this.cmbMonth.TabIndex = 41;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(239, 62);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 41);
            this.cmbYear.TabIndex = 40;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek.Location = new System.Drawing.Point(862, 65);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(171, 36);
            this.lblWeek.TabIndex = 39;
            this.lblWeek.Text = "Chọn tuần:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(443, 65);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(189, 36);
            this.lblMonth.TabIndex = 38;
            this.lblMonth.Text = "Chọn tháng:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(54, 65);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(168, 36);
            this.lblYear.TabIndex = 37;
            this.lblYear.Text = "Chọn năm:";
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.label3);
            this.grpSummary.Controls.Add(this.txtAvgPace);
            this.grpSummary.Controls.Add(this.label2);
            this.grpSummary.Controls.Add(this.txtTrainingLoad);
            this.grpSummary.Controls.Add(this.label1);
            this.grpSummary.Controls.Add(this.txtTotalRuns);
            this.grpSummary.Controls.Add(this.lblBuoiChay);
            this.grpSummary.Controls.Add(this.txtTotalDistance);
            this.grpSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSummary.Location = new System.Drawing.Point(47, 291);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(1590, 212);
            this.grpSummary.TabIndex = 29;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Tổng quan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(856, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 36);
            this.label3.TabIndex = 40;
            this.label3.Text = "Pace trung bình";
            // 
            // txtAvgPace
            // 
            this.txtAvgPace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgPace.Location = new System.Drawing.Point(1183, 141);
            this.txtAvgPace.Name = "txtAvgPace";
            this.txtAvgPace.ReadOnly = true;
            this.txtAvgPace.Size = new System.Drawing.Size(298, 41);
            this.txtAvgPace.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(856, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 36);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tải luyện tập:";
            // 
            // txtTrainingLoad
            // 
            this.txtTrainingLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainingLoad.Location = new System.Drawing.Point(1183, 58);
            this.txtTrainingLoad.Name = "txtTrainingLoad";
            this.txtTrainingLoad.ReadOnly = true;
            this.txtTrainingLoad.Size = new System.Drawing.Size(298, 41);
            this.txtTrainingLoad.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 36);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tổng buổi chạy:";
            // 
            // txtTotalRuns
            // 
            this.txtTotalRuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRuns.Location = new System.Drawing.Point(461, 53);
            this.txtTotalRuns.Name = "txtTotalRuns";
            this.txtTotalRuns.ReadOnly = true;
            this.txtTotalRuns.Size = new System.Drawing.Size(298, 41);
            this.txtTotalRuns.TabIndex = 37;
            // 
            // lblBuoiChay
            // 
            this.lblBuoiChay.AutoSize = true;
            this.lblBuoiChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuoiChay.Location = new System.Drawing.Point(90, 141);
            this.lblBuoiChay.Name = "lblBuoiChay";
            this.lblBuoiChay.Size = new System.Drawing.Size(294, 36);
            this.lblBuoiChay.TabIndex = 34;
            this.lblBuoiChay.Text = "Tổng quãng đường:";
            // 
            // txtTotalDistance
            // 
            this.txtTotalDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDistance.Location = new System.Drawing.Point(461, 138);
            this.txtTotalDistance.Name = "txtTotalDistance";
            this.txtTotalDistance.ReadOnly = true;
            this.txtTotalDistance.Size = new System.Drawing.Size(298, 41);
            this.txtTotalDistance.TabIndex = 35;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(39, 1108);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(216, 67);
            this.btnPrint.TabIndex = 30;
            this.btnPrint.Text = "In thống kê";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmStatistic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1674, 1229);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpChooseTime);
            this.Controls.Add(this.tabStatictis);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblTimKiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStatistic";
            this.Text = "Thống kê chạy";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.tabStatictis.ResumeLayout(false);
            this.tabVolume.ResumeLayout(false);
            this.tabIntensityAndPerformance.ResumeLayout(false);
            this.tabDistribution.ResumeLayout(false);
            this.grpChooseTime.ResumeLayout(false);
            this.grpChooseTime.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TabControl tabStatictis;
        private System.Windows.Forms.TabPage tabVolume;
        private System.Windows.Forms.TabPage tabIntensityAndPerformance;
        private System.Windows.Forms.GroupBox grpChooseTime;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAvgPace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrainingLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalRuns;
        private System.Windows.Forms.Label lblBuoiChay;
        private System.Windows.Forms.TextBox txtTotalDistance;
        private System.Windows.Forms.ComboBox cmbWeek;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TabPage tabDistribution;
        private LiveCharts.WinForms.CartesianChart chartVolume;
        private LiveCharts.WinForms.CartesianChart chartIntensityAndPerformance;
        private LiveCharts.WinForms.PieChart chartDistribution;
        private System.Windows.Forms.Button btnPrint;
    }
}