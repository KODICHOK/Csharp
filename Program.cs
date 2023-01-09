using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lb10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть число\t");
            int n = int.Parse(Console.ReadLine());
            int d = n * 2;
            Random rand = new Random();
            int[] array = new int[d];
            for (int i = 0; i < n; i++)
            {
            array[i] = rand.Next(5);
            }
            int[] arr = new int[2*n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < d; j++) 
                {
                    if (arr[j] == 0)
                    {
                        arr[j] = array[i];
                        arr[j + 1] = array[i];
                        break;
                    }
                }
            }
            Console.WriteLine("стартовий масив\t");
            for (int i = 0; i < n; i++)
            {
            Console.WriteLine(array[i] +  "");
            }
            Console.WriteLine("вихідний масив з дублюючими елементами\t");
            for (int i = 0; i < d; i++)
            {
            Console.WriteLine(arr[i] +  "");
            }
        }
    }
}