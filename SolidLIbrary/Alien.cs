using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLIbrary
{
    //
    // By the way Liskov is a woman (Barbara Liskov), married Natan Liskov... 
    // 

    // S is single responsibility principle(SRP)
    // O stands for open closed principle(OCP)
    // L Liskov substitution principle(LSP)
    // I interface segregation principle(ISP)
    // D Dependency injection principle(DIP)


    // I - Many specific interfaces are better than a single, all-encompassing interface
    interface IAlien
    {
        bool isFriendly();
    }

    public class Alien : Animal, IAlien
    {
        private int legs;

        // This is violation of Liskov substitution principle
        // Basically we will be unable to substitute Animal with Alien
        // To fix it, we need to create new class,
        // Possible to create a bunch of interfaces which have Legs and Alien body parts 
        // and implement them in a new class
        public override int Legs { 
            get {
                throw new Exception("Not allowed, it's not an animal, it's alien! ");
            }

            set {
                legs = value;
            }
        }

        public bool isFriendly()
        {
            throw new NotImplementedException();
        }
    }
}
