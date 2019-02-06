using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ForLoop
{
    public class Task4 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Sum and avarage of ten numbers
            int sum = 0;
            for (var i = 0; i < 10; i++)
            {
                loger.Write(string.Format("The {0} number is: ", i + 1));
                int number = Convert.ToInt32(loger.Read());
                sum += number;
            }
            loger.Write("\nThe sum is: " + sum + "\n");
            loger.Write("The average is: " + sum / 10.0 + "\n");
        }
    }
}
