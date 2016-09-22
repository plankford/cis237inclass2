using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Factorial or 2 for Tower Of Hanoi");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                //Do Factorial
                //The Dawn Way
                Factorial factorial = new Factorial();
            }
            else
            {
                //Do Tower Of Hanoi
                //The Dawn way AGAIN
                TowerOfHanoi towerOfHanoi = new TowerOfHanoi();
            }

        }
    }
}
