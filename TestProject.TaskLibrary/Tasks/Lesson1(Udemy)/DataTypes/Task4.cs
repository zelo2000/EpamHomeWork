using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.DataTypes
{
    public class Task4 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Calculation with an arithmetic sign.
            logger.Write("Input first number: ");
            double a = Convert.ToDouble(logger.Read());
            logger.Write("Input sign: ");
            char sign = Convert.ToChar(logger.Read());
            logger.Write("Input second number: ");
            double b = Convert.ToDouble(logger.Read());
            switch (sign)
            {
                case '+':
                    logger.Write(string.Format("{0} + {1} = {2}\n", a, b, a + b));
                    break;
                case '-':
                    logger.Write(string.Format("{0} - {1} = {2}\n", a, b, a - b));
                    break;
                case '*':
                case 'x':
                    logger.Write(string.Format("{0} * {1} = {2}\n", a, b, a * b));
                    break;
                case '/':
                    logger.Write(string.Format("{0} / {1} = {2}\n", a, b, a / b));
                    break;
                default:
                    logger.Write("Wrong sign\n");
                    break;
            }
        }
    }
}
