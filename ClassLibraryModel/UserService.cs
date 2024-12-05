﻿namespace ClassLibraryModel
{
    public class UserService
    {
        private string? _loggedInUserEmail;

        // In-memory user store for roles
        private readonly Dictionary<string, (string Password, string Role)> _users = new()
        {
            { "aitisam11@gmail.com", ("Aitisam@1234", "Admin") },
            { "teacher@teacher.edu", ("TeacherPass123", "Teacher") },
            { "student@gmail.com", ("StudentPass123", "Student") }
        };

        public void SetLoggedInUser(string email)
        {
            _loggedInUserEmail = email;
        }

        public string? GetLoggedInUser()
        {
            return _loggedInUserEmail;
        }

        public Task<bool> ValidateUserAsync(string email, string password, string role)
        {
            if (_users.ContainsKey(email))
            {
                var (storedPassword, storedRole) = _users[email];
                return Task.FromResult(storedPassword == password && storedRole == role);
            }

            return Task.FromResult(false);
        }
    }
}
