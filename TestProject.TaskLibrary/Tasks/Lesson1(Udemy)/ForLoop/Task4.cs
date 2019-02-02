using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ForLoop
{
    public class Task4 : IRunnable
    {
        public void Run()
        {
            //Sum and avarage of ten numbers
            int sum = 0;
            for (var i = 0; i < 10; i++)
            {
                Console.Write("The {0} number is: ", i + 1);
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("\nThe sum is: " + sum);
            Console.WriteLine("\nThe average is: " + sum / 10.0);
        }
    }
}
