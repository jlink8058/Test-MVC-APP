using System;

namespace Parts.Core.Models
{
    public class Pet
    {
        public Pet(string name, DateTime birthday, string color)
        {
            Name = name;
            Birthday = birthday;
            Color = color;
        }

        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Color { get; set; }
    }
}
