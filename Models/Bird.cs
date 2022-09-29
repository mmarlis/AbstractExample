using System;

namespace AbstractExample.Models
{
    public class Bird : Animal
    {
        public int NumberOfWings { get; set; }

        // default constructor
        public Bird()
        {
            Name = "Tweety";
            NumberOfWings = 2;
        }

        // constructor??
        public Bird(string name)
        {
            Name = name;
        }

        public void Fly()
        {
            Console.WriteLine("I can fly!");
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says cheep cheep");
        }

        public override void Sleep()
        {
            Console.WriteLine("TTTTTttttttz");
        }
    }
}
