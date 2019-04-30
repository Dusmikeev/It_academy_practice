using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighbor> neighbors = new List<Neighbor>();
            neighbors.Add(new Neighbor() { FlatNumber = 32, Fullname = "Vasya Pupkin" });
            neighbors.Add(new Neighbor() { FlatNumber = 45, Fullname = "Vasya Buslav" });
            neighbors.Add(new Neighbor() { FlatNumber = 22, Fullname = "Vasya Mamkin" });
            neighbors.Add(new Neighbor() { FlatNumber = 6, Fullname = "Vasya Genadiev" });
            neighbors.Add(new Neighbor() { FlatNumber = 17, Fullname = "Vasya Rushkin" });

            Console.WriteLine("Enter a flat number, please: ");
            var flatNumber = Convert.ToInt32(Console.ReadLine());

            neighbors.Where

            foreach (var item in neighbors)
            {
                if (item.FlatNumber != flatNumber) continue;
                
                Console.WriteLine($"Neighbors name is {item.Fullname}");
            }

            Console.Read();
        }
    }

    class Neighbor
    {
        public string Fullname { get; set; }
        public int FlatNumber { get; set; }
    }
}
