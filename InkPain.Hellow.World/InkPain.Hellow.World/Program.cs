//импорт сторонних пространств именн
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// пространство имен 
/// создание собственной библиотеки
/// </summary>
namespace InkPain.Hellow.World
{
   /// <summary>
   /// Главная составляющая единица приложения - класс
   /// Подробности в теме 7. Структуры и введения в ООп
   /// </summary>
    class Program
    {
        /// <summary>
        /// Код, который выполняется в первую очередь
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {
            WriteLine("Hello World!");  // Вывод текста
                                        // В консоль
            ReadLine();                 //Ожидание от пользователя
                                        //введения чего-либо

        }
    }
}
