using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ForLoop
{
    public class Task6 : IRunnable
    {
        public void Run()
        {
            //Multiplication table
            Console.Write("Input number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            for (var i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, (a * i));
            }
        }
    }
}
