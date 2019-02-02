using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task6 : IRunnable
    {
        public void Run()
        {
            //Multiplication of three numbers
            Console.Write("Input first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input third number: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}*{1}*{2} = {3}", a, b, c, (a * b * c));
        }
    }
}
