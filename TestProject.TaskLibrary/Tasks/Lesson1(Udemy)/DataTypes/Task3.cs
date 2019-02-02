using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.DataTypes
{
    public class Task3 : IRunnable
    {
        public void Run()
        {
            //Password checker
            Console.Write("Input id: ");
            string id = Console.ReadLine();
            Console.Write("Input password: ");
            string password = Console.ReadLine();

            bool checker = false;
            for (var i = 2; i >= 0; i--)
            {
                if (id == "myid" && password == "123")
                {
                    checker = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Access denied\n");
                    Console.Write("Input id: ");
                    id = Console.ReadLine();
                    Console.Write("Input password: ");
                    password = Console.ReadLine();
                }
            }

            if (checker)
            {
                Console.WriteLine("Access allow");
            }
            else
            {
                Console.WriteLine("Try later");
            }
        }
    }
}
