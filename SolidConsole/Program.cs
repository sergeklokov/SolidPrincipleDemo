using System;
using SolidLIbrary;
using System.Collections.Generic;

namespace SolidConsole
{
    /// <summary>
    /// Here I'm trying to demonstrate some SOLID OOP design principles on c# language 
    /// Written by Serge Klokov in 2019
    /// because somebody asked me to explain it on example, 
    /// and I was ... not immediately able to do it. 
    /// 
    /// Loosely based on these articles and examples: 
    /// https://www.dotnetcurry.com/software-gardening/1365/solid-principles
    /// https://www.codeproject.com/Articles/703634/SOLID-architecture-principles-using-simple-Csharp
    /// https://www.codeproject.com/Tips/1033646/SOLID-Principle-with-Csharp-Example
    /// 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Legs = 4;
            dog.HaveTail = true;

            var alien = new Alien();
            alien.Hands = 5;
            alien.Legs = 18;

            var emailGenerator = new EmailGeneratorPlain();
            emailGenerator.SendEmail(dog.ToString());

            try
            {
                var animals = new List<Animal>();
                animals.Add(dog);
                animals.Add(alien);

                // it will throw violation of Liskov principle 
                foreach (var animal in animals)
                    Console.WriteLine(animal.ToString());

                //Console.WriteLine(dog);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Done.");
        }
    }
}
