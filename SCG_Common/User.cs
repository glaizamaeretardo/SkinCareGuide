using System;
using System.Text.Json.Serialization;

namespace SCG_Common
{
    public class User
    {
        public string Name { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SkinType SkinType { get; set; }

        public User() { }

        public User(string name, SkinType skinType)
        {
            Name = name;
            SkinType = skinType;
        }
    }
}