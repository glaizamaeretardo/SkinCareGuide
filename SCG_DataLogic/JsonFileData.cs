using SCG_Common;
using System.Text.Json;

namespace SCG_DataLogic
{
    public class JsonFileData : ISkinCareData
    {
        private readonly string filePath = "users.json";
        private List<User> users;

        public JsonFileData()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
            else
            {
                users = new List<User>();
            }
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void AddUser(User user)
        {
            users.Add(user);
            SaveToFile();
        }

        public void UpdateUser(User user)
        {
            var existing = users.FirstOrDefault(u => u.Name == user.Name);
            if (existing != null)
            {
                existing.SkinType = user.SkinType;
                SaveToFile();
            }
        }

        public void DeleteUser(User user)
        {
            users.RemoveAll(u => u.Name == user.Name);
            SaveToFile();
        }

        private void SaveToFile()
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
