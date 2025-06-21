using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class AssemblyOneClass1
    {
        protected int Id;
        public void Display1()
        {
            //protected Members Accessible with the Containing Type 
            //Where they are created
            Console.WriteLine(Id);
        }
    }
    public class AssemblyOneClass2 : AssemblyOneClass1
    {
        public void Display2()
        {
            //We Can access protected Member from Derived Classes
            //Within the Same Assembly
            Console.WriteLine(Id); //No-Compile Time Error
        }
    }

    public class AssemblyOneClass3 : AssemblyOneClass1
    {
        public void Dispplay3()
        {
            //We Cannot access protected Member from Non-Derived Classes
            //Within the Same Assembly
            //This will give Compile Time Error
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            //obj.Id = 10; //Compile Time Error
            //Console.WriteLine(obj.Id); //Compile Time Error
        }
    }

}
