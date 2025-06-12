using SCG_Common;

namespace SCG_DataLogic
{
    public interface ISkinCareData
    {
        List<User> GetUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}