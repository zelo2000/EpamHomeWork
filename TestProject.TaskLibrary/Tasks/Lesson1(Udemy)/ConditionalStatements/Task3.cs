using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task3 : IRunnable
    {
        public void Run()
        {
            //Is number positive
            Console.Write("Input number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }
    }
}
