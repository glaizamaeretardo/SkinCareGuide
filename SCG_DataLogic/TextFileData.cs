using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCG_Common;
using System.IO;

namespace SCG_DataLogic
{
    public class TextFileData : ISkinCareData
    {
        private readonly string filePath = "users.txt";
        
        public void SaveUser(User user)
        {
            File.AppendAllLines(filePath, new[] { $"{user.Name}|{user.SkinType}" });
        }
        
        public List<User> GetAllUsers()
        {
            if (!File.Exists(filePath)) return new List<User>();

            return File.ReadAllLines(filePath)
                .Select(line => line.Split('|'))
                .Where(parts => parts.Length == 2)
                .Select(parts => new User { Name = parts[0], SkinType = int.Parse(parts[1]) })
                .ToList();
        }

        public void UpdateUser(string name, int newSkinType)
        {
            var users = GetAllUsers();
            var user = users.FirstOrDefault(u => u.Name == name);
            if(user != null)
            {
                user.SkinType = newSkinType;
                File.WriteAllLines(filePath, users.Select(u => $"{u.Name}|{u.SkinType}"));
            }
        }

        public void DeleteUser(string name)
        {
            var users = GetAllUsers();
            users.RemoveAll(u => u.Name == name);
            File.WriteAllLines(filePath, users.Select(u => $"{u.Name}|{u.SkinType}"));
        }

        public User SearchUser(string name)
        {
            return GetAllUsers().FirstOrDefault(u => u.Name == name);
        }
    }

   
}