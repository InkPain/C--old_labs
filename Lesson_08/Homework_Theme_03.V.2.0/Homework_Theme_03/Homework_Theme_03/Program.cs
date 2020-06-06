using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Приветствие и правила
            WriteLineCenter("Добро пожаловать в игру!");
            WriteLineCenter("Это игра против ИИ");
            WriteLineCenter("Комп. задумывает число от 12 до 360 зависит от уровня сложности.");
            WriteLineCenter("Игроки ходят по очереди(игра сообщает о ходе текущего игрока).");
            WriteLineCenter("Игрок, ход которого указан вводит число, которое может принимать значения от 1 до 4");
            WriteLineCenter("введенное число вычитается из числа, которое придумал комп., Новое значение показывается игрокам на экране.");
            WriteLineCenter("Выигрывает тот игрок, после чьего хода число компа. обратилась в ноль.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Чтобы продолжить нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();

            //Действие 2 - Просим играков ввести свое имя и уровень сложности
            Console.Write("Игрок 1, введите ваше имя: ");
            string userName_1 = Console.ReadLine();
            Console.WriteLine($"Добро пожаловать, {userName_1}!");

            Console.WriteLine();
            Console.Write("Игрок 2, введите ваше имя: ");
            string userName_2 = "ИИ";
            Console.WriteLine($"Добро пожаловать, {userName_2}!");

            Console.WriteLine();
            Console.WriteLine("Введите число характеризующие уровень сложности.");
            Console.WriteLine("1 - легкий задуманное число от 12 до 120, 2 - средний задуманное число от 12 до 240, 3 и последующие - сложный задуманное число от 12 до 360");
            int level = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу");

            Console.ReadKey();
            Console.Clear();

            //Действие 3 - Создаем случайное число и сообщаем его пользователю.

            Random rnd = new Random();
            int gameNumber;
            if (level == 1)
            {
                gameNumber = rnd.Next(12, 121);
            }
            else if (level == 2)
            {
                gameNumber = rnd.Next(12, 241);
            }
            else
            {
                gameNumber = rnd.Next(12, 361);
            }

            WriteLineCenter($"ДА НАЧНЕТСЯ ИГРА!! СЛУЧАЙНОЕ ЧИСЛО {gameNumber}");

            //Действие 4 - код игры.
            int iiTry;

            int userTry;                    // Создаем переменную для ввода числа пользователем
            for (; ; )                      // Создаем цикл котороый прекратится только тогда когда gameNumber будет равен 0 
            {
                Console.Write($"\n{userName_1}, Введите ваше число: ");                             //просим первого игрока ввести число                   
                for (; ; )                                                                                                   
                {                                                                            
                    userTry = Convert.ToInt32(Console.ReadLine());                                  //конвертируем то что ввел игрок в значение инт
                    if (userTry > 4)                                                                //что будет выполнятся если игрок ввел число больше 4
                    {                                                                        
                        Console.WriteLine("Вы ввели число больше 4, попробуйте еще раз");
                        continue;
                    }
                    else
                    {
                        break;                                                               
                    }                                                                        
                }
                gameNumber = gameNumber - userTry;                                                  //вычитаем из числа задуманного ИИ то что ввел юзер
                Console.WriteLine($"Теперь число задуманное ИИ равно: {gameNumber}");               //выводим на экран что получилось

                if (gameNumber <= 0)                                                                //что произойдет если после ввода числа юзером число ии меньше или ровно 0
                {                                                                            
                    Console.WriteLine($"Игрок {userName_1} победил");
                    Console.WriteLine("Хотите реванш? \"д - ДА\" \"н - НЕТ\"");              
                    string revange = Console.ReadLine();
                    if (revange == "д")                                                             
                    {
                        gameNumber = rnd.Next(12, 121);
                        Console.Clear();
                        WriteLineCenter($"ДА НАЧНЕТСЯ ИГРА!! СЛУЧАЙНОЕ ЧИСЛО {gameNumber}");
                        continue;
                    }
                    else                                                                            //Что произойдет если пользователь введет ответ что не хочет повторить
                    {
                        Console.WriteLine("Игра окончена. Для закрытия программы нажмити любую кнопку");
                        Console.ReadKey();
                        break;
                    }
                }
                iiTry = rnd.Next(1, 5);                                                             //Создаем число игрока ИИ от 1 до 4
                Console.Write($"\n{userName_2}, Ввел число: {iiTry}");
                gameNumber = gameNumber - iiTry;                                                    //Вычитаем число игрока ИИ из числа ИИ
                Console.WriteLine($"\nТеперь число задуманное ИИ равно: {gameNumber}");

                if (gameNumber <= 0)                                                                //что произойдет если после ввода числа игрока ИИ число ии меньше или ровно 0
                {
                    Console.WriteLine($"Игрок {userName_2} победил");
                    Console.WriteLine("Хотите реванш? \"д - ДА\" \"н - НЕТ\"");
                    string revange = Console.ReadLine();
                    if (revange == "д")
                    {
                        gameNumber = rnd.Next(12, 121);
                        Console.Clear();
                        WriteLineCenter($"ДА НАЧНЕТСЯ ИГРА!! СЛУЧАЙНОЕ ЧИСЛО {gameNumber}");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Игра окончена. Для закрытия программы нажмити любую кнопку");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
            /// <summary>
            /// Создаем функцию для вывода текста по центру экрана
            /// </summary>
            /// <param name="text"></param>
            static void WriteLineCenter(string text)
            {
                var width = Console.WindowWidth; //Создаем переменную  width и указывачто она ровна ширине консоли
                var padding = width / 2 + text.Length / 2;
                Console.WriteLine("{0," + padding + "}", text);
            }

        }
    }


