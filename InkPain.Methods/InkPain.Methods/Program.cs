using System;
using System.Linq;
using System.Threading;
using System.Threading;

namespace InkPain.Methods
{
    class Program
    {

        #region Как описывать метод

        //Для того чтобы указать метод нужно указать уровни доступа, Модификатор доступа, возвращаемый тип, Имя метода(Параметр метода)
        //{
        //    Тело метода;
        //}

        //Уровни доступа: public, protected, internal, private.
        //    с помощью 4ех модификаторов можно объявить 6 уровней доступности.

        //Модификаторы доступа: static, abstract, async, extern, private.

        //Возвращаемый тип: int double string и тд
        //                  void если ничего возвращать не нужно

        //параметры метода: аргументы над которыми, как правило производится какое-то действие
        //                  Формальные параметры - параметры указанные при описании метода
        //                  Фактические параметны - параметры указанные при вызове метода

        //Вызов метода: Написать имя метода и в скобках фактический параметр если он есть, если нет скобки оставить пустыми

        #endregion

        #region Методы которыечто-то делают
        //такой метод как черная коробка которая что-то делает но получить содержимая мы не можем, и положить ничего не можем
        /// <summary>
        /// Метод который будет ждать пока нажмем какаую-то клавишу
        /// </summary>
        static void Pause()
        {
            Console.ReadKey();
        }
        /// <summary>
        /// Метод который будет выводить на консоль Hello
        /// </summary>
        static void Hi1()
        {
            Console.WriteLine("Hello");
        }

        /// <summary>
        /// Метод будет вызывать в рандомном месте рандомно надписи которые мы зададим в методе
        /// </summary>
        static void chaoseOfConsole() 
        {
            Random r = new Random(); //задаем переменную рандома

            for (int i = 0; i < r.Next(30,50); i++) //пока i меньше рандомного числа от 30 до 50 выполняем цикл
            {
                int posX = r.Next(Console.WindowWidth-5);  //создаем переменную posX которая равна рандомному числу ширены экрана и -5 от этого числа
                int posY = r.Next(Console.WindowHeight-1); //создаем переменную posY которая равна рандомному числу высоты экрана и -1 от этого числа
                Console.SetCursorPosition(posX, posY + 1);   //Говорим что хотим поставить курсор в кардинаты от posX до posY +1
                Console.Write(r.Next(2) == 0 ? "Пошел" : "на хуй"); // Выводим на экран Пошел если r.(Next(2) будет 0, если нет то выводим на хуй


            }
            
            
        }


        #endregion

        #region что-то принемает(аргумент) и что-то делает
        //примером такого метода может являтся вывод какого-то текста Print(string text)
        /// <summary>
        /// Метод будет делать паузу на (Interval(передоваемый)) секунд
        /// </summary>
        /// <param name="Interval"></param>
        static void Pause2(int Interval)
        {
            Thread.Sleep(Interval * 1000); //При вызове функции указываем в теле функции число и оно будет умножено на 1000, в нашем случаи это милисекунды
        }

        static void Hi2(string name)
        {
            Random r = new Random();

            string text = string.Empty;

            switch (r.Next(5))
            {
                case 0:
                    {
                        text = $"Привет, {name}";
                        break;
                    }
                case 1:
                    {
                        text = $"Добрый день, {name}";
                        break;
                    }
                case 2:
                    {
                        text = $"Приветствую, {name}";
                        break;
                    }
                case 3:
                    {
                        text = $"Рад тебя видить, {name}";
                        break;
                    }
                default:
                    {
                        text = $"Я так ждал тебя {name}";
                        break;
                    }
            }

            Console.WriteLine(text);

        }
        /// <summary>
        /// Уорядоченый хос в консоли, текст и число выводов вводятся вручную
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <param name="count"></param>
        static void chaoseOfConsole2(string text1, string text2, int count)
        {

            Random r = new Random();
            int max = new int[] { text1.Length, text1.Length }.Max();

            for (int i = 0; i < count; i++)
            {
                int posX = r.Next(Console.WindowWidth - max);
                int posY = r.Next(Console.WindowHeight);
                Console.SetCursorPosition(posX, posY + 1);
                Console.WriteLine(r.Next(2) == 0 ? text1 : text2);
            }

        }


