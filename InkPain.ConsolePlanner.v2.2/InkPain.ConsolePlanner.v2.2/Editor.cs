using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;

namespace InkPain.ConsolePlanner.v2._2
{
    class Editor
    {
        #region переменные и поля
        string[] titles;                //массив для хранения заголовка
        private string path;            //переменная хронящия в себе путь до файла
        private List<Record> plan;      //Указываем что создаем список хранящий в себе запись и обзываем его plan
        #endregion

        #region Конструкторы

        public Editor()
        {

            this.titles = new string[5];            //указываем массив который равен 5 элементам
            this.plan = new List<Record>();         //указываем что список не пустой
        }

        /// <summary>
        /// Конструктор который инцилизирует путь до файла
        /// </summary>
        /// <param name="Path"></param>
        public Editor(string Path)
        {
            this.path = Path;                       //указываем путь
            this.titles = new string[5];            //указываем массив который равен 5 элементам
            this.plan = new List<Record>();         //указываем что список не пустой
        }

        #endregion

        #region методы

        #region Приватные

        private DateTime ReadDateTime()
        {
            Console.WriteLine("Введите дату: ");
            DateTime Date;
            string userDate = Console.ReadLine();
            try
            {
                Date = Convert.ToDateTime(userDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода возраста: " + ex.Message);

                Date = ReadDateTime();

            }

            return Date;
        }

        private string ReadLand()
        {
            Console.WriteLine("Введите код страны: ");
            string useerLand;
            useerLand = Console.ReadLine().ToUpper();

            if (useerLand.Length > 3)
            {
                Console.WriteLine("Код страны не может содержать больше 3ех символов");
                useerLand = ReadLand();
            }
            return useerLand;

        }

        private string ReadIp()
        {
            string userIp;
            Console.WriteLine("Введите Ip: ");
            userIp = Console.ReadLine();
            try
            {
                IPAddress adress = IPAddress.Parse(userIp);

            }
            catch (Exception)
            {

                Console.WriteLine("Ошибка ввода IP, пример:254.254.254.254 ");
                userIp = ReadIp();
            }

            return userIp;
        }

        private string ReadPort()
        {
            Console.WriteLine("Введите порт: ");
            int userPortInt;
            string userPort = Console.ReadLine();
            try
            {
                userPortInt = Convert.ToInt32(userPort);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода: " + ex.Message);
                userPort = ReadPort();
            }

            return userPort;

        }

        /// <summary>
        /// Добавляет строку записи
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Land"></param>
        /// <param name="Ip"></param>
        /// <param name="Port"></param>
        /// <param name="Notes"></param>
        private void Create(int Id, DateTime Date, string Land, string Ip, string Port)
        {

            plan.Add(new Record() { Id = Id, Date = Date, Land = Land.ToUpper(), Ip = Ip, Port = Port, }); //добавляем значения в списки
        }

        /// <summary>
        /// Метод удаляет все пустые строки в файле
        /// </summary>
        private void RemoveStringEmpty()
        {
            if (File.Exists(this.path))                              
            {
                string[] file = File.ReadAllLines(this.path);       //Создаем массив и заполняем его строками нашего файла
                List<string> list = new List<string>(file);         //Переводим массив в список
                list.RemoveAll(x => x == string.Empty);             //Удаляем пустые строки из списка
                File.WriteAllLines(this.path, list);                //Записывыаем в наш файл наш результат
            }
            else                                                //Что делаем если файл не существует
            {
                Console.WriteLine("Файл не существует");
            }

        }

        //private void CheckFile()
        //{
        //    if (this.plan.Count == 0)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Сначала нужно открыть или создать файл");
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //    }
        //}

        #endregion

        #region Публичные

        /// <summary>
        /// Метод открывает файл и создает списки из файла
        /// </summary>
        public void Open()
        {
            Console.WriteLine("Введите путь до файла");

            string path = Console.ReadLine();

            this.path = path;

            RemoveStringEmpty();
            if (File.Exists(this.path))
            {
                using (StreamReader sr = new StreamReader(this.path))   //создаем обьект и указываем из какого файла нужно прочесть данные
                {
                    titles = sr.ReadLine().Split(',');                  //заполняем массив titles элементами и указываем что элемент кончается как только видим ,
                    while (!sr.EndOfStream)                             //создаем цикл, указываем что он будет выполнятся пока не закончится поток
                    {
                        string[] args = sr.ReadLine().Split(',');       //создаем массив и указываем что каждый элемент массива это строка после
                                                                        //запятой  начинается новый элемент массива
                        Create(Convert.ToInt32(args[0]),                //выполняем метод и подставляем эллементы массива
                               Convert.ToDateTime(args[1]),
                               args[2],
                               args[3],
                               args[4]);

                    }
                }
            }

        }

        /// <summary>
        /// Создание файла и запись в него заголовка
        /// </summary>
        public void NewFile()
        {
            Console.WriteLine("Введите путь до файла");

            string path = Console.ReadLine();

            this.path = path;

            string txt = "  ID,дата создания записи,страна прокси,IP,Порт"; //Заголовок который будет создаваться в файле
            using (StreamWriter sw = new StreamWriter(this.path, false, Encoding.UTF8)) //Указываем что если файл существует то мы его перезаписываем в кодировке UTF8
            {
                sw.WriteLine(txt); //указываем что записываем в файл
            }
        }

        /// <summary>
        /// Создание записи пользователем
        /// </summary>
        /// <param name="userDate"></param>
        /// <param name="userLand"></param>
        /// <param name="userIp"></param>
        /// <param name="userPort"></param>
        public void AddRecord()
        {
            //CheckFile();
            int userId = 1;
            for (int i = 0; i < plan.Count; i++)
            {
                userId = i + 1;

            }
            
            DateTime userDate = ReadDateTime();
            string userLand = ReadLand();
            string userIp = ReadIp();
            string userPort = ReadPort();

            Create(userId, userDate, userLand, userIp, userPort);                                                                        //создаем запись

            string txt = Convert.ToString(userId) + "," + Convert.ToString(userDate) + "," + userLand + "," + userIp + "," + userPort;   //Создаем переменную в которой
                                                                                                                                         //Хранятся введеные значения
            using (StreamWriter sw = new StreamWriter(this.path, true, Encoding.UTF8))
            {
                sw.Write("\n" + txt);
            }
        }

        /// <summary>
        /// Метод который выводит все на экран
        /// </summary>
        public void PrintFile()
        {
            //CheckFile();

            //выводим заголовок на консоль
            Console.WriteLine($"{this.titles[0]}        " +
                              $"{this.titles[1]}        " +
                              $"{this.titles[2]}           " +
                              $"{this.titles[3]}           " +
                              $"{this.titles[4]}");

            for (int i = 0; i < plan.Count; i++)           //указываем что цикл будет выполнятся пока i меньше количества элементов в списке
            {
                Console.WriteLine(plan[i].Print());         //выводим элемент списка

            }
        }

        /// <summary>
        /// Метод удаляет указанную строку
        /// </summary>
        /// <param name="id"></param>
        public void RemoveString()
        {
            //CheckFile();
            string[] file = File.ReadAllLines(this.path);

            Console.Write("Введите номер редактируемой заметки: ");
            string sId = Console.ReadLine();
            int id;
            try
            {
                id = Convert.ToInt32(sId);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибка ввода " + ex.Message);
                return;
            }

            this.plan.RemoveAll(e => e.Id == id);
            File.WriteAllLines(this.path, file);
            PrintFile();

        }

        /// <summary>
        /// Метод изменяет указанную строку
        /// </summary>
        public void EditeString()
        {
            //CheckFile();
            string[] file = File.ReadAllLines(this.path);

            Console.Write("Введите номер редактируемой заметки: ");
            string sNumber = Console.ReadLine();
            int iNumber;
            try
            {
                iNumber = Convert.ToInt32(sNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода номера: " + ex.Message);
                return;
            }


            this.plan.RemoveAll(e => e.Id == iNumber);


            int id = iNumber;
            DateTime testdata = ReadDateTime();
            string testland = ReadLand();
            string testip = ReadIp();
            string testport = ReadPort();
            Create(id, testdata, testland, testip, testport);

            PrintFile();
            File.WriteAllLines(this.path, file);

        }

        /// <summary>
        /// Метод выполняющий сортировку по ид, дате, стране
        /// </summary>
        /// <param name="how"></param>
        public void RecordSort()
        {

            var sort = plan.OrderBy(s => s.Date);



            Console.WriteLine($"{this.titles[0]}        " +
                              $"{this.titles[1]}        " +
                              $"{this.titles[2]}           " +
                              $"{this.titles[3]}           " +
                              $"{this.titles[4]}");
            foreach (Record item in sort)

                Console.WriteLine($"{item.Id,5}" +
                                  $"{item.Date,23:dd.MM.yyyy}" +
                                  $"{item.Land,20}" +
                                  $"{item.Ip,25}" +
                                  $"{item.Port,9}");
        }

        #endregion

        #endregion

        #region управление



        #endregion

    }
}
