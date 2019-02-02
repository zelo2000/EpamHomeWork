using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task5 : IRunnable
    {
        public void Run()
        {
            //Swap numbers
            Console.Write("Input first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = b;
            b = a;
            a = c;
            Console.WriteLine("First number: " + a);
            Console.WriteLine("Second number: " + b);
        }
    }
}
