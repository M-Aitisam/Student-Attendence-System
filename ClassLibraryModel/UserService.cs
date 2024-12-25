namespace ClassLibraryModel
{
    public class UserService
    {
        private string? _loggedInUserEmail;

        // In-memory user store for roles
        private readonly Dictionary<string, string> _adminUsers = new()
        {
            { "aitisam11@gmail.com", "Aitisam@1234" }
        };

        public void SetLoggedInUser(string email)
        {
            _loggedInUserEmail = email;
        }

        public Task<bool> ValidateUserAsync(string email, string password, string role)
        {
            if (role == "Admin" && _adminUsers.ContainsKey(email))
            {
                return Task.FromResult(_adminUsers[email] == password);
            }

            if (role == "Teacher" && email.EndsWith("@teacher.edu"))
            {
                return Task.FromResult(true); // Password is ignored
            }

            if (role == "Student" && email.EndsWith("@students.au.edu.pk"))
            {
                return Task.FromResult(true); // Password is ignored
            }

            return Task.FromResult(false);
        }
    }
}
