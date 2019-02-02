using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ForLoop
{
    public class Task5 : IRunnable
    {
        public void Run()
        {
            //Cude of ten numbers
            Console.Write("Input n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}^3 = {1}", i, i * i * i);
            }
        }
    }
}
