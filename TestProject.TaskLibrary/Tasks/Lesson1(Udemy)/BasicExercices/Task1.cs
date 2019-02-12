﻿using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.BasicExercices
{
    public class Task1 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Output hello world
            logger.Write("Hello:\nOleksandr Zelinskyi!\n");
        }
    }
}
