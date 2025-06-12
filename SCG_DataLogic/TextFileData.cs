using SCG_Common;

namespace SCG_DataLogic
{
    public class TextFileData : ISkinCareData
    {
        private readonly string filePath = "users.txt";
        private List<User> users = new List<User>();

        public TextFileData()
        {
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            if (!File.Exists(filePath))
                return;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 2)
                {
                    if (Enum.TryParse(parts[1], out SkinType skinType))
                    {
                        users.Add(new User
                        {
                            Name = parts[0],
                            SkinType = skinType
                        });
                    }
                }
            }
        }

        private void SaveToFile()
        {
            var lines = users.Select(u => $"{u.Name}|{u.SkinType}").ToArray();
            File.WriteAllLines(filePath, lines);
        }

        public List<User> GetUsers() => users;

        public void AddUser(User user)
        {
            users.Add(user);
            SaveToFile();
        }

        public void UpdateUser(User user)
        {
            int index = users.FindIndex(u => u.Name == user.Name);
            if (index >= 0)
            {
                users[index] = user;
                SaveToFile();
            }
        }

        public void DeleteUser(User user)
        {
            users.RemoveAll(u => u.Name == user.Name);
            SaveToFile();
        }
    }
}