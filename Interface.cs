using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp.Interface;

namespace CSharp
{
    interface Interface
    {
        // Define an interface - a contract of what must be implemented
        public interface IVehicle
        {
            void Start();    // Method signature
            void Stop();     // Another method signature
        }

    }
    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car started.");
        }
        public void Stop()
        {
            Console.WriteLine("Car stopped.");
        }
    }

    // Bike also implements IVehicle
    public class Bike : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike started.");
        }
        public void Stop()
        {
            Console.WriteLine("Bike stopped.");
        }
    }
}
