using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.MemoryStorage;

namespace CSharp
{
    //Install
    //dotnet add package Hangfire
    //dotnet add package Hangfire.MemoryStorage
    class HangfireExample
    {
        // 1. Configure Hangfire with In-Memory storage (or use SQL Server, etc.)
        public  void PrintMessage(string msg)
        {
            Console.WriteLine($"[Job] {DateTime.Now}: {msg}");
        }
    }
}