        #endregion 

        #region что-то делает и выдвет результат
        //допустим метод возвращения r.Next() - вот метод некст ничего не принял но вернул какое-то число из большого диапазона

        /// <summary>
        /// Возвращает случайную строку
        /// </summary>
        /// <returns></returns>
        static string GetRandomString()
        {
            return Guid.NewGuid().ToString();
        }

        static string GetRandomHi()
        {
            Random r = new Random();
            string text = string.Empty;
            switch (r.Next(5))
            {
                case 0:
                    {
                        text = $"Привет";
                        break;
                    }
                case 1:
                    {
                        text = $"Привет2";
                        break;
                    }
                case 2:
                    {
                        text = $"Привет3";
                        break;
                    }
                case 3:
                    {
                        text = $"Привет4";
                        break;
                    }
                default:
                    {
                        text = $"Привет5";
                        break;
                    }
            }

            return text;
        }

        #endregion 

        #region что-то принемают и что-то возвращают
        //опять же тот же рендом r.Next(10) то есть метод прнемает число 10 и отдает числа до 10


        /// <summary>
        /// Выдвет рандомную строку, столько символов сколько мы передадим и возвращает ее
        /// </summary>
        /// <param name="Count"></param>
        /// <returns></returns>
        static string GetRandomString2(int Count)
        {
            return Guid.NewGuid().ToString().Substring(0, Count);
        }

        static int Max(int value1, int value2)
        {

            if(value1 > value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }

        }

        /// <summary>
        /// Метод принемает массив целых чисел и возвращает его же с противоположным знаком
        /// </summary>
        /// <param name="Arges"></param>
        /// <returns></returns>
        static int[] Invers(int[] Arges)
        {
            int[] t = new int[Arges.Length];

            for (int i = 0; i < Arges.Length; i++)
            {

                t[i] = -Arges[i];

            }
            return t;
        }



        #endregion

        #region Практическое применение методов 1
        /// <summary>
        /// метод создает интервал
        /// </summary>
        /// <param name="Interval">Значение в мили секундах</param>
        static void PauseInterval(int Interval)
        {
            Thread.Sleep(Interval * 1000);
        }

        /// <summary>
        /// Метод заполняющий массив Coll
        /// </summary>
        /// <param name="Col">Передаваемый массив</param>
        static void Fill(int[] Col)
        {
            Random r = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Col[i] = r.Next(100);
            }
        }

        /// <summary>
        /// Выводит массив
        /// </summary>
        /// <param name="col"></param>
        static void PrintArray(int[] col)
        {
            foreach(var e in col)
            {
                Console.Write($"{e} ");
            }

        }
        /// <summary>
        /// Ищим максимум
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        static int MaxArr(int[] col)
        {
            return col.Max();
        }
        /// <summary>
        /// Ищим минимум
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        static int MinArr(int[] col)
        {
            return col.Min();
        }


        #endregion

        #region Перегрузка методов

        //Перегрузка методов это набор методов
        //имеющих одинаковое имя, отличающиеся количеством формальных парамметров или их типам

        /// <summary>
        /// Метод заполняющий массив col. Если в качестве парамметра передается массив то будет вызванна перегрузка этого метода
        /// </summary>
        /// <param name="col">массив</param>
        static void Fill2(int[] col)
        {
            Random r = new Random();

            for (int i = 0; i < col.Length; i++)
            {
                col[i] = r.Next(100);
            }
        }

        /// <summary>
        /// Метода заполняющий массив col count элементами. Если в качестве парамметра передается массив и число элементов будет
        /// вызвана перегрузка этого метода
        /// </summary>
        /// <param name="col">масив</param>
        /// <param name="count">количество элементов которые нужно заполнить</param>
        static void Fill2(int[] col, int count)
        {
            Random r = new Random();

            for (int i = 0; i < count; i++)
            {
                col[i] = r.Next(100);
            }
        }

