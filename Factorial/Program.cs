using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
#if Example1
            int factorial = 1;
            Console.WriteLine("");
            string numberTest = Console.ReadLine();
            int number = int.Parse(numberTest);

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Факториал числа {number} равен {factorial}");
            Console.ReadLine();
#endif

#if Example3
            Console.WriteLine("");
            string example = Console.ReadLine();
            string[] parts = example.Split(' ');

            if (parts[1] == "+")
            {
                int plus = int.Parse(parts[0]) + int.Parse(parts[2]);
                Console.WriteLine($"Ответ: {plus}");
            }
            if (parts[1] == "-")
            {
                int minus = int.Parse(parts[0]) - int.Parse(parts[2]);
                Console.WriteLine($"Ответ: {minus}");
            }
            if (parts[1] == "*")
            {
                int multiplication = int.Parse(parts[0]) * int.Parse(parts[2]);
                Console.WriteLine($"Ответ: {multiplication}");
            }
            if (parts[1] == "/")
            {
                int division = int.Parse(parts[0]) / int.Parse(parts[2]);
                Console.WriteLine($"Ответ: {division}");
            }

            Console.ReadLine();
#endif
        }
    }
}
