using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ForLoop
{
    public class Task1 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Print first ten numbers
            for (var i = 1; i <= 10; i++)
            {
                logger.Write(i + " ");
            }
            logger.Write("\n");
        }
    }
}
