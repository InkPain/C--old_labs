using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Таблица расходов, доходов, прибыли");

            int[] income = new int[12];         //массив дохода, который имеет 12 элементов
            int[] consumption = new int[12];    //массив расхода который тоже имеет 12 элементов
            int[] month = new int[12];
            int[] profit = new int[12];

            // int profit = 0;

            string monthString = "Месяц";
            string incomeString = "Доход, тыс. руб.";
            string consumptionString = "Расход, тыс. руб.";
            string profitString = "Прибыль, тыс. руб.";

            Random r = new Random();
            Console.Write($"{monthString}" +
                          $"          " +
                          $"{incomeString}" +
                          $"          " +
                          $"{consumptionString}" +
                          $"         " +
                          $" {profitString}");
            for (int i = 0; i < income.Length; i++)
            {

                month[i] = 1 + i;
                income[i] = r.Next(200_000);
                consumption[i] = r.Next(200_000);
                profit[i] = income[i] - consumption[i];

                Console.Write(
                    $"\n{month[i],5}" +
                    $"{income[i].ToString("### ###"),26}" +
                    $"{consumption[i].ToString("### ###"),26}" +
                    $"{profit[i].ToString("### ###"),29}");
                Array.Sort(profit, month);
            }

            Console.WriteLine();
            Console.WriteLine("Самые худшие месяца: ");

            for (int i = 0; i < 3; i++)
            {

                Console.Write($"{month[i]}: {profit[i]} ");
            }


            Console.ReadKey();




            // * Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля

            Console.ForegroundColor = ConsoleColor.Red; // Потому что подгорает

            Console.Write("Введите количество строк : ");
            int n = int.Parse(Console.ReadLine());


            int[][] triangle = new int[n][];
            triangle[0] = new int[] { 1 };

            for (int i = 1; i < triangle.Length; i++)
            {
                triangle[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        triangle[i][j] = 1;
                    else
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }
            }

            for (int i = 0; i < triangle.Length; i++)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write("{0,-7} ", triangle[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();




            // 
            // * Задание 3.1
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            //

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            double[,] array2d = new double[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array2d[i, j] = r.Next(1, 10);
                    Console.Write($"{array2d[i, j],3}  ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите действие которое хотите сделать");
            string act = Console.ReadLine();
            Console.WriteLine("Введите значение");
            double num = Convert.ToDouble(Console.ReadLine());

            if (act == "*")
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        array2d[i, j] = array2d[i, j] * num;
                        Console.Write($"{array2d[i, j],3}  ");

                    }
                    Console.WriteLine();
                }
            }
            else if (act == "+")
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        array2d[i, j] = array2d[i, j] + num;
                        Console.Write($"{array2d[i, j],3}  ");

                    }
                    Console.WriteLine();
                }
            }
            else if (act == "-")
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        array2d[i, j] = array2d[i, j] - num;
                        Console.Write($"{array2d[i, j],3}  ");

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        array2d[i, j] = array2d[i, j] / num;

                        Console.Write($"{array2d[i, j].ToString("0.00"),3}  ");

                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();

            //
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
            //
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Введите количество строк: ");
            int row_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int col_2 = int.Parse(Console.ReadLine());

            double[,] array2d_2 = new double[row_2, col_2];

            double[,] array2d_3 = new double[row_2, col_2];
            Console.WriteLine("Первая матрица");
            for (int i = 0; i < row_2; i++)
            {
                for (int j = 0; j < col_2; j++)
                {
                    array2d_2[i, j] = r.Next(1, 10);
                    Console.Write($"{array2d_2[i, j],3}  ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("вторая матрица");
            for (int i = 0; i < row_2; i++)
            {
                for (int j = 0; j < col_2; j++)
                {
                    array2d_3[i, j] = r.Next(1, 10);
                    Console.Write($"{array2d_3[i, j],3}  ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Введите действие которое хотите сделать");
            act = Console.ReadLine();

            if (act == "*")
            {
                Console.WriteLine("произведение матрицы");
                for (int i = 0; i < row_2; i++)
                {
                    for (int j = 0; j < col_2; j++)
                    {
                        array2d_2[i, j] = array2d_2[i, j] * array2d_3[i, j];
                        Console.Write($"{array2d_2[i, j],3}  ");

                    }
                    Console.WriteLine();
                }
            }
            else if (act == "+")
            {
                Console.WriteLine("сумма матрицы");
                for (int i = 0; i < row_2; i++)
                {
                    for (int j = 0; j < col_2; j++)
                    {
                        array2d_2[i, j] = array2d_2[i, j] + array2d_3[i, j];
                        Console.Write($"{array2d_2[i, j],3}  ");

                    }
                    Console.WriteLine();
                }
            }
            else if (act == "-")
            {
                Console.WriteLine("разность матрицы");
                for (int i = 0; i < row_2; i++)
                {
                    for (int j = 0; j < col_2; j++)
                    {
                        array2d_2[i, j] = array2d_2[i, j] - array2d_3[i, j];
                        Console.Write($"{array2d_2[i, j],3}  ");

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Частное матрицы");
                for (int i = 0; i < row_2; i++)
                {
                    for (int j = 0; j < col_2; j++)
                    {
                        array2d_2[i, j] = array2d_2[i, j] / array2d_3[i, j];

                        Console.Write($"{array2d_2[i, j].ToString("0.00"),3}  ");

                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();

            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  | стобики на строки
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Введите количество строк для матриц: ");
            int matrixRow = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов для матриц: ");
            int matrixCol = int.Parse(Console.ReadLine());

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

            //подсчет матриец
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

            Console.ReadKey();
        }
    }
}
