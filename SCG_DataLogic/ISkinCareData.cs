using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCG_Common;

namespace SCG_DataLogic
{
    public interface ISkinCareData
    {
        void SaveUser(User user);
        List<User> GetAllUsers();
        void UpdateUser(string name, int newSkinType);
        void DeleteUser(string name);
        User SearchUser(string name);
    }
}
