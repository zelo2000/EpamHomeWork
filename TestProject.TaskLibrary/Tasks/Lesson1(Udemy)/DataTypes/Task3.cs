using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.DataTypes
{
    public class Task3 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Password checker
            loger.Write("Input id: ");
            string id = loger.Read();
            loger.Write("Input password: ");
            string password = loger.Read();

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
                    loger.Write("Access denied\n");
                    loger.Write("Input id: ");
                    id = loger.Read();
                    loger.Write("Input password: ");
                    password = loger.Read();
                }
            }

            if (checker)
            {
                loger.Write("Access allow\n");
            }
            else
            {
                loger.Write("Try later\n");
            }
        }
    }
}
