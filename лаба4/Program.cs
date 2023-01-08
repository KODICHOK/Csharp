﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int K = 0;
            int c = 0;
            double A = 0;
            double d = 0;
            int sum = 0;
            int sad = 0;
            Console.WriteLine("Введіть розмір");
            N = int.Parse(Console.ReadLine());
            int[] b = new int[N];
            for (int i = 0; i < N; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            K = b[1] - b[0];
            A = b[1] / b[0];
            for (int i = 2; i < N; i++)
            {
                c = b[i] - b[i - 1];
                d = b[i] / b[i - 1];
                if (c == K)
                {
                    sum++;
                }
                else if (d == A)
                {
                    sad++;
                }
            }
            if (sum == N - 2)
            {
                Console.Write("арифметична прогресія з різницею у " + K + " елементів");
            }
            else if (sad == N - 2)
            {
                Console.Write("геометрична прогресія з множником у " + A + " елементів");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}