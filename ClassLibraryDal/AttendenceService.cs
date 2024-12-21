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

        // Add a new attendance record (synchronous)
        public void AddAttendanceRecord(AttendanceRecord record)
        {
            if (record == null)
                throw new ArgumentNullException(nameof(record));

            _attendanceRecords.Add(record);
            NotifyAttendanceUpdated();
        }

        // Save attendance record asynchronously
        public Task SaveAttendanceRecordAsync(AttendanceRecord record)
        {
            if (record == null)
                throw new ArgumentNullException(nameof(record));

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

        // Update an existing attendance record (optional utility)
        public void UpdateAttendanceRecord(AttendanceRecord updatedRecord)
        {
            if (updatedRecord == null)
                throw new ArgumentNullException(nameof(updatedRecord));

            var existingRecord = _attendanceRecords.FirstOrDefault(r => r.Id == updatedRecord.Id);
            if (existingRecord != null)
            {
                // Replace the existing record with updated data
                _attendanceRecords.Remove(existingRecord);
                _attendanceRecords.Add(updatedRecord);
                NotifyAttendanceUpdated();
            }
        }

        // Delete an attendance record
        public void DeleteAttendanceRecord(int recordId)
        {
            var record = _attendanceRecords.FirstOrDefault(r => r.Id == recordId);
            if (record != null)
            {
                _attendanceRecords.Remove(record);
                NotifyAttendanceUpdated();
            }
        }

        // Seed instructors for testing/demo purposes
        public void SeedInstructors(List<Instructor> instructors)
        {
            _instructors.AddRange(instructors);
        }

        // Seed attendance records for testing/demo purposes
        public void SeedAttendanceRecords(List<AttendanceRecord> records)
        {
            _attendanceRecords.AddRange(records);
        }

        public Task<List<Employee>> GetEmployees()
        {
            var employees = new List<Employee>
        {
            new Employee { Id = "1", Name = "John Doe", Status = "Active", DOB = new DateTime(1990, 5, 15), JoinDate = new DateTime(2020, 1, 1) },
            new Employee { Id = "2", Name = "Jane Smith", Status = "Inactive", DOB = new DateTime(1988, 3, 22), JoinDate = new DateTime(2019, 6, 10) }
            // Add more employees as needed
        };

            return Task.FromResult(employees);
        }

        // Example: Get a list of leave applications (replace with actual data fetching logic)
        public Task<List<LeaveApplication>> GetLeaveApplications()
        {
            var leaveApplications = new List<LeaveApplication>
        {
            new LeaveApplication { EmployeeName = "John Doe", Date = new DateTime(2024, 12, 15), Status = "Approved" },
            new LeaveApplication { EmployeeName = "Jane Smith", Date = new DateTime(2024, 12, 18), Status = "Pending" }
            // Add more leave applications as needed
        };

            return Task.FromResult(leaveApplications);
        }
       
            public List<Subject> GetSubjects()
            {
                // Fetch attendance data from the database or in-memory
                return new List<Subject>
        {
            new Subject { SrNo = 1, SubjectName = "Mathematics", Total = 50, Atts = 45, Abs = 5, Percent = 90.0 },
            new Subject { SrNo = 2, SubjectName = "Physics", Total = 50, Atts = 40, Abs = 10, Percent = 80.0 }
        };
            }
        

    }
}
