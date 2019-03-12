using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfA
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWord;
            int numberOfA=0;
            Console.WriteLine("Please enter a word:");
            userWord = Console.ReadLine();
            
            for(int i = 0; i < userWord.Length; i++)
            {

                if (userWord[i] == 'a')
                {
                    numberOfA++;
                }
                
            }
            Console.WriteLine(numberOfA);
            Console.ReadLine();
        }
    }
}
