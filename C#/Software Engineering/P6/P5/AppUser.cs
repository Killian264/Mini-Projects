namespace P6
{
    public class AppUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsAuthenticated { get; set; }
        public AppUser()
        {
            IsAuthenticated = false;
        }
    }
}
