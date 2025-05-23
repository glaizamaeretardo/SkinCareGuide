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
        public int SkinType { get; set; }

        public User() { }

        public User (string name, int skinType)
        {
            Name = name;
            SkinType = skinType;
        }
    }
}
