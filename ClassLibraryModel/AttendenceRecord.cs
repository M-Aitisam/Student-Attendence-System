﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class AttendanceRecord
    {
        public int SrNo { get; set; }
        public string? ScheduleID { get; set; }
        public string? SubjectName { get; set; }
        public string? ScheduleDate { get; set; }
        public string? ClassTime { get; set; }
        public string? ClassName { get; set; }

        public string? Duration { get; set; }
    }
}
