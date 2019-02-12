using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task1 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Are two numbers equal?
            logger.Write("Input first number: ");
            int a = Convert.ToInt32(logger.Read());
            logger.Write("Input second number: ");
            int b = Convert.ToInt32(logger.Read());

            if (a == b)
            {
                logger.Write("Number are equal\n");
            }
            else
            {
                logger.Write("Number are not equal\n");
            }
        }
    }
}
