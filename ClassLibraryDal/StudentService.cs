    using ClassLibraryModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    namespace ClassLibraryDal
    {
        public class StudentService
        {
            public readonly List<Student> _students;

            public StudentService()
            {
                _students = new List<Student>
                {
                    new Student { Id = 1 , Name = "Aitisam" , Email="aitisam11@gmail.com"},
                    new Student { Id = 2 , Name = "Ruhma" , Email="ruhma@gmail.com"},
                    new Student { Id = 3 , Name = "Talha" , Email="talha@gmail.com"}

                };
            }
            public List<Student> GetStudents() => _students;    

            public void AddStudent(Student student)
            {
                student.Id = _students.Any() ? _students.Max(s => s.Id) + 1 : 1;
                { _students.Add(student); }
            }
            public void EditStudent(int id, Student updatedStudent)
            {
                var student = _students.FirstOrDefault(s => s.Id == id);
                if (student != null)
                {
                    student.Name = updatedStudent.Name;
                    student.Email = updatedStudent.Email;
                }
            }
            public void DeleteStudent(int id)
            {
                var student = _students.FirstOrDefault(s => s.Id == id);
                if (student != null)
                {
                    _students.Remove(student);

                }
            }
        }
    }