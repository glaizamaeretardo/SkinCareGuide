using SCG_Common;

namespace SCG_DataLogic
{
    public class SCGData
    {
        private readonly ISkinCareData skinCareData;

        public SCGData()
        {
            skinCareData = new JsonFileData();
            //skinCareData = new TextFileData();
            //skinCareData = new InMemoryData();
        }

        public List<User> GetAllUserDetails()
        {
            return skinCareData.GetUsers();
        }

        public void SaveUserDetails(string nameToAdd, int skinType)
        {
            var user = new User { Name = nameToAdd, SkinType = (SkinType)skinType };
            var existing = skinCareData.GetUsers().FirstOrDefault(u => u.Name == nameToAdd);
            if (existing != null)
                skinCareData.UpdateUser(user);
            else
                skinCareData.AddUser(user);
        }

        public bool UpdateUserDetails(string userToUpdate, int updatedSkinType, out string newUserSkinType)
        {
            newUserSkinType = string.Empty;
            var existingUser = skinCareData.GetUsers().FirstOrDefault(u => u.Name == userToUpdate);
            if (existingUser != null)
            {
                existingUser.SkinType = (SkinType)updatedSkinType;
                skinCareData.UpdateUser(existingUser);
                newUserSkinType = existingUser.SkinType.ToString();
                return true;
            }
            return false;
        }

        public bool DeleteUserDetails(string nameToDelete)
        {
            var existingUser = skinCareData.GetUsers().FirstOrDefault(u => u.Name == nameToDelete);
            if (existingUser != null)
            {
                skinCareData.DeleteUser(existingUser);
                return true;
            }
            return false;
        }

        public bool SearchUserDetails(string nameToSearch, out string skinType)
        {
            var existingUser = skinCareData.GetUsers().FirstOrDefault(u => u.Name == nameToSearch);
            if (existingUser != null)
            {
                skinType = existingUser.SkinType.ToString();
                return true;
            }

            skinType = string.Empty;
            return false;
        }
    }
}