﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;
            int nn;
            int nk;
            double sum = 0;
            Console.WriteLine("Введіть число nn ");
            nn = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число nk ");
            nk = int.Parse(Console.ReadLine());
            if (nn >= nk || nn <= 0)
                {
                    Console.WriteLine("неправильні значення!!!");
                    return;
                }
            for (k = nn;  k<nk; k++)
            {
                if (0 <= nn && nn <= nk)
                {
                    sum += (Math.Pow(-1, Math.Pow(k, 2)- 2 * k + 3) * k + 1)/(Math.Pow(k, 2) - 2);
                }
            }
            Console.WriteLine(" результат " + sum);
            return;
        }
    }
}