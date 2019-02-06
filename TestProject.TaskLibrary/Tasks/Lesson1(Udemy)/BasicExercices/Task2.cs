using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task2 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Add the numbers
            loger.Write("Input first number: ");
            double a = Convert.ToDouble(loger.Read());
            loger.Write("Input second number: ");
            double b = Convert.ToDouble(loger.Read());
            loger.Write("Add: " + (a + b) + "\n");
        }
    }
}