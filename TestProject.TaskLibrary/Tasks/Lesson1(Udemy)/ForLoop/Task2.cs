using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ForLoop
{
    public class Task2 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Print sum of first ten number
            int sum = 0;
            for (var i = 1; i <= 10; i++)
            {
                loger.Write(i + " ");
                sum += i;
            }
            loger.Write("\nThe sum is: " + sum + "\n");
        }
    }
}