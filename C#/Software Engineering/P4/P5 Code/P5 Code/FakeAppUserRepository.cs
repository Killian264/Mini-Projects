using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Code
{
    public class FakeAppUserRepository : IAppUserRepository
    {
        public static Dictionary<string, AppUser> Users;


        public FakeAppUserRepository()
        {
            if (Users == null)
            {
                Users = new Dictionary<string, AppUser>();

                Users.Add("John240", new AppUser
                {
                    UserName = "John240",
                    Password = "password123",
                    FirstName = "John",
                    LastName = "Doe",
                    EmailAddress = "JohnDoe@gmail.com",
                    isAuthenticated = false,
                });
            }
        }
        public bool Login(string userName, string Password)
        {

            foreach (KeyValuePair<string, AppUser> User in Users)
            {
                if (userName == User.Value.UserName && Password == User.Value.Password)
                {
                    User.Value.isAuthenticated = true;
                    SetAuthentication(User.Value.UserName, User.Value.isAuthenticated);
                    return true;
                }
            }

            return false;
        }

        public List<AppUser> GetAll()
        {
            List<AppUser> tmp = new List<AppUser>(Users.Values);
            return tmp;
        }

        public void SetAuthentication(string userName, bool IsAuthenticated)
        {
            AppUser user = GetByUserName(userName);
            if (user == null)
            {
                throw new Exception();
            }
            user.isAuthenticated = IsAuthenticated;
        }

        public AppUser GetByUserName(string userName)
        {
            foreach (KeyValuePair<string, AppUser> user in Users)
            {
                if (user.Value.UserName.Equals(userName))
                {
                    return user.Value;
                }
            }

            return null;
        }
    }
}
