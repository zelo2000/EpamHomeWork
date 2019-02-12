using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task2 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Is number even?
            logger.Write("Input number: ");
            int a = Convert.ToInt32(logger.Read());

            if (a % 2 == 0)
            {
                logger.Write("Number is even\n");
            }
            else
            {
                logger.Write("Number is odd\n");
            }
        }
    }
}