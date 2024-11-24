using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class SystemSettings
    {
        public int AttendanceThreshold { get; set; } = 75;
        public string AttendanceMarkingType { get; set; } = "Present/Absent";
        public string AcademicYear { get; set; } = "2024-2025";
        public bool EnableNotifications { get; set; } = true;
        public string NotificationFrequency { get; set; } = "Weekly"; // Daily, Weekly, Monthly
        public string DefaultReportFormat { get; set; } = "PDF"; // PDF, Excel
        public bool EnableBackup { get; set; } = true;
        public int SessionTimeoutMinutes { get; set; } = 30;
    }
}
