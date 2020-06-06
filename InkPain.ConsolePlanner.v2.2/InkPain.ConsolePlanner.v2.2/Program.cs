using System;
using System.Net;
using System.Collections.Generic;

namespace InkPain.ConsolePlanner.v2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Editor plan = new Editor();

            //plan.Open();

            //plan.PrintFile();

            //plan.NewFile();

            //plan.PrintFile();

            

            for (; ; )
            {
                UserInterface plan;
                plan = new UserInterface();
                plan.StartProgram();
            }


        }
    }
}



