using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task3 : IRunnable
    {
        public void Run()
        {
            //Divide the numbers.
            Console.Write("Input first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Div: " + (a / b));
        }
    }
}
