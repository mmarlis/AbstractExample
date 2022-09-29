using System;

namespace AbstractExample.Models
{
    public abstract class Animal
    {
        // common properties only
        public string Name { get; set; }
        public string Owner { get; set; }

        // common methods
        public abstract void MakeNoise();

        public virtual void Sleep()
        {
            Console.WriteLine("ZZZZzzzzz");
        }
    }
}
