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
        private string filePath = "users.json";
        private List<User> users = new List<User>();

        public JsonFileData()
        {
            LoadFromJson();
        }

        private void LoadFromJson()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var data = JsonSerializer.Deserialize<List<User>>(json);

                if (data != null)
                    users = data;
            }
        }

        private void SaveToJson()
        {
            var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public List<User> GetUsers() => users;

        public void AddUser(User user)
        {
            users.Add(user);
            SaveToJson();
        }

        public void UpdateUser(User user)
        {
            int index = users.FindIndex(u => u.Name == user.Name);
            if (index >= 0)
            {
                users[index] = user;
                SaveToJson();
            }
        }

        public void DeleteUser(User user)
        {
            users.RemoveAll(u => u.Name == user.Name);
            SaveToJson();
        }
    }


}