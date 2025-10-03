using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Gender { get; set; } = "Female";
        public int Age { get; set; } = 1;
        public double Weight { get; set; }
        public bool IsHungry { get; set; }
        public bool IsAsleep { get; set; }
        public bool IsEndangered { get; set; }



        public abstract void MakeSound();

        public abstract void Eat();
        public abstract void Sleep();

    }
}
