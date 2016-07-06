//Program: Video_Week_08
//Description: In-video instruction example -- Handling Exception Errors
//Name: Andy E. Wold
//Date: 05 Jul 2016
//Instructor: Brother Daniel Masterson
//Course: CS 176 - Windows Desktop Design

using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assign the %APPDATA% folder to a string variable
            string appDataFolder = Environment.GetFolderPath(
Environment.SpecialFolder.ApplicationData);

            // Assign the data file path to a string variable
            string fullDataPath = Path.Combine(appDataFolder,
                    @"Lunch Order System\Example.txt");

            try
            {
                string content = File.ReadAllText(fullDataPath);
                WriteLine(content);
            }

            catch (DirectoryNotFoundException ex)
            {
                WriteLine("The folder is not found.");
                WriteLine("Please make sure that the Lunch Order System folder is located in your AppData folder.");
            }

            catch (FileNotFoundException ex)
            {
                WriteLine("The file is not found.");
                WriteLine("Please make sure that the file named Example.txt is named correctly.");
            }

            catch (Exception ex)
            {
                WriteLine("There was a problem!");
                WriteLine(ex.Message);
            }
            finally
            {
                //Code to safely shut down the app
            }
            ReadLine();
        }
    }
}
