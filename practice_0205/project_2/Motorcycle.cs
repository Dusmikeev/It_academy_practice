using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    delegate void NotifyHandler(string message);

    class Motorcycle
    {
        private int _odometer;
        private NotifyHandler _handler;
        public int Odometer { get { return _odometer; } set { _odometer = value; } }

        public void RegisterHandler(NotifyHandler @delegate)
        {
            _handler = @delegate;
        }

        public void Move(int km)
        {
            Odometer += km;
            if (Odometer >= 10000)
            {
                //Console.WriteLine("Hello, Rider!");
                _handler("This message");
            }
        }

    }
}
