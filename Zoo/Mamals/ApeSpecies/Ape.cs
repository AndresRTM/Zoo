using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Mamals.ApeSpecies
{
    internal abstract class Ape : Animal

    {
        public abstract string FavoriteFood { get; set; }
        public abstract bool IsSwinging { get; set; }
        public override string Name { get; set; }
        public override int Height { get; set; }
        public string Gender { get; set; }
        public  int Age { get; set; }
        public override double Weight { get; set; }
        public override bool IsHungry { get; set; }
        public override bool IsAsleep { get; set; }
        public override bool IsEndangered { get; set; }

        public Ape(string gender, int age)
        {
            Gender = gender;
            Age = age;
        
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
            Console.WriteLine($"{Name} found a comfortable spot to sleep.. ZzzZzzz...");
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
            Console.WriteLine($"{Name} throws {FavoriteFood} at a nearby visitor!");
        }


    }
}