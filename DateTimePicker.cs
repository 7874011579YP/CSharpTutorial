using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp
{
    class DateTimePicker
    {
        public void GetCurrntDate()
        {
            //string TodayDate = DateTime.Now.ToString();
            //Console.WriteLine(TodayDate);

            Console.WriteLine("DateTime Demo (Current Time: 10:26 AM IST, May 19, 2025)\n");

            // 1. Creating DateTime 
            Console.WriteLine("1. Creating DateTime");

            DateTime now = DateTime.Now;
            Console.WriteLine($"Current Local Time: {now:yyyy-MM-dd HH:mm:ss}"); //It'll retuen current local time

            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine($"Current UTC Time: {utcNow:yyyy-MM-dd HH:mm:ss}");//It'll retuen current local time

            DateTime specific = new DateTime(2025, 5, 19, 10, 26, 0);
            Console.WriteLine($"Specific DateTime: {specific:yyyy-MM-dd HH:mm:ss}");


            Console.WriteLine("");

            // 2. Accessing DateTime properties
            Console.WriteLine("2. DateTime Properties:");
            Console.WriteLine($"Year: {now.Year}");     //It'll retuen Year of current Datetime
            Console.WriteLine($"Month: {now.Month}");   //It'll retuen Month of current Datetime
            Console.WriteLine($"Day: {now.Day}");       //It'll retuen Day of current Datetime
            Console.WriteLine($"Hour: {now.Hour}");     //It'll retuen Hour of current Datetime
            Console.WriteLine($"Minute: {now.Minute}"); //It'll retuen Minute of current Datetime
            Console.WriteLine($"Day of Week: {now.DayOfWeek}\n"); //It'll retuen Day Of week of current Datetime

            Console.WriteLine("");
            // 3. DateTime
            Console.WriteLine("3. DateTime Operations:");
            // How to Get Tommorw's Date 
            DateTime tomorrow = now.AddDays(1);
            Console.WriteLine($"Tomorrow: {tomorrow:yyyy-MM-dd HH:mm:ss}");

            // How to Get last Hour
            DateTime lastHour = now.AddHours(-1);
            Console.WriteLine($"Last Hour: {lastHour:yyyy-MM-dd HH:mm:ss}");

            // How to set date in format like yyyy-MM-dd.
            string formatted = now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"Formatted: {formatted}");

            // How to Get Date only. 
            string shortDate = now.ToShortDateString();
            Console.WriteLine($"Short Date: {shortDate}");

            Console.WriteLine("");
            // 4. TimeSpan(Duration) example
            Console.WriteLine("4. TimeSpan Example:");
            DateTime start = DateTime.Now;
            DateTime end = start.AddHours(2);
            TimeSpan duration = end - start;

            Console.WriteLine($"Duration: {duration.TotalHours} hours");

        }
    }
}
