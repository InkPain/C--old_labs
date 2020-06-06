using System;

namespace InkPain.GetDataApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomize = new Random(); //Создаем переменную randomize и делаем чтоб значение в нее подбиралось рандомно

            Console.WriteLine($"Int.MaxValue = {int.MaxValue}"); // Получаем максимальное значение инт
            Console.WriteLine($"Int.MinValue = {int.MinValue}"); // Получаем минимально значение инт
                                                                 //Работает со всеми числовыми типами

            //Получаем рандомное число
            int randomIntResult = randomize.Next(); //Создаем переменную с рандомным значением
            Console.WriteLine(randomIntResult);

            //Получаем рандомное число до указанного нами числа
            randomIntResult = randomize.Next(100); //Указываем что наше число может быть максимум 100 не включая 100
            Console.WriteLine(randomIntResult);

            //Получаем рандомное число от и до указаного нами числа
            randomIntResult = randomize.Next(10, 100);
            Console.WriteLine(randomIntResult);

            //Получаем рандомное число с точкой
            double randomDoubleResult = randomize.NextDouble(); //стандартный диапазон от 0 до 1.0 не включая 1
                                                                // чтобы получить 1, 2, 10, 100 и тд надо домнажаь
                                                                //например чтб получить один десяток целого умнажаем на 10, 2 на 100 и тд

        }
    }
}
