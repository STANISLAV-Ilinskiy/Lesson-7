using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 * Даны два неотрицательных числа m и n.*/

namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение M:");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение N:");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int result = 0;

            if (M < 0 || N < 0)
            {
                Console.WriteLine("Ошибка: значения M и N не могут быть отрицательными.");
                Console.WriteLine();
                return;
            }
            else
            {
                result = Ackermann(M, N);
            }
                          
            
            Console.WriteLine($"Результат функции Аккермана для M={M} и N={N} равен {result}");
            Console.WriteLine();
        }

        static int Ackermann(int M, int N)
        {
            if (M == 0)
            {
                return N + 1;
            }
            else if (N == 0)
            {
                return Ackermann(M - 1, 1);
            }
            else
            {
                return Ackermann(M - 1, Ackermann(M, N - 1));
            }

        }
    }
}
