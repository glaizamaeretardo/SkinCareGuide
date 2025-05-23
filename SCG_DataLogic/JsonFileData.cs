using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCG_Common;
using System.IO;
using System.Text.Json;

namespace SCG_DataLogic
{
    public class JsonFileData : ISkinCareData
    {
        private readonly string filePath = "users.json";

        public void SaveUser(User user)
        {
            var users = GetAllUsers();
            users.Add(user);
            File.WriteAllText(filePath, JsonSerializer.Serialize(users));
        }

        public List<User> GetAllUsers()
        {
            if (!File.Exists(filePath)) return new List<User>();
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
        }

        public void UpdateUser(string name, int newSkinType)
        {
            var users = GetAllUsers();
            var user = users.FirstOrDefault(u => u.Name == name);
            if (user != null)
            {
                user.SkinType = newSkinType;
                File.WriteAllText(filePath, JsonSerializer.Serialize(users));
            }
        }

        public void DeleteUser(string name)
        {
            var users = GetAllUsers();
            var user = users.FirstOrDefault(u => u.Name == name);
            File.WriteAllText(filePath, JsonSerializer.Serialize(users));
        }

        public User SearchUser(string name)
        {
            return GetAllUsers().FirstOrDefault(u => u.Name == name);
        }
    }


}