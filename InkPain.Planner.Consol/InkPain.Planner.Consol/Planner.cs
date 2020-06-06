using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace InkPain.Planner.Consol
{

    /// <summary>
    /// Структура, которая управляет логикой программы
    /// </summary>
    struct Planner
    {
        #region поля, переменные и массивы
        /// <summary>
        /// Создаем массив запись, в которой будут хранится или прочитанны из файла записис.
        /// </summary>
        private PlannerRecord[] record;

        /// <summary>
        /// Поле которое хранит в себе путь до файла
        /// </summary>
        private string path;

        int index;              //переменная которая нужна для подсчета сколько записей в файле

        string[] titles;        //массив в который помещается заголовки ежедневника

        int[] ids;
        #endregion
        #region конструкторы

        /// <summary>
        /// Конструктор инициализирующий путь файла из которого будет получать нужные данные
        /// </summary>
        /// <param name="Path"></param>
        public Planner (string Path)
        {
            this.path = Path;
            this.index = 0;
            this.titles = new string[6];
            this.record = new PlannerRecord[3];
        }

        /// <summary>
        /// конструкотор отвечающий за создание запись
        /// </summary>
        /// <param name="CreateRecord"></param>
        public void Add(PlannerRecord CreateRecord)
        {
            this.Resize(index >= this.record.Length);
            this.record[index] = new ;
            this.index++;

        }
        #endregion

        #region Методы

        /// <summary>
        /// Метод вызывает инструкцию как пользоваться программой
        /// </summary>
        public static void Instruction()
        {
            Console.WriteLine("planner -new - позволят создать файл");
            //Console.WriteLine("planner -save - позволят сохранить в файл");
            Console.WriteLine("planner -open - позволят открыть файл");
            Console.WriteLine("planner -add - позволяет сделать запись в ежедневник");
            Console.WriteLine("В поле использование 1 - значит, что IP был использован, 0 что не был использован");
            Console.WriteLine("planner -edit позволяет изменить запись с нужным id");
            Console.WriteLine("planner -remove позволяет удалить запись с нужным id");
            Console.WriteLine("planner -print позволяет вывести записи");
        }

        /// <summary>
        /// Увеличивает величину массива если вдруг в нем кончилось место
        /// </summary>
        /// <param name="Flag"></param>
        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.record, this.record.Length * 2);
            }
        }

        /// <summary>
        /// Метод выводящий ежедневник на консоль
        /// </summary>
        public void PrintPlanner()
        {
            Console.WriteLine($"{this.titles[0]}        " +
                              $"{this.titles[1]}        " +
                              $"{this.titles[2]}           " +
                              $"{this.titles[3]}           " +
                              $"{this.titles[4]}        " +
                              $"{this.titles[5]}");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(this.record[i].Print());
            }

        }



        /// <summary>
        /// Загружает данные из файла
        /// </summary>
        public void Load()
        {
            using (StreamReader sr = new StreamReader(this.path))
            {
                titles = sr.ReadLine().Split(',');

                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split(',');

                    Add(new PlannerRecord(Convert.ToInt32(args[0]), 
                                          Convert.ToDateTime(args[1]), 
                                          args[2], 
                                          args[3], 
                                          args[4],
                                          Convert.ToInt32(args[5])));
                }
            }
        }


        #endregion



        public static void Start()
        {
            string path = string.Empty;
            for (; ; )
            {
                Console.WriteLine("Ожидаю команду");
                string answer = Console.ReadLine();
                
                if(answer == "planner -idsort")
                {
                    path = @"testfile.txt";
                    Planner plan = new Planner(path);
                    
                    plan.PrintPlanner();
                }

                if(answer == "planner -open")
                {
                    Console.WriteLine("Укажите путь до файла чтобы его открыть и использовать");

                    path = @"testfile.txt"; //Console.ReadLine();

                    Planner plan = new Planner(path);
                    plan.Load();
                    plan.PrintPlanner();
                }

                if (answer == "planner -new")
                {
                    Console.WriteLine("Укажите путь до файла чтобы его создать, если файл создан, то он будет перезаписан");

                    path = Console.ReadLine();

                    string txtTitle = "  ID,Дата создания записи,Страна прокси,IP,Порт,Использовалась-ли";

                    using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                    {
                        sw.WriteLine(txtTitle);
                    }
                    continue;
                }

                if (answer == "planner -q")
                {
                    Console.WriteLine("Программа будет закрыта. Пока пока");
                    Thread.Sleep(3000);
                    break;
                }

                if (answer == "planner -add")
                {
                    if (path == string.Empty)
                    {
                        Console.WriteLine("Сначала нужно создать или открыть файл, команды planner -new, planner -open");
                        continue;
                    }
                    else
                    {
                        Planner plan = new Planner(path);

                        Console.WriteLine("Введите запись которые хотите добавить");
                        Console.WriteLine("Введите id записи");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите дату записи dd.MM.yyyy или оставте пустым");
                        DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Введите страну прокси или оставте пустым");
                        string land = Console.ReadLine();
                        Console.WriteLine("Введите ip прокси или оставте пустым");
                        string ip = Console.ReadLine();
                        Console.WriteLine("Введите порт прокси или оставте пустым");
                        string port = Console.ReadLine();
                        Console.WriteLine("использовалась ли проксти введите число (0 - нет, 1 и больше - да) или оставте пустым");
                        int checkBox = Convert.ToInt32(Console.ReadLine());

                        plan.Add(new PlannerRecord(id, dateTime, land, ip, port, checkBox));
                        plan.Load();

                        string txt =id + "," + dateTime + "," + land + "," + ip + "," + port + "," + checkBox;

                        using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
                        {
                            sw.WriteLine(txt);
                        }
                        Console.WriteLine("Добавлено:");
                        plan.PrintPlanner();
                    }
                }
            }
        }







    }
}
