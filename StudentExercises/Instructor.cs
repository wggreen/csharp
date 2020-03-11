using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor : NSSPerson
    {
        public string Speciality { get; set; }

        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }

    }
}