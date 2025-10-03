using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Mamals.ApeSpecies
{
    internal abstract class Ape : Animal

    {
        public string FavoriteFood { get; set; }
        public bool IsSwinging { get; set; }  

        public Ape(string favoriteFood, bool isSwinging)
        {
            FavoriteFood = favoriteFood;
            IsSwinging = isSwinging;        
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