using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task6 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Multiplication of three numbers
            logger.Write("Input first number: ");
            double a = Convert.ToDouble(logger.Read());
            logger.Write("Input second number: ");
            double b = Convert.ToDouble(logger.Read());
            logger.Write("Input third number: ");
            double c = Convert.ToDouble(logger.Read());
            logger.Write(string.Format("{0}*{1}*{2} = {3}\n", a, b, c, (a * b * c)));
        }
    }
}
