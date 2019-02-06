using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Arrays
{
    public class Task4 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Copy array
            loger.Write("Input amount: ");
            int number = Convert.ToInt32(loger.Read());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                loger.Write(string.Format("Element {0}: ", i));
                array[i] = Convert.ToInt32(loger.Read());
            }

            loger.Write("This array: \n");
            for (int i = 0; i < number; i++)
            {
                loger.Write(array[i] + " ");
            }

            int[] otherArray = new int[number];
            otherArray = array;
            loger.Write("\nOther array: \n");
            for (int i = 0; i < number; i++)
            {
                loger.Write(otherArray[i] + " ");
            }
            loger.Write("\n");
        }
    }
}
