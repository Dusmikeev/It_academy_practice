using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringExtension.Extensions;

namespace StringExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "I am in a good mood today";
            Console.WriteLine(test.StringCut(5));
            Console.Read();
        }
    }
}
