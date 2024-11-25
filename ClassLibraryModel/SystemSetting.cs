using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class SystemSettings
    {
        public bool EnableBackup { get; set; } = false;
        public int SessionTimeoutMinutes { get; set; } = 30;

        public int AttendanceThreshold { get; set; }
        public string AcademicYear { get; set; } = string.Empty;
        public bool EnableNotifications { get; set; }
    }
}
