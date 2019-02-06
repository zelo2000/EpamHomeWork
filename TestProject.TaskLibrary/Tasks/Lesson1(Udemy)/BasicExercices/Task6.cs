using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task6 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Multiplication of three numbers
            loger.Write("Input first number: ");
            double a = Convert.ToDouble(loger.Read());
            loger.Write("Input second number: ");
            double b = Convert.ToDouble(loger.Read());
            loger.Write("Input third number: ");
            double c = Convert.ToDouble(loger.Read());
            loger.Write(string.Format("{0}*{1}*{2} = {3}\n", a, b, c, (a * b * c)));
        }
    }
}
