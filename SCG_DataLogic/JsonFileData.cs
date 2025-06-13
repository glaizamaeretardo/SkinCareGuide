using SCG_Common;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SCG_DataLogic
{
    public class JsonFileData : ISkinCareData
    {
        private readonly string filePath = "users.json";
        private List<User> users;

        private readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };

        public JsonFileData()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<List<User>>(json, options) ?? new List<User>();
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

        public bool AddUser(User user)
        {
            users.Add(user);
            SaveToFile();
            return true;
        }

        public bool UpdateUser(User user)
        {
            var existing = users.FirstOrDefault(u => u.Name == user.Name);
            if (existing != null)
            {
                existing.SkinType = user.SkinType;
                SaveToFile();
                return true;
            }
            return false;
        }

        public bool DeleteUser(User user)
        {
            int removed = users.RemoveAll(u => u.Name == user.Name);
            if (removed > 0)
            {
                SaveToFile();
                return true;
            }
            return false;
        }

        private void SaveToFile()
        {
            string json = JsonSerializer.Serialize(users, options);
            File.WriteAllText(filePath, json);
        }
    }
}