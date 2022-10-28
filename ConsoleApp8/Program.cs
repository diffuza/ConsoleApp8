using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result; // присвоение локальной переменной целого типа int

            // Реализуем функцию модуля числа
            for (int i = 5; i >= -5; i--) //применение цикла for // реализация функции модуля числа
            {
                result = i >= 0 ? i : -i; // вычисление значения локальной переменной result
                Console.Write("{0}\t", result); // вывод на экран строки с вычисленным значением result
            }

            Console.WriteLine("\n\n"); // вывод на экран строки

            // Выбор четных чисел
            for (int i = 0; i < 10; i++) // применение цикла for и указание присвоенной локальной переменной i целого типа int интервального значения
            {
                if (i % 2 == 0 ? true : false) //Вложенный оператор if используется для дальнейшей проверки данных после того, как условие предыдущего оператора if принимает значение true.
                    Console.Write("{0}\t", i); // вывод на экран строки с вычисленным значением переменной i
            }

            Console.ReadLine(); // чтение строк
        }
    }
}
