using Green_Basket.Models;

namespace Green_Basket.Service
{
    public class UserServiceImpl : IUserService
    {
        public bool Delete(int id)
        {
            return false;
        }

        public User GetUser(int id)
        {
            User u = null;
            return u;
        }

        public List<User> GetUsers()
        {
            return new List<User>();

        }

        public bool Insert(User user)
        {
            return true;
        }

        public bool Update(User user)
        {
            return false;
        }
    }
}
