﻿using System;
using System.Text;

namespace lb6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число\t");
            int n = int.Parse(Console.ReadLine());
            string chislo = n.ToString();
            char[] mystr = chislo.ToCharArray();
            for (int i = mystr.Length; i > 0; i--)
            {
                Console.Write(mystr[i - 1]);
            }
            Console.WriteLine("\nВведіть слово\t");

            string str = Console.ReadLine();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }


            Console.Write("\nВведіть кількість елементів масиву \t");
            int elm = int.Parse(Console.ReadLine());
            int[] myArray = new int[elm];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"\nвведіть елемент під індексом {i} \t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nобернений масив:");
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}