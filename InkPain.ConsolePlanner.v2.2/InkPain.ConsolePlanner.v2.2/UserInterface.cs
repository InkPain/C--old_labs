using System;
using System.Collections.Generic;
using System.Text;

namespace InkPain.ConsolePlanner.v2._2
{
    class UserInterface
    {

        private Editor editor;

        private int CurrentFuncton = -1;

        string path;

        /// <summary>
        /// конструктор класса
        /// </summary>
        public UserInterface()
        {
            this.editor = new Editor(this.path);
        }

        /// <summary>
        /// Приветствие
        /// </summary>
        public void StartProgram()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Привет!!! Эта программа позволит тебе записывать твои прокси socks5 и хранить их в удобном для тебя месте");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Меню программы");
            ShowMenu();
        }

        /// <summary>
        /// Меню
        /// </summary>
        void ShowMenu()
        {

            CurrentFuncton = -1;                                            //пришли из меню
            Console.WriteLine("1 - Открыть файл");
            Console.WriteLine("2 - создать файл");
            Console.WriteLine("3 - Показать введенные заметки");
            Console.WriteLine("4 - Создать заметку");
            Console.WriteLine("5 - Редактировать заметку");
            Console.WriteLine("6 - Удалить заметку");
            Console.WriteLine("7 - Сортировать заметки");
            Console.WriteLine("0 - Выход");
            ReadUserChoise();
            ProcessUserChoise();

        }
        void ReadUserChoise()
        {
            string choise = Console.ReadLine();
            int intChoise;

            try
            {
                intChoise = Convert.ToInt32(choise);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка ввода: " + ex.Message);
                ReadUserChoise();
                return;
            }
            CurrentFuncton = intChoise;
        }

        //string ReadPath()
        //{
        //    Console.WriteLine("Введите путь до файла: ");
        //    string path = Console.ReadLine();
        //    return path;
            
        //}

        /// <summary>
        /// Обработка выбранного пункта
        /// </summary>
        void ProcessUserChoise()
        {
            switch(CurrentFuncton)
            {
                case -1:
                    ShowMenu();
                    return;
                case -0:
                    Environment.Exit(0);
                    return;
                case 1:
                    //ReadPath();
                    editor.Open();
                    break;
                case 2:
                    //ReadPath();
                    editor.NewFile();
                    Console.WriteLine("Файл успешно создан теперь его нужно открыть");
                    return;
                case 3:
                    editor.PrintFile();
                    break;
                case 4:
                    editor.AddRecord();
                    break;
                case 5:
                    editor.EditeString();
                    break;
                case 6:
                    editor.RemoveString();
                    break;
                case 7:
                    editor.RecordSort();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Такого пункта нет в меню. Выберите корректный.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                    ShowMenu();
                    return;
            }
            CurrentFuncton = -1;
            Console.WriteLine();
            ShowMenu();

        }

    }
}
