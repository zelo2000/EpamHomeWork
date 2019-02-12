using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Arrays
{
    public class Task5 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Dublicate array
            logger.Write("Input amount: ");
            int number = Convert.ToInt32(logger.Read());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                logger.Write(string.Format("Element {0}: ", i));
                array[i] = Convert.ToInt32(logger.Read());
            }

            int dublicate = 0;
            for (int i = 0; i < number; i++)
            {
                for (int j = i + 1; j < number; j++)
                {
                    if (array[i] == array[j])
                    {
                        dublicate++;
                    }
                }
            }
            logger.Write("Dublicate element: " + dublicate + "\n");
        }
    }
}
