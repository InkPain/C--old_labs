using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InkPain.Methods.HomeWork
{
    class Program
    {
        #region Методы для Задания 1.

        /// <summary>
        /// Метод, создающий матрицу, который потом умножает эту матрицу на число
        /// </summary>
        /// <param name="num1">Число колонок матрицы</param>
        /// <param name="num2">Число строк матрицы</param>
        /// <param name="value">Значение на которое нужно умножить матрицу</param>
        static void multiplicatioValueMatrix(int num1, int num2, int value)
        {
            //Создаем матрицу
            Random r = new Random();

            int col = num1;
            int row = num2;

            double[,] array2d = new double[row, col];

            Console.WriteLine("Матрица: ");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array2d[i, j] = r.Next(1, 10);
                    Console.Write($"{array2d[i, j],3}  ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Умножаем матрицу на число
            Console.WriteLine("Умноженная на число матрица: ");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array2d[i, j] = array2d[i, j] * value;
                    Console.Write($"{array2d[i, j],3}  ");

                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Метод создает 2 матрицы и суммирует их
        /// </summary>
        /// <param name="num1">Число колонок</param>
        /// <param name="num2">Число столбцов</param>
        static void sumMatrix(int num1, int num2)
        {
            Random r = new Random();

            int col = num1;
            int row = num2;

            double[,] array2d_2 = new double[row, col];

            double[,] array2d_3 = new double[row, col];

            //создаем первую матрицу
            Console.WriteLine("Первая матрица: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array2d_2[i, j] = r.Next(1, 10);
                    Console.Write($"{array2d_2[i, j],3}  ");

                }
                Console.WriteLine();
            }

            //Создаем вторую матрицу
            Console.WriteLine("вторая матрица: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array2d_3[i, j] = r.Next(1, 10);
                    Console.Write($"{array2d_3[i, j],3}  ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //находим сумму мтариц
            Console.WriteLine("сумма матриц: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array2d_2[i, j] = array2d_2[i, j] + array2d_3[i, j];
                    Console.Write($"{array2d_2[i, j],3}  ");

                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Создает 2 матрицы и перемножает их
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        static void multiplicatioMatrix(int num1, int num2)
        {
            Random r = new Random();

            int matrixRow = num1;
            int matrixCol = num2;

            int[][] matrix1 = new int[matrixRow][]; //создаем матрицу 1 
            int[][] matrix2 = new int[matrixRow][]; //создаем матрицу 2
            int[][] result = new int[matrixRow][];  //создаем матрицу результат

            Console.WriteLine("Матрица 1: ");       //выводим на экран какая это матрица
            Console.WriteLine();

            for (int i = 0; i < matrix1.Length; i++)            //создаем цыкл который переключает массивы по строчно
            {                                                   //т.е. пробигается по строкам
                matrix1[i] = new int[matrixCol];                //говорим, что при каждой итерации цикла к массиву i добавляется столько-то массивов
                matrix2[i] = new int[matrixCol];                //т.е. добавляет колонки
                result[i] = new int[matrixCol];                 //т.е. добавляет колонки

                for (int j = 0; j < matrix1[i].Length; j++)     //указываем что при каждой итерации цикла
                {                                               //заполняем массив массивов рандомным числом по индексу i и j
                    matrix1[i][j] = r.Next(1, 5);               //и каждый раз выводим число которое присвоили
                    matrix2[i][j] = r.Next(1, 5);
                    Console.Write($"{matrix1[i][j]} ");         //выводим первую матрицу на экран
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Матрица 2: ");

            foreach (var item in matrix2)                       //создаем список перебора
            {
                Console.WriteLine();
                foreach (var el in item)
                {
                    Console.Write($"{el} ");                    //выводим вторую матрицу
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Результат умножения: ");

            //подсчет матриц
            for (int i = 0; i < matrix1.Length; i++)
            {
                for (int j = 0; j < matrix2[i].Length; j++)
                {
                    for (int l = 0; l < matrix2.Length; l++)
                    {
                        result[i][j] += matrix1[i][l] * matrix2[l][j];
                    }
                }
            }

            foreach (var item in result)                       //создаем список перебора
            {
                Console.WriteLine();
                foreach (var el in item)
                {
                    Console.Write($"{el} ");                    //выводим вторую матрицу
                }
            }

        }



        #endregion
        #region Методы для Задания 2.
        /// <summary>
        /// Метод, который будет отбирать минимальное слово из текста
        /// </summary>
        /// <param name="txt">Текс из которого нужно отобрать слово</param>
        /// <returns></returns>
        static void giveMinWords(string txt)
        {
            string[] words = txt.Split(' ', ',', '.');           //массив который хранит в себе слова разделенные " ", ",", ".".
            string word = words[0];                 //создаем переменую слово которая будет ровна первому элементу массива слова
            int min = 100;

            for (int i = 0; i < words.Length; i++)  
            {
                if(words[i].Length < min)
                {
                    min = words[i].Length;
                    word = words[i];
                }
                
            }

            Console.WriteLine($"Самое маленькое слово: {word}");
        }

        static void giveMaxWords(string txt)
        {
            string[] words = txt.Split(' ', ',', '.');
            string word = words[0];                 
            int min = 0;

            List<string> maxWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= min)
                {
                    min = words[i].Length;

                    maxWords.Add(words[i]);
                }
                    
            }

            foreach(string el in maxWords)
            {
                Console.Write($"{el}, ");
            }

        }
        #endregion
        #region Методы для Задания 3.

        /// <summary>
        /// Метод убирает из строки все дубли
        /// </summary>
        /// <param name="text"></param>
        static void normaString1(string text)
        {
            string str = text.ToLower(); // строка для преобразования
            var list = new List<char>();                 // создаем список

            for (int i = 0; i < str.Length; i++)         //запалняем список эллементами строки
            {
                list.Add(str[i]);
            }

            var newlist = new List<char>(list.Distinct()); // Убераем дубли из списка

            var arr = new char[newlist.Count];             //Создаем массив который будет хранить значения из списка

            for (int i = 0; i < arr.Length; i++)           //Заполняем массив значениями из списка
            {
                arr[i] = newlist[i];
            }

            string newstr = new string(arr);               //Преобразуем массив char в строку

            Console.WriteLine($"Старая строка: {str}");                        //выводим страую строку
            Console.WriteLine($"Новая строка: {newstr}");                      //выводим новую строку
        }

        static void normaString2(string text)
        {
            string str = text.ToLower();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    Console.Write(str[i]);
                }
            }

            Console.WriteLine(str[str.Length - 1]);
        }

        #endregion
        #region Методы для Задания 4.

        /// <summary>
        /// Выявляет является ли прогрессия арифметической
        /// </summary>
        /// <param name="arrInt1"></param>
        static void arithmeticProgression(int[] arrInt1) 
        {

            for (int i = 0; i < arrInt1.Length; i++)
            {
                int d1 = arrInt1[i + 1] - arrInt1[i];
                int d2 = arrInt1[i + 2] - arrInt1[i + 1];

                if (i == arrInt1.Length - 3)
                {
                    break;
                }

                if (d1 == d2 && i == arrInt1.Length - 4)
                {
                    Console.WriteLine("Прогрессия является арифметической");
                    break;
                }
                else if (d1 != d2)
                {
                    Console.WriteLine("Прогрессия не является арифметической");
                    break;
                }
            }
        }

        static void geometicProgression(int[] arrInt1)
        {

            for (int i = 0; i < arrInt1.Length; i++)
            {
                int d1 = arrInt1[i + 1] / arrInt1[i];
                int d2 = arrInt1[i + 2] / (arrInt1[i] * 2);

                if (i == arrInt1.Length - 3)
                {
                    break;
                }

                if (d1 == d2 && i == arrInt1.Length - 4)
                {
                    Console.WriteLine("Прогрессия является геометрической");
                    break;
                }
                else if (d1 != d2)
                {
                    Console.WriteLine("Прогрессия не является геометрической");
                    break;
                }
            }
        }

        #endregion
        #region Методы для Задания 5.

        /// <summary>
        /// Метод вычисляет функцию Аккермана
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static int AccMethod(int n, int m)
        {
            if (n == 0)
            {
                return m + 1;
            }
            else if (m == 0)
            {
                return AccMethod(n - 1, 1);
            }
            else
            {
                return AccMethod(n - 1, AccMethod(n, m - 1));
            }
        }

        #endregion

        static void Main(string[] args)
        {
            #region Задание 1
            //Задание 1.1 Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число

            //Console.Write("Введите число колонок матрицы: ");
            //int col = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\nВведите число строк матрицы: ");
            //int row = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\nВведите значение на которое нужно умножить: ");
            //int Value = Convert.ToInt32(Console.ReadLine());

            //multiplicatioValueMatrix(col, row, Value);

            multiplicatioValueMatrix(3, 7, 2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Задание 1.2 Создать метод, который будет суммировать матрицы
            //Console.Write("Введите число колонок матрицы: ");
            //int col = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\nВведите число строк матрицы: ");
            //int row = Convert.ToInt32(Console.ReadLine());

            //sumMatrix(col, row);

            sumMatrix(4, 3);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Задание 3.3 Создать метод, который будет принемать две матрицы и умнажать их

            //for (; ; )
            //{

            //    Console.Write("Введите число колонок матрицы: ");
            //    int col = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("\nВведите число строк матрицы: ");
            //    int row = Convert.ToInt32(Console.ReadLine());

            //    if (row < col)
            //    {
            //        Console.WriteLine("Количество строк не может быть больше количества колонок, попробуйте еще раз");
            //        continue;
            //    }
            //    else 
            //    {
            //        multiplicatioMatrix(col, row);
            //        break;
            //    }


            //}
            multiplicatioMatrix(3, 4);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            #endregion

            Console.WriteLine();

            #region Задание 2
            // Создать метод и вернуть слово содержащие минимальное количество символов
            Console.WriteLine("Введите текст: ");
            //string text = Console.ReadLine();

            giveMinWords("aaaaaa,bbbb,cccccc,dd");

            //Вернуть слова содержащие максимальное количество символов

            giveMaxWords("aaaaaa,bbbb,cccccc,dd,bbbbbb");

            #endregion

            Console.WriteLine();

            #region Задание 3
            //Убрать все кратные символы из текста "ххххххххооооооррроооошшшиииййй день" => "хороший день"
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();
            //normaString(text);

            normaString1("хххххоооооорррррррооооооошшшшиииииийййййй ддень");

            normaString2("хххххоооооорррррррооооооошшшшиииииийййййй ддень");


            #endregion

            Console.WriteLine();

            #region Задание 4

            // Выявить является ли прогрессия арифметической, и выявить является ли прогрессия геометрической

            //Арифметические прогрессии
            int[] arrProg1 = { 1, 3, 5, 7, 9, 11, 13 };
            foreach (int el in arrProg1)
                Console.Write($"{el} ");
            Console.Write(" - ");
            arithmeticProgression(arrProg1);

            int[] arrProg2 = { 1, 3, 5, 4, 9, 11, 13 };
            foreach (int el in arrProg2)
                Console.Write($"{el} ");
            Console.Write(" - ");
            arithmeticProgression(arrProg2);

            int[] geoProg1 = { 2, 4, 8, 16, 32, 64, 128 };
            foreach (int el in geoProg1)
                Console.Write($"{el} ");
            Console.Write(" - ");
            geometicProgression(geoProg1);


            int[] geoProg2 = { 2, 4, 8, 25, 32, 64, 128 };
            foreach (int el in geoProg2)
                 Console.Write($"{el} ");
            Console.Write(" - ");
            geometicProgression(geoProg2);


            #endregion

            Console.WriteLine();

            #region Задание 5

            Console.WriteLine(AccMethod(0,0));
            Console.WriteLine(AccMethod(1,0));
            Console.WriteLine(AccMethod(0,1));
            Console.WriteLine(AccMethod(1,2));

            #endregion





        }
    }
    }


