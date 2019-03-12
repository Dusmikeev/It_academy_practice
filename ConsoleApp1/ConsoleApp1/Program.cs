using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkInClass
{
    class Program
    {
        static void Main(string[] args)
        {

            var timeSpan = DateTime.Now.TimeOfDay;
            TimeSpan time = timeSpan;
            int hours = time.Hours;
            Console.WriteLine(hours);

            if (hours <= 12)
            {
                Console.WriteLine("Good morning, guys");
            }
            else if (hours >= 15)
            {
                Console.WriteLine("Good evening, guys");
            }
            else
            {
                Console.WriteLine("Good day, guys");
            }

            Console.ReadLine();
        }
    }
}
