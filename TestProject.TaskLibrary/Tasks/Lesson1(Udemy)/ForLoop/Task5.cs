using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ForLoop
{
    public class Task5 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Cude of ten numbers
            loger.Write("Input n: ");
            int n = Convert.ToInt32(loger.Read());
            for (var i = 1; i <= n; i++)
            {
                loger.Write(string.Format("{0}^3 = {1}\n", i, i * i * i));
            }
        }
    }
}
