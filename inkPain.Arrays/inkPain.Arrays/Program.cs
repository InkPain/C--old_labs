using System;

namespace inkPain.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            ////4.1 Одномерные массивы: инициализация, определения, использование, задание
            //Console.WriteLine("Одномерные массивы: инициализация, определения, использование, задание");



            ////Свормировать массив из N случайных числе от -5 до 5
            //Console.WriteLine("Свормировать массив из N случайных числе от -5 до 5");

            ////Решение
            //Console.WriteLine("введите n: ");                   //Просим ввести число
            //int n = Convert.ToInt32(Console.ReadLine());        //ввод числа с клаввы и конвертация в инт

            //Random random = new Random();                       //Инцилизация генерации псевдослучайных чисел
            //int[] numbs = new int[n];                           //Создаем масив с n элементами

            //for (int i = 0; i < numbs.Length; i++)
            //{

            //    numbs[i] = random.Next(-5, 6);                  //заполняем массив
            //    Console.Write($" { numbs[i]}");                 //выводим элементы массива

            //}
            //Console.ReadKey();

            ////Свормировать массив из N случайных числе подсчитать количество четных
            //Console.WriteLine("\nСвормировать массив из N случайных числе подсчитать количество четных");

            //Console.WriteLine("введите n: ");                   //Просим ввести число
            //n = Convert.ToInt32(Console.ReadLine());        //ввод числа с клаввы и конвертация в инт

            //Random rnd = new Random();
            //numbs = new int[n];

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    numbs[i] = random.Next(10);
            //}

            //int evenElement = 0;

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    if (numbs[i] % 2 == 0)
            //    {
            //        evenElement++;
            //    }
            //}

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    Console.Write($" {numbs[i]}");
            //}

            //Console.WriteLine($"\nЧетных Элементов: {evenElement}");

            ////В массиве из 10 чисел посмотреть сколько раз встречается введеное число

            //Console.WriteLine("В массиве из 10 чисел посмотреть сколько раз встречается введеное число");
            //numbs = new int[10];

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    numbs[i] = rnd.Next(10);
            //    Console.Write(numbs[i]);
            //}

            //Console.WriteLine("\nВведите число которое ищем");
            //int serchNumber = Convert.ToInt32(Console.ReadLine());

            //int find = 0;

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    if (numbs[i] == serchNumber)
            //    {
            //        find++;
            //    }
            //}
            //Console.WriteLine($"\nЭлемент {serchNumber} найден: {find}");
            //Console.ReadKey();

            ////Массив из N элементов состоит из 0 и 1 поставить 0 в начало а 1 в конец
            //Console.WriteLine("Массив из N элементов состоит из 0 и 1 поставить 0 в начало а 1 в конец");

            //Console.WriteLine("Введите число n");       //Просим пользователя ввести число
            //n = Convert.ToInt32(Console.ReadLine());    //Создаем переменную и помещаем в нее значение которое вводится с клавиатуры

            //random = new Random();                      //Создаем переменную рандомизации
            //numbs = new int[n];                         //создаем массив длиной которой ввелась пользователем

            //for (int i = 0; i < numbs.Length; i++)      //Создаем цикл который выполняется пока не заполнится весь массив
            //{
            //    numbs[i] = random.Next(0, 2);           //Добавляем в массив случайное число от 0 до 1
            //    Console.WriteLine($"{numbs[i]}");       //выводим массив на экран
            //}

            //int head = 0;                                    //Указатель первого индекса в массиве голова
            //int tail = numbs.Length - 1;                     //Указатель последнего индекса в массиве хвост

            //bool flag = true;                                //флаг, показывающий увеличивть позицию первого индекса - true
            //                                                 //или уменьшать позицию хвостового -false
            //while (head < tail)                              //пока голова меньше хвоста
            //{
            //    if (flag)
            //    {
            //        if (numbs[head] == 1)
            //        {
            //            flag = false;
            //        }
            //        else
            //        {
            //            head++;
            //        }
            //    }
            //    else
            //    {
            //        if (numbs[tail] == 0)
            //        {
            //            flag = true;
            //        }
            //        else
            //        {
            //            tail--;
            //        }
            //    }

            //    if (numbs[head] == 1 && numbs[tail] == 0) //если голова ровна 1 и хвост равен 0 то
            //    {
            //        int tmp = numbs[head];                //засовываем голову во времену переменую
            //        numbs[head] = numbs[tail];            //а хвост засовываем в голову
            //        numbs[tail] = tmp;                    //затем в хвост засовываем временную переменную

            //        head++;                               //сдвигаем голову дальше вправо
            //        tail--;                               //а хвост опять влево
            //    }

            //}

            //Console.WriteLine("\nВывод нового массива");
            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    Console.Write($"{numbs[i]} ");
            //}

            //Console.WriteLine();

            //Array.Sort(numbs); //тоже самое что мы делали сверху. Так же сортирует массив от меньшего к большему

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    Console.Write($"{numbs[i]} ");
            //}





            //4.2 Основные методы работы с одномерными массивами

            Console.WriteLine("4.2 Основные методы работы с одномерными массивами");

            var data = new int[] { 1, 5, 2, 5, 4, 6, 5, 7, 6, 6, 7, 9, 2, 5, 1 };
            Console.WriteLine("Исходый массив");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }

            int result = Array.IndexOf(data, 5); //выполняет поиск указанного объекта, в нашем случаи 5,
                                                 //в массиве, в нашем случае data, и возвращает инедекс первого найденного такого элемента
            Console.WriteLine($"\nAray.IndexOf: {result}");

            result = Array.LastIndexOf(data, 5);//выполняет поиск указанного объекта, в нашем случаи 5,
                                                //в массиве, в нашем случае data, и возвращает инедекс последнего найденного такого элемента
            Console.WriteLine($"Aray.LastIndexOf: {result}");

            int rang = data.Rank; //получаем ранг (число измерений) массива

            Console.WriteLine($"data.Rank: {rang}");

            Array.Sort(data); //Сортируем массив
            Console.Write($"Array.Sort: ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }

            Array.Reverse(data); //Сортирует массив в порядке убывания
            Console.Write($"\nArray.Revers: ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }

            Array.Clear(data, 7, 3); //Обнуляет массив - первый элеммент указываем массив, второй элемент указывает индекс с которого
                                     //начинается очистка, третий элемент указывает сколько элементов очистить
            Console.WriteLine("\nМассив после применения Array.Clear(data, 7 ,3): ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }



            int[] copyData = new int[20];

            Console.WriteLine("\nМассив copyData до копирования в него массива data: ");

            for (int i = 0; i < copyData.Length; i++)

            {
                Console.Write($"{copyData[i]} ");
            }

            Array.ConstrainedCopy(data, 2, copyData, 10, 5);
            //Копирует диапазон элементов из массива (data), начиная с заданного индекса (2) источника
            //и вставляет его в другой массив (copyData), начиная с заданного элемента (10).
            //Гарантирует, что в случаи невозможности успешно скопировать весь диапазон все изменения будут отменены
            //5 - количество копируемых элементов

            Console.WriteLine("\nМассив copyData после копирования в него массива data: ");
            for (int i = 0; i < copyData.Length; i++)
            {
                Console.Write($"{copyData[i]} ");
            }




            //4.3 Вложенные циклы, операторы break и continue

            //Для написания таблици умножения используем вложеный цикл for в цикл for;

            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }

            //показать все 3ех буквенные слова из алфавита s k i l

            char[] symbles = { 'S', 'K', 'I', 'L' };
            int count = 1;

            for (int i = 0; i < symbles.Length; i++)
            {
                for (int j = 0; j < symbles.Length; j++)
                {
                    for (int k = 0; k < symbles.Length; k++)
                    {
                        Console.WriteLine($"{count++,3}: {symbles[i]}{symbles[j]}{symbles[k]}");
                    }
                }
            }

            //решить уровнение (2*(a)^3 + 3*(b)^2 = 8337

            Console.WriteLine("решить уровнение (2*(a)^3 + 3*(b)^2 = 8337");
            for (double a = 1; a < 500; a++)
            {
                for (double b = 1; b < 500; b++)
                {
                    if((2 * (a * a *a) + 3 * (b * b)) == 8337)
                    {
                        Console.WriteLine($"a = {a} b = {b}");
                    }
                }
            }


            //4.4 Двумерные массивы: использование, задание

            int[,] matrix = new int[3, 4];      //Задание двумерного массива в котором 3 строки и 4 столбца

            matrix[1, 2] = 3;                   //Помещаем цифру 3 во 2ую строку 4 стобец
            //Выгледит это так
            //0 0 0 0
            //0 0 3 0
            //0 0 0 0

            Random r = new Random();            //создаем рандом

            for (int i = 0; i < 3; i++)         //i указывает какую строку мы заполняем, пока не будут заполнены 3 строки цикл будет продолжатся
            {
                for (int j = 0; j < 4; j++)     //j указывает какой столбец мы заполняем
                {
                    matrix[i, j] = r.Next(10);  //указываем что числа в масивах будут рандомными до 10
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }

            //Создать массив в котором будет столько строк и столбцов сколько укажет пользователь
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] array2d = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array2d[i, j] = r.Next(10);
                    Console.Write($"{array2d[i,j]} ");

                }
                Console.WriteLine();
            }

            //Создание таблицы вручную

            Console.WriteLine();

            string[,] table = new string[,]
            {
                {"00","01","02","03" },
                {"04","05","06","07" },
                {"08","09","10","11" }
            };

            Console.WriteLine();

            Console.WriteLine(table.Rank); //Узаем ранг массива в нашем случае 2 так как массив двумерный
            Console.WriteLine($"table.GetLength = {table.GetLength(0)}"); //показывает сколько строк массива
            Console.WriteLine($"table.GetLength = {table.GetLength(1)}"); //показывает сколько столбцов массива

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write($"{table[i,j]} ");
                }
                Console.WriteLine();
            }

            //4.5 Многомерные массивы: использование, задание
            Console.ForegroundColor = ConsoleColor.Red;

            int[,,] matrix3d = new int[3, 4, 5]; //стооки, столбцы(мини массивы), столбцы в мини масивах

            Console.WriteLine($"matrix3d.Rank = {matrix3d.Rank}");
            Console.WriteLine($"matrix3d.Length = {matrix3d.Length}");
            Console.WriteLine($"matrix3d.GetLength = {matrix3d.GetLength(0)}");
            Console.WriteLine($"matrix3d.GetLength = {matrix3d.GetLength(1)}");
            Console.WriteLine($"matrix3d.GetLength = {matrix3d.GetLength(2)}");

            //Чтобы вывести такой массив на экран нужно 3 вложенных цыкла
            for (int i = 0; i < matrix3d.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3d.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix3d.GetLength(2); k++)
                    {
                        matrix3d[i, j, k] = r.Next(10);
                        Console.Write($"{matrix3d[i, j, k]} ");
                    }
                    Console.Write("    ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            //4.6 Массив массивов
            //Массив массивов это зубчатый массив, Они могу иметь не правильный размер,
            //например в первой строке 2 элемента, во второй строке 3 элемента и тд.
            //Размеры распределяются зараз

            int[][] jaggedArray = new int[3][]; // этот массив будет содержать в себе 3 массива
            //после того как мы создали такой массив мы должны каждый из этих массивов проинцилизировать
            jaggedArray[0] = new int[2]; //указываем что в первой строке массивов будет 2 массива
            jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 3;

            jaggedArray[1] = new int[4];
            jaggedArray[1][0] = 1;
            jaggedArray[1][1] = 0;
            jaggedArray[1][2] = 3;
            jaggedArray[1][3] = 1;

            jaggedArray[2] = new int[3];
            jaggedArray[2][0] = 2;
            jaggedArray[2][1] = 0;
            jaggedArray[2][2] = 1;

            for (int i = 0; i < jaggedArray.Length; i++) //щелкает количество эллементов массива получается в нашем случаи 3
            {
                for (int j = 0; j < jaggedArray[i].Length; j++) //щелкает количество элементов в каждем вложенном массиве в нажем случае 9
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            // написать программу, моделирующию получение показания 
            // собирать и хранить информацию о температуре воздуха
            // в периуд с 9ч. утра до 21ч. вечера каждые 5 минут
            //с 21ч. до 9ч. каждые 15 минут

            int[][] dataTime = new int[24][]; //создаем массив из 24 массивов

            for (int j = 0; j < dataTime.Length; j++) //перебираем этот массив
            {
                dataTime[j] = (j >= 9 && j <= 21) ? new int[12] : new int[4]; //если в этом массиве значение от 9 до 21 то мне нужно
                                                                              //вернуть массив из 12 элементов
            }                                                                 //если же нет из 4 элементов
            Console.WriteLine(dataTime.Length);
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{i} ч. ");
                for (int j = 0; j < dataTime[i].Length; j++)
                {
                    dataTime[i][j] = r.Next(20);
                    Console.Write   ($"{dataTime[i][j]} ");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            //4.7 Цикл foreach

            dataTime = new int[24][];
            for (int j = 0; j < dataTime.Length; j++) //перебираем этот массив
            {
                dataTime[j] = (j >= 9 && j <= 21) ? new int[12] : new int[4]; //если в этом массиве значение от 9 до 21 то мне нужно
                                                                              //вернуть массив из 12 элементов
            }                                                                 //если же нет из 4 элементов

            foreach (int[] array in dataTime) //говорим что у нас есть массив array из массива массивов dataTime
            {
                foreach(int e in array)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine();
            }








        }
    }
}
