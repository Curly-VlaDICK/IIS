using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1_Kochetkov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Вывод персональной информации
            Console.WriteLine("Лабораторная работа №1");
            Console.WriteLine("ФИО: Кочетков Влад александрович");
            Console.WriteLine("Группа: 1731; Шифр специальности: 09.03.01");
            Console.WriteLine("Дата рождения: 01.09.2002");
            Console.WriteLine("Город проживания: Биробиджан");
            Console.WriteLine("Любимый предмет в школе: Физкультура");
            Console.WriteLine("Хобби: Программирование, безделье\n");

            // 2. Объявление переменных и вычисление выражения R
            int x = 2;
            double y = 2.5;
            int z = 4;
            // Вычисление выражения R = 2 * x + 2 * y - 4 * x * y + z
            double R = 2 * x + 2 * y - 4 * x * y + z;

            // Вывод результатов
            Console.WriteLine("Выражение: R = 2 * x + 2 * y - 4 * x * y + z");
            Console.WriteLine($"При x = {x}, y = {y}, z = {z}");
            Console.WriteLine($"Результат вычисления R: {R:F2}");
            Console.WriteLine("\nНажмите любую клавишу для завершения работы...");
            Console.ReadKey();
        }
    }
}