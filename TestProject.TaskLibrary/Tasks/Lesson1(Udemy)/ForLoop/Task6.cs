using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ForLoop
{
    public class Task6 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Multiplication table
            logger.Write("Input number: ");
            double a = Convert.ToDouble(logger.Read());
            for (var i = 1; i < 11; i++)
            {
                logger.Write(string.Format("{0} * {1} = {2}\n", a, i, (a * i)));
            }
        }
    }
}
