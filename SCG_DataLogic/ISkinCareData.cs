using SCG_Common;

namespace SCG_DataLogic
{
    public interface ISkinCareData
    {
        List<User> GetUsers();
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(User user);
    }
}