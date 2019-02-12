using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Arrays
{
    public class Task2 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Revers array
            logger.Write("Input amount: ");
            int number = Convert.ToInt32(logger.Read());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                logger.Write(string.Format("Element {0}: ", i));
                array[i] = Convert.ToInt32(logger.Read());
            }

            logger.Write("Normal order: \n");
            for (int i = 0; i < number; i++)
            {
                logger.Write(array[i] + " ");
            }

            logger.Write("\nRevers order: \n");
            for (int i = number - 1; i >= 0; i--)
            {
                logger.Write(array[i] + " ");
            }
            logger.Write("\n");
        }
    }
}