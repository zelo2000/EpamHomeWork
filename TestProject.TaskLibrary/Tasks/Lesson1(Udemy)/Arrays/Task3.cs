using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Arrays
{
    public class Task3 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Sum array element
            logger.Write("Input amount: ");
            int number = Convert.ToInt32(logger.Read());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                logger.Write(string.Format("Element {0}: ", i));
                array[i] = Convert.ToInt32(logger.Read());
            }

            logger.Write("Sum: ");
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += array[i];
            }
            logger.Write(sum + "\n");
        }
    }
}
