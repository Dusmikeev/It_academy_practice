using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var moto = new
            {
                Name = "Honda",
                Year = 2004,
                Odometer = 35000
            };


            Console.WriteLine(moto.GetType());
            Console.WriteLine(moto);


            Console.ReadKey();


        }
    }
}
