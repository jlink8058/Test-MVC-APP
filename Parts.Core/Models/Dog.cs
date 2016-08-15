using System;

namespace Parts.Core.Models
{
    public class Dog : Pet
    {
        public Dog(string name, DateTime birthday, string color, DogBreed breed) : base(name, birthday, color)
        {
            Breed = breed;
        }

        public DogBreed Breed { get; set; }
    }
}
