using System;
using System.Threading;

namespace InkPain.Planner.Consol
{
    class Program
    {

        static void Main(string[] args)
        {
            //Приветствие
            Console.WriteLine("Привет, это приложение что-то вроде ежедневника для хранения прокси socks5");

            for (; ; )
            {
                Console.WriteLine("Для вывода инструкции введите planner -i, для начала работы с приложением введите planner -s,");
                Console.WriteLine("для завершения работы с приложением введите planner -q,");
                Console.WriteLine();
                Console.WriteLine();

                string answer = "planner -s";//Console.ReadLine();

                if (answer == "planner -i") 
                {
                    Planner.Instruction();
                    continue;
                }

                else if (answer == "planner -s")
                {
                    Planner.Start();
                    
                    break;
                }

                else if (answer == "planner -q")
                {
                    Console.WriteLine("Программа будет закрыта. Пока пока");
                    Thread.Sleep(3000);
                    break;
                }

                else
                {
                    Console.WriteLine("Вы ввели не известное значение попробуйте еще раз");
                    continue;
                }
            }

        }
    }
}
