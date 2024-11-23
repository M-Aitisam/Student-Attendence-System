namespace ClassLibraryModel
{
    public class UserService
    {
        private string? _loggedInUserEmail;

        // A simple in-memory user store (for demonstration purposes)
        private readonly Dictionary<string, string> _users = new()
        {
            { "aitisam11@gmail.com", "Aitisam@1234" }, // Admin user
                  // Example user
        };

        public void SetLoggedInUser(string email)
        {
            _loggedInUserEmail = email;
        }

        public string? GetLoggedInUser()
        {
            return _loggedInUserEmail;
        }

        // Async method to validate the user
        public Task<bool> ValidateUserAsync(string email, string password)
        {
            if (_users.ContainsKey(email) && _users[email] == password)
            {
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
    }
}
