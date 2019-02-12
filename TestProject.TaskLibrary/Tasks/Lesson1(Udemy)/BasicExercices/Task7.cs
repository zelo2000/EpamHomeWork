using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task7 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Arithmetic operations with three numbers
            logger.Write("Input first number: ");
            double a = Convert.ToDouble(logger.Read());
            logger.Write("Input second number: ");
            double b = Convert.ToDouble(logger.Read());
            logger.Write(string.Format("{0} + {1} = {2}\n", a, b, (a + b)));
            logger.Write(string.Format("{0} - {1} = {2}\n", a, b, (a - b)));
            logger.Write(string.Format("{0} * {1} = {2}\n", a, b, (a * b)));
            logger.Write(string.Format("{0} / {1} = {2}\n", a, b, (a / b)));
            logger.Write(string.Format("{0} mod {1} = {2}\n", a, b, (a % b)));
        }
    }
}
