using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OOPS
{
    class Person
    {
            public string Name { get; set; }
            public int Age { get; set; }

            // Constructor
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void SayHello()
            {
                Console.WriteLine("Hello, my name is " + Name);
            }
    }
}
