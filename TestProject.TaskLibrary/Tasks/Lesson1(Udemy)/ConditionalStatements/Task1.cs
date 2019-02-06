using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task1 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Are two numbers equal?
            loger.Write("Input first number: ");
            int a = Convert.ToInt32(loger.Read());
            loger.Write("Input second number: ");
            int b = Convert.ToInt32(loger.Read());

            if (a == b)
            {
                loger.Write("Number are equal\n");
            }
            else
            {
                loger.Write("Number are not equal\n");
            }
        }
    }
}
