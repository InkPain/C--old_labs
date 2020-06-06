using System;

namespace InkPain.DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 100                              //тут не будет никахи ошибок
            //int a = b

            //int i = 10
            //byte j = i                                //тут будут ошибки так как инт нельзя переводить в байт

            //double d = a                              //никаих ошибок инт переводится в дабл

            //ing g = d                                 //но в этом случаи будет ошибка так как дабл не переводится в инт

            int i = 330;
            byte j = (byte)i;
            Console.WriteLine($"j = {j}");


            string inputString = "2029";
            int intVariable = int.Parse(inputString); // int.Parse double.Parse byte.Parse ulong.Parse
            Console.WriteLine(intVariable);

            //Convert.To...
            string inputString2 = "2029";
            int intVariable2 = Convert.ToInt32(inputString2);
            Console.WriteLine(intVariable2);







        }
    }
}
