using System;

namespace ClassLibraryModel
{
    public class Employee
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DOB { get; set; } = DateTime.Now.AddYears(-20); // Default DOB set to 20 years ago
        public DateTime JoinDate { get; set; } = DateTime.Now; // Default Join Date set to today
        public string Status { get; set; } = "Active";
        public decimal Salary { get; set; } = 0.0m; // Default salary set to 0.0
        public bool IsNewRecruit { get; set; } = true; // Default as a new recruit

        
    }
}
