using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ForLoop
{
    public class Task5 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Cude of ten numbers
            logger.Write("Input n: ");
            int n = Convert.ToInt32(logger.Read());
            for (var i = 1; i <= n; i++)
            {
                logger.Write(string.Format("{0}^3 = {1}\n", i, i * i * i));
            }
        }
    }
}
