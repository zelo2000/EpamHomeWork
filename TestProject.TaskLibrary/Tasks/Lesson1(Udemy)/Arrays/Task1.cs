using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Arrays
{
    public class Task1 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Input output array
            loger.Write("Input amount: ");
            int number = Convert.ToInt32(loger.Read());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                loger.Write(string.Format("Element {0}: ", i));
                array[i] = Convert.ToInt32(loger.Read());
            }

            foreach (var num in array)
            {
                loger.Write(num + " ");
            }

            loger.Write("\n");
        }
    }
}
