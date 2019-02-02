using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task5 : IRunnable
    {
        public void Run()
        {
            //Are you can vote?
            Console.Write("How old are you? ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote");
            }
            else
            {
                Console.WriteLine("Sory. You are not eligible for casting your vote");
            }
        }
    }
}
