using System;
using System.Threading.Tasks;
using TestProject.Common.Core.Interfaces;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of .NetLab Tasks
            var tasks = new IRunnable[]
            {
                //C# basic exercices
                new TaskLibrary.Tasks.Lesson1.BasicExercices.Task1(),
                new TaskLibrary.Tasks.Lesson1.BasicExercices.Task2(),
                new TaskLibrary.Tasks.Lesson1.BasicExercices.Task3(),
                new TaskLibrary.Tasks.Lesson1.BasicExercices.Task4(),
                new TaskLibrary.Tasks.Lesson1.BasicExercices.Task5(),
                new TaskLibrary.Tasks.Lesson1.BasicExercices.Task6(),
                new TaskLibrary.Tasks.Lesson1.BasicExercices.Task7(),
                new TaskLibrary.Tasks.Lesson1.BasicExercices.Task8(),
                //Data types exercices
                new TaskLibrary.Tasks.Lesson1.DataTypes.Task1(),
                new TaskLibrary.Tasks.Lesson1.DataTypes.Task2(),
                new TaskLibrary.Tasks.Lesson1.DataTypes.Task3(),
                new TaskLibrary.Tasks.Lesson1.DataTypes.Task4(),
                //Conditional statements exercices
                new TaskLibrary.Tasks.Lesson1.ConditionalStatements.Task1(),
                new TaskLibrary.Tasks.Lesson1.ConditionalStatements.Task2(),
                new TaskLibrary.Tasks.Lesson1.ConditionalStatements.Task3(),
                new TaskLibrary.Tasks.Lesson1.ConditionalStatements.Task4(),
                new TaskLibrary.Tasks.Lesson1.ConditionalStatements.Task5(),
                //For loop exercices
                new TaskLibrary.Tasks.Lesson1.ForLoop.Task1(),
                new TaskLibrary.Tasks.Lesson1.ForLoop.Task2(),
                new TaskLibrary.Tasks.Lesson1.ForLoop.Task3(),
                new TaskLibrary.Tasks.Lesson1.ForLoop.Task4(),
                new TaskLibrary.Tasks.Lesson1.ForLoop.Task5(),
                new TaskLibrary.Tasks.Lesson1.ForLoop.Task6(),
                //Arrays exercices
                new TaskLibrary.Tasks.Lesson1.Arrays.Task1(),
                new TaskLibrary.Tasks.Lesson1.Arrays.Task2(),
                new TaskLibrary.Tasks.Lesson1.Arrays.Task3(),
                new TaskLibrary.Tasks.Lesson1.Arrays.Task4(),
                new TaskLibrary.Tasks.Lesson1.Arrays.Task5()
            };

            foreach (var task in tasks)
            {
                task.Run();
            }
            Console.ReadLine();
        }
    }
}
