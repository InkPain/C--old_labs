using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.



            // Создаем переменные с информацией об учениках

            string fName1 = "Дмитрий", fName2 = "Адель", fName3 = "Павел", fName4 = "Курт";         //Имена учеников
            string lName1 = "Гусев", lName2 = "Помидоров", lName3 = "Кауфман", lName4 = "Кобейн";   //Фамилии учеников
            byte age1 = 13, age2 = 14, age3 = 15, age4 = 16;                                        //Возраста учеников
            short height1 = 173, height2 = 154, height3 = 189, height4 = 228;                       //Рост учеников
            double hMarek1 = 3, hMarek2 = 5, hMarek3 = 4, hMarek4 = 2;                              //Баллы по истории
            double mMarek1 = 5, mMarek2 = 4, mMarek3 = 4, mMarek4 = 3;                                //Баллы по математике
            double rMarek1 = 5, rMarek2 = 4, rMarek3 = 3, rMarek4 = 2;                              //Баллы по русскому языку

            double average1 = (hMarek1 + mMarek1 + rMarek1) / 3;                                    //средний бал первого ученика
            double average2 = (hMarek2 + mMarek2 + rMarek2) / 3;                                    //средний бал второго ученика
            double average3 = (hMarek3 + mMarek3 + rMarek3) / 3;                                    //средний бал третьего ученика
            double average4 = (hMarek4 + mMarek4 + rMarek4) / 3;                                    //средний бал четвертого ученика

            //Приветствие

            WriteLineCenter("Добро пожаловать в записную книжку!");
            Console.WriteLine();                                  //Пропуск строки

            //Вывод в консоль учеников

            //Первый ученик
            WriteLineCenter("Первый ученик");
            string average1Formated = average1.ToString("#.###"); // Конвертим значение double в string и указываем сколько
            WriteLineCenter(                                      // чисел после запятой отображаем
                            $"Имя: {fName1} " +
                            $"Фамилия: {lName1} " +
                            $"Возраст: {age1} " +
                            $"Рост {height1} ");
            WriteLineCenter(
                            $"Балл по истории: {hMarek1} " +
                            $"Балл по математике: {mMarek1} " +
                            $"Балл По русскому языку: {rMarek1}");
            WriteLineCenter($"Средний Балл: {average1Formated}");
            Console.WriteLine();                                  //Пропуск строки

            //Второй ученик
            WriteLineCenter("Второй ученик");
            string average2Formated = average2.ToString("#.###"); // Конвертим значение double в string и указываем сколько
            WriteLineCenter(                                      // чисел после запятой отображаем
                            $"Имя: {fName2} " +
                            $"Фамилия: {lName2} " +
                            $"Возраст: {age2} " +
                            $"Рост {height2} ");
            WriteLineCenter(
                            $"Балл по истории: {hMarek2} " +
                            $"Балл по математике: {mMarek2} " +
                            $"Балл По русскому языку: {rMarek2}");
            WriteLineCenter($"Средний Балл: {average2Formated}");
            Console.WriteLine();                                  //Пропуск строки

            //Третий ученик
            WriteLineCenter("Третий ученик");
            string average3Formated = average3.ToString("#.###"); // Конвертим значение double в string и указываем сколько
            WriteLineCenter(                                      // чисел после запятой отображаем
                            $"Имя: {fName3} " +
                            $"Фамилия: {lName3} " +
                            $"Возраст: {age3} " +
                            $"Рост {height3} ");
            WriteLineCenter(
                            $"Балл по истории: {hMarek3} " +
                            $"Балл по математике: {mMarek3} " +
                            $"Балл По русскому языку: {rMarek3}");
            WriteLineCenter($"Средний Балл: {average3Formated}");
            Console.WriteLine();                                  //Пропуск строки

            //Четвертый ученик ученик
            WriteLineCenter("Четвертый ученик");
            string average4Formated = average4.ToString("#.###"); // Конвертим значение double в string и указываем сколько
            WriteLineCenter(                                      // чисел после запятой отображаем
                            $"Имя: {fName4} " +
                            $"Фамилия: {lName4} " +
                            $"Возраст: {age4} " +
                            $"Рост {height4} ");
            WriteLineCenter(
                            $"Балл по истории: {hMarek4} " +
                            $"Балл по математике: {mMarek4} " +
                            $"Балл По русскому языку: {rMarek4}");
            WriteLineCenter($"Средний Балл: {average4Formated}");

            Console.ReadKey();


        }

        /// <summary>
        /// Создаем функцию которая делает вывод текста по средине консоли
        /// </summary>
        /// <param name="text"></param>
        static void WriteLineCenter(string text)
        {
            int width = Console.WindowWidth;
            if (text.Length < width)
            {
                text = text.PadLeft((width - text.Length) / 2 + text.Length, ' ');
            }
            Console.WriteLine(text);

        }

    }
}
