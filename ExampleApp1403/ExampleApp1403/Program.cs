using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp1403
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];

            for(int x = 0; x<arraySize;x++)
            {
                array[x] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int x in array)
            {
                Console.Write(" "+x);
            }
            Console.Read();
        }
    }
}
