using System;

namespace AbstractExample.Models
{
    public class Pig : Animal
    {
        public Pig(string name)
        {
            Name = name;
        }

        public Pig()
        {
            Name = "Wilbur";
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says oink oink");
        }
    }
}
