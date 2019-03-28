using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_6_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = @"\\server\file\file.txt";
            Console.WriteLine(str1);
            Console.Read();

            string nullString = null;
            Console.WriteLine(nullString.Length); //doesnt highlight potential - Nullable reference exception


            

        }
    }
}
