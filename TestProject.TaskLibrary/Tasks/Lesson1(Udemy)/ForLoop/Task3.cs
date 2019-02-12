using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ForLoop
{
    public class Task3 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Sun of n numbers
            logger.Write("Input n: ");
            int n = Convert.ToInt32(logger.Read());
            int sum = 0;
            for (var i = 1; i <= n; i++)
            {
                logger.Write(i + " ");
                sum += i;
            }
            logger.Write("\nThe sum is: " + sum + "\n");
        }
    }
}
