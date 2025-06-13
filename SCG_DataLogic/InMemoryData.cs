using SCG_Common;

namespace SCG_DataLogic
{
    public class InMemoryData : ISkinCareData
    {
        private List<User> users = new List<User>();

        public List<User> GetUsers()
        {
            return users;
        }

        public bool AddUser(User user)
        {
            users.Add(user);
            return true;
        }

        public bool UpdateUser(User user)
        {
            int index = users.FindIndex(u => u.Name == user.Name);
            if (index >= 0)
            {
                users[index] = user;
                return true;
            }
            return false;
        }

        public bool DeleteUser(User user)
        {
            int removedCount = users.RemoveAll(u => u.Name == user.Name);
            return removedCount > 0;
        }
    }
}