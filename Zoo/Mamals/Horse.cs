using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Mamals
{
    internal class Horse : Animal
    {
        public int HorsePower { get; set; }
        public double ManeLength { get; set; }
   
        public Horse(int horsePower = 0, double maneLength = 0.0, string name = "Nameless", int height = 1, string gender = "Unknown", int age = 1, double weight = 1.0, bool isHungry = true, bool isAsleep = true, bool isEndangered = false)
        {
            HorsePower = horsePower;
            ManeLength = maneLength;
            Name = name;
            Height = height;
            Gender = gender;
            Age = age;
            Weight = weight;
            IsHungry = isHungry;
            IsAsleep = isAsleep;
            IsEndangered = isEndangered;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Heeeihhhhhh");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating some hay!");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} is standing quietly and sleeping.. ZzzZzzz...");
        }

        // Unika metoder
        public void Gallop()
        {
            Console.WriteLine($"{Name} gallops across the field!");
        }

        public void JumpFence()
        {
            Console.WriteLine($"{Name} jumps over the fence with elegance.");
        }



    }
}
