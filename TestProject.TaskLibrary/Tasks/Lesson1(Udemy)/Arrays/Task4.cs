using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Arrays
{
    public class Task4 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Copy array
            logger.Write("Input amount: ");
            int number = Convert.ToInt32(logger.Read());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                logger.Write(string.Format("Element {0}: ", i));
                array[i] = Convert.ToInt32(logger.Read());
            }

            logger.Write("This array: \n");
            for (int i = 0; i < number; i++)
            {
                logger.Write(array[i] + " ");
            }

            int[] otherArray = new int[number];
            otherArray = array;
            logger.Write("\nOther array: \n");
            for (int i = 0; i < number; i++)
            {
                logger.Write(otherArray[i] + " ");
            }
            logger.Write("\n");
        }
    }
}
