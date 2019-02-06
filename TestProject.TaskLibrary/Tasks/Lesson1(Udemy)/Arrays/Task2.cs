using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Arrays
{
    public class Task2 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Revers array
            loger.Write("Input amount: ");
            int number = Convert.ToInt32(loger.Read());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                loger.Write(string.Format("Element {0}: ", i));
                array[i] = Convert.ToInt32(loger.Read());
            }

            loger.Write("Normal order: \n");
            for (int i = 0; i < number; i++)
            {
                loger.Write(array[i] + " ");
            }

            loger.Write("\nRevers order: \n");
            for (int i = number - 1; i >= 0; i--)
            {
                loger.Write(array[i] + " ");
            }
            loger.Write("\n");
        }
    }
}