using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ForLoop
{
    public class Task3 : IRunnable
    {
        public void Run()
        {
            //Sun of n numbers
            Console.Write("Input n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (var i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine("\nThe sum is: " + sum);
        }
    }
}
