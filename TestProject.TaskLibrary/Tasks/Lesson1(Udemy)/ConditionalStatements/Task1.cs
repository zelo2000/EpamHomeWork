using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            //Are two numbers equal?
            Console.Write("Input first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Number are equal");
            }
            else
            {
                Console.WriteLine("Number are not equal");
            }
        }
    }
}
