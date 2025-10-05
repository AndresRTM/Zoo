using System.Runtime.InteropServices;

namespace Zoo.Mamals.ApeSpecies;

internal class Program
{
    static void Main(string[] args)
    {

        Animal dog1 = new Dog("Golden Retriever", "Luna", 10, "female", 3, 20.0, true, false);
        Animal cat1 = new Cat("Siamese", "Misty", 25, "female", 4, 5.0, true, false);
        Animal cow1 = new Cow(true, 40.0, "Bella", 150, "female", 6, 600.0, false, false);
        Animal gorilla1 = new Gorilla("Banana", false, "Koko", 170, "male", 12, 160.0, true, false);
        Animal orangutan1 = new Orangutan("Durian", false, "Ruby", 140, "female", 8, 90.0, false, false);      

        List<Animal> animals = new List<Animal> { dog1, cat1, cow1, gorilla1, orangutan1 };

        foreach (var animal in animals)
        {
           animal.MakeSound();    
        }
    }
}