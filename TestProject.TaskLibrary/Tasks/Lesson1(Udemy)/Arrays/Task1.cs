using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Arrays
{
    public class Task1 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Input output array
            logger.Write("Input amount: ");
            int number = Convert.ToInt32(logger.Read());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                logger.Write(string.Format("Element {0}: ", i));
                array[i] = Convert.ToInt32(logger.Read());
            }

            foreach (var num in array)
            {
                logger.Write(num + " ");
            }

            logger.Write("\n");
        }
    }
}
