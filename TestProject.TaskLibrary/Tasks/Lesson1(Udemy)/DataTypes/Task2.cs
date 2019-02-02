using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.DataTypes
{
    public class Task2 : IRunnable
    {
        public void Run()
        {
            //Create rectengular
            Console.Write("Input number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            int temp = amount;
            for (var i = 0; i < amount; i++)
            {
                for (var j = 0; j < temp; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
                temp--;
            }
        }
    }
}