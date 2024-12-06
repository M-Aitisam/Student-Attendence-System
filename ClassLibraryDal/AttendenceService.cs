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

        // Constructor to initialize the lists
        public AttendanceService()
        {
            _instructors = new List<Instructor>();
            _attendanceRecords = new List<AttendanceRecord>();
        }

        // Fetch instructor details based on inputs
        public Instructor? GetInstructorDetails(string className, string subjectName, string teacherName)
        {
            return _instructors.FirstOrDefault(i =>
                i.ClassName == className && i.SubjectName == subjectName && i.Name == teacherName);
        }

        // Fetch attendance records for a specific class and subject
        public List<AttendanceRecord> GetAttendanceRecords(string className, string subjectName)
        {
            return _attendanceRecords
                .Where(r => r.ClassName == className && r.SubjectName == subjectName)
                .ToList();
        }

        // Add a new attendance record
        public void AddAttendanceRecord(AttendanceRecord record)
        {
            _attendanceRecords.Add(record);
        }

        // Event for notifying changes
        public event Action? OnAttendanceUpdated;

        public void NotifyAttendanceUpdated()
        {
            OnAttendanceUpdated?.Invoke();
        }
        public void SaveAttendanceRecord(AttendanceRecord record)
        {
            _attendanceRecords.Add(record);
        }
    }
}
