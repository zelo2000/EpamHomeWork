using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public class Task1 : IRunnable
    {
        const int temp = 100000;

        private void CheckSort(ISortAlgorithm function)
        {
            int[] array = new int[temp];

            for (int i = temp; i > 0; i--)
            {
                array[temp - i] = i;
            }
            function.Sort(array);
        }

        public void Run(ILog logger)
        {
            var watch = new Stopwatch();

            double time = 0;
            for (int i = 0; i < 100; i++)
            {
                watch.Reset();
                watch.Start();
                CheckSort(new BubbleSort());
                watch.Start();
                time += watch.ElapsedMilliseconds;
            }
            logger.Write("Bubble sort time:\n" + time / 100.0 + "\n");

            time = 0;
            for (int i = 0; i < 100; i++)
            {
                watch.Reset();
                watch.Start();
                CheckSort(new OptimizedBubbleSort());
                watch.Start();
                time += watch.ElapsedMilliseconds;
            }
            logger.Write("Optimized bubble sort time:\n" + time / 100.0 + "\n");
        }
    }
}
