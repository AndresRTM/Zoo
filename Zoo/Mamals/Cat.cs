using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Mamals
{
    internal class Cat : Animal
    {
        public string CatRace { get; set; }
        public override string Name { get; set; }
        public override int Height { get; set; }
        //public string Gender { get; set; }
        //public  int Age { get; set; }
        public override double Weight { get; set; }
        public override bool IsHungry { get; set; }
        public override bool IsAsleep { get; set; }
        public override bool IsEndangered { get; set; }

        public Cat(string catRace = "Unknown", string name = "Nameless", int height = 1, string gender = "Unknown", int age = 1, double weight = 1.0, bool isHungry = true, bool isAsleep = true, bool isEndangered = false)
        {
            CatRace = catRace;
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
            Console.WriteLine("Meow!");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating some tuna!");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping..ZzzZzzz...");
        }
        
       
        public void Purr()
        {
            Console.WriteLine($"{Name} is purring!");
        }

        public void ChaseLaser()
        {
            Console.WriteLine($"{Name} is trying to catch the laser!");
        }
    }
}
