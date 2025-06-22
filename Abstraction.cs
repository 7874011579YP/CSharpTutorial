using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Abstraction
    {
        // Abstract class: cannot be instantiated, provides a base for other classes
        public abstract class Animal
        {
            // Abstract method: must be implemented by derived classes
            public abstract void Speak();

            // Concrete method: shared logic for all animals
            public void Eat()
            {
                Console.WriteLine("This animal is eating.");
            }
        }

        // Dog class inherits from Animal and implements Speak
        public class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Dog says: Woof Woof!");
            }
        }

        // Cat class inherits from Animal and implements Speak
        public class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Cat says: Meow!");
            }
        }

    }
}
