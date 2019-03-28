using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_classwork
{
    class Program
    {
        static void Main(string[] args)
        {

            //StringBuilder sb = new StringBuilder("Hello, guys!");
            //Console.WriteLine(sb.Capacity);
            //Console.WriteLine(sb.Length);
            //Console.WriteLine(sb.MaxCapacity);

            //sb.Append("\nHello");
            //Console.WriteLine($"{sb.Capacity}----{sb.Length}");

            string a = "Hello guys";
            string b = "HELLO GUYS";

            var res = a.Equals(b);

            var str1 = "Hello";
            var str2 = "my friend";
            var result = string.Compare(str1, str2);

            var culture = System.Globalization.CultureInfo.CurrentCulture;
            Console.WriteLine($"{culture.DisplayName}");

            foreach(var item in culture.DateTimeFormat.DayNames)
            {
                Console.WriteLine($"{item} - ");
            }

            Console.Read();

        }
    }
}
