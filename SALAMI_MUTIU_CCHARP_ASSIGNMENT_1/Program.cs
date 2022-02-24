using System;
using System.IO;  

namespace SALAMI_MUTIU_CCHARP_ASSIGNMENT_1
{
    class INT_DOUBLE_STRING_CONC
    {
        static void Main(string[] args)
        {

            int i = 4;

            double d = 4.0;

            string s = "Polyilaro";

            int integer; double doub; string str;

            Console.Write("Enter Integer Number: ");

            integer = int.Parse(Console.ReadLine());

            Console.Write("Enter double number: ");

            doub = double.Parse(Console.ReadLine());

            Console.Write("enter a string words: ");

            str = Console.ReadLine();

            Console.WriteLine(i + integer);

            Console.WriteLine(Math.Round(d + doub, 1));

            Console.WriteLine(s+ " " +str);

            Console.ReadLine();
            
             
              }
    }
}
