// See https://aka.ms/new-console-template for more information
using CSharp;
using System;



Console.WriteLine("Hello, Geeks! We are learning her C# programming.");


#region 1. DateTime

//DateTimePicker dt = new DateTimePicker();
//dt.GetCurrntDate();
#endregion

#region 2.Interview Programs
//2.Interview Programs
//InterviewPorgrams IP= new InterviewPorgrams();
//IP.programsRUn();
#endregion

#region 3. Partial Class
//Partial Class
//PartialEmployee employee = new PartialEmployee
//{
//    FirstName = "Alice",
//    LastName = "Smith",
//    Gender = "Female",
//    Salary = 75000
//};

//employee.DisplayFullName();
//employee.DisplayEmployeeDetails();
#endregion

#region 4. LInq
//List<Customer> customers = new List<Customer>
//{
//    new Customer { Id = 1, Name = "Raj", City = "Ahmedabad", Age = 25 },
//    new Customer { Id = 2, Name = "Meera", City = "Surat", Age = 32 },
//    new Customer { Id = 3, Name = "Yash", City = "Ahmedabad", Age = 45 },
//    new Customer { Id = 4, Name = "Neha", City = "Baroda", Age = 20 },
//};

////1.Filter(Where: Get Ahmedabad customers)
//Console.WriteLine("1.Filter(Where: Get Ahmedabad customers)");
//var result = customers.Where(c => c.City == "Ahmedabad");
//foreach (var c in result)
//    Console.WriteLine(c.Name); // Raj, Yash

////2. Sort (OrderBy: Sort by Age)
//Console.WriteLine("2. Sort (OrderBy: Sort by Age)");
//var sorted = customers.OrderBy(c => c.Age);
//var sortedDescending = customers.OrderByDescending(c => c.Age);

//foreach (var c in sorted)
//    Console.WriteLine($"{c.Name} - {c.Age}");

//Console.WriteLine("");
//Console.WriteLine("");

//foreach (var c in sortedDescending)
//    Console.WriteLine($"{c.Name} - {c.Age}");

//Console.WriteLine("");
//Console.WriteLine("");

/////3. Select (Project only names)
//Console.WriteLine("3. Select (Project only names)");
//var names = customers.Select(c => c.Name);

//foreach (var name in names)
//    Console.WriteLine(name); // Raj, Meera, Yash, Neha

//Console.WriteLine("");
//Console.WriteLine("");

////4. Group (Group by City)
//Console.WriteLine("4. Group (Group by City)");
//var grouped = customers.GroupBy(c => c.City);
//foreach (var group in grouped)
//{
//    Console.WriteLine($"City: {group.Key}");
//    foreach (var customer in group)
//        Console.WriteLine($" → {customer.Name}");
//}
//Console.WriteLine("");
//Console.WriteLine("");
////5. Check conditions (Any, All)
//Console.WriteLine("5. Check conditions (Any, All)");
//bool hasMinor = customers.Any(c => c.Age < 18); // false
//bool allAdults = customers.All(c => c.Age >= 18); // true

//Console.WriteLine("6. First / FirstOrDefault"); // Has minor: False
////6. First / FirstOrDefault
//var firstAhmedabadCustomer = customers.FirstOrDefault(c => c.City == "Ahmedabad");
//Console.WriteLine(firstAhmedabadCustomer?.Name); // Raj
#endregion

# region 5.Mutlthreading

Console.WriteLine("=== Multithreading Demo App ===\n");

MultiThreading multiThreading = new MultiThreading();
// 1. Run Background Task
Console.WriteLine("1. Background Task (Task.Run)");
await Task.Run(() => multiThreading.HeavyComputation());

// 2. API Call using async/await
Console.WriteLine("\n2. Async API Call");
await multiThreading.CallApiAsync();

// 3. Parallel For Loop
Console.WriteLine("\n3. Parallel File Processing Simulation");
multiThreading.SimulateFileProcessing();

// 4. Shared Counter with Lock
Console.WriteLine("\n4. Safe Counter with Lock");
multiThreading.ThreadSafeCounter();

Console.WriteLine("\nAll operations completed.");

#endregion