using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
            
        enum PetType
        {
            Dog,
            Duck
        }

        class PetClass
        {
            public int Legs;
            public PetType Type;
            public string Name;
            public bool HasFur;
        }

        struct PetStruct
        {
            public int Legs;
            public PetType Type;
            public string Name;
            public bool HasFur;
        }

        static void MultiplyLegs(PetStruct petStruct, PetClass petClass)
        {
            petStruct.Legs = petStruct.Legs * 2;
            petClass.Legs = petClass.Legs * 2;

            Console.WriteLine("Internal method) A " + petStruct.Type + " has " + petStruct.Legs);
            Console.WriteLine("Internal method) A " + petClass.Type + " has " + petClass.Legs);
        }

        static void Main(string[] args)
        {
            PetStruct dog = new PetStruct();
            dog.Type = PetType.Dog;
            dog.Legs = 4;
            dog.HasFur = true;
            Console.WriteLine("A " + dog.Type + " has " + dog.Legs + " legs");

            PetClass duck = new PetClass();
            duck.Type = PetType.Duck;
            duck.Legs = 2;
            duck.HasFur = false;
            Console.WriteLine("A " + duck.Type + " has " + duck.Legs + " legs");

            //MultiplyLegs(dog, duck);
            //Console.WriteLine("A " + dog.Type + " has " + dog.Legs);
            //Console.WriteLine("A " + duck.Type + " has " + duck.Legs);

            PetStruct copiedDog = dog;
            PetClass copiedDuck = duck;

            copiedDog.Legs = copiedDog.Legs * 2;
            copiedDuck.Legs = copiedDuck.Legs * 2;

            Console.WriteLine("A " + dog.Type + " has " + dog.Legs);
            Console.WriteLine("A " + duck.Type + " has " + duck.Legs);

            Console.WriteLine("A " + copiedDog.Type + " has " + copiedDog.Legs);
            Console.WriteLine("A " + copiedDuck.Type + " has " + copiedDuck.Legs);

            Console.ReadLine();
        }
    }
}
