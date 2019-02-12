using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.DataTypes
{
    public class Task3 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Password checker
            logger.Write("Input id: ");
            string id = logger.Read();
            logger.Write("Input password: ");
            string password = logger.Read();

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
                    logger.Write("Access denied\n");
                    logger.Write("Input id: ");
                    id = logger.Read();
                    logger.Write("Input password: ");
                    password = logger.Read();
                }
            }

            if (checker)
            {
                logger.Write("Access allow\n");
            }
            else
            {
                logger.Write("Try later\n");
            }
        }
    }
}
