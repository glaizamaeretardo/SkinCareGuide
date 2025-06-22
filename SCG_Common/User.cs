using System;

namespace SCG_Common
{
    public class User
    {
        public string Name { get; set; }
        public SkinType SkinType { get; set; }

        public User() { }

        public User(string name, SkinType skinType)
        {
            Name = name;
            SkinType = skinType;
        }
    }
}