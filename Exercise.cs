using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Fitness_tracker
{
   public class Exercise
    {
        public string NameOfExercise;
        public double CaloriesBurnedPerMin;

        public static void View_exercises(List<Exercise> exercises)     // viewing the list of available exercises
        {
            for (int i = 0; i < exercises.Count; i++)
            {
                Console.Write($"{i + 1}- Name of exercise: {exercises[i].NameOfExercise}\t\t");
                Console.WriteLine($"CaloriesBurnedPerMin: {exercises[i].CaloriesBurnedPerMin}");
            }

        }


    }
}
