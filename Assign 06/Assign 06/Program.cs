﻿using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{
    public class Program
    {
        public static List<Int64> FindAllFib(List<Int64> fib)
        {
            List<Int64> fibNum = new List<Int64>();
            Int64 num1 = 0;
            Int64 num2 = 1;

            for (int i = 0; i < 50; i++)
            {
                if (fibNum.Count == 0)
                {
                    fibNum.Add(num2); // Adds first "1" before calcs
                }
                Int64 resultNum = num1 + num2;
                fibNum.Add(resultNum);
                num1 = num2;
                num2 = resultNum;
                //WriteLine(resultNum);
            }
            //for (int i = 0; i < fibNum.Count; i++)
            //{
            //    WriteLine(fibNum[i]);
            //}
            return fibNum;
        }
        public static List<Int64> FindEven(List<Int64> fib)
        {
            List<Int64> fibNumEven = new List<Int64>();

            var result = fib.Where(n => n % 2 == 0);

            foreach (Int64 item in result)
            {
                //WriteLine(item);
                fibNumEven.Add(item);
            }

            return fibNumEven;
        }
        public static void Main(string[] args)
        {
            List<Int64> fibNumbers = new List<Int64>();

            //Call method to determine first 50 fibNumbers
            fibNumbers = FindAllFib(fibNumbers);
            
            WriteLine("Start Output:");

            List<Int64> fibNumbersEven = new List<Int64>();

            //Call method to determine if fibNumbers are even
            fibNumbersEven = FindEven(fibNumbers);

            WriteLine("fibNumbersEven:");

            for (int i = 0; i < fibNumbersEven.Count; i++)
            {
                WriteLine(fibNumbersEven[i]);
            }

            WriteLine("Please press Enter.");
            ReadLine();
        }
    }
}
