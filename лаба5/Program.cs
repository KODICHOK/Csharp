using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            int r = 0;
            int C = 0;
            int D = 0;
            Random rand = new Random();
            Console.WriteLine("Введіть кількість рядків");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпчиків");
            M = int.Parse(Console.ReadLine());
            int[,] A = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rand.Next(5);
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                r = 0;
                for (int j = 0; j < M; j++)
                {
                    for (int s = j + 1; s < M; s++)
                    {
                        if (A[i, j] == A[i, s])
                        {
                            r++;
                            break;
                        }
                    }
                    if (r != 0)
                    {
                        break;
                    }
                    else if (j == M - 1)
                    {
                        C++;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                r = 0;
                for (int j = 0; j < M; j++)
                {
                    for (int s = j + 1; s < M; s++)
                    {
                        if (A[j, i] == A[s, i])
                        {
                            r++;
                            break;
                        }
                    }
                    if (r != 0)
                    {
                        break;
                    }
                    else if (j == M - 1)
                    {
                        D++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("кількість рядків з різними значеннями = " + C);
            Console.WriteLine("Кількість стовпчиків з різними значеннями = " + D);
        }
    }
}