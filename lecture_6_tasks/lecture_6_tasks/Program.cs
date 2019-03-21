using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_6_tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { };
            CreateArray();
            string element1 = "32";
            string element2 = "A";
            string element3 = "Hello";

            string[] array2 = { element1, element2, element3 };

            foreach (object x in array2)
            {
                Console.WriteLine(x);
            }

        }

        public void CreateArray()
        {
            int[] array = { };
        }

        

    }
    
}
