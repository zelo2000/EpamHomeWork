using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Arrays
{
    public class Task4 : IRunnable
    {
        public void Run()
        {
            //Copy array
            Console.Write("Input amount: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Element {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("This array: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write(array[i] + " ");
            }

            int[] otherArray = new int[number];
            otherArray = array;
            Console.WriteLine("\nOther array: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write(otherArray[i] + " ");
            }
        }
    }
}
