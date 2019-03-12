using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = (Color) new Random().Next(0,3);
            Console.WriteLine(color);
            Console.Read();
            switch (color)
            {
                case Color.Red:
                    Console.Write("The color is red");
                    break;
                case Color.Green:
                    Console.Write("The color is green");
                    break;
                case Color.Blue:
                    Console.Write("The color is blue");
                    break;
                default:
                    Console.WriteLine("No color defined");
                    break;
            }
        }
    }

    public enum Color {Red, Green, Blue};
}
