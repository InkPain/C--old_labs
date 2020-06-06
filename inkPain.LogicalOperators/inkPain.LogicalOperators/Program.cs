using System;

namespace inkPain.LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int x = rnd.Next(3); // создаем х с рандомным значением до 3ех
            Console.WriteLine($"Значение Х: {x}");

            if (x < 2) // дословно переводится как если
            {
                Console.WriteLine("X = 0 или 1");
            }

            if (x == 1)
            {
                Console.WriteLine("X = 1");
            }
            else  //говорим что делаем если условие иф не выполнено
            {
                Console.WriteLine("X != 1");
            }

            if (x <1 ) //если
            {
                Console.WriteLine("X < 1");
            }
            else if (x > 1) //в противном случаи если
            {
                Console.WriteLine("X > 1");
            }
            else //в противном случае
            {
                Console.WriteLine("X = 1");
            }


            //Написать программу, которая должна генерировать 2 случайных числа
            //из диапозона от -10 до 10 после чего выводить:
            //максимальное из чисел
            //минимальное из чисел
            //добавить в прогу определение чисел
            //и вывод соответствующего сообщения на экран  

            Random rand =   new Random();

            int maxValue, minValue;
            int firstNumber = rand.Next(-10, 11); //Выдвет число от -10 до 10
            int secondNumber = rand.Next(-10, 11); //Выдвет число от -10 до 10

            if (firstNumber > secondNumber)
            {
                maxValue = firstNumber;
                minValue = secondNumber;
            }
            else
            {
                maxValue = secondNumber;
                minValue = firstNumber;
            }
            if (firstNumber == secondNumber)
            {
                Console.WriteLine("Числа ровны");
            }
            Console.WriteLine($"Максимальное число: {maxValue}");
            Console.WriteLine($"Максимальное число: {minValue}");

            //Написать приложение, которое по введеному номеру недели
            //выдает название этого дня или сообщит, что введеное число не корректно

            Console.Write("Введите номер дня: ");
            int dayIndex = int.Parse(Console.ReadLine());

            if (dayIndex == 1)
            {
                Console.WriteLine("Понедельник");
            }
            else if (dayIndex == 2)
            {
                Console.WriteLine("Вторник");
            }
            else if (dayIndex == 3)
            {
                Console.WriteLine("Среда");
            }
            else if (dayIndex == 4)
            {
                Console.WriteLine("Четверг");
            }
            else if (dayIndex == 5)
            {
                Console.WriteLine("Пятница");
            }
            else if (dayIndex == 6)
            {
                Console.WriteLine("Суббота");
            }
            else if (dayIndex == 7)
            {
                Console.WriteLine("Воскресенье");
            }
            else
            {
                Console.WriteLine("Ты что дурак?");
            }

        }
    }
}
