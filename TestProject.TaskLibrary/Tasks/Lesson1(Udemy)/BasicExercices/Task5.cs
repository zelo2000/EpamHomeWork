using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task5 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Swap numbers
            logger.Write("Input first number: ");
            double a = Convert.ToDouble(logger.Read());
            logger.Write("Input second number: ");
            double b = Convert.ToDouble(logger.Read());
            double c = b;
            b = a;
            a = c;
            logger.Write("First number: " + a + "\n");
            logger.Write("Second number: " + b + "\n");
        }
    }
}
