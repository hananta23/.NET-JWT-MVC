using Net5.JWT.Models;
using System.Collections.Generic;
using System.Linq;

namespace Net5.JWT.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "hananta", Password = "hananta", Role = "manager" });
            users.Add(new User { Id = 2, Username = "adhi", Password = "adhi", Role = "employee" });
            users.Add(new User { Id = 3, Username = "rahmansyach", Password = "rahmansyach", Role = "tester" });
            users.Add(new User { Id = 4, Username = "Admin", Password = "admin", Role = "Administrator" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }
    }
}
