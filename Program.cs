using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB6
{
    class Program
    {
        private static Controllers.ViewConroller viewController = new Controllers.ViewConroller();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Нажмите 1, чтобы вывести все школы");
                Console.WriteLine("Нажмите 2, чтобы вывести все направления");
                Console.WriteLine("Нажмите 3, чтобы вывести направления определенной школы");
                Console.WriteLine("Нажмите esc для выхода");
                Console.WriteLine();
                var button = Console.ReadKey(true).Key;
                switch (button)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.D1:
                        viewController.PrintSchools();
                        break;
                    case ConsoleKey.D2:
                        viewController.PrintDirections();
                        break;
                    case ConsoleKey.D3:
                        viewController.PrintDirectionsOfSchool();
                        break;
                    default:
                        Console.Write("Неизвестный ввод");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
