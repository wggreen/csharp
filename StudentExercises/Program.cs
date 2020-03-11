using System;
using System.Collections.Generic;
using System.Linq;

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
                Language = "JavaScript"
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

            List<Cohort> Cohorts = new List<Cohort>();
            Cohorts.Add(Cohort1);
            Cohorts.Add(Cohort2);
            Cohorts.Add(Cohort3);

            Student Audrey = new Student()
            {
                FirstName = "Audrey",
                LastName = "Borgra",
                SlackHandle = "@Audrey",
                Cohort = Cohort1
            };
            Cohort1.addStudent(Audrey);

            Student James = new Student()
            {
                FirstName = "James",
                LastName = "Nitz",
                SlackHandle = "@James",
                Cohort = Cohort2
            };
            Cohort2.addStudent(James);

            Student Kevin = new Student()
            {
                FirstName = "Kevin",
                LastName = "Penny",
                SlackHandle = "@Kevin",
                Cohort = Cohort3
            };
            Cohort3.addStudent(Kevin);

            Student Willy = new Student()
            {
                FirstName = "Willy",
                LastName = "Metcalf",
                SlackHandle = "@Willy",
                Cohort = Cohort3
            };
            Cohort3.addStudent(Willy);

            Student Daniel = new Student()
            {
                FirstName = "Daniel",
                LastName = "Bennett",
                SlackHandle = "@Daniel",
                Cohort = Cohort3
            };
            Cohort3.addStudent(Daniel);


            Instructor Instructor1 = new Instructor()
            {
                FirstName = "Albert",
                LastName = "Einstein",
                SlackHandle = "@Instructor1",
                Cohort = Cohort1,
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
                Cohort = Cohort2,
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
                Cohort = Cohort3,
                Speciality = "Cupid Shuffle"
            };
            Cohort3.addInstructor(Instructor3);
            Instructor3.AssignExercise(Kevin, HolidayRoad);
            Instructor3.AssignExercise(Kevin, Nutshell);
            Instructor3.AssignExercise(Willy, MartinsAquarium);
            Instructor3.AssignExercise(Willy, DailyJournal);
            Instructor3.AssignExercise(Willy, HolidayRoad);

            List<Instructor> Instructors = new List<Instructor>();
            Instructors.Add(Instructor1);
            Instructors.Add(Instructor2);
            Instructors.Add(Instructor3);

            List<Student> Students = new List<Student>();
            Students.Add(Audrey);
            Students.Add(James);
            Students.Add(Kevin);
            Students.Add(Willy);
            Students.Add(Daniel);

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

            var JavaScriptExercises = Exercises.Where(exercise => exercise.Language == "JavaScript");

            Console.WriteLine("These are the Javascript exercises:");

            foreach (var exercise in JavaScriptExercises)
            {
                Console.WriteLine($"{exercise.Name}");
            }
            Console.WriteLine("\n");

            foreach (var cohort in Cohorts)
            {
                var CohortStudents = Students.Where(student => student.Cohort == cohort);
                Console.WriteLine($"These are the students in {cohort.Name}:");
                foreach (var student in CohortStudents)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                }
                Console.WriteLine("\n");
                var CohortInstructors = Instructors.Where(instructor => instructor.Cohort == cohort);
                Console.WriteLine($"These are the instructors for {cohort.Name}:");
                foreach (var instructor in CohortInstructors)
                {
                    Console.WriteLine($"{instructor.FirstName} {instructor.LastName}");
                }
                Console.WriteLine("\n");
            }

            var studentsSorted = Students.OrderBy(student => student.LastName);
            Console.WriteLine("Here are the students sorted by last name:");
            foreach (var student in studentsSorted)
            {
                Console.WriteLine($"{student.LastName}, {student.FirstName}");
            }
            Console.WriteLine("\n");


            var StudentsWithoutExercises = Students.Where(student => student.Exercises.Count == 0);
            Console.WriteLine("These are the students that haven't been assigned any exercises:");
            foreach (var student in StudentsWithoutExercises)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine("\n");

            var MostExercises = Students.OrderByDescending(student => student.Exercises.Count).First();

            Console.WriteLine($"The student assigned the most exercises is {MostExercises.FirstName} {MostExercises.LastName}");
            Console.WriteLine("\n");

            foreach (var cohort in Cohorts)
            {
                var CohortStudents = Students.Where(student => student.Cohort == cohort);
                Console.WriteLine($"There are {CohortStudents.Count()} students in {cohort.Name}");
            }
            Console.WriteLine("\n");
        }
    }
}
