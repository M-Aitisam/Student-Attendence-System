using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace ClassLibraryDal
{
    public class LeaveService
    {
        private readonly List<LeaveApplication> _leaveApplications = new List<LeaveApplication>();

        public List<LeaveApplication> GetLeaveApplications()
        {
            // Return the list of leave applications (you may fetch it from a database)
            return _leaveApplications;
        }

        public void ApplyLeave(LeaveApplication leaveApplication)
        {
            // Add the leave application to the list (or save to the database)
            _leaveApplications.Add(leaveApplication);
            SaveLeaveApplicationsToLocalStorage(); // Save to localStorage
        }

        public void CancelLeave(int leaveId)
        {
            // Remove the leave application (or update status)
            var leaveApplication = _leaveApplications.FirstOrDefault(l => l.LeaveId == leaveId);
            if (leaveApplication != null)
            {
                _leaveApplications.Remove(leaveApplication);
                SaveLeaveApplicationsToLocalStorage(); // Save to localStorage
            }
        }

        public void UpdateLeaveApplication(LeaveApplication leaveApplication)
        {
            // Find and update the status of the leave application (for simplicity, updating the list directly)
            var existingApplication = _leaveApplications.FirstOrDefault(l => l.LeaveId == leaveApplication.LeaveId);
            if (existingApplication != null)
            {
                existingApplication.Status = leaveApplication.Status;
                existingApplication.Date = leaveApplication.Date; // Sync other fields if needed
                existingApplication.StudentName = leaveApplication.StudentName;
                SaveLeaveApplicationsToLocalStorage(); // Save to localStorage
            }
        }

        public Task<List<LeaveApplication>> GetLeaveApplication()
        {
            // Simulating async call by returning Task.FromResult
            return Task.FromResult(_leaveApplications);
        }

        public void UpdateLeaveStatus(int leaveId, string status)
        {
            var leaveApplication = _leaveApplications.FirstOrDefault(l => l.LeaveId == leaveId);
            if (leaveApplication != null)
            {
                leaveApplication.Status = status;
                SaveLeaveApplicationsToLocalStorage(); // Save to localStorage
            }
        }

        // Helper method to save leave applications to localStorage
        private void SaveLeaveApplicationsToLocalStorage()
        {
            // Convert leave applications list to JSON and save to localStorage
            var json = JsonSerializer.Serialize(_leaveApplications);
            // This part would ideally call JavaScript Interop to store the data in localStorage on the frontend.
            // Example:
            // JSRuntime.InvokeVoidAsync("localStorageHelper.setItem", "leaveApplications", json);
        }
    }
}
