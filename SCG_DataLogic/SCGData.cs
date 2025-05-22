namespace SCG_DataLogic
{
    public class SCGData
    {
        private static Dictionary<string, string> savedReference = new Dictionary<string, string>();

        public static void SaveUserDetails(string nameToAdd, int skinType) //save user
        {
            string skintypeName = SCGProcess.GetSkinTypeName(skinType);
            savedReference[nameToAdd] = skintypeName;
        }

        public static Dictionary<string, string> GetAllUserDetails() //view user's details
        {
            return new Dictionary<string, string>(savedReference);
        }

        public static bool UpdateUserDetails(string userToUpdate, int updatedSkinType, out string newUserSkinType) //update user
        {
            newUserSkinType = string.Empty;

            if (savedReference.ContainsKey(userToUpdate))
            {
                newUserSkinType = SCGProcess.GetSkinTypeName(updatedSkinType);
                savedReference[userToUpdate] = newUserSkinType;

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
            return savedReference.TryGetValue(nameToSearch, out skinType);
        }
    }
}
