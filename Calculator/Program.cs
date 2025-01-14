using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        static void Main()
        {
            Console.WriteLine("Введите пожалуйста первое число:");
            double sum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*,/,-,+ ?");
            char symbol = Convert.ToChar(Console.ReadLine());
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine("Введите пожалуйста второе число:");
            double sum2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            bool isValid = true;
            switch (symbol)
            {
                case '*': result = sum1 * sum2; break;
                case '-': result = sum1 - sum2; break;
                case '+': result = sum1 + sum2; break;
                case '/': result = sum1 / sum2; break;
            }
            if (isValid)
            {


                Console.WriteLine($"Результатат: {result} ");
                Console.WriteLine("Нажмите пробел для закрытия.");

                Console.ReadKey();
            }
            
            
            
        }
    }
}
