using System;

namespace SolidLIbrary
{

// S is single responsibility principle(SRP)
// O stands for open closed principle(OCP)
// L Liskov substitution principle(LSP)
// I interface segregation principle(ISP)
// D Dependency injection principle(DIP)
    public class Animal
    {
        public virtual int Legs { get; set; }
        public int Hands { get; set; }
        public int Wings { get; set; }
        public int Eyes { get; set; }
        public bool HaveTail { get; set; }

        // will use 
        public override string ToString()
        {
            return String.Format("Legs: {0}, hands: {1}, wings: {2}, tail: {3}", Legs, Hands, Wings, HaveTail);
        }
        // Violation of S single responsibility principle
        public void SendEmail(string email) {
            // send email with info about this object
        }
    }




}
