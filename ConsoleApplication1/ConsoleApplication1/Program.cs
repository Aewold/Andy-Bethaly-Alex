using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int64> fibNumbers = new List<Int64>();
            //List<Int64> fibNumbersEven = new List<Int64>();
            Int64 num1 = 0;
            Int64 num2 = 1;

            fibNumbers.Add(1); // Adds first "1" before calcs
            for (int i = 0; i < 50; i++)
            {
                Int64 resultNum = num1 + num2;
                fibNumbers.Add(resultNum);
                num1 = num2;
                num2 = resultNum;
                //WriteLine(resultNum);
            }

            WriteLine("Start Output:");
            object fibNumbersEven = fibNumbers.Where(n => n % 2 == 0);

            for (int i = 0; i < fibNumbers.Count; i++)
            {
                WriteLine(fibNumbersEven);
            }

            WriteLine("Please press Enter.");
            ReadLine();
        }
    }
}
