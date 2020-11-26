using System.Collections.Generic;

namespace P6
{
    public class FakeAppUserRepository : IAppUserRepository
    {
        private static Dictionary<string, AppUser> _AppUsers;

        public FakeAppUserRepository()
        {
            // A temporary dictionary to fake a database
            _AppUsers = new Dictionary<string, AppUser>();
            _AppUsers.Add("DSU", new AppUser
            {
                UserName = "DSU",
                Password = "Password1!",
                FirstName = "First",
                LastName = "Last",
                EmailAddress = "email@dsu.edu",
                IsAuthenticated = false
            });
            _AppUsers.Add("a", new AppUser
            {
                UserName = "a",
                Password = "a",
                FirstName = "AAA",
                LastName = "AAAA",
                EmailAddress = "AA@AA.AAA",
                IsAuthenticated = false
            });
            _AppUsers.Add("PL", new AppUser
            {
                UserName = "PL",
                Password = "PL",
                FirstName = "Payton",
                LastName = "Lawson",
                EmailAddress = "payton.lawson@trojans.dsu.edu",
                IsAuthenticated = false
            });
        }
        public bool Login(string UserName, string givenPassword)
        {
            bool match = false;
            AppUser appUser;
            if (_AppUsers.TryGetValue(UserName,out appUser))
            {
                match = appUser.Password == givenPassword;
            }
            return match;
        }
        public void SetAuthentication(string UserName, bool IsAuthenticated)
        {
            _AppUsers[UserName].IsAuthenticated = IsAuthenticated;
        }
        public List<AppUser> GetAll()
        {
            List<AppUser> appUsers = new List<AppUser>();
            foreach (AppUser appUser in _AppUsers.Values)
            {
                appUsers.Add(appUser);
            }
            return appUsers;
        }
        public AppUser GetByUserName(string UserName)
        {
            AppUser curUser;
            try
            {
                curUser = _AppUsers[UserName];
            }
            catch
            {
                curUser = null;
            }
            return curUser;
        }
    }
}
