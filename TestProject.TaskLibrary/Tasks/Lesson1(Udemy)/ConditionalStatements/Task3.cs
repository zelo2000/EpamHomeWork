using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task3 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Is number positive
            loger.Write("Input number: ");
            int a = Convert.ToInt32(loger.Read());

            if (a >= 0)
            {
                loger.Write("Number is positive\n");
            }
            else
            {
                loger.Write("Number is negative\n");
            }
        }
    }
}
