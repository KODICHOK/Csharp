using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7
{
    class Program
    {
        static void Main(string[] args)
        {
            //10


            List<int> nb = new List<int>();

            Console.WriteLine("Розмір листу ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("Ввеліть {0} елемент", i);
                nb.Add(int.Parse(Console.ReadLine()));
            }

            int[] arr = new int[nb.Count];
            int numb;

            Console.WriteLine("скільки чисел ви будете вводити? ");
            int d = int.Parse(Console.ReadLine());


            for (int i = 0; i < d; i++)
            {
                int p = 0;
                Console.WriteLine("Введіть {0} число ", i);
                numb = int.Parse(Console.ReadLine());
                for (int j = 0; j < nb.Count; j++)
                {
                    if (numb == nb[j])
                    {
                        p++;
                        arr[j] += p;
                    }
                }
            }



            Console.WriteLine();
            Console.WriteLine("масив: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(+arr[i] + " ");
            }

            Console.Read();
        }
    }
}