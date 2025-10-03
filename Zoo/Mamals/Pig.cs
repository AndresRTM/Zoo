using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Mamals
{
    internal class Pig : Animal
    {
        public int MudLevel { get; set; }
        public string FavoriteSnack { get; set; }

        public Pig(int mudLevel = 0, string favoriteSnack = "Unknown", string name = "Nameless", int height = 1, string gender = "Unknown", int age = 1, double weight = 1.0, bool isHungry = true, bool isAsleep = true, bool isEndangered = false)
        {
            MudLevel = mudLevel;
            FavoriteSnack = favoriteSnack;
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
            Console.WriteLine("Oink, oink");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating some hay!");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} sleeping in hay");
        }


        public void RollInMud()
        {
            MudLevel++;
            Console.WriteLine($"{Name} rolls happily in the mud. Mud level is now {MudLevel}.");
            if (MudLevel >= 10)
            {
                Console.WriteLine($"{Name} is very dirty now. You should really clean {Name} up!");
            }
        }

        public void DigForFood()
        {
            Console.WriteLine($"{Name} digs around in the dirt looking for tasty roots.");
        }

        public void CleanUp()
        {
            MudLevel = 0;
            Console.WriteLine($"{Name} has been cleaned. Mud level reset.");
        }



    }
}
