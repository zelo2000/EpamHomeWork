using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.ConditionalStatements
{
    public class Task4 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Is year leap?
            loger.Write("Input year: ");
            int a = Convert.ToInt32(loger.Read());
            if (((a % 4 == 0) && (a % 100 != 0)) || (a % 400 == 0))
            {
                loger.Write("Is a leap lear\n");
            }
            else
            {
                loger.Write("Is not a leap lear\n");
            }
        }
    }
}
