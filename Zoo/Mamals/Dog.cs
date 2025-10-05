using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Mamals
{
    internal class Dog : Animal
    {
        public string DogRace { get; set; }


        public Dog(string dogRace = "Unknown", string name = "Nameless", int height = 1, string gender = "Unknown", int age = 1, double weight = 1.0, bool isHungry = true, bool isAsleep = true)
        {
            DogRace = dogRace;
            Name = name;
            Height = height;
            Gender = gender;
            Age = age;
            Weight = weight;
            IsHungry = isHungry;
            IsAsleep = isAsleep;            
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating dogfood!");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping..ZzzZzzz...");
        } 

        public void SearchForCandy()
        {
            Console.WriteLine($"{Name} is searching for candy!");
        }

    }
}
