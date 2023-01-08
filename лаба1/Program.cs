using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t;
            int a = 0;
            int b = 0;
            int c = 0;
            Console.WriteLine("Введіть кількість секунд ");
            t = int.Parse(Console.ReadLine());
            if (t >= 3600) {
                a = t / 3600;
                b = (t / 60) % 60;
                c = t % 60;
                Console.WriteLine("Кількість секунд " + t + " = " + a + " годин " + b + " хвилин " + c + " секунд");
            }
            else if (t >= 60 && t < 3600) {
                b = t / 60;
                c = t % 60;
                Console.WriteLine("Кількість секунд " + t + " = " + b + " хвилин " + c + " секунд");
            }
            else if (t > 0 && t < 60) {
                c = t;
                Console.WriteLine("Кількість секунд " + t);
            }
            else {
                Console.WriteLine("Помилка");
            }
        }
    }
}