        /// <summary>
        /// Метода заполняющий массив числами из диапазона
        /// </summary>
        /// <param name="col">массив</param>
        /// <param name="botomRange">от какого числа</param>
        /// <param name="upperRange">до какого числа</param>
        static void Fill2(int[] col, int botomRange, int upperRange)
        {
            Random r = new Random();

            for (int i = 0; i < col.Length; i++)
            {
                col[i] = r.Next(botomRange, upperRange);
            }
        }


        static void Fill2(double[] col, int botomRange, int upperRange)
        {
            Random r = new Random();
            for (int i = 0; i < col.Length; i++)
            {
                col[i] = r.Next(botomRange, upperRange);
            }
        }

        /// <summary>
        /// Заполняет массив col, count элементами диапазоном от botomRange до upperRange
        /// </summary>
        /// <param name="col">массив</param>
        /// <param name="count">элементы массива</param>
        /// <param name="botomRange">от числа</param>
        /// <param name="upperRange">до числа</param>
        static void Fill2(int[] col, int count, int botomRange, int upperRange)
        {
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                col[i] = r.Next(botomRange, upperRange);
            }
        }


        #endregion

        #region Понятие рекурсивной функции это функции которые вызывают сами себя


        /// <summary>
        /// Выводит на консоль сам себя, потом делает перерыв 100 мили секунд и вызывает сам себя
        /// </summary>
        static void NotInfinity(int count)
        {
            Console.WriteLine("0_-");
            Thread.Sleep(100);
            count = count - 1;
            if (count > 0)
            {
                NotInfinity(count);
            }
        }

        #endregion

        static void Main(string[] args)
        {
            #region урок 1
            //chaoseOfConsole();
            Pause();
            Console.WriteLine();
            Hi2("Увася");

            //chaoseOfConsole2("Ты", "Пидор", 50);
            string res = GetRandomString();
            Console.WriteLine(res);
            Console.WriteLine(GetRandomHi());

            Console.WriteLine(GetRandomString2(5));

            Console.WriteLine("Введите число 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите число 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            string ResultMaxNum = Convert.ToString(Max(num1, num2));
            Console.WriteLine(ResultMaxNum);

            int[] col = { 1, 2, 3, 6, 3, 8, 3, 6 };

            foreach (var e in col)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();

            int[] inversCol = Invers(col);

            Console.WriteLine();
            foreach (var e in inversCol)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            //Pause2(5); //Будет ожидание 5 секунд
            #endregion

            #region урок 2//Практическое задание Найти максимум и минимум в двух массивах

            Random r = new Random();
            int N = r.Next(10, 20);
            int M = r.Next(10, 20);

            int[] arr = new int[N];
            int[] brr = new int[N];

            Fill(arr);                                      
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine($"Maxarr = {MaxArr(arr)}");
            Console.WriteLine($"Minarr = {MinArr(arr)}");
            Console.WriteLine();

            PauseInterval(2);

            Fill(brr);
            PrintArray(brr);
            Console.WriteLine();
            Console.WriteLine($"Maxbrr = {MaxArr(brr)}");
            Console.WriteLine($"Minbrr = {MinArr(brr)}");
            Console.WriteLine();

            Console.ReadKey();

            //перегрузки методов примеры

            int[] arr2 = new int[20]; //создаем массив в котором будет 20 элементов 
            Fill2(arr2, 10);          //static void Fill2(int[] col, int count)
            PrintArray(arr2);         //заполняем первые 10 элемента массива
            Console.ReadKey();

            Fill2(arr2);              // static void Fill2(int[] col)
            PrintArray(arr2);         //А теперь говорим что хотим заполнить массив полностью, но при этом используем тоже самое имя метода
            Console.ReadKey();

            Fill2(arr2, -10, 0);      //static void Fill2(int[] col, int botomRange, int upperRange)
            PrintArray(arr2);         //Заполняем элементами от -10 до 10 при этом опять используем тоже имя метода
            Console.ReadKey();

            Fill2(arr2, 10, 1 , 10);    //static void Fill2(int col, int count, int botomRange, int upperRange)
            PrintArray(arr2);          //Заполняет массив указанныех элементов в диапазоне
            Console.ReadKey();
            #endregion

            #region //Понятие рекурсивной функции это функции которые вызывают сами себя

            NotInfinity(3);

            #endregion






        }
    }
}
