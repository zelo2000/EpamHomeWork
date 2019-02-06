using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task5 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Swap numbers
            loger.Write("Input first number: ");
            double a = Convert.ToDouble(loger.Read());
            loger.Write("Input second number: ");
            double b = Convert.ToDouble(loger.Read());
            double c = b;
            b = a;
            a = c;
            loger.Write("First number: " + a + "\n");
            loger.Write("Second number: " + b + "\n");
        }
    }
}
