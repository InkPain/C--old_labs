using System;

namespace TestTRI
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
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
                        result[i][j] += matrix1[i][l] * matrix2[l][j] ; 
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
    

