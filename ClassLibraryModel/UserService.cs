namespace ClassLibraryModel
{
    public class UserService
    {
        private string? _loggedInUserEmail;

        public void SetLoggedInUser(string email)
        {
            _loggedInUserEmail = email;
        }

        public string? GetLoggedInUser()
        {
            return _loggedInUserEmail;
        }
    }
}
