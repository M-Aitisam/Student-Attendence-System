using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public void CancelLeave(int leaveId)
        {
            // Remove the leave application (or update status)
            var leaveApplication = _leaveApplications.FirstOrDefault(l => l.LeaveId == leaveId);
            if (leaveApplication != null)
            {
                _leaveApplications.Remove(leaveApplication);
            }
        }

        public void UpdateLeaveApplication(LeaveApplication leaveApplication)
        {
            // Find and update the status of the leave application (for simplicity, updating the list directly)
            var existingApplication = _leaveApplications.FirstOrDefault(l => l.LeaveId == leaveApplication.LeaveId);
            if (existingApplication != null)
            {
                existingApplication.Status = leaveApplication.Status;
            }
        }
    }

}
