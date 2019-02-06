using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task4 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Arithmetic operations.
            loger.Write("Random result: \n");
            loger.Write((-1 + 4 * 6) + "\n");
            loger.Write(((35 + 5) % 7) + "\n");
            loger.Write((14 + -4 * 6 / 11) + "\n");
            loger.Write((2 + 15 / 6 * 1 - 7 % 2) + "\n");
        }
    }
}
