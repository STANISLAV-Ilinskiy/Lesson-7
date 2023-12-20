using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
 * Использовать рекурсию, не использовать циклы.*/

namespace Zadanie_1
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

            if (M > N)
            {
                Console.WriteLine("Ошибка: M не может быть больше N");
                return;
            }
            else
            {
                PrintNumbers(M, N);
            }

            
        }

        static void PrintNumbers(int M, int N)
        {
            
            if (M <= N)
            {
                Console.WriteLine(M);
                PrintNumbers(M + 1, N);
            }
                        
        }
    }
}
