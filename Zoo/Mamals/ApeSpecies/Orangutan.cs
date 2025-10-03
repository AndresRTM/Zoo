using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Mamals.ApeSpecies
{
    internal class Orangutan : Ape
    {
        public double ArmLength { get; set; }

        public Orangutan(string favoriteFood = "Durian", bool isSwinging = false, string name = "Nameless",
                             int height = 1, string gender = "Unknown", int age = 1, double weight = 1.0,
                             bool isHungry = true, bool isAsleep = true, bool isEndangered = false) : base(gender, age)
        {

            Name = name;
            Height = height;
            Weight = weight;
            Weight = weight;
            IsHungry = isHungry;
            IsAsleep = isAsleep;
            IsEndangered = isEndangered;
        }


        public override void MakeSound()
        {
            Console.WriteLine("OO OO AA AA!");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating a {FavoriteFood}!");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} found a comfortable spot to sleep on.. ZzzZzzz...");
        }


        public void SwingBetweenTrees()
        {
            IsSwinging = true;
            Console.WriteLine($"{Name} swings  between the trees.");
        }


        public void ClimbTree()
        {
            Console.WriteLine($"{Name} climbs a tree!");
        }

        public void ThrowFruit()
        {
            Console.WriteLine($"{Name} throws a banana at a nearby visitor!");
        }

        //unika  
        public void HangUpsideDown()
        {
            Console.WriteLine($"{Name} hangs upside down from a branch, and observes its surroundings.");
        }

        public void WaveHello()
        {
            Console.WriteLine($"{Name} waves hello to a visitor.");
        }


    }
}
