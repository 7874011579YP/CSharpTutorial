using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp
{
    //LINQ(Language Integrated Query) is a feature in C# that lets you query data (like arrays, lists, databases, XML, JSON) using SQL-like syntax directly inside your C# code.
    //    It helps you:

    //Filter

    //Sort

    //Project(select specific columns)

    //Group

    //Join
    //Without writing raw SQL or complex loops.
    //LINQ can be used with various data sources, such as collections, databases, XML, and more.

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }
}
