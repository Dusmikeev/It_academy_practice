using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem item1 = new UniqueItem();
            UniqueItem item2 = new UniqueItem();
            
            Console.WriteLine(UniqueItem.Id);
            Console.WriteLine(UniqueItem.Id);

            Console.Read();
        }
    }

    public class UniqueItem
    {
        public static int Id { get; set; }

        static UniqueItem()
        {
            Id++;
        }
    }
}
