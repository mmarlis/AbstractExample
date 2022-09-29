using System;

namespace AbstractExample.Models
{
    public class Cat : Animal
    {
        public Cat(string name)
        {
            Name = name;
        }

        public Cat()
        {
            Name = "Mr Fluffy";
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says meow meow");
        }
    }
}
