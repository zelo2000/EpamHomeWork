using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task4 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Is year leap?
            logger.Write("Input year: ");
            int a = Convert.ToInt32(logger.Read());
            if (((a % 4 == 0) && (a % 100 != 0)) || (a % 400 == 0))
            {
                logger.Write("Is a leap lear\n");
            }
            else
            {
                logger.Write("Is not a leap lear\n");
            }
        }
    }
}
