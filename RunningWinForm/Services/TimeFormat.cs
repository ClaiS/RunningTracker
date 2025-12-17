using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace RunningWinForm.Services
{
    public static class TimeFormat
    {
        public static string FormatDuration(int totalSeconds)
        {
            var hours = totalSeconds / 3600;
            var minutes = (totalSeconds % 3600) / 60;
            var seconds = totalSeconds % 60;
            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        public static string FormatPace(int totalSeconds)
        {
            var minutes = totalSeconds / 60;
            var seconds = totalSeconds % 60;
            return $"{minutes:D2}:{seconds:D2}";
        }

        // Chuyển String vào cmb khi CellClick
        public static void RedoTime(string timeString,
                          System.Windows.Forms.ComboBox cbHour,
                          System.Windows.Forms.ComboBox cbMin,
                          System.Windows.Forms.ComboBox cbSec)
        {
            if (cbHour != null) cbHour.SelectedIndex = -1;
            if (cbMin != null) cbMin.SelectedIndex = -1;
            if (cbSec != null) cbSec.SelectedIndex = -1;

            if (string.IsNullOrEmpty(timeString)) return;

            string[] parts = timeString.Split(':');

            if (parts.Length == 3)
            {
                if (cbHour != null) cbHour.Text = parts[0];
                if (cbMin != null) cbMin.Text = parts[1];
                if (cbSec != null) cbSec.Text = parts[2];
            }

            else if (parts.Length == 2)
            {
                if (cbMin != null) cbMin.Text = parts[0];
                if (cbSec != null) cbSec.Text = parts[1];
            }
        }
    }
}
