using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task5 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Are you can vote?
            logger.Write("How old are you? ");
            int a = Convert.ToInt32(logger.Read());
            if (a >= 18)
            {
                logger.Write("Congratulation! You are eligible for casting your vote\n");
            }
            else
            {
                logger.Write("Sory. You are not eligible for casting your vote\n");
            }
        }
    }
}
