using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task7 : IRunnable
    {
        public void Run()
        {
            //Arithmetic operations with three numbers
            Console.Write("Input first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
            Console.WriteLine("{0} - {1} = {2}", a, b, (a - b));
            Console.WriteLine("{0} * {1} = {2}", a, b, (a * b));
            Console.WriteLine("{0} / {1} = {2}", a, b, (a / b));
            Console.WriteLine("{0} mod {1} = {2}", a, b, (a % b));
        }
    }
}
