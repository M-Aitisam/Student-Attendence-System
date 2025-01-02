using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;

namespace ClassLibraryDal
{
    
    public class EmployeeService
    {
        private List<Employee> employees = new();

        public IEnumerable<Employee> GetEmployees() => employees;

        public void AddEmployee(Employee employee) => employees.Add(employee);

        public void RemoveEmployee(Employee employee) => employees.Remove(employee);

        public void UpdateEmployee(Employee updatedEmployee)
        {
            var existingEmployee = employees.FirstOrDefault(e => e.Id == updatedEmployee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = updatedEmployee.Name;
                existingEmployee.Email = updatedEmployee.Email;
                existingEmployee.DOB = updatedEmployee.DOB;
                existingEmployee.JoinDate = updatedEmployee.JoinDate;
                existingEmployee.Status = updatedEmployee.Status;
            }
        }
    }

}
