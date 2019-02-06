using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task8 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Multiplication table 
            loger.Write("Input number: ");
            double a = Convert.ToDouble(loger.Read());
            for (var i = 1; i < 11; i++)
            {
                loger.Write(string.Format("{0} * {1} = {2}\n", a, i, (a * i)));
            }
        }
    }
}
