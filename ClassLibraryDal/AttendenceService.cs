using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDal
{
    public class AttendanceService
    {
        public Instructor GetInstructorDetails()
        {
            return new Instructor
            {
                Name = "Mr. Kaleemullah",
                Designation = "Lecturer",
                Department = "Computer Science",
                FacultyType = "Regular Faculty",
                TotalRegularClasses = 1,
                TotalMakeupClasses = 7
            };
        }

        public List<AttendanceRecord> GetAttendanceRecords()
        {
            return new List<AttendanceRecord>
            {
                new AttendanceRecord
                {
                    SrNo = 1,
                    ScheduleID = "84933",
                    SubjectName = "F-24-Full Stack Web Development-Frontend Lab-9",
                    ScheduleDate = "Wednesday, 27 November 2024",
                    ClassTime = "16:00 - 18:40",
                    Duration = "3 Hrs."
                }
            };
        }
    }
}