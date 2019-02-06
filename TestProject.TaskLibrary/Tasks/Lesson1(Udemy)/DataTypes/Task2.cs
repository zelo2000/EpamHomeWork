using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.DataTypes
{
    public class Task2 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Create rectengular
            loger.Write("Input number: ");
            int number = Convert.ToInt32(loger.Read());
            loger.Write("Input amount: ");
            int amount = Convert.ToInt32(loger.Read());

            int temp = amount;
            for (var i = 0; i < amount; i++)
            {
                for (var j = 0; j < temp; j++)
                {
                    loger.Write(number.ToString());
                }
                loger.Write("\n");
                temp--;
            }
        }
    }
}