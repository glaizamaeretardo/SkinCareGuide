using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCG_Common;

namespace SCG_DataLogic
{
    public class InMemoryData : ISkinCareData
    {
        private List<User> users = new List<User>();

        public void SaveUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return new List<User>(users);
        }

        public void UpdateUser(string name, int newSkinType)
        {
            User user = users.FirstOrDefault(u => u.Name == name);
            if (user != null)
            {
                user.SkinType = newSkinType;
            }
        }

        public void DeleteUser(string name)
        {
            users.RemoveAll(u => u.Name == name);
        }

        public User SearchUser(string name)
        {
            return users.FirstOrDefault(u => u.Name == name);
        }
    }
}
