using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Arrays
{
    public class Task3 : IRunnable
    {
        public void Run()
        {
            //Sum array element
            Console.Write("Input amount: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Element {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Sum: ");
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
