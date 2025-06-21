using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp
{
    class MultiThreading
    {
        // Simulates a CPU-bound operation
        public void HeavyComputation()
        {
            Console.WriteLine("  [Task] Starting heavy computation...");
            int result = 0;
            for (int i = 0; i < 1_000_000; i++) result += i;
            Console.WriteLine("  [Task] Computation done. Sum = " + result);
        }

        // Simulates a network call
        public async Task CallApiAsync()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1");
            Console.WriteLine("  [HttpClient] Response: " + response.Substring(0, 50) + "...");
        }

        // Simulates processing 10 files in parallel
        public void SimulateFileProcessing()
        {
            Parallel.For(1, 11, i =>
            {
                Console.WriteLine($"  [File {i}] Processing started on Thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(500); // Simulate delay
                Console.WriteLine($"  [File {i}] Processing completed");
            });
        }

        // Demonstrates a safe counter using lock
        public void ThreadSafeCounter()
        {
            object locker = new object();
            int counter = 0;

            Parallel.For(0, 1000, i =>
            {
                lock (locker)
                {
                    counter++;
                }
            });

            Console.WriteLine("  Final Counter Value (Expected 1000): " + counter);
        }
    }
}
