using System;

namespace InkPain.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //MontlyReport[] report = new MontlyReport[12];

            //report[0] = new MontlyReport()
            //{
            //    month = "01",
            //    consuption = 90_000,
            //    Income = 120_000,
            //    profit = report[0].Income - report[0].consuption
            //};

            //for (int i = 0; i < report.Length; i++)
            //{
            //    Console.WriteLine(report[i]);
            //}

            //Random r = new Random();

            //MontlyReport[] report = new MontlyReport[12];

            //for (int i = 0; i < report.Length; i++)
            //{
            //    report[i].month = Convert.ToString(i + 1);
            //    report[i].Income = 10000;
            //    Convert.ToString(report[i].Income);
            //    report[i].consuption = r.Next(1, 200000);
            //    Convert.ToString(report[i].consuption);
            //    report[i].profit = report[i].Income - report[i].consuption;
            //    Convert.ToString(report[i].profit);
            //    Console.Write($"{report[i].month}       {report[i].Income}      {report[i].consuption}      {report[i].profit}");
            //    Console.WriteLine("\n");
            //}

            Worker worker1 = new Worker("кашевар", 
                                         111111,
                                         "Эпифан", 
                                         "Чурка", 
                                         new DateTime(1111, 11, 11));

            Console.WriteLine(worker1.Print());



        }
    }
}
