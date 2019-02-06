using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.DataTypes
{
    public class Task4 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Calculation with an arithmetic sign.
            loger.Write("Input first number: ");
            double a = Convert.ToDouble(loger.Read());
            loger.Write("Input sign: ");
            char sign = Convert.ToChar(loger.Read());
            loger.Write("Input second number: ");
            double b = Convert.ToDouble(loger.Read());
            switch (sign)
            {
                case '+':
                    loger.Write(string.Format("{0} + {1} = {2}\n", a, b, a + b));
                    break;
                case '-':
                    loger.Write(string.Format("{0} - {1} = {2}\n", a, b, a - b));
                    break;
                case '*':
                case 'x':
                    loger.Write(string.Format("{0} * {1} = {2}\n", a, b, a * b));
                    break;
                case '/':
                    loger.Write(string.Format("{0} / {1} = {2}\n", a, b, a / b));
                    break;
                default:
                    loger.Write("Wrong sign\n");
                    break;
            }
        }
    }
}
