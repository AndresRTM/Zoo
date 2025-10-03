
using System.Runtime.InteropServices;
using Zoo.Mamals.ApeSpecies;

namespace Zoo.Mamals.Ape;

internal class Program
{
    static void Main(string[] args)
    {

        Animal dog1 = new Dog("Golden Retriever","Luna", 10, "female", 3, 20.0, true, false, false);
        Animal cat1 = new Cat("Siamese", "Misty", 25, "female", 4, 5.0, true, false, false);
        Animal horse1 = new Horse(100,30.0, "Rocky", 50, "Male", 10, 80.0);
        Animal pig1 = new Pig(3, "apples","Peppa", 80, "female", 2, 40.0, true, false, false);
        Animal cow1 = new Cow(true, 40.0, "Bella", 150, "female", 6, 600.0, false, false, false);
        Animal gorilla1 = new Gorilla("Banana", false, "Koko", 170, "male", 12, 160.0, true, false, true);
        Animal orangutan1 = new Orangutan("Durian", false, "Ruby", 140, "female", 8, 90.0, false, false, true);

        List<Animal> animals = new List<Animal> { dog1, cat1, horse1, pig1, cow1, gorilla1, orangutan1 };
       
        foreach (var animal in animals)
            animal.MakeSound();
        }
       
}
