using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryDal
{
    public class AttendanceService
    {
        // Private fields for storing data
        private readonly List<Instructor> _instructors = new();
        private readonly List<AttendanceRecord> _attendanceRecords = new();

        // Fetch instructor details based on class name, subject name, and teacher name
        public Instructor? GetInstructorDetails(string className, string subjectName, string teacherName)
        {
            return _instructors.FirstOrDefault(i =>
                string.Equals(i.ClassName, className, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(i.SubjectName, subjectName, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(i.Name, teacherName, StringComparison.OrdinalIgnoreCase));
        }

        // Fetch attendance records for a specific class and subject
        public List<AttendanceRecord> GetAttendanceRecords(string className, string subjectName)
        {
            return _attendanceRecords
                .Where(r =>
                    string.Equals(r.ClassName, className, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(r.SubjectName, subjectName, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Fetch all attendance records asynchronously
        public Task<List<AttendanceRecord>> GetAttendanceRecordsAsync()
        {
            return Task.FromResult(_attendanceRecords);
        }

        // Add a new attendance record
        public void AddAttendanceRecord(AttendanceRecord record)
        {
            if (record == null) throw new ArgumentNullException(nameof(record));
            _attendanceRecords.Add(record);
            NotifyAttendanceUpdated();
        }

        // Save attendance record asynchronously
        public Task SaveAttendanceRecordAsync(AttendanceRecord record)
        {
            if (record == null) throw new ArgumentNullException(nameof(record));
            _attendanceRecords.Add(record);
            NotifyAttendanceUpdated();
            return Task.CompletedTask;
        }

        // Event for notifying when attendance is updated
        public event Action? OnAttendanceUpdated;

        private void NotifyAttendanceUpdated()
        {
            OnAttendanceUpdated?.Invoke();
        }

        // Save attendance record (synchronous method)
        public void SaveAttendanceRecord(AttendanceRecord record)
        {
            if (record == null) throw new ArgumentNullException(nameof(record));
            _attendanceRecords.Add(record);
            NotifyAttendanceUpdated();
        }
    }
}
