using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal abstract class Animal
    {

        public abstract string Name { get; set; }
        public abstract int Height { get; set; }
        public string Gender { get; set; } = "Female";
        public int Age { get; set; } = 1;
        public abstract double Weight { get; set; }
        public abstract bool IsHungry { get; set; }
        public abstract bool IsAsleep { get; set; }
        public abstract bool IsEndangered { get; set; }


        public abstract void MakeSound();

        public abstract void Eat()
            ;
        public abstract void Sleep();

    }
}
