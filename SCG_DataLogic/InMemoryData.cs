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

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void UpdateUser(User user)
        {
            int index = users.FindIndex(u => u.Name == user.Name);
            if (index >= 0)
                users[index] = user;
        }

        public void DeleteUser(User user)
        {
            users.RemoveAll(u => u.Name == user.Name);
        }
    }
}