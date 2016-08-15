using System;

namespace Parts.Core.Models
{
    public class Cat : Pet
    {
        public Cat(string name, DateTime birthday, string color, CatBreed breed) : base(name, birthday, color)
        {
            Breed = breed;
        }

        public CatBreed Breed { get; set; }
    }
}
