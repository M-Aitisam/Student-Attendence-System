using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class LeaveApplication
    {
        public int LeaveId { get; set; }
        public string? StudentName { get; set; }
        public string? EmployeeName { get; set; }

        public DateTime Date { get; set; }
        public string? Status { get; set; }
        public string? Reason { get; set; }

    }


}
