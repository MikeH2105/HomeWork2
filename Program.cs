/*Пользователь вводит с клавиатуры четыре цифры.
Необходимо создать число, содержащее эти цифры. На-
пример, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
сформировать число 1578*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Доброго дня!\nВведіть будь-ласка перше число:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Введіть будь-ласка друге число:");
            string num2 = Console.ReadLine();
            Console.WriteLine("Введіть будь-ласка третьє число:");
            string num3 = Console.ReadLine();
            Console.WriteLine("Введіть будь-ласка четверте число:");
            string num4 = Console.ReadLine();
            string rezult = num1 + num2 + num3 + num4;
            double numFinal = Convert.ToInt32(rezult);
            Console.WriteLine(rezult);
            Console.WriteLine("Дякуємо!!!");
            Console.ReadKey();
        }
    }
}