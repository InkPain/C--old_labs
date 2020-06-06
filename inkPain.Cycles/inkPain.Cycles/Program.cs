using System;

namespace inkPain.Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            //сгенерировать 10 раномных чисел от -8 до 9

            Random r = new Random();
            Console.ForegroundColor = ConsoleColor.Green;

            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{r.Next(0, 2)} ");
            }
            Console.ReadKey();

            //Программа в которой пользователь вводит число start
            //программа выводит число от start до start +10

            Console.Write("Введите число старт: ");
            int start1 = Convert.ToInt32(Console.ReadLine());

            for (int i = start1; i <= start1 + 10 ; i++)
            {
                Console.WriteLine($"{i}^2 = {i * i}");
            }

            //Программа в которой пользователь может ввести 2 целых числа end и start
            //программа выводит числа от start до end 

            Console.WriteLine("\nВведите start: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВведите end: ");
            int end = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i < end; i++)
            {
                Console.WriteLine($"{i}^2 = {i * i}");
            }


            //Написать программу по подсчету среднего бала
            //полученного на экзамене пользователь вводит числа, нужно найти их 
            //среднее арефмитическое
            //пользователь вводит 10 чисел

            double Value;
            double average = 0;

            for (int i = 1; i < 10; i++)
            {
                Console.Write($"Введите {i}-й результать вступительного испытания: ");
                Value = Convert.ToDouble(Console.ReadLine());
                average += Value;
            }
            Console.WriteLine($"Среднее = {average / 10}");

            //Написать игру угадайка в которой игрок должен угадать число от 1 до 100
            //за минимальное количество шагов. при этом после каждой попытки игрок должен видеть сообщение
            //Введенное число больше загаданного попробуй еще раз
            //Введенное число меньше загаданного попробуй еще раз
            // поздравляю число угаданно! Число попыток: число

            Console.WriteLine("Игра Угадайка");

            Random rend = new Random();
            int iiNumber = rend.Next(1, 101);
            int count = 0;
            int userNumber;

            for(; ; )
            {
                Console.Write("\nВведите число: ");
                count++;
                userNumber = Convert.ToInt32(Console.ReadLine());
                if(userNumber < iiNumber)
                {
                    Console.WriteLine("Введенное число меньше заданного. Попробуй еще раз");
                }
                else if(userNumber > iiNumber)
                {
                    Console.WriteLine("Введенное число больше заданного. Попробуй еще раз");
                }
                else
                {
                    Console.WriteLine($"Поздравляю число угаданно! Число попыток: {count}");
                    break;
                }
            }




























        }
    }
}
