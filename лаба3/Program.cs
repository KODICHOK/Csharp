using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введiть чотирьохзначне число");
            x = int.Parse(Console.ReadLine());
            int y = (x / 10) % 10;
            int z = (x / 100) % 10;
            int f = x / 1000;
            int g = x % 10;
            if (f == g && z == y)
            {
                Console.WriteLine("не ну все підходить");
            }
            else
            {
                Console.WriteLine("кажись нас десь обманули");
            }
        }
    }
}