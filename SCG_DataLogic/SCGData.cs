using SCG_Common;

namespace SCG_DataLogic
{
    public class SCGData
    {
        private readonly ISkinCareData skinCareData;

        public SCGData()
        {
            //skinCareData = new JsonFileData();
            skinCareData = new TextFileData();
            // skinCareData = new InMemoryData();
        }

        public List<User> GetAllUserDetails()
        {
            return skinCareData.GetUsers();
        }

        public void SaveUserDetails(string nameToAdd, int skinType)
        {
            var user = new User { Name = nameToAdd, SkinType = skinType };
            var existing = skinCareData.GetUsers().FirstOrDefault(u => u.Name == nameToAdd);
            if (existing != null)
                skinCareData.UpdateUser(user);
            else
                skinCareData.AddUser(user);
        }

        public bool UpdateUserDetails(string userToUpdate, int updatedSkinType, out string newUserSkinType)
        {
            newUserSkinType = string.Empty;
            var user = skinCareData.GetUsers().FirstOrDefault(u => u.Name == userToUpdate);
            if (user != null)
            {
                user.SkinType = updatedSkinType;
                skinCareData.UpdateUser(user);
                newUserSkinType = ((SkinType)updatedSkinType).ToString();
                return true;
            }
            return false;
        }

        public bool DeleteUserDetails(string nameToDelete)
        {
            var user = skinCareData.GetUsers().FirstOrDefault(u => u.Name == nameToDelete);
            if (user != null)
            {
                skinCareData.DeleteUser(user);
                return true;
            }
            return false;
        }

        public bool SearchUserDetails(string nameToSearch, out string skinType)
        {
            var user = skinCareData.GetUsers().FirstOrDefault(u => u.Name == nameToSearch);
            if (user != null)
            {
                skinType = ((SkinType)user.SkinType).ToString();
                return true;
            }
            skinType = string.Empty;
            return false;
        }
    }
}

//using SCG_Common;

//namespace SCG_DataLogic
//{
//    public class SCGData
//    {
//        private static Dictionary<string, int> savedReference = new();

//        public static void SaveUserDetails(string nameToAdd, int skinType) //save user
//        {
//            savedReference[nameToAdd] = skinType;
//        }

//        public static Dictionary<string, string> GetAllUserDetails() //view user's details
//        {
//            Dictionary<string, string> userDetails = new();

//            foreach (var user in savedReference)
//            {
//                userDetails[user.Key] = ((SkinType)user.Value).ToString();
//            }
//            return userDetails;
//        }

//        public static bool UpdateUserDetails(string userToUpdate, int updatedSkinType, out string newUserSkinType) //update user
//        {
//            newUserSkinType = string.Empty;

//            if (savedReference.ContainsKey(userToUpdate))
//            {
//                savedReference[userToUpdate] = updatedSkinType;
//                newUserSkinType = ((SkinType)updatedSkinType).ToString();

//                return true;
//            }
//            return false;
//        }

//        public static bool DeleteUserDetails(string nameToDelete) //delete user
//        {
//            return savedReference.Remove(nameToDelete);
//        }

//        public static bool SearchUserDetails(string nameToSearch, out string skinType) //search a user
//        {
//            if(savedReference.TryGetValue(nameToSearch, out int st))
//            {
//                skinType = ((SkinType)st).ToString();
//                return true;
//            }

//            skinType = string.Empty;
//            return false;
//        }
//    }
//}
