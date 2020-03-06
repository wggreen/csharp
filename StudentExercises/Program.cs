using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise HolidayRoad = new Exercise()
            {
                Name = "Holiday Road",
                Language = "C#"
            };
            Exercise Nutshell = new Exercise()
            {
                Name = "Nutshell",
                Language = "React"
            };
            Exercise MartinsAquarium = new Exercise()
            {
                Name = "Martin's Aquarium",
                Language = "Javascript"
            };
            Exercise DailyJournal = new Exercise()
            {
                Name = "Daily Journal",
                Language = ".NET"
            };


            Cohort Cohort1 = new Cohort()
            {
                Name = "Cohort 1"
            };

            Cohort Cohort2 = new Cohort()
            {
                Name = "Cohort 2"
            };

            Cohort Cohort3 = new Cohort()
            {
                Name = "Cohort 3"
            };


            Student Audrey = new Student()
            {
                FirstName = "Audrey",
                LastName = "Borgra",
                SlackHandle = "@Audrey",
                Cohort = "Cohort 1"
            };
            Cohort1.addStudent(Audrey);

            Student James = new Student()
            {
                FirstName = "James",
                LastName = "Nitz",
                SlackHandle = "@James",
                Cohort = "Cohort 2"
            };
            Cohort2.addStudent(James);

            Student Kevin = new Student()
            {
                FirstName = "Kevin",
                LastName = "Penny",
                SlackHandle = "@Kevin",
                Cohort = "Cohort 3"
            };
            Cohort3.addStudent(Kevin);

            Student Willy = new Student()
            {
                FirstName = "Willy",
                LastName = "Metcalf",
                SlackHandle = "@Willy",
                Cohort = "Cohort 4"
            };
            Cohort3.addStudent(Willy);


            Instructor Instructor1 = new Instructor()
            {
                FirstName = "Albert",
                LastName = "Einstein",
                SlackHandle = "@Instructor1",
                Cohort = "Cohort 1",
                Speciality = "The Cha Cha Slide"
            };
            Cohort1.addInstructor(Instructor1);
            Instructor1.AssignExercise(Audrey, HolidayRoad);
            Instructor1.AssignExercise(Audrey, Nutshell);

            Instructor Instructor2 = new Instructor()
            {
                FirstName = "Miss",
                LastName = "Frizzle",
                SlackHandle = "@Instructor2",
                Cohort = "Cohort 2",
                Speciality = "Electric Slide"
            };
            Cohort2.addInstructor(Instructor2);
            Instructor2.AssignExercise(James, MartinsAquarium);
            Instructor2.AssignExercise(James, DailyJournal);

            Instructor Instructor3 = new Instructor()
            {
                FirstName = "Mister",
                LastName = "Miyagi",
                SlackHandle = "@Instructor3",
                Cohort = "Cohort 3",
                Speciality = "Cupid Shuffle"
            };
            Cohort3.addInstructor(Instructor3);
            Instructor3.AssignExercise(Kevin, HolidayRoad);
            Instructor3.AssignExercise(Kevin, Nutshell);
            Instructor3.AssignExercise(Willy, MartinsAquarium);
            Instructor3.AssignExercise(Willy, DailyJournal);

            List<Student> Students = new List<Student>();
            Students.Add(Audrey);
            Students.Add(James);
            Students.Add(Kevin);
            Students.Add(Willy);

            List<Exercise> Exercises = new List<Exercise>();
            Exercises.Add(HolidayRoad);
            Exercises.Add(Nutshell);
            Exercises.Add(MartinsAquarium);
            Exercises.Add(DailyJournal);

            foreach (Exercise exercise in Exercises)
            {
                Console.WriteLine($"{exercise.Name}:");
                foreach (Student student in Students)
                {
                    foreach (Exercise studentExercise in student.Exercises)
                    {
                        if (studentExercise == exercise)
                        {
                            Console.WriteLine($"{student.FirstName} {student.LastName}");
                        }
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
