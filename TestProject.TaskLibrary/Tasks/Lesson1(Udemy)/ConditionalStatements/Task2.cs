using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task2 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Is number even?
            loger.Write("Input number: ");
            int a = Convert.ToInt32(loger.Read());

            if (a % 2 == 0)
            {
                loger.Write("Number is even\n");
            }
            else
            {
                loger.Write("Number is odd\n");
            }
        }
    }
}