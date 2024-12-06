using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryDal
{
    public class AttendanceService
    {
        // Private fields for storing data
        private readonly List<Instructor> _instructors;
        private readonly List<AttendanceRecord> _attendanceRecords;

        // Constructor to initialize sample data
        public AttendanceService()
        {
            // Sample instructor data
            _instructors = new List<Instructor>
            {
                new Instructor
                {
                    ClassName = "CS101",
                    SubjectName = "Computer Science",
                    Name = "Mr. Kaleemullah",
                    Designation = "Lecturer",
                    Department = "Computer Science",
                    FacultyType = "Regular Faculty",
                    TotalRegularClasses = 1,
                    TotalMakeupClasses = 7
                },
                new Instructor
                {
                    ClassName = "CS102",
                    SubjectName = "Data Structures",
                    Name = "Ms. Ayesha",
                    Designation = "Assistant Professor",
                    Department = "Computer Science",
                    FacultyType = "Visiting Faculty",
                    TotalRegularClasses = 5,
                    TotalMakeupClasses = 2
                }
            };

            // Sample attendance record data
            _attendanceRecords = new List<AttendanceRecord>
            {
                new AttendanceRecord
                {
                    SrNo = 1,
                    ScheduleID = "84933",
                    ClassName = "CS101",
                    SubjectName = "Computer Science",
                    ScheduleDate = "Wednesday, 27 November 2024",
                    ClassTime = "16:00 - 18:40",
                    Duration = "3 Hrs."
                },
                new AttendanceRecord
                {
                    SrNo = 2,
                    ScheduleID = "84934",
                    ClassName = "CS102",
                    SubjectName = "Data Structures",
                    ScheduleDate = "Thursday, 28 November 2024",
                    ClassTime = "10:00 - 12:00",
                    Duration = "2 Hrs."
                }
            };
        }

        // Methods
        public Instructor GetInstructorDetails()
        {
            // Default instructor details
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

        public Instructor? GetInstructorDetails(string className, string subjectName, string teacherName)
        {
            // Fetch details based on inputs
            return _instructors.FirstOrDefault(i =>
                i.ClassName == className && i.SubjectName == subjectName && i.Name == teacherName);
        }

        public List<AttendanceRecord> GetAttendanceRecords(string className, string subjectName)
        {
            // Fetch records based on inputs
            return _attendanceRecords
                .Where(r => r.ClassName == className && r.SubjectName == subjectName)
                .ToList();
        }

        public List<AttendanceRecord> GetAttendanceRecords()
        {
            // Default attendance records
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
