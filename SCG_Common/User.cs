using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCG_Common
{
    public class User
    {
        public string Name { get; set; }
        public SkinType SkinType { get; set; }

        public User (string name, SkinType skinType)
        {
            Name = name;
            SkinType = skinType;
        }
    }
}
