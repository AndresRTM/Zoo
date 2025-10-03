using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Mamals
{
    internal class Cow : Animal
    {
        public bool HasHorn { get; set; }
        public double MilkProductionPerDay { get; set; }


        public Cow(bool hasHorn = false, double milkProductionPerDay = 0.0, string name = "Nameless", int height = 1, string gender = "Unknown", int age = 1, double weight = 1.0, bool isHungry = true, bool isAsleep = true, bool isEndangered = false)
        {
            HasHorn = hasHorn;
            MilkProductionPerDay = milkProductionPerDay;
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
            Console.WriteLine("Mooo!");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating some grass!");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping..ZzzZzzz...");
        }

        public void ProduceMilk()
        {
            Console.WriteLine($"{Name} just produced 20 liters of milk!");
        }

        public void RespondToBell()
        {
            Console.WriteLine($"{Name} hears the bell and starts heading toward the barn.");
        }


    }
}
