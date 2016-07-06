//Program: Lab 3
//Decscription: Student Grades using Objects
//Name: Alex Moreno, Andy E. Wold, Bethaly Tenango
//Date: 20 Jun 2016
//Instructor: Bro. Daniel Masterson
//Course: CS 176 Windows Desktop Development

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    public class Program
    {
        public string CheckFileExists()
        {
            string inputFile = ReadLine();
            // Check to see if the input file exists
            while (!File.Exists(inputFile))
            {
                WriteLine("Input file does not exist.");
                Write("Please enter the file name to retrieve: ");
                inputFile = ReadLine();
            }
            

            // Get output file name from user
            Write("Please enter the file name to save: ");
            string outputFile = ReadLine();

            // Check to see if the output file exists, and create if it doesn't
            CheckOutputExist:
            if (!File.Exists(outputFile))
            {
                WriteLine("Output file does not exist.  Creating new output file.");
                File.Create(outputFile).Close();
            }
            else
            {
                WriteLine("Output file already exists.");
                Write("Please enter the new file name to save: ");
                outputFile = ReadLine();
                goto CheckOutputExist;
            }
            public string PullData() { 
            // Pull data from input file
            var reader = new StreamReader(File.OpenRead(inputFile));


            return string1;
        }

        class Student
        {
            String firstName;
            String lastName;
            List<double> grades;

        }

        class Course
        {
            List<object> Students;
            List<double> assignmentAverage;
            double overallAverage = 0;

            public void LoadStudents()
            {

            }

            public void WriteStudents()
            {

            }

            public List<double> CalculateAssignmentAverage()
            {
                List<double> result = new List<double> ();

                return result;
            }

            public void WriteAssignmentAverage()
            {

            }

            public double CalculateOverallAverage()
            {
                double result = 0.0;

                return result;
            }

            public void WriteOverallAverage()
            {

            }

        }

        public static Main(string[] args)
        {
            // Get input file name from user
            Write("Please enter the file name to retrieve: ");
            string inputFile = ReadLine();

            temp1 = new CheckFileExists();

        }
    }
}
