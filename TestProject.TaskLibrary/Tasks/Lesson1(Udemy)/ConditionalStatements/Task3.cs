using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task3 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Is number positive
            logger.Write("Input number: ");
            int a = Convert.ToInt32(logger.Read());

            if (a >= 0)
            {
                logger.Write("Number is positive\n");
            }
            else
            {
                logger.Write("Number is negative\n");
            }
        }
    }
}
