using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.DataTypes
{
    public class Task4 : IRunnable
    {
        public void Run()
        {
            //Calculation with an arithmetic sign.
            Console.Write("Input first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input sign: ");
            char sign = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            switch (sign)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                    break;
                case '*':
                case 'x':
                    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("Wrong sign");
                    break;
            }
        }
    }
}
