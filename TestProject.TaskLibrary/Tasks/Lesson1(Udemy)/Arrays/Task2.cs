using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Arrays
{
    public class Task2 : IRunnable
    {
        public void Run()
        {
            //Revers array
            Console.Write("Input amount: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Element {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Normal order: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nRevers order: ");
            for (int i = number - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}