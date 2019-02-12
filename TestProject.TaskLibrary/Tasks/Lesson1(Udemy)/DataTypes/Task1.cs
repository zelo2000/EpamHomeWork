using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.DataTypes
{
    public class Task1 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Revers leters
            logger.Write("Input first leter: ");
            char leter1 = Convert.ToChar(logger.Read());
            logger.Write("Input second leter: ");
            char leter2 = Convert.ToChar(logger.Read());
            logger.Write("Input third leter: ");
            char leter3 = Convert.ToChar(logger.Read());
            logger.Write(string.Format("{0} {1} {2}\n", leter3, leter2, leter1));
        }
    }
}
