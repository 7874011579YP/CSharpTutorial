using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp
{
    class InterviewPorgrams 
    {
        public static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        public static bool IsPrime(int num)
        {
            //A prime number must have exactly 2 positive divisors:
            //1 and itself only
            
            if (num <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0) return false;
            return true;
        }
        public static bool IsPalindrome(string input)
        {
            //A palindrome is a word, number, phrase, or sequence that reads the same forward and backward.
            //exampl : Words: "radar", "level", "rotor", "civic", "deified", "madam", "noon", "racecar", "refer", "repaper"
            //Exampl : Number:  121 ,1331
            string reversed = new string(input.Reverse().ToArray());
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        public static void Fibonacci(int n)
        {
            int a = 0, b = 1, temp;
            Console.Write($"{a} {b} ");
            for (int i = 2; i < n; i++)
            {
                temp = a + b;
                Console.Write($"{temp} ");
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }

         //6. Factorial of a Number(Using Recursion)
        public static int Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * Factorial(n - 1);
        }

        public void programsRUn()
        {
            Console.WriteLine("C# Interview Programs:");
            Console.WriteLine("1. Reverse String");
            Console.WriteLine("2. Prime Check");
            Console.WriteLine("3. Palindrome Check");
            Console.WriteLine("4. Swap Numbers");
            Console.WriteLine("5. Fibonacci Series");
            Console.WriteLine("6. Factorial of a Number");
            Console.WriteLine("Choose (1-6): ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a string: ");
                    string str = Console.ReadLine(); //Example enter "Hello World"
                    Console.WriteLine($"Reversed: {ReverseString(str)}"); //Output: "dlroW olleH"
                    break;

                case 2:
                    Console.Write("Enter a number: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine(IsPrime(n) ? "Prime" : "Not Prime");
                    break;

                case 3:
                    Console.Write("Enter a string: ");
                    string pal = Console.ReadLine();
                    Console.WriteLine(IsPalindrome(pal) ? "Palindrome" : "Not Palindrome");
                    break;

                case 4:
                    int a = 5, b = 10;
                    Console.WriteLine($"Before Swap: a={a}, b={b}");
                    Swap(ref a, ref b);
                    Console.WriteLine($"After Swap: a={a}, b={b}");
                    break;

                case 5:
                    Console.Write("Enter N: ");
                    int count = int.Parse(Console.ReadLine());
                    Fibonacci(count);
                    break;

                case 6:
                    Console.Write("Enter N: ");
                    int num = int.Parse(Console.ReadLine());
                    Factorial(num);
                    break;
            }

        }
    }

}
