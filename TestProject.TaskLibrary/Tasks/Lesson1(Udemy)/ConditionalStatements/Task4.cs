using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task4 : IRunnable
    {
        public void Run()
        {
            //Is year leap?
            Console.Write("Input year: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (((a % 4 == 0) && (a % 100 != 0)) || (a % 400 == 0))
            {
                Console.WriteLine("Is a leap lear");
            }
            else
            {
                Console.WriteLine("Is not a leap lear");
            }
        }
    }
}
