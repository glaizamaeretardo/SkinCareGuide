using SCG_Common;

namespace SCG_DataLogic
{
    public class SCGData
    {
        private static Dictionary<string, int> savedReference = new();

        public static void SaveUserDetails(string nameToAdd, int skinType) //save user
        {
            savedReference[nameToAdd] = skinType;
        }

        public static Dictionary<string, string> GetAllUserDetails() //view user's details
        {
            Dictionary<string, string> userDetails = new();
            
            foreach (var user in savedReference)
            {
                userDetails[user.Key] = ((SkinType)user.Value).ToString();
            }
            return userDetails;
        }

        public static bool UpdateUserDetails(string userToUpdate, int updatedSkinType, out string newUserSkinType) //update user
        {
            newUserSkinType = string.Empty;

            if (savedReference.ContainsKey(userToUpdate))
            {
                savedReference[userToUpdate] = updatedSkinType;
                newUserSkinType = ((SkinType)updatedSkinType).ToString();
                
                return true;
            }
            return false;
        }

        public static bool DeleteUserDetails(string nameToDelete) //delete user
        {
            return savedReference.Remove(nameToDelete);
        }

        public static bool SearchUserDetails(string nameToSearch, out string skinType) //search a user
        {
            if(savedReference.TryGetValue(nameToSearch, out int st))
            {
                skinType = ((SkinType)st).ToString();
                return true;
            }

            skinType = string.Empty;
            return false;
        }
    }
}
