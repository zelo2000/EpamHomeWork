using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task5 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Are you can vote?
            loger.Write("How old are you? ");
            int a = Convert.ToInt32(loger.Read());
            if (a >= 18)
            {
                loger.Write("Congratulation! You are eligible for casting your vote\n");
            }
            else
            {
                loger.Write("Sory. You are not eligible for casting your vote\n");
            }
        }
    }
}
