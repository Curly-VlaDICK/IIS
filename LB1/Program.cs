using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb1_Sayapin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Вывод персональной информации
            Console.WriteLine("Лабораторная работа №1");
            Console.WriteLine("ФИО: Саяпин Никита Анатольевич"); 
            Console.WriteLine("Группа: 1731; Шифр специальности: 09.03.01");
            Console.WriteLine("Дата рождения: 27.01.2003");
            Console.WriteLine("Город проживания: Биробиджан");
            Console.WriteLine("Любимый предмет в школе: Математика");
            Console.WriteLine("Хобби: Программирование, настольные игры, чтение\n");

            // 2. Объявление переменных и вычисление выражения Se
            double w = 2.5;  
            double l11 = 3.0;
            double bt = 4.2;
            double x = 1.5;
            double y = 2.0;

            // Вычисление выражения Se = w * l11 + bt - x + y * w
            double Se = w * l11 + bt - x + y * w;

            // Вывод результатов
            Console.WriteLine("Выражение: Se = w * l11 + bt - x + y * w");
            Console.WriteLine($"При w = {w}, l11 = {l11}, bt = {bt}, x = {x}, y = {y}");
            Console.WriteLine($"Результат вычисления Se: {Se:F2}");

            Console.WriteLine("\nНажмите любую клавишу для завершения работы...");
            Console.ReadKey();
        }
    }
}
