using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    delegate int CulcOperation(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            CulcOperation sum = program.Add;
            sum += program.Subtract;

            Console.WriteLine($"{sum(2, 5)}");

            Console.Read();

        }

        int Add(int arg1, int arg2) => arg1 + arg2;
        int Subtract(int arg1, int arg2) => arg1 - arg2;
        
    }
}
