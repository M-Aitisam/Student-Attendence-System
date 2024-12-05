using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class AttendanceRecord
    {
        public int SrNo { get; set; }
        public int ScheduleId { get; set; }
        public string? Subject { get; set; } 
        public string? Teacher { get; set; } 
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string? Status { get; set; }
    }


}
