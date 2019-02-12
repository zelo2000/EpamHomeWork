using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task3 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Divide the numbers.
            logger.Write("Input first number: ");
            double a = Convert.ToDouble(logger.Read());
            logger.Write("Input second number: ");
            double b = Convert.ToDouble(logger.Read());
            logger.Write("Div: " + (a / b) + "\n");
        }
    }
}
