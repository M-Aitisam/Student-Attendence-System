using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class Instructor
    {
        public string? Name { get; set; }
        public string? ClassName { get; set; }
        public string? SubjectName { get; set; }

        public string? Designation { get; set; }
        public string? Department { get; set; }
        public string? FacultyType { get; set; }
        public int TotalRegularClasses { get; set; }
        public int TotalMakeupClasses { get; set; }
    }
}
