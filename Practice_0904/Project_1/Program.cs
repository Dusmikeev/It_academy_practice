using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rects = new Rectangle[100];
            Random rnd = new Random();
            int dublicats = 0;

            for (int i = 0; i < rects.Length; i++)
            {
                rects[i].Widght = rnd.Next(1, 10);
                rects[i].Height = rnd.Next(1, 10);
            }

            for (int i = 0; i < rects.Length; i++)
            {
                if (rects[0].Widght == rects[i].Widght && rects[0].Height == rects[i].Height)
                {
                    dublicats++;
                }
                Console.WriteLine($"Rectangular - {rects[i].Widght} {rects[i].Height}");
            }
            Console.WriteLine(dublicats);
            Console.ReadKey();
        }


    }
    struct Rectangle
    {
        public int Widght { get; set; }
        public int Height { get; set; }
    }
}
