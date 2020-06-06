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



            //Создаем переменные.

            List<string> fName = new List<string>();    //Создаем список для ввода имен.
            List<string> lName = new List<string>();     //Создаем список для ввода фамилий.
            List<string> age = new List<ushort>();      //Создаем список для ввода возрастов.
            List<string> height = new List<double>();   //Создаем список для ввода роста.
            List<string> hMark = new List<double>();    //Создаем список балов для урока истории.
            List<string> mMark = new List<double>();    //Создаем список балов для урока математики.
            List<string> rMark = new List<double>();    //Создаем список балов для урока русского языка.
            string hLesons = "История";
            string mLesons = "Математика";
            string rLesons = "Русский язык";

            //Просим пользователя сделать записи в записной книжке.

            WriteLineCenter("Приветствую!");                                    //приветствуем юзера.
            WriteLineCenter("Желаете ли вы ввести информацию по ученику?");     //Спрашиваем будет ли он вводить инфу по ученикам.

            WriteLineCenter("Введите \"д\" или \"н\"");
            string answer = Console.ReadLine();
            if (answer == "д")
            {


                while (answer == "д")
                {
                    WriteLineCenter("Введите имя ученика");
                    fName.Add(Console.ReadLine());
                    WriteLineCenter("Введите Фамилию ученика");
                    lName.Add(Console.ReadLine());
                    WriteLineCenter("Введите возраст ученика");
                    age.Add(Console.ReadLine());
                    WriteLineCenter("Введите рост ученика");
                    height.Add(Console.ReadLine());
                    WriteLineCenter("Введите оценку по истории ученика");
                    hMark.Add(Console.ReadLine());
                    WriteLineCenter("Введите оценку по математике ученика");
                    mMark.Add(Console.ReadLine());
                    WriteLineCenter("Введите оценку по русскому языку ученика");
                    rMark.Add(Console.ReadLine());

                    WriteLineCenter("Закончить ввод учеников? \"д\" или \"н\"");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "д")
                    {
                        break;
                    }
                    else if (answer2 == "н")
                    {
                        continue;
                    }
                    else

                    {
                        WriteLineCenter("Вы ввели неизвестное значение, ввод учеников будет закончен");
                        break;
                    }

                }
            }
            else
            {
                WriteLineCenter("Для закрытия программы нажмите любую клавишу");
            }
            foreach (string el in fName)
            {
                WriteLineCenter(el);
            }
            WriteLineCenter("Для закрытия программы нажмите любую клавишу");
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
