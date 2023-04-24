using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taxi_workshop.DomainModels.Models;
using taxi_workshop.Services.Interfaces;

namespace taxi_workshop.Services.Implementations
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public User CurrentUser { get; set; }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            User user = _db.GetById(CurrentUser.Id);
            if (user.Password != oldPassword)
                return false;
            user.Password = newPassword;
            _db.Update(user);
            return true;
        }

        public void Login(string username, string password)
        {
            CurrentUser = _db.GetAll().SingleOrDefault(x => x.Username == username && x.Password == password);
            if (CurrentUser == null)
                throw new Exception("Incorrect username or password");
        }
    }
}
