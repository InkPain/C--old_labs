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


            ///Приветствие

            WriteLineCenter("Добро пожаловать в записную книжку!");
            Console.WriteLine();                                  //Пропуск строки

            //Просим пользователя ввести ответ и проверяем его
            WriteLineCenter("Хотите ли вы Продолжить? " +
                            "Введите: \"д\" - Да,\"н\" - Нет");
            string answer = Console.ReadLine();
            string fName, lName, age, height, hMark, mMark, rMark;
            double average;
            List<string> students = new List<string>();
            while(answer == "д")
            {
                WriteLineCenter("Ввести информацию об ученике? Введите: \"д\" - Да,\"н\" - Нет");
                string answer2 = Console.ReadLine();
                if(answer2 == "д")
                {
                    WriteLineCenter("Введите имя ученика");
                    fName = Console.ReadLine();
                    WriteLineCenter("Введите фамилию ученика");
                    lName = Console.ReadLine();

                    WriteLineCenter("Введите возраст ученика");
                    age = Console.ReadLine();
                    while (answer == "д")
                    {
                        WriteLineCenter("Вы ввели не число попробуйте еще раз");
                        WriteLineCenter("Введите возраст ученика");
                        age = Console.ReadLine();
                        int Num;
                        bool ageIsInt = int.TryParse(age, out Num);
                        if (ageIsInt)
                        {
                            break;
                        }
                        else
                        {

                            continue;
                        }
                    }
                    WriteLineCenter("Введите рост ученика");
                    height = Console.ReadLine();
                    while (answer == "д")
                    {
                        WriteLineCenter("Вы ввели не число попробуйте еще раз");
                        WriteLineCenter("Введите рост по ученика");
                        height = Console.ReadLine();
                        int Num;
                        bool heightIsInt = int.TryParse(height, out Num);
                        if (heightIsInt)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    WriteLineCenter("Введите балл по истории");
                    hMark = Console.ReadLine();
                    while (answer == "д")
                    {
                        WriteLineCenter("Вы ввели не число попробуйте еще раз");
                        WriteLineCenter("Введите балл по истории");
                        hMark = Console.ReadLine();
                        int Num;
                        bool hMarkIsInt = int.TryParse(hMark, out Num);
                        if (hMarkIsInt)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    WriteLineCenter("Введите балл по математике");
                    mMark = Console.ReadLine();
                    while (answer == "д")
                    {
                        WriteLineCenter("Вы ввели не число попробуйте еще раз");
                        WriteLineCenter("Введите балл по математике");
                        mMark = Console.ReadLine();
                        int Num;
                        bool mMarkIsInt = int.TryParse(mMark, out Num);
                        if (mMarkIsInt)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    WriteLineCenter("Введите балл по русскому языку");
                    rMark = Console.ReadLine();
                    while (answer == "д")
                    {
                        WriteLineCenter("Вы ввели не число попробуйте еще раз");
                        WriteLineCenter("Введите балл по русскому языку");
                        rMark = Console.ReadLine();
                        int Num;
                        bool rMarkIsInt = int.TryParse(rMark, out Num);
                        if (rMarkIsInt)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    students.Add(
                                 $"Имя: {fName}" +
                                 $"Фамилия: {lName} " +
                                 $"Возраст: {age} " +
                                 $"Рост: {height}" + 
                                 $"\nбалл по истории: {hMark}" +
                                 $"балл по математике: {mMark} " +
                                 $"балл по русскому языку: {rMark} " +
                                 $"средний балл: {height}");

                }
                else if (answer2 == "н")
                {
                    WriteLineCenter("Вы ввели нет, для закрытия программы нажмите любую клавишу");
                    foreach(string el in students)
                    {
                        WriteLineCenter(el);
                    }
                    break;
                    
                }
                else
                {
                    WriteLineCenter("Вы ввели неизвестное значение попробуйте еще раз");
                    continue;
                }

            }


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
