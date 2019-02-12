using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task2 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Add the numbers
            logger.Write("Input first number: ");
            double a = Convert.ToDouble(logger.Read());
            logger.Write("Input second number: ");
            double b = Convert.ToDouble(logger.Read());
            logger.Write("Add: " + (a + b) + "\n");
        }
    }
}