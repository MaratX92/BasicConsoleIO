using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Console I/O");
            GetUserData();
            Console.ReadLine();
        }
        static void GetUserData()
        {
            // Получить информацию
            Console.WriteLine("Введите пожалуйста своё имя: ");// Запрос на ввод имени
            string userName = Console.ReadLine();
            Console.WriteLine("Сколько тебе лет?: ");
            string userAge = Console.ReadLine();
            // Изменить цвет переднего плана, просто ради интереса.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            // Вывести полученные сведения на консоль.
            Console.WriteLine("Привет{0}! Твой возраст {1} лет.", userName, userAge);
            // Восстановить предыдущий цвет переднего плана.
            Console.ForegroundColor = prevColor;

        }
    }

}
