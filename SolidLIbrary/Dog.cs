using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLIbrary
{
    interface IDog {
        bool isRetriever();
    }

    public class Dog : Animal, IDog 
    {
        public bool isRetriever()
        {
            throw new NotImplementedException();
        }

        // This is violation of the Dependency Inversion principle.
        // We should "inject" furr color as property, or in constructor
        // and not hardcode it
        public string FurrColor() {
            return "White";
        }
    }

    // It will inherit furr color, which is again violation of the Dependency Inversion principle.
    // High level modules should not depend on low level modules but should depend on abstraction.
    public class SmallDoggy : Dog
    {
    }

    // Proper use of Dependency Injection
    public class RetrieverDog : Animal, IDog
    {
        public RetrieverDog(string furrColor) {
            FurrColor = furrColor;
        }
        public string FurrColor { get; set; }

        public bool isRetriever()
        {
            return true;
        }
    }

}
