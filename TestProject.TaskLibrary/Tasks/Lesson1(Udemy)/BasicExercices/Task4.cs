using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task4 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Arithmetic operations.
            logger.Write("Random result: \n");
            logger.Write((-1 + 4 * 6) + "\n");
            logger.Write(((35 + 5) % 7) + "\n");
            logger.Write((14 + -4 * 6 / 11) + "\n");
            logger.Write((2 + 15 / 6 * 1 - 7 % 2) + "\n");
        }
    }
}
