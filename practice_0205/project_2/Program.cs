using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();

            moto.Move(1000);
            moto.Move(20000);

            NotifyHandler handler = ShowMessage;
            moto.RegisterHandler(handler);

            Console.Read();
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
