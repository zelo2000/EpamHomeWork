using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.DataTypes
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            //Revers leters
            Console.Write("Input first leter: ");
            char leter1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second leter: ");
            char leter2 = Convert.ToChar(Console.ReadLine());
            Console.Write("Input third leter: ");
            char leter3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}", leter3, leter2, leter1);
        }
    }
}
