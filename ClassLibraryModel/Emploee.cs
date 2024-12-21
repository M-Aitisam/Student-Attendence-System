using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
   
        public class Employee
        {
            public string Id { get; set; } = string.Empty;
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public DateTime DOB { get; set; } = DateTime.Now;
            public DateTime JoinDate { get; set; } = DateTime.Now;
            public string Status { get; set; } = "Active";
        public decimal Salary { get; set; }
        public bool IsNewRecruit { get; set; }
        // Default constructor
        public Employee() { }

            // Copy constructor
            public Employee(Employee other)
            {
                Id = other.Id;
                Name = other.Name;
                Email = other.Email;
                DOB = other.DOB;
                JoinDate = other.JoinDate;
                Status = other.Status;
            }

            // Update method to overwrite properties
            public void Update(Employee other)
            {
                Name = other.Name;
                Email = other.Email;
                DOB = other.DOB;
                JoinDate = other.JoinDate;
                Status = other.Status;
            }
        }
    }

