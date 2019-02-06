using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ForLoop
{
    public class Task3 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Sun of n numbers
            loger.Write("Input n: ");
            int n = Convert.ToInt32(loger.Read());
            int sum = 0;
            for (var i = 1; i <= n; i++)
            {
                loger.Write(i + " ");
                sum += i;
            }
            loger.Write("\nThe sum is: " + sum + "\n");
        }
    }
}
