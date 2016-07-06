//Program: Video_Week_08
//Description: In-video instruction example
//Name: Andy E. Wold
//Date: 05 Jul 2016
//Instructor: Brother Daniel Masterson
//Course: CS 176 - Windows Desktop Design

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Video_Week_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);        // Every 2,000 milliseconds (about)

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;    // "+=", Tab defines new method

            myTimer.Start();

            WriteLine("Press Enter to remove the red event.");
            ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;

            ReadLine();
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
