using System;

namespace inkPainFetchOrerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //создать эмулятор игры в котором у игрока есть возможность выбрать 
            //уровень сложности, в зависимости от которого будет генерироваться разный игровой мир

            Console.WriteLine("Введите уровоень сложности 1-Простой, 2-Средний, 3-Сложный");

            int level; // 1 - простой
                       // 2 - средний
                       // 3 сложный
                       // В зависимости от уровня сложности определить количество генерируемых НПС
                       // Простой 2
                       // Средний 4
                       // Сложный 5

            level = Convert.ToInt32(Console.ReadLine());

            switch (level)
            {
                case 1:
                    Console.WriteLine("Сгенерирован НПС");
                    Console.WriteLine("Сгенерирован НПС");
                    break;
                case 2:
                    Console.WriteLine("Сгенерирован НПС");
                    Console.WriteLine("Сгенерирован НПС");
                    Console.WriteLine("Сгенерирован НПС");
                    Console.WriteLine("Сгенерирован НПС");
                    break;
                case 3:
                    Console.WriteLine("Сгенерирован НПС");
                    Console.WriteLine("Сгенерирован НПС");
                    Console.WriteLine("Сгенерирован НПС");
                    Console.WriteLine("Сгенерирован НПС");
                    Console.WriteLine("Сгенерирован НПС");
                    break;
                default:
                    Console.WriteLine("Выбран неизвестный уровень");
                    break;
            }








            // Программа показывает нназвания дней неели по номеру

            Console.Write("Чтобы узнать название дня недели введите его число: ");
            int dayIndex = int.Parse(Console.ReadLine());

            switch (dayIndex)
            {
                case 1:
                    Console.WriteLine("Понедельник"); //Это будет выведено если пользователь введет 1
                    break;
                case 2:
                    Console.WriteLine("Вторник");     //Это будет выведено если пользователь введет 2 и тд
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Ты дурачек? в неделе всего 7 дней"); //Это будет выведенно если пользователь введет что-то что не входит в case
                    break;
            }


        }
    }
}